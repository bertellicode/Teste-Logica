using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeiraVogal;

namespace PrimeiraVogal.Test
{
    /// <summary>
    /// Summary description for StringStreamTest
    /// </summary>
    [TestClass]
    public class StringStreamTest
    {
        public StringStreamTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// Método de teste da funcionalidade macro da tela, encontrar.
        /// Achar o primeiro caracter vogal da stream que não se repete após a primeira consoante.
        /// </summary>
        [TestMethod]
        public void StringStreamTestMethod()
        {
            var teste1 = new StringStream("uiaxfdefghijlilmox").FindFirstVowel();

            Assert.AreEqual('e', teste1);

            var teste2 = new StringStream("aAbBABacfe").FindFirstVowel();

            Assert.AreEqual('e', teste2);

            var teste3 = new StringStream("AAEBUJAXIulMIopq").FindFirstVowel();

            Assert.AreEqual('0', teste3, "Retorna 0 porque a string não atende as condições.");
        }

        /// <summary>
        /// Método de teste da funcionalidade que verifica se um caracter é uma vogal.
        /// </summary>
        [TestMethod]
        public void IsVowelTest()
        {
            StringStream stringStream = new StringStream();

            var isVowel = stringStream.IsVowel('a', false);

            Assert.IsTrue(isVowel);

            isVowel = stringStream.IsVowel('b', false);

            Assert.IsFalse(isVowel);
        }

        /// <summary>
        /// Método de teste que cruza as informações manipuladas para dar o resultado final.
        /// </summary>
        [TestMethod]
        public void GiveResultTest()
        {
            StringStream stringStream = new StringStream();
            char[] array = new char[5] { '\0', 'a', '\0', 'i', '\0' };
            stringStream.countVowel = new int[5] { 0, 3, 1, 0, 2 };

            var result = stringStream.GiveResult(array);

            Assert.AreEqual('i', result);
        }
    }
}
