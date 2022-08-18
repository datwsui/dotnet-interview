using System;
using System.Collections.Generic;
using System.Linq;
using CodingTests.Tester;
using CodingExercise;
using NUnit.Framework;

namespace CodingTests
{
    [TestFixture]
    public class CodingTests
    {
        [Test]
        public void oldchar_should_be_replaced_with_newchar_test()
        {
            string input = "Hello, Welcome to your interview!";
            string expected = "Hollo, Wolcomo to your intorviow!";
            char oldChar = 'e';
            char newchar = 'o';

            string result = StringReplace.Replace(input, oldChar, newchar);


            Assert.AreEqual(expected, result);

        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 2, 3, 4, 5, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 12, new int[] { 3, 4, 5, 1, 2 })]
        public void array_rotate(int[] array, int rotateAmount, int[] expectedValues)
        {
            var output = array.Rotate(rotateAmount);

            var expected = $"[ { string.Join(", ", expectedValues) } ]";
            var actual = $"[ { string.Join(", ", output) } ]";

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void fizz_buzz_should_return_first_bit_correctly()
        {
            string resultString = FizzBuzz.Generate();

            Tuple<bool, string> testResult = FizzBuzzTester.VerifyString(resultString);

            Assert.AreEqual("1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz", resultString.Take(57));

        }

        [Test]
        public void fizz_buzz_should_be_returned_properly_test()
        {
            string resultString = FizzBuzz.Generate();

            Tuple<bool, string> testResult = FizzBuzzTester.VerifyString(resultString);

            Assert.IsTrue(testResult.Item1, testResult.Item2 + "Result was : " + testResult);

        }


        [Test]
        [TestCase("", null, null)]
        [TestCase("2", "2", "2")]
        [TestCase("2,2", "2", "2")]
        [TestCase(">3", "3", null)]
        [TestCase("<5", null, "5")]
        [TestCase("1,3", "1", "3")]
        public void string_input_should_be_parsed_to_valid_tuple_test(string incoming, string first, string second)
        {
            var result = StringRangeParser.Parse(incoming);

            Assert.AreEqual(first, result.Item1);
            Assert.AreEqual(second, result.Item2);
        }

        [Test]
        public void integer_value_should_be_extracted_simple_test()
        {
            string input = "Cooktown – 250 Endeavour River Frontage, Large Acreage - 345000";
            int[] expected = new[] { 250, 345000 };

            int[] result = IntegerExtraction.Extract(input);

            Assert.That(result, Is.EquivalentTo(expected));

        }


        [Test]
        public void integer_value_should_be_extracted_test()
        {
            string input = "Cooktown – 250m 1 Endeavour River Frontage, Large Acreage - $345,000";
            int[] expected = new[] { 250, 1, 345000 };

            int[] result = IntegerExtraction.Extract(input);

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(9, 34)]
        [TestCase(25, 75025)]
        public void fibonacci_number_should_be_return_based_on_index_test(int index, int expected)
        {
            int result = Fibonacci.At(index);

            Assert.AreEqual(expected, result);
        }


        public void ienumerable_for_each()
        {
            var sum = 0;

            // This is the default .Net `ForEach` function on a List<T>
            var inputList = new List<int> { 1, 2, 3 };
            inputList.ForEach(x => sum += x);

            /*
            // Implement a `ForEach` extension method on IEnumerable<T>
            var input = new int[] { 1, 2, 3 };
            input.ForEach(x => sum += x);
            */

            Assert.AreEqual(6, sum);
        }
    }
}
