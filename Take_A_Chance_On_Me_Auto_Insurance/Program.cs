using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_A_Chance_On_Me_Auto_Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To TAKE A CHANCE ON ME AUTO INSURANCE !!!\n\n " +
                " NOTE: A subsidary of the ABBA GROUP ( the fine folks that brought you: Dancing Queen Personal Injury Insurance\n" +
                "         Make those pesky Doctor's bills accumulated from frequent mishaps at the local bar's 70's Themed Lady's Night!!! \n" +
                "         Worry No More!! Those DISCO-BALL INDUCED dizzy spells\n" +
                "         and subsequent injuries from drunkenly dancing on table-tops, speakers, etc. topless need not get you down !!!!! \n " +
                "         Make those troubles a thing of the past !!! 'cuz WE'VE GOT YOU COVERED!!!\n" +
                "         ... So you can keep on Gettin' Down!!!\n\n");
            Console.WriteLine("Let's Get You Started with TAKE A CHANCE ON ME AUTO INSURANCE... \n\n" +
                "Take a brief moment to provide the necessary information: \n");

            Console.WriteLine("Applicant's Name:\n");
            string applicantName = Console.ReadLine();

            Console.WriteLine("Applicant's Age: ");
            int applicantAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (answer: \"true\" or\"false\")");
            bool previousDUI = Convert.ToBoolean(Console.ReadLine());
            int dui = Convert.ToInt32(previousDUI);

            Console.WriteLine("How many speeding tickets have you had in the last 3 years?");
            int numSpeedingTickets = Convert.ToInt32(Console.ReadLine());

            //Qualification Rules Implemented and Evaluated
            bool insuranceQualVerification = applicantAge > 15 &&  dui < 1  &&  numSpeedingTickets <  3;

            // Response

            Console.WriteLine("Verification Output for: \n " + applicantName + " \nAge: " + applicantAge);
            Console.WriteLine("DUI Status: " + Convert.ToString(previousDUI) + "\nNumber of Speeding Tickets: " + Convert.ToString(numSpeedingTickets));
            Console.WriteLine("\n\nQualified To Continue with Application Process? " + insuranceQualVerification);
            Console.ReadLine();
        }
    }
}
         


