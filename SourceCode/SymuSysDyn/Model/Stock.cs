﻿#region Licence

// Description: SymuSysDyn - SymuSysDyn
// Website: https://symu.org
// Copyright: (c) 2020 laurent Morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

#region using directives

using System;
using System.Collections.Generic;
using Symu.SysDyn.Equations;
using Symu.SysDyn.Functions;
using Symu.SysDyn.Parser;

#endregion

namespace Symu.SysDyn.Model
{
    /// <summary>
    ///     Core building block of a model, also called level or state. Stocks accumulate change.
    ///     Use Stock when past event influence present event. Stocks are a kind of memory, storing the results of past
    ///     actions.
    ///     Their value at the start of the simulation must be set as either a constant or with an initial equation.
    ///     The initial equation is evaluated only once, at the beginning of the simulation.
    /// </summary>
    public class Stock : Variable, IComparable
    {
        private Stock(string name) : base(name)
        {
        }
        public static Stock CreateInstance(List<IVariable> variables, string name)
        {
            if (variables == null)
            {
                throw new ArgumentNullException(nameof(variables));
            }

            var variable = new Stock(name);
            variables.Add(variable);
            return variable;
        }

        public Stock(string name, string eqn, List<string> inflow, List<string> outflow) : base(name, eqn)
        {
            Inflow = StringUtils.CleanNames(inflow);
            Outflow = StringUtils.CleanNames(outflow);
            SetChildren();
        }
        public static Stock CreateInstance(Variables variables, string name, string eqn, List<string> inflow, List<string> outflow)
        {
            if (variables == null)
            {
                throw new ArgumentNullException(nameof(variables));
            }

            var variable = new Stock(name, eqn, inflow, outflow);
            variables.Add(variable);
            return variable;
        }

        private Stock(string name, string eqn, List<string> inflow, List<string> outflow, GraphicalFunction graph,
            Range range, Range scale, NonNegative nonNegative) : base(name, eqn, graph, range, scale, nonNegative)
        {
            Inflow = StringUtils.CleanNames(inflow);
            Outflow = StringUtils.CleanNames(outflow);
            SetChildren();
        }
        public static Stock CreateInstance(Variables variables, string name, string eqn, List<string> inflow, List<string> outflow, GraphicalFunction graph,
            Range range, Range scale, NonNegative nonNegative)
        {
            if (variables == null)
            {
                throw new ArgumentNullException(nameof(variables));
            }

            var variable = new Stock(name, eqn, inflow, outflow, graph, range, scale, nonNegative);
            variables.Add(variable);
            return variable;
        }

        public override IVariable Clone()
        {
            var clone = new Stock(Name);
            CopyTo(clone);
            clone.Inflow = Inflow;
            clone.Outflow = Outflow;
            return clone;
        }

        /// <summary>
        ///     stock(t) = stock(t - dt) + dt*(inflows(t - dt) – outflows(t - dt))
        ///     Re compute SetChildren with the new equation
        /// </summary>
        public void SetStockEquation()
        {
            var equation = Name;
            var inflows = AggregateFlows(Inflow, "+");
            var outflows = AggregateFlows(Outflow, "-");
            if (inflows.Length > 0 || outflows.Length > 0)
            {
                equation += "+" + Dt.Value + "*(" +
                            inflows;
                if (outflows.Length > 0)
                {
                    equation += "-" + outflows;
                }

                equation += ")";
            }

            Equation = EquationFactory.CreateInstance(equation, out _);

            SetChildren();
        }

        private static string AggregateFlows(IReadOnlyList<string> list, string @operator)
        {
            var flow = string.Empty;
            if (list == null)
            {
                return flow;
            }
            for (var i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    flow += list[i];
                }
                else
                {
                    flow += @operator + list[i];
                }
            }

            return flow;
        }


        #region Xml attributes

        public List<string> Inflow { get; private set; }
        public List<string> Outflow { get; private set; }

        #endregion

        #region IComparable

        public override bool Equals(object that)
        {
            if (that is Variable stock)
            {
                return Name.Equals(stock.Name);
            }

            return ReferenceEquals(this, that);
        }

        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 0;
        }

        public int CompareTo(object obj)
        {
            var that = obj as Variable;
            return string.Compare(Name, that?.Name, StringComparison.Ordinal);
        }

        #endregion
    }
}