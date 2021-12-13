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
    }
}
