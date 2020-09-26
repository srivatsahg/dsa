using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormatting
{
    /*
     * 
     * Given a date string in the format Day Month Year where:
        Day is in set {"1st", "2nd", "3rd", "4th", "5th", "6th", .... , "31st"}.
        Month is in set {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" , "Oct" , "Nov", "Dec"}.
        Year is in the inclusive range [1900, 2100]
For Example:
•	"1st Mar 1984" -> "1984-03-01"
•	"2nd Feb 2013" -> "2013-02-02"
•	"4th Apr 1990" -> "1990-04-04"
Function Description: Complete the function reformateDate in the editor below.
The function must return an array of converted date strings in the order presented.
reformateDate has the following parameter(s):
•	dates[dates[0], ..., dates[n-1]]: an array of date strings in the format Day Month Year
Constraints:
•	The values of Day, Month, Year are restricted to the value ranges specified above.
•	The given dates are guaranteed to be valid so no error handling is necessary.
•	1 <= n <= 10000
•	 Sample Input 0:
•	 10
•	 20th Oct 2052
•	 6th Jun 1933
•	 26th May 1960
•	 20th Sep 1958
•	 16th Mar 2068
•	 25th May 1912
•	 16th Dec 2018
•	 26th Dec 2061
•	 4th Nov 2030
•	 28th Jul 1963
•	 
•	 Sample Output 0:
•	 2052-10-20
•	 1933-06-06
•	 1960-05-26
•	 1958-09-20
•	 2068-03-16
•	 1912-05-25
•	 2018-12-16
•	 2061-12-26
•	 2030-11-04
•	 1963-07-28

     
         */
    class DateFormatter
    {
        static void Main(string[] args)
        {
            //Day is in set { "1st", "2nd", "3rd", "4th", "5th", "6th", .... , "31st"}.
            //Month is in set { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" , "Oct" , "Nov", "Dec"}.

            string[] dates = { "1st", "2nd", "3rd", "4th", "5th", "6th","7th","8th", "9th","10th",
                                "11th", "12th", "23rd", "14th", "15th", "16th","17th","18th", "19th","20th",
                                "21st", "22nd", "23rd", "24th", "25th", "26th","27th","28th", "29th","30th","31st"};

            string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun","July","Aug", "Sep","Oct","Nov", "Dec"};

            string[] input = { "30th Oct 1982", "5th Feb 1982", "12th Jan 1955", "22nd Oct 1953" };

            var formattedDates = reformateDate(input,dates,month);

            formattedDates.ForEach(date => Console.WriteLine(date));

            Console.ReadLine();
        }

        private static List<String> reformateDate(string[] input,string[] datesReference,string[] month)
        {
            List<String> formattedDates = new List<string>();

            foreach (var date in input)
            {
                var dateSplit = date.Split(' ');
                if(dateSplit.Length > 2)
                {
                    var stringDay = dateSplit[0];
                    var stringMonth = dateSplit[1];
                    var stringYear = dateSplit[2];
                    int formattedMonth = Array.IndexOf(month, stringMonth) + 1;
                    int formattedDay = Array.IndexOf(datesReference, stringDay) + 1;
                    var formattedDate = stringYear + "-" + formattedMonth.ToString() + "-" + formattedDay.ToString();
                    formattedDates.Add(formattedDate);
                }
                else
                {
                    formattedDates.Add("ERR");
                }
            }

            return formattedDates;
        }
    }
}
