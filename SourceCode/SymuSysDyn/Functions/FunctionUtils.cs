﻿#region Licence

// Description: SymuSysDyn - SymuSysDyn
// Website: https://symu.org
// Copyright: (c) 2020 laurent morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Symu.SysDyn.Equations;
using Symu.SysDyn.Parser;

namespace Symu.SysDyn.Functions
{
    /// <summary>
    /// Utils method to parse string for functions and theirs parameters
    /// </summary>
    public static class FunctionUtils
    {


        /// <summary>
        /// Extract functions from a string as a list of BuiltIn functions
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static IEnumerable<BuiltInFunction> ParseFunctions(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            var builtInFunctions = new List<BuiltInFunction>();

            var functions = ParseStringFunctions(input);

            if (functions != null)
            {
                builtInFunctions.AddRange(functions.Select(FunctionFactory.CreateInstance));
            }

            if (IfThenElse.IsContainedIn(input))
            {
                builtInFunctions.Add(new IfThenElse(input));
            }

            return builtInFunctions;
        }

        /// <summary>
        /// Functions Without Brackets ni lowercase
        /// </summary>
        private static readonly List<string> FunctionsWithoutBrackets= new List<string> {"dt","time"};
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <remarks>No regex approach for maintainability reason</remarks>
        /// <code>var regex = new Regex(@"([a-zA-Z0-9]+)\s*\([^)]*\)");</code>
        public static List<string> ParseStringFunctions(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            var result = new List<string>();
            
            var name = string.Empty;
            var counter = 0;
            var isFunction=true;
            foreach (var split in input.ToCharArray())
            {
                switch (split)
                {
                    case ' ':
                    case '-':
                    case '+':
                    case '*':
                    case '/':
                        if (counter == 0)
                        {
                            if (FunctionsWithoutBrackets.Contains(name.ToLowerInvariant()))
                            {
                                result.Add(name);
                            }
                            name = string.Empty;
                        }
                        else if (isFunction)
                        {
                            name += split;
                        }
                        break;
                    case '(':
                        isFunction = !string.IsNullOrEmpty(name);
                        if (isFunction)
                        {
                            name += split;
                        }
                        counter++;
                        break;
                    case ')':
                        counter--;
                        if (isFunction)
                        {
                            name += split;
                            if (counter == 0)
                            {
                                result.Add(name);
                                name = string.Empty;
                            }
                        }
                        else if (counter == 0)
                        {
                            isFunction = true;
                        }

                        break;
                    default:
                        if (isFunction)
                        {
                            name += split;
                        }

                        break;
                }
            }
            // Case of a single BuiltInFunction without brackets
            if (!result.Any() && FunctionsWithoutBrackets.Contains(name.ToLowerInvariant()))
            {
                result.Add(name);
            }
            return result;
        }

        /// <summary>
        ///     Get the list of parameters/args of a function with nested functions
        /// </summary>
        /// <param name="function"></param>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <param name="args"></param>
        /// <returns>input = "function(func(param1, param2), param3)" - return {func(param1, param2), param3}</returns>
        //public static List<IEquation> ParseParameters(ref string function,  out string name)
        public static void ParseParameters(ref string function, out string name, out List<IEquation> parameters, out List<float> args)
        {
            if (function == null)
            {
                throw new ArgumentNullException(nameof(function));
            }

            parameters= new List<IEquation>();
            args = new List<float>();
            name = StringUtils.CleanName(function.Split('(')[0]);
            const string extractFuncRegex = @"\b[^()]+\((.*)\)$";
            const string extractArgsRegex = @"(?:[^,()]+((?:\((?>[^()]+|\((?<open>)|\)(?<-open>))*\)))*)+";

            var match = Regex.Match(function, extractFuncRegex);

            if (string.IsNullOrEmpty(match.Groups[1].Value))
            {
                return;// parameters;
            }

            var innerArgs = match.Groups[1].Value;
            var matches = Regex.Matches(innerArgs, extractArgsRegex);
            for (var i = 0; i < matches.Count; i++)
            {
                var equation = EquationFactory.CreateInstance(matches[i].Value, out var value);
                parameters.Add(equation);
                args.Add(value);
            }
            function = GetInitializedFunction(name, parameters, args);
        }

        public static string GetInitializedFunction(string name, List<IEquation> parameters, List<float> args)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var initializedFunction = name + "(";
            for (var i = 0; i < parameters.Count; i++)
            {
                if (parameters[i] != null)
                {
                    initializedFunction += parameters[i];
                }
                else
                {
                    initializedFunction += args[i];
                }
                if (i < parameters.Count - 1)
                {

                    initializedFunction += ",";
                }
            }
            initializedFunction += ")";
            return initializedFunction;
        }
    }
}