﻿#region Licence

// Description: SymuSysDyn - SymuSysDynTests
// Website: https://symu.org
// Copyright: (c) 2020 laurent Morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

#region using directives

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Symu.SysDyn.Model;

#endregion

namespace SymuSysDynTests.Model
{
    [TestClass]
    public class GroupTests
    {
        [TestMethod]
        public void GroupTest()
        {
            var group = new Group("name", new List<string> {"variable1", "variable2"});
            Assert.AreEqual("Name", group.Name);
            Assert.AreEqual("Name", group.ToString());
            Assert.AreEqual(2, group.Entities.Count);
            Assert.AreEqual("Variable1", group.Entities[0]);
            Assert.AreEqual("Variable2", group.Entities[1]);
        }
    }
}