using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTests.Tester
{
    public class FizzBuzzTester
    {
        public static Tuple<bool,string> VerifyString(string input, params char[] splitter)
        {
            Tuple<bool,string> result = new Tuple<bool, string>(true,"Success!");


            string[] resultArray = input.Split(splitter);

            for (int i = 0; i < resultArray.Length; i++)
            {
                string missingString = string.Empty;
                int locationNumber = i + 1;

                if(locationNumber % 3 == 0 && !resultArray[i].StartsWith("fizz"))
                {
                    missingString = "fizz";

                }
                if (locationNumber % 5 == 0 && !resultArray[i].EndsWith("buzz"))
                {
                    missingString += "buzz";
                }

                if (locationNumber % 3 != 0 && locationNumber % 5 != 0 && resultArray[i] != locationNumber.ToString())
                {
                    missingString = locationNumber.ToString();
                }

                if (!string.IsNullOrEmpty(missingString))
                {
                    result = new Tuple<bool, string>(false,$"Expecting {missingString} at position {locationNumber} but found {resultArray[i]}");
                    break;
                }
            }

            return result;

        } 
    }
}
