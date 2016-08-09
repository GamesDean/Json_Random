
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyForecast.SymEngine.Json
{
    [TestClass]
    public class JsonInputTest
    {
        


[TestMethod]
        public void GetFecFieldValuesTestXYZ1()
        {
            JsonInput jTest = new JsonInput();
           
            var result = jTest.GetFecFieldValues("'NumArrayNameXYZ1'",input);
            CollectionAssert.AreEqual(new int[] { 1,2,3,4,5 },result);
        }

        [TestMethod]
        public void GetFecFieldValuesTestXYZ2()
        {
            JsonInput jTest = new JsonInput();
            var result = jTest.GetFecFieldValues("'NumArrayNameXYZ2'");
            CollectionAssert.AreEqual(new int[] { 10,11,12 }, result);
        }

        [TestMethod]
        public void GetFecFieldValuesTestXYZ3()
        {
            JsonInput jTest = new JsonInput();
            var result = jTest.GetFecFieldValues("'NumArrayNameXYZ3'");
            CollectionAssert.AreEqual(new int[] { 7,8,9 }, result);
        }


    }
}
