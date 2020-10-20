﻿#region Licence

// Description: SymuSysDyn - SymuSysDyn
// Website: https://symu.org
// Copyright: (c) 2020 laurent morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

#region using directives

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using NCalc2;
using Symu.SysDyn.Model;
using Symu.SysDyn.Parser;
using Symu.SysDyn.Simulation;

#endregion

namespace Symu.SysDyn.Equations
{
    /// <summary>
    ///     IF condition THEN expression ELSE expression
    ///      all non-zero values are true, while zero is false.
    /// Generally, condition is an expression involving the logical, relational, and equality operators.

    /// </summary>
    public class IfThenElse : BuiltInFunction
    {

        public IfThenElse(string function) 
        {
            OriginalFunction = function ?? throw new ArgumentNullException(nameof(function));
            Name = "If";
            Parameters = Parse(function);
            Expression = new Expression(SetEquation());
        }
        /// <summary>
        /// Parse the string function to extract the if-then-else conditions in the parameters
        /// </summary>
        /// <param name="input"></param>
        public static List<ManagedEquation> Parse(string input)
        {
            var parameters = new List<ManagedEquation>();


            var result = MatchRegex(input);
            if (!result.Success)
            {
                return parameters;
            }
            parameters.Add(new ManagedEquation(result.Groups[1].Value)); //If
            parameters.Add(new ManagedEquation(result.Groups[2].Value)); //Then
            parameters.Add(new ManagedEquation(result.Groups[3].Value)); //Else
            return parameters;
        }

        private static Match MatchRegex(string input)
        {
            var regex = new Regex(@"IF (.*) THEN (.*) ELSE (.*)", RegexOptions.IgnoreCase);
            return regex.Match(input);
        }

        /// <summary>
        /// "if(Condition,ThenExpression,ElseExpression)"
        /// </summary>
        /// <returns></returns>
        public string SetEquation()
        {
            var condition = Parameters.ElementAt(0);
            var thenExpression = Parameters.ElementAt(1);
            var elseExpression = Parameters.ElementAt(2);
            return "if(" + condition + StringUtils.Comma + thenExpression + StringUtils.Comma + elseExpression + StringUtils.RParenthesis;
        }

        /// <summary>
        ///     Check if it is a IfThenElse function
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsContainedIn(string input)
        {
            return MatchRegex(input).Success;
        }
    }
}