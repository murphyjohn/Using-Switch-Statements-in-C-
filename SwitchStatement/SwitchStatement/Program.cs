using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSwitch(8, 4, '-');
            // TestGrade(9);
          
        }
        /* This method takes two numbers and an arithmetic operator.
         * It then outputs the result of the operation on these numbers.*/
        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown Operator");
                    return;
            }
            Console.WriteLine("Result: {0}", result);
            return;
        }

        /* This method takes in an int representing the percentage value scored in an exam and then outputs
         * the appropriate Letter grade result for that percentage */
        public static void TestGrade(int result)
        {
            String grade;
            switch (result/5)
            {
                case 20:
                case 19:
                case 18:
                case 17:
                    grade = "A";
                    break;
                case 16: case 15: case 14:
                    grade = "B";
                    break;
                case 13: case 12: case 11:
                    grade = "C";
                    break;
                case 10:b case 9: case 8:
                    grade = "D";
                    break;
                case 7: case 6: case 5:
                    grade = "E";
                    break;
                case 4: case 3: case 2:
                    grade = "F";
                    break;
                default:
                    grade = "No Grade";
                    break;
            }
            Console.WriteLine("Grade is {0}", grade);
        }

    }
}
