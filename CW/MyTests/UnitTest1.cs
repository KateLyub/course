using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTests
{
    [TestClass]
    public class HumanTest
    {
        public void CheckTypeSingleton()
        {

            Singleton w = Singleton.GetInstance();
            Singleton m = Singleton.GetInstance();

            Assert.AreSame(m, w);
        }
    }
}
