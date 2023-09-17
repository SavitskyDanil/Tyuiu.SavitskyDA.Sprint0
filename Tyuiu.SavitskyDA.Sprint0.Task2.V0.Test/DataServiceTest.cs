using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SavitskyDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Данил";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Данил", res);
        }
    }
}
