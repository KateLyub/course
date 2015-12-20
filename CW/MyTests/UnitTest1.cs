using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CW;

namespace MyTests
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void CheckTypeSingleton()
        {
            Singleton w = Singleton.GetInstance();
            Singleton m = Singleton.GetInstance();

            Assert.AreSame(m, w);
        }

        [TestMethod]
        public void CheckInherits()
        {
            Man mm = new Man();
            Woman ww = new Woman();

            Assert.IsInstanceOfType(ww, typeof(Wo_Man));
            Assert.IsInstanceOfType(mm, typeof(Wo_Man));
        }

    }
}
