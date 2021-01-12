﻿#region Licence

// Description: SymuBiz - SymuSysDynTests
// Website: https://symu.org
// Copyright: (c) 2020 laurent Morisseau
// License : the program is distributed under the terms of the GNU General Public License

#endregion

#region using directives

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Symu.SysDyn.Core.Functions;

#endregion

namespace SymuSysDynTests.Functions
{
    [TestClass]
    public class FunctionFactoryTests
    {
        [TestMethod]
        public void ParseStringFunctionsTest()
        {
            const string test =
                "xxx func0(a)+b + func1(a,b+c) - func2(a*b,func3(a+b,c)) * func4(e)+func5((f))+func6(func7(g,h)+func8(i,(a)=>a+2)) yyy";
            var result = FunctionUtils.ParseStringFunctions(test);
            Assert.AreEqual(6, result.Count);
            Assert.AreEqual("func0(a)", result[0]);
            Assert.AreEqual("func1(a,b+c)", result[1]);
            Assert.AreEqual("func2(a*b,func3(a+b,c))", result[2]);
            Assert.AreEqual("func4(e)", result[3]);
            Assert.AreEqual("func5((f))", result[4]);
            Assert.AreEqual("func6(func7(g,h)+func8(i,(a)=>a+2))", result[5]);
        }

        [TestMethod]
        public void ParseStringFunctionsTest1()
        {
            const string test =
                "Func1(param1,param2)+someStuffAfterFunction + DT + TIME + STEP( 1 , 2)-Normal(1,2)*RAMP(2,1)";
            var result = FunctionUtils.ParseStringFunctions(test);
            Assert.AreEqual(6, result.Count);
            Assert.AreEqual("Func1(param1,param2)", result[0]);
            Assert.AreEqual("DT", result[1]);
            Assert.AreEqual("TIME", result[2]);
            Assert.AreEqual("STEP( 1 , 2)", result[3]);
            Assert.AreEqual("Normal(1,2)", result[4]);
            Assert.AreEqual("RAMP(2,1)", result[5]);
        }

        [TestMethod]
        public void ParseStringFunctionsTest1Bis()
        {
            const string test = "TIME";
            var result = FunctionUtils.ParseStringFunctions(test);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("TIME", result[0]);
        }

        [TestMethod]
        public void ParseStringFunctionsTest1Ter()
        {
            const string test = "DT";
            var result = FunctionUtils.ParseStringFunctions(test);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("DT", result[0]);
        }


        /// <summary>
        ///     Non passing test
        /// </summary>
        [TestMethod]
        public void ParseStringFunctionsTest2()
        {
            const string test = "someStuffBeforeFunction + ( param1 ) + ((param2) + (param3)) + xxx";
            var results = FunctionUtils.ParseStringFunctions(test);
            Assert.AreEqual(0, results.Count);
        }

        /// <summary>
        ///     passing test : Is variable false then true
        /// </summary>
        [TestMethod]
        public void ParseStringFunctionsTest3()
        {
            const string test = "Dt* (variable1 - variable2)-Time+SET(3,5)";
            var results = FunctionUtils.ParseStringFunctions(test);
            Assert.AreEqual(3, results.Count);
            Assert.AreEqual("Dt", results[0]);
            Assert.AreEqual("Time", results[1]);
            Assert.AreEqual("SET(3,5)", results[2]);
        }
        /// <summary>
        ///     passing test : Is variable false then true
        /// </summary>
        [TestMethod]
        public void ParseStringFunctionsTest4()
        {
            const string test = "10*(1+Ramp(0,5))";
            var results = FunctionUtils.ParseStringFunctions(test);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Ramp(0,5)", results[0]);
        }


        /// <summary>
        ///     Passing tests
        /// </summary>
        [TestMethod]
        public void GetFunctionsTest()
        {
            const string test =
                "Func1((param1),(param2))+DT + TIME + STEP( 1 , 2)-Normal(1,2)*RAMP(2,1)-ExternalUpdate+2";
            var results = FunctionUtils.ParseFunctions(string.Empty, test).ToList();
            // Result is 8 because Func1((param1),(param2)) appears twice, once with a false result : Func1((param1))
            // To correct
            Assert.AreEqual(7, results.Count);
            Assert.AreEqual("Func1", results[0].Name);
            Assert.IsTrue(results[1] is Dt);
            Assert.IsTrue(results[2] is Time);
            Assert.AreEqual("Step", results[3].Name);
            Assert.IsTrue(results[3] is Step);
            Assert.IsTrue(results[4] is Normal);
            Assert.AreEqual("Normal", results[4].Name);
            Assert.IsTrue(results[5] is Ramp);
            Assert.AreEqual("Ramp", results[5].Name);
            Assert.IsTrue(results[6] is ExternalUpdate);
            Assert.AreEqual("Externalupdate", results[6].Name);
        }

