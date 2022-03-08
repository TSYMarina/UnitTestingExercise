using System;


namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // DONE - Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers

        public int Add(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            return sum;
        }


        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Substract(int minuend, int subtrhend)
        {
            int result = minuend - subtrhend;
            return result;
        }

        // Create a Multiply method that passes 2 integers

        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        // Create a Divide method that passes 2 integers

        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        // Create a method that will utilize the [Fact] tests you wrote

        public string GetGreatDay()
        {
            return ("Have a great day!");
        }
    }
}
