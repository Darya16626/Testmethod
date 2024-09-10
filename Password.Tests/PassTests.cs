using Microsoft.VisualStudio.TestTools.UnitTesting;
using Password;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PassTests
    {
        // Тестовый пароль для всех тестов
        private const string testPassword = "Pass@w0rd123456789";

        private static int totalScore = 0; //  общее  количество  баллов

        [TestMethod]
        public void Any_DigitScore_score()
        {
            int expectedScore = 1;
            int actualScore = Pass.GetDigitScore(testPassword);
            Assert.AreEqual(expectedScore, actualScore);
            Console.WriteLine("TestDigitScore: {0} баллов", actualScore);
            totalScore += actualScore;
        }

        [TestMethod]
        public void Any_LowercaseScore_score()
        {
            int expectedScore = 1; 
            int actualScore = Pass.GetLowercaseScore(testPassword); 
            Assert.AreEqual(expectedScore, actualScore);
            Console.WriteLine("TestLowercaseScore: {0} баллов", actualScore); 
            totalScore += actualScore;
        }

        [TestMethod]
        public void Any_CaitalScore_score()
        {
            int expectedScore = 1; 
            int actualScore = Pass.GetCaitalScore(testPassword); 
            Assert.AreEqual(expectedScore, actualScore); 
            Console.WriteLine("TestUppercaseScore: {0} баллов", actualScore); 
            totalScore += actualScore; 
        }

        [TestMethod] 
        public void Any_SpecialScore_score()
        {
            int expectedScore = 1; 
            int actualScore = Pass.GetSpecialScore(testPassword);
            Assert.AreEqual(expectedScore, actualScore);
            Console.WriteLine("TestSpecialScore: {0} баллов", actualScore);
            totalScore += actualScore;
        }

        [TestMethod]
        public void Any_LengthScore_score()
        {
            int expectedScore = 1;
            int actualScore = Pass.GetLengthScore(testPassword);
            Assert.AreEqual(expectedScore, actualScore); 
            Console.WriteLine("TestLengthScore: {0} баллов", actualScore);
            totalScore += actualScore; 
        }

        [TestCleanup] // Атрибут который  выполняется  после  всех  тестов.
        public void Cleanup()
        {
            Console.WriteLine("Итого: {0} баллов", totalScore);
        }
    }
}