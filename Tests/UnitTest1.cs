using Microsoft.VisualStudio.TestTools.UnitTesting;
using Typograph;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            string text = "Какой же хороший          день !!";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же хороший день !!", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string text = "Какой же хороший день...";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же хороший день…", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod3()
        {
       
            string text =  "Какой же хороший \"cool\" день ";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же хороший «cool» день ", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string text = "Какой удивительно хороший 10 H день !!";
            Form1 form = new Form1();
            Assert.AreEqual("Какой удивительно хороший 10 H день !!", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod5()
        {
            string text = "Какой же ...хороший м день ";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же …хороший м (значит масоны) день ", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod6()
        {
            string text = "Какой же хороший        день плюс-минус!!";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же хороший день ±!!", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod7()
        {
            string text = "Какой же хор  оший день !!";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же хор оший день !!", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod8()
        {
            string text = "Какой       же хороший -  день !!";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же хороший-день !!", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod9()
        {
            string text = "        Какой же хороший  день !!";
            Form1 form = new Form1();
            Assert.AreEqual(" Какой же хороший день !!", form.Apply_Rules(ref text));
        }

        [TestMethod]
        public void TestMethod10()
        {
            string text = "Какой же    хороший  день... !!";
            Form1 form = new Form1();
            Assert.AreEqual("Какой же хороший день… !!", form.Apply_Rules(ref text));
        }
    }
}