        /// <summary>
        ///     Non passing test
        /// </summary>
        [TestMethod]
        public void GetFunctionsTest1()
        {
            const string test = "someStuffBeforeFunction + ( param1 ) + ( param2 + param3 ) + xxx";
            var results = FunctionUtils.ParseFunctions(string.Empty, test).ToList();
            Assert.AreEqual(0, results.Count);
        }


        /// <summary>
        ///     If then else test
        /// </summary>
        [TestMethod]
        public void GetFunctionsTest21()
        {
            const string test = "If x1 then x2 else x3";
            var results = FunctionUtils.ParseFunctions(string.Empty, test).ToList();
            Assert.AreEqual(1, results.Count);
            Assert.IsTrue(results[0] is IfThenElse);
            Assert.AreEqual(3, results[0].Parameters.Count);
            Assert.AreEqual("_X1", results[0].Parameters[0].ToString());
            Assert.AreEqual("_X2", results[0].Parameters[1].ToString());
            Assert.AreEqual("_X3", results[0].Parameters[2].ToString());
        }

        /// <summary>
        ///     If then else test with brackets
        ///     If() may be identified as a function
        /// </summary>
        [TestMethod]
        public void GetFunctionsTest22()
        {
            const string test = "If(x1) then x2 else x3";
            var results = FunctionUtils.ParseFunctions(string.Empty, test).ToList();
            Assert.AreEqual(1, results.Count);
            Assert.IsTrue(results[0] is IfThenElse);
            Assert.AreEqual(3, results[0].Parameters.Count);
            Assert.AreEqual("_X1", results[0].Parameters[0].ToString());
            Assert.AreEqual("_X2", results[0].Parameters[1].ToString());
            Assert.AreEqual("_X3", results[0].Parameters[2].ToString());
        }

        /// <summary>
        ///     If then else test with brackets
        ///     If() may be identified as a function
        /// </summary>
        [TestMethod]
        public void GetFunctionsTest23()
        {
            const string test = "If(TIME < 3) then x2 else (TIME-3)";
            var results = FunctionUtils.ParseFunctions(string.Empty, test).ToList();
            Assert.AreEqual(1, results.Count);
            Assert.IsTrue(results[0] is IfThenElse);
            Assert.AreEqual(3, results[0].Parameters.Count);
            Assert.AreEqual("Time0<3", results[0].Parameters[0].ToString());
            Assert.AreEqual("_X2", results[0].Parameters[1].ToString());
            Assert.AreEqual("Time0-3", results[0].Parameters[2].ToString());
        }

        [TestMethod]
        public void GetParametersTest()
        {
            var function = "Func";
            FunctionUtils.ParseParameters(string.Empty, ref function, out var name, out var parameters, out _);
            Assert.AreEqual(0, parameters.Count);
            Assert.AreEqual("Func", name);
        }

        [TestMethod]
        public void GetParametersTest1()
        {
            var function = "Func()";

            FunctionUtils.ParseParameters(string.Empty, ref function, out var name, out var parameters, out _);
            Assert.AreEqual(0, parameters.Count);
            Assert.AreEqual("Func", name);
        }

        [TestMethod]
        public void GetParametersTest2()
        {
            var function = "Func(param1)";

            FunctionUtils.ParseParameters(string.Empty, ref function, out var name, out var parameters, out _);
            Assert.AreEqual(1, parameters.Count);
            Assert.AreEqual("_Param1", parameters[0].Variables.First());
            Assert.AreEqual("Func", name);
        }

        [TestMethod]
        public void GetParametersTest3()
        {
            var function = "Func(param1, param2)";

            FunctionUtils.ParseParameters(string.Empty, ref function, out var name, out var parameters, out _);
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("_Param1", parameters[0].Variables.First());
            Assert.AreEqual("_Param2", parameters[1].Variables.First());
            Assert.AreEqual("Func", name);
        }

        [TestMethod]
        public void GetParametersTest4()
        {
            var function =
                @"someFunc((a),b,func1(a,b+c),func2(a*b,func3(a+b,c)),func4(e)+func5(f),func6(func7(g,h)+func8(i,(a)=>a+2)),g+2)";

            FunctionUtils.ParseParameters(string.Empty, ref function, out var name, out var parameters, out _);
            Assert.AreEqual(7, parameters.Count);
            Assert.AreEqual("Somefunc", name);
        }
    }
}