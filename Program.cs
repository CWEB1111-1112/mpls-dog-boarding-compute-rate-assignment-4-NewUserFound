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
            
            //call welcome method
            welcome();

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
            
            //call Conclusion module
            conclusion(number_of_days, add_on_code, compute_rate);

        }
        //Welcome Module
        static void welcome(){
            System.Console.WriteLine("Welcome to MPLS Dog Boarding Compute Rate Program\nThis program will compute the rate of your dogs stay based on a standard rate of $75.00\nor Two add-on packages, Package A: Bathing and Grooming for $169.00 per day or Package C: Bathing for $112.00 per day.\n");
        }
        //Conclusion Module
        static void conclusion(int number_of_days, string add_on_code, double compute_rate){

            //safeguard for entering only valid codes and conclusion of program
            if(add_on_code == "A" || add_on_code == "C" || add_on_code == "NONE"){
                Console.WriteLine(String.Format($"Number of days for stay: [{number_of_days}] Add on Services Code: [{add_on_code}] Total cost of stay: [${compute_rate}]\nThank you for using MPLS Dog Boarding Compute Rate Program"));
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
