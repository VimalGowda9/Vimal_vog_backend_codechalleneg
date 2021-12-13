using System;
using System.Collections.Generic;
using System.Linq;

namespace VogCodeChallenge.ConsoleApplication
{
    /// <summary>
    /// Question Class
    /// </summary>
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John"
        };

        /// <summary>
        /// Method to iterate through NameList and get the list of Names
        /// </summary>
        /// <returns>list of string</returns>
        public static List<string> GetListOfNames()
        {
            var names = new List<string>();
            int cnt = 0;

            while(cnt < NamesList.Count)
            {
                names.Add(NamesList.ElementAt(cnt));
                cnt++;
            }
            
            return names;
        }

        /// <summary>
        /// TestModule to return result as per the input value
        /// </summary>
        /// <param name="inputValueType">input value type</param>
        /// <param name="value">input value</param>
        /// <returns></returns>
        public static string TestModule(string inputValueType, string value)
        {
            string result;

            try
            {
                switch (inputValueType)
                {
                    case HelperConstants.oneToFour:
                        result = (int.Parse(value) * 2).ToString();
                        break;
                    case HelperConstants.greaterThanFour:
                        result = (int.Parse(value) * 3).ToString();
                        break;
                    case HelperConstants.lessThanOne:
                        throw new System.Exception();                        
                    case HelperConstants.floatValue:
                        result = "3.0";
                        break;
                    case HelperConstants.stringValue:
                        result = value.ToUpper();
                        break;
                    default:
                        result = value;
                        break;
                }
            }
            catch(Exception)
            {
                result = "Input Value can not be less than One";
            }           

            return result;
        }
    }
}
