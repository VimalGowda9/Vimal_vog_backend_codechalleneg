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
        }

        /// <summary>
        /// Method to get list of names from QuestionClass
        /// </summary>
        /// <returns>List of names</returns>
        private static List<string> GetNames()
        {
            return QuestionClass.GetListOfNames();            
        }
    }
}
