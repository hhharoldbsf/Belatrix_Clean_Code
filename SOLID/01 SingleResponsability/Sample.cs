using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public void Sum(int value1, int value2)
        {            
            int sum = Operations.Sum(value1, value2);
            string range = Operations.GetRange(sum);
            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", sum, range));
        }
    }    
}
