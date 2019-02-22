using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class URLEncoder
    {
        static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }
    
        static string CreateURL(string project_name, string activity_name)
        {
            Console.WriteLine("You entered: {0}", activity_name);
            Console.WriteLine("Your URL is: http://companyserver.com/content/{0}/files/{1}/{2}Report.pdf", project_name, activity_name, activity_name);
        }

        static string GetUserInput()
        {
            Console.WriteLine("Enter the company's project name: ");
            string project_name;
            project_name = Console.ReadLine();
            Console.WriteLine("You entered: {0}", project_name);
            string activity_name;
            Console.WriteLine("Enter the company's activity name: ");
            activity_name = Console.ReadLine();
        }
        static bool IsValid(string input)
        {

        }

        static string Encode(string value)
        {
            string encodedValue = "";
            foreach (char character in value.ToCharArray())
            {
                if (character == 0x1F) ;
            }
            return encodedValue;
        }
    }
}
