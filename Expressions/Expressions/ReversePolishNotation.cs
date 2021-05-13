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
            //  n 2 n 3 n
            //  4 5 1 3 2 
            string converted_expression = "";
            string weighted_expression = CreateWeightedExpression(expression);
            while (weighted_expression.Length > 0)
            {
                int index = GetHighestWeightIndex(weighted_expression);
                if (weighted_expression.Length > 2)
                {
                    converted_expression += expression[index - 1] + expression[index + 1] + expression[index];
                    //weighted_expression = weighted_expression.Substring(0, index-2) + weighted_expression.Substring(index + 1);
                }
                else
                { 
                
                }


            }

            
            return converted_expression; 
                //"23*1+";
        }

        private static int GetHighestWeightIndex(string weighted_string) {
            int record = 0;
            int index = 0;
            for (int i = 0; i < weighted_string.Length; i++) {
                if (weighted_string[i] != 'n' && (int)Char.GetNumericValue(weighted_string[i]) > record)
                {
                    record = (int)Char.GetNumericValue(weighted_string[i]);
                    index = i;
                }
            }
            return index;
        }

        private static string CreateWeightedExpression(string expression) {
            string weighted_expression = "";
            for (int i = 0; i < expression.Length; i++)
            {
                char letter = expression[i];
                if (isOperator(letter))
                {
                    weighted_expression += operators[letter].ToString();
                }
                else
                {
                    weighted_expression += "n";
                }
                Console.WriteLine(weighted_expression);
            }
            return weighted_expression;
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
