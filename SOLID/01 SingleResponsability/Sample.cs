using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public void Main(int value1, int value2)
        {            
            int sum = Operations.Sum(value1, value2);
            string range = GetRange(sum);
            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", sum, range));
        }

        private string GetRange(int value)
        {
            if (Operations.IsBetween(value, 10, 20)) return "Value between 0 and 10";
            else if (Operations.IsBetween(value, 10, 20)) return "Value between 11 and 20";
            else if (Operations.IsBetween(value, 20, 30)) return "Value between 21 and 30";
            else return "Value is greather than 30";
        }
    }    
}
