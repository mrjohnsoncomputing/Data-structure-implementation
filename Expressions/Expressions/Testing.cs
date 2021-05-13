using System;
using System.Collections.Generic;
using System.Text;

namespace Expressions
{
    class Testing
    {
        public static void TestRPN() {
            string[] expressions = { "1+2*3", "3/2-1", "(1+2)*3" };
            string[] RPNexpressions = { "+*123", "-/321", "*+123" };
            Double[] answers = { 7.0, 0.5, 9.0 };

            for (int i = 0; i < expressions.Length; i++) 
            {
                Console.WriteLine("Test #" + (i+1).ToString() + "\n#############\nConverting " + expressions[i] + " to Reverse Polish Notation" );
                string conversion = ReversePolishNotation.Convert(expressions[i]);
                if (conversion == RPNexpressions[i])
                {
                    Console.WriteLine("Test PASS");
                    Console.WriteLine(expressions[i] + " successfully converted to " + conversion);
                }
                else
                {
                    Console.WriteLine("Test FAIL");
                    Console.WriteLine(expressions[i] + " converted to " + conversion + "which is incorrect");
                }
                Console.WriteLine("\n\n");


            }

        }
    }
}
