﻿#region Licence

// Description: SymuSysDyn - SymuSysDynTests
// Website: https://symu.org
// Copyright: (c) 2021 laurent Morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

#region using directives

using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Symu.SysDyn.Core.Models.XMile;

#endregion

namespace Symu.SysDyn.Tests.Models.XMile
{
    [TestClass]
    public class VariableTests
    {
        private const string Equation1 = "variable1 + variable2 {unit}\r";
        private const string Equation2 = "name + DT *(variable1 - variable2)";
        private const string Equation3 = "STEP(3, 5)";
        private const string Equation4 = "";
        private const string Equation5 = "10";
        private Variable _variable;

        /// <summary>
        ///     No equation
        /// </summary>
        [TestMethod]
        public void VariableTest()
        {
            _variable = new Variable("name", "Model");
            Assert.AreEqual("Model_Name", _variable.FullName);
            Assert.IsNull(_variable.Equation);
            Assert.IsNull(_variable.Children);
        }

        /// <summary>
        ///     Equation
        /// </summary>
        [TestMethod]
        public async Task VariableTest1()
        {
            _variable = await Variable.CreateVariable<Variable>("name", string.Empty, Equation1);
            Assert.AreEqual("_Name", _variable.FullName);
            Assert.AreEqual(0, _variable.Value);
            Assert.IsNotNull(_variable.Equation);
            Assert.AreEqual(2, _variable.Children.Count);
            Assert.IsTrue(_variable.Children.Contains("_Variable1"));
            Assert.IsTrue(_variable.Children.Contains("_Variable2"));
            Assert.IsFalse(_variable.Updated);
        }

        /// <summary>
        ///     Constant
        /// </summary>
        [TestMethod]
        public async Task VariableTest5()
        {
            _variable = await Variable.CreateVariable<Variable>("name", string.Empty, Equation5);
            Assert.AreEqual("_Name", _variable.FullName);
            Assert.AreEqual(10, _variable.Value);
            Assert.IsNull(_variable.Equation);
            Assert.AreEqual(0, _variable.Children.Count);
            Assert.IsTrue(_variable.Updated);
        }

        /// <summary>
        ///     With built in functions
        /// </summary>
        [TestMethod]
        public async Task VariableTest2()
        {
            _variable = await Variable.CreateVariable<Variable>("name", string.Empty, Equation2);
            Assert.AreEqual("_Name", _variable.FullName);
            Assert.AreEqual(0, _variable.Value);
            Assert.IsNotNull(_variable.Equation);
            Assert.AreEqual(3, _variable.Children.Count);
            Assert.IsTrue(_variable.Children.Contains("_Dt"));
            Assert.IsTrue(_variable.Children.Contains("_Variable1"));
            Assert.IsTrue(_variable.Children.Contains("_Variable2"));
            Assert.IsFalse(_variable.Updated);
        }

        /// <summary>
        ///     With built in functions
        /// </summary>
        [TestMethod]
        public async Task VariableTest3()
        {
            _variable = await Variable.CreateVariable<Variable>("name", string.Empty, Equation3);
            Assert.AreEqual("_Name", _variable.FullName);
            Assert.AreEqual(0, _variable.Value);
            Assert.IsNotNull(_variable.Equation);
            Assert.AreEqual(0, _variable.Children.Count);
            Assert.IsFalse(_variable.Updated);
        }

        /// <summary>
        ///     No equation
        /// </summary>
        [TestMethod]
        public async Task VariableTest4()
        {
            _variable = await Variable.CreateVariable<Variable>("name", string.Empty, Equation4);
            Assert.AreEqual("_Name", _variable.FullName);
            Assert.AreEqual(0, _variable.Value);
            Assert.IsNull(_variable.Equation);
            Assert.AreEqual(0, _variable.Children.Count);
            Assert.IsTrue(_variable.Updated);
        }

        [TestMethod]
        public void ToStringTest()
        {
            _variable = new Variable("name");
            Assert.AreEqual("_Name", _variable.ToString());
        }
    }
}