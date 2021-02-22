﻿#region Licence

// Description: SymuBiz - SymuSysDyn
// Website: https://symu.org
// Copyright: (c) 2020 laurent Morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

#region using directives

using System;

#endregion

namespace Symu.SysDyn.Core.Functions
{
    /// <summary>
    ///     The smth1, smth3 and smthn functions perform a first-, third- and nth-order respectively exponential smooth of
    ///     input, using an exponential averaging time of averaging,
    ///     and an optional initial value initial for the smooth.smth3 does this by setting up a cascade of three first-order
    ///     exponential smooths, each with an averaging time of averaging/3.
    ///     The other functions behave analogously.They return the value of the final smooth in the cascade.
    ///     If you do not specify an initial value initial, they assume the value to be the initial value of input.
    /// </summary>
    public class SmthN : Smth
    {
        public const string Label = "Smthn";

        public SmthN(string model, string function) : base(model, function)
        {
            Order = Convert.ToByte(GetParamFromOriginalEquation(2));
            InitialIndex = Parameters.Count == 4 ? 3 : 0;
        }

        public override IBuiltInFunction Clone()
        {
            var clone = new SmthN(Model, OriginalFunction);
            CopyTo(clone);
            return clone;
        }
    }
}