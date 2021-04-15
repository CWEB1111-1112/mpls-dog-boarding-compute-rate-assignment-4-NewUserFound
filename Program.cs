using System;
//Comment Latest Name and Date
namespace assignment_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int number_of_days;
            double compute_rate;
            string add_on_code;

            //Recieve data for computeRate methods
            System.Console.WriteLine("Enter the number of days the dog will stay: ");
            number_of_days = Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine("Will the dog require add-on services: [Y] or [N]");

            //Decision logic for add-on services
            if(Console.ReadLine().ToUpper() == "Y"){
                System.Console.WriteLine("Enter your add-on service code: [A] or [C]");
                add_on_code = Console.ReadLine().ToUpper();
                compute_rate = computeRate(number_of_days, add_on_code);
            }else{
                compute_rate = computeRate(number_of_days);
                add_on_code = "NONE";
            }

            //safeguard for entering only valid codes and conclusion of program
            if(add_on_code == "A" || add_on_code == "C" || add_on_code == "NONE"){
                Console.WriteLine(String.Format($"Number of days for stay: [{number_of_days}] Add on Services Code: [{add_on_code}] Total cost of stay: [${compute_rate}]"));
            }else{
                System.Console.WriteLine("Code entered was invalid");
            }
            

        }

        //Overloaded method with one argument
        static double computeRate(int number_of_days)
        {
            //declare variables
            const double STANDARD_RATE = 75.00;
            double compute_rate;

            //Convert days from int to double
            Convert.ToDouble(number_of_days);

            //compute rate with standard function
            compute_rate = number_of_days * STANDARD_RATE;

            //return total value
            return compute_rate;
        }


        //Overloaded method with two arguments
        static double computeRate(int number_of_days, string add_on_code)
        {
            //declare variables
            const double ADD_ON_RATE_A = 169.00, ADD_ON_RATE_C = 112.00;
            double compute_rate = 0;

            //Convert days from int to double
            Convert.ToDouble(number_of_days);

            //Decision logic for add-on, by code
            if(add_on_code == "A"){
                compute_rate = number_of_days * ADD_ON_RATE_A;
            }
            else if(add_on_code == "C"){
                compute_rate = number_of_days * ADD_ON_RATE_C;
            }

            //return total value
            return compute_rate;
        }
    }
}
