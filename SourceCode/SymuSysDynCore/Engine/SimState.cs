﻿#region Licence

// Description: SymuSysDyn - SymuSysDynCore
// Website: https://symu.org
// Copyright: (c) 2020 laurent Morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

namespace Symu.SysDyn.Core.Engine
{
    /// <summary>
    ///     Collection of the states of the simulator
    /// </summary>
    public enum SimState
    {
        NotStarted,
        Started,
        Pause,
        Stopped
    }
}