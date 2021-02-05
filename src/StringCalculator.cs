using System;

namespace coding_dojo_dotnetcore.tests
{
    public class StringCalculator
    {
        public int Compute(params string[] input)
        {
            if (input == null || input.Length == 0 || (input.Length == 1 && input[0] == ""))
            {
                return 0;
            }

            int sum = 0;
            Array.ForEach(Array.ConvertAll(String.Join(",", input).Split(","), n => Int32.Parse(n)), n => sum+= n);
            return sum;
        }
    }
}
