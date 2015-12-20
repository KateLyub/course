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

            //Assert.IsInstanceOfType(ww, typeof(Wo_Man));
            Assert.IsInstanceOfType(mm, typeof(Wo_Man));
        }

        [TestMethod]
        public void CheckGender()
        {
            Man mm = new Man();
            Woman ww = new Woman();

            Assert.IsNotNull(mm);
            Assert.IsNotNull(ww);
        }

        [TestMethod]
        public void CheckTypeAfterAdapter()
        {
            Singleton w = new Adapter();
            Singleton m = new Adapter();

            w = Singleton.GetInstance();
            m = Singleton.GetInstance();

            Assert.AreSame(m, w);
        }

    }
}
