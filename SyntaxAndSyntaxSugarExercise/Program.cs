namespace SyntaxAndSyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Example from lecture
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + "greater than or equal to nine";
            //}

            int answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);

            //inferred typing
            var answerInferred = 4;
            string responseInferred;

            if (answerInferred < 9)
            {
                responseInferred = answerInferred + "is less than nine";
            }
            else
            {
                responseInferred = answerInferred + "greater than or equal to nine";
            }

            //String Interpolation
            int answerInterpolation = 4;
            string responseInterpolation;

            if (answerInterpolation < 9)
            {
                responseInterpolation = answerInterpolation + " is less than nine";
            }
            else
            {
                responseInterpolation = answerInterpolation + "greater than or equal to nine";
            }

            Console.WriteLine($"The answer was {answerInterpolation} and the response was {responseInterpolation}, so the IF Statement is true!");

            //Ternary operator
            int ternaryFirstNumber = 4;
            int ternarySecondNumber = 9;
            var ternaryTrue = (ternaryFirstNumber < ternarySecondNumber) ? "that is true!" : "that is false!";

        }
    }
}