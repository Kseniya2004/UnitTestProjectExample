using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryExample;

namespace UnitTestProjectExample
{
    [TestClass]
    public class UnitTestSquareSolve
    {
        [TestMethod]
        public void TestMethod_x1_1_minus5_6_returned3()
        {//x^2 - 5x + 6 = 0
            //d=1 x1=3
            int a = 1;
            int b = -5;
            int c = 6;
            string xTest = "3";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();            
            Assert.AreEqual(xTest, x.x1(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
        [TestMethod]
        public void TestMethod_x2_1_minus5_6_returned2()
        {
            //x^2 - 5x + 6 = 0
            //d=1 x1=3
            int a = 1;
            int b = -5;
            int c = 6;
            string xTest = "2";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();
            Assert.AreEqual(xTest, x.x2(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
        [TestMethod]
        public void TestMethod_x1_3_1_3_returnedNo()
        {
            int a = 3;
            int b = 1;
            int c = 3;
            string xTest = "Действительных корней нет";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();
            Assert.AreEqual(xTest, x.x1(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
        [TestMethod]
        public void TestMethod_x2_3_1_3_returnedNo()
        {
            int a = 3;
            int b = 1;
            int c = 3;
            string xTest = "Действительных корней нет";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();
            Assert.AreEqual(xTest, x.x2(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
        [TestMethod]
        public void TestMethod_x1_0_1_3_returned3()
        {
            int a = 0;
            int b = 1;
            int c = 3;
            string xTest = "-3";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();
            Assert.AreEqual(xTest, x.x1(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
        [TestMethod]
        public void TestMethod_x2_0_1_3_returned3()
        {
            int a = 0;
            int b = 1;
            int c = 3;
            string xTest = "-3";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();
            Assert.AreEqual(xTest, x.x2(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
        [TestMethod]
        public void TestMethod_x1_0_0_0_returned0()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            string xTest = "0";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();
            Assert.AreEqual(xTest, x.x1(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
        [TestMethod]
        public void TestMethod_x2_0_0_0_returned3()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            string xTest = "Действительных корней нет";
            // вызов метода
            ClassSquareSolve x = new ClassSquareSolve();
            Assert.AreEqual(xTest, x.x2(a, b, c));//сравнение на равенство ожидаемого и фактического значений
        }
    }
}
