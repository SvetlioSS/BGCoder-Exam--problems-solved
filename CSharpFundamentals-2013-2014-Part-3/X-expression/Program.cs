using System;

class Program
{
    private static string CalculateExpressionInBrackets(string expression)
    {
        int index = 0;
        while (true)
        {
            if (expression[index] == '=')
            {
                break;
            }
            if (expression[index] == '+')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('+'));
                double number = Convert.ToDouble(numToAdd) +
                             Convert.ToInt32(expression[index + 1].ToString());
                expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                index = -1;
            }
            else if (expression[index] == '/')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('/'));
                double number = Convert.ToDouble(numToAdd) /
                             Convert.ToInt32(expression[index + 1].ToString());
                expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                index = -1;
            }
            else if (expression[index] == '*')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('*'));
                double number = Convert.ToDouble(numToAdd) *
                             Convert.ToInt32(expression[index + 1].ToString());
                expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                index = -1;
            }
            else if (index != 0 && expression[index] == '-')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('-'));
                double number = Convert.ToDouble(numToAdd) -
                             Convert.ToInt32(expression[index + 1].ToString());
                expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                index = -1;
            }
            index++;
        }
        return expression;
    }

    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        int index = 0;
        while (true)
        {
            if (expression[index] == '=')
            {
                break;
            }
            if (index == 0 && expression[index] == '(')
            {
                string numToAdd = CalculateExpressionInBrackets(expression.Substring(expression.IndexOf('(') + 1, expression.IndexOf(')') - expression.IndexOf('(') - 1) + "=");
                numToAdd = numToAdd.Remove(numToAdd.Length - 1);
                expression = numToAdd + expression.Remove(expression.IndexOf('('), expression.IndexOf(')') + 1);
                index = -1;
            }
            else if (expression[index] == '+')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('+'));
                double number = Convert.ToDouble(numToAdd);
                if (expression[index+1] == '(')
                {
                    string numToAdd2 = CalculateExpressionInBrackets(expression.Substring(expression.IndexOf('(') + 1, expression.IndexOf(')') - expression.IndexOf('(') - 1) + "=");
                    numToAdd2 = numToAdd2.Remove(numToAdd2.Length - 1);
                    number += Convert.ToDouble(numToAdd2);
                    expression = number.ToString() + expression.Remove(0, expression.IndexOf(')')+1);
                }
                else
                {
                    number += Convert.ToInt32(expression[index + 1].ToString());
                    expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                }
                index = -1;
            }
            else if (expression[index] == '/')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('/'));
                double number = Convert.ToDouble(numToAdd);
                if (expression[index + 1] == '(')
                {
                    string numToAdd2 = CalculateExpressionInBrackets(expression.Substring(expression.IndexOf('(') + 1, expression.IndexOf(')') - expression.IndexOf('(') - 1) + "=");
                    numToAdd2 = numToAdd2.Remove(numToAdd2.Length - 1);
                    number /= Convert.ToDouble(numToAdd2);
                    Math.Round(number, 2);
                    expression = number.ToString() + expression.Remove(0, expression.IndexOf(')') + 1);
                }
                else
                {
                    number /= Convert.ToInt32(expression[index + 1].ToString());
                    Math.Round(number, 2);
                    expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                }
                index = -1;
            }
            else if (expression[index] == '*')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('*'));
                double number = Convert.ToDouble(numToAdd);
                if (expression[index + 1] == '(')
                {
                    string numToAdd2 = CalculateExpressionInBrackets(expression.Substring(expression.IndexOf('(') + 1, expression.IndexOf(')') - expression.IndexOf('(') - 1) + "=");
                    numToAdd2 = numToAdd2.Remove(numToAdd2.Length - 1);
                    number *= Convert.ToDouble(numToAdd2);
                    expression = number.ToString() + expression.Remove(0, expression.IndexOf(')') + 1);
                }
                else
                {
                    number *= Convert.ToInt32(expression[index + 1].ToString());
                    expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                }
                index = -1;
            }
            else if (index != 0 && expression[index] == '-')
            {
                string numToAdd = expression.Substring(0, expression.IndexOf('-'));
                double number = Convert.ToDouble(numToAdd);
                if (expression[index + 1] == '(')
                {
                    string numToAdd2 = CalculateExpressionInBrackets(expression.Substring(expression.IndexOf('(') + 1, expression.IndexOf(')') - expression.IndexOf('(') - 1) + "=");
                    numToAdd2 = numToAdd2.Remove(numToAdd2.Length - 1);
                    number -= Convert.ToDouble(numToAdd2);
                    expression = number.ToString() + expression.Remove(0, expression.IndexOf(')') + 1);
                }
                else
                {
                    number -= Convert.ToInt32(expression[index + 1].ToString());
                    expression = number.ToString() + expression.Remove(0, 2 + numToAdd.Length);
                }
                index = -1;
            }
            index++;
        }
        double tmp = Convert.ToDouble(expression.Remove(expression.Length - 1));
        Console.WriteLine("{0:0.00}",tmp);
        //string expression = "6+7-9-5*2*2+5+5/2=";
        //string exp = CalculateExpressionInBrackets(expression);
        //Console.WriteLine(exp.Remove(exp.LastIndexOf('=')));
    }
}

