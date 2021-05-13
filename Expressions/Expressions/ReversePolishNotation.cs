using System;
using System.Collections.Generic;
using System.Text;

namespace Expressions
{
    class ReversePolishNotation
    {
        private static readonly Dictionary<char, int> operators = new Dictionary<char, int>()
        {
            {'=',0},
            {'(',1},
            {'+',2},
            {'-',2},
            {')',2},
            {'/',3},
            {'*',3},
            {'^',4},
        };

        public static Double Evaluate(string expression) {
            for (int i = 0; i < expression.Length; i++) 
            { 
                
            }

            return 1.0;
        }

        public static string Convert(string expression) {
            // "1 + 2 * 3"
            //  4 5 1 3 2 
            string converted_expression = "";
            string weighted_expression = ""
            Dictionary<string, int>  { }
            
            for (int i = 0; i < expression.Length; i++)
            {
                char letter = expression[i];
                if (isOperator(letter) == false)
                {

                }
            }
            return "23*1+";
        }

        private static bool isOperator(char character)
        {
            if (operators.ContainsKey(character))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
