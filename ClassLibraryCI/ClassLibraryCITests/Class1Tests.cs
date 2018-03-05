using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCI.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            Class1 s = new Class1();
            Assert.AreEqual("Nikolai", s.GetName());
        }

        [TestMethod()]
        public void GetAdressTest()
        {
            Class1 s = new Class1();
            Assert.AreEqual("elisagasdaardsvej 5", s.GetAdress());
        }
    }
}