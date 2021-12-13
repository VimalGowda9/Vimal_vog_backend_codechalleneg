using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.ConsoleApplication
{
    /// <summary>
    /// VogCode class
    /// </summary>
    public class VogCode
    {
        /// <summary>
        /// Main class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("############ Part-1 ############");
            Console.WriteLine("Please find below the list of Valid Names:");

            var nameList = GetNames();

            if(nameList != null)
            {
                string result = string.Join(Environment.NewLine, nameList);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Sorry for the inconvenience. At present, no Valid Names are available in the System");
            }

            Console.WriteLine("############ Part-2 ############");
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine(String.Format(" Attempt {0} :- Please enter your input", i));
                string input = Console.ReadLine();

                Console.WriteLine(ApplyConditions(input));
                Console.WriteLine();
            }            
        }

        /// <summary>
        /// Method to get list of names from QuestionClass
        /// </summary>
        /// <returns>List of names</returns>
        private static List<string> GetNames()
        {
            return QuestionClass.GetListOfNames();            
        }

        /// <summary>
        /// Method to check the type of input value and accordingly create the result
        /// </summary>
        /// <param name="inputValue">input value</param>
        /// <returns>string value</returns>
        private static string ApplyConditions(string inputValue)
        {
            string inputValueType = string.Empty;
            inputValueType = GetTheTypeOfInputValue(inputValue);

            return QuestionClass.TestModule(inputValueType, inputValue);

        }

        /// <summary>
        /// Method to identify the type of the input variable
        /// </summary>
        /// <param name="inputValue">input value</param>
        /// <returns>string</returns>
        private static string GetTheTypeOfInputValue(string inputValue)
        {
            int inputVal;
            bool isIntValue = int.TryParse(inputValue, out inputVal);

            float floatVal;
            bool isFloatValue = float.TryParse(inputValue, out floatVal);

            bool isStringValue = inputValue is string;
            string inputValueType = String.Empty;
            List<int> valueBetweenOneTOFour = new List<int> { 1, 2, 3, 4 };

            if (isIntValue)
            {
                if (valueBetweenOneTOFour.Contains(inputVal))
                {
                    inputValueType = HelperConstants.oneToFour;
                }
                else if (inputVal > 4)
                {
                    inputValueType = HelperConstants.greaterThanFour;
                }
                else if (inputVal < 1)
                {
                    inputValueType = HelperConstants.lessThanOne;
                }
            }
            else if (isFloatValue && (floatVal == 1.0f || floatVal == 2.0f))
            {
                inputValueType = HelperConstants.floatValue;
            }
            else if (isStringValue)
            {
                inputValueType = HelperConstants.stringValue;
            }
            else
            {
                inputValueType = HelperConstants.unKnownValue;
            }

            return inputValueType;
        }
    }
}
