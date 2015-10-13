using NumricSequenceCalculator.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System;

namespace NumricSequenceCalculator.Classes.Tests
{
    [TestClass]
    public class GenerateSequenceTests
    {
        [TestMethod]
        public void AllNumbersTest()
        {
            // Arrange
            int numberEnteredByUser = 10;
            GenerateSequence gs = new GenerateSequence();
            List<int> ExpectedOutput = new List<int>();
            List<int> ActualOutput = new List<int>();

            for (int i = 1; i <= numberEnteredByUser; i++)
            {
                ExpectedOutput.Add(i);
            }

            // Act
            ActualOutput.AddRange(gs.AllNumbers(numberEnteredByUser));

            // Assert
            NUnit.Framework.Assert.AreEqual(ExpectedOutput, ActualOutput, "Sequences do not match!");
        }

        [TestMethod]
        public void AllNumbersMultipleOfTest()
        {
            // Arrange
            int numberEnteredByUser = 10;
            GenerateSequence gs = new GenerateSequence();
            List<string> ExpectedOutput = new List<string>();
            List<string> ActualOutput = new List<string>();

            for (int num = 1; num <= numberEnteredByUser; num++)
            {
                // If multiple of 3
                if (num % 3 == 0 && num % 5 != 0)
                {
                    ExpectedOutput.Add("C");
                }
                else if (num % 3 != 0 && num % 5 == 0) // If multiple of 5
                {
                    ExpectedOutput.Add("E");
                }
                else if (num % 3 == 0 && num % 5 == 0) // If multiple of both 3 and 5
                {
                    ExpectedOutput.Add("Z");
                }
                else // If not multiple of niether 3 or 5
                {
                    ExpectedOutput.Add(num.ToString());
                }
            }

            // Act
            ActualOutput.AddRange(gs.AllNumbersMultipleOf(numberEnteredByUser));

            // Assert
            NUnit.Framework.Assert.AreEqual(ExpectedOutput, ActualOutput, "Sequences do not match!");
        }

        [TestMethod]
        public void EvenSequenceTest()
        {
            // Arrange
            int numberEnteredByUser = 10;
            GenerateSequence gs = new GenerateSequence();
            List<int> ExpectedOutput = new List<int>();
            List<int> ActualOutput = new List<int>();

            for (int num = 1; num <= numberEnteredByUser; num++)
            {
                if (num % 2 == 0)
                {
                    ExpectedOutput.Add(num);
                }
            }

            if (!ExpectedOutput.Contains(numberEnteredByUser))
            {
                ExpectedOutput.Add(numberEnteredByUser);
            }

            // Act
            ActualOutput.AddRange(gs.EvenSequence(numberEnteredByUser));

            // Assert
            NUnit.Framework.Assert.AreEqual(ExpectedOutput, ActualOutput, "Sequences do not match!");
        }

        [TestMethod]
        public void OddSequenceTest()
        {
            // Arrange
            int numberEnteredByUser = 10;
            GenerateSequence gs = new GenerateSequence();
            List<int> ExpectedOutput = new List<int>();
            List<int> ActualOutput = new List<int>();

            for (int num = 1; num <= numberEnteredByUser; num++)
            {
                if (num % 2 != 0)
                {
                    ExpectedOutput.Add(num);
                }
            }

            if (!ExpectedOutput.Contains(numberEnteredByUser))
            {
                ExpectedOutput.Add(numberEnteredByUser);
            }

            // Act
            ActualOutput.AddRange(gs.OddSequence(numberEnteredByUser));

            // Assert
            NUnit.Framework.Assert.AreEqual(ExpectedOutput, ActualOutput, "Sequences do not match!");
        }

        [TestMethod]
        public void FabonacciSequenceTest()
        {
            // Arrange
            int numberEnteredByUser = 10;
            GenerateSequence gs = new GenerateSequence();
            string ExpectedSequence = "1,1,2,3,5,8,10,13,21,34,55";
            List<int> ExpectedOutput = new List<int>();
            List<int> ActualOutput = new List<int>();

            foreach (string str in ExpectedSequence.Split(','))
            {
                ExpectedOutput.Add(Convert.ToInt32(str));
            }

            // Act
            ActualOutput.AddRange(gs.FabonacciSequence(numberEnteredByUser));

            // Assert
            NUnit.Framework.Assert.AreEqual(ExpectedOutput, ActualOutput, "Sequences do not match!");
        }
    }
}