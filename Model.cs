using System;
using System.Collections;

namespace CyberHW12_4
{
    class Model
    {
       
        private ArrayList StringToExpression(string input)
        {
            ArrayList Values = new ArrayList();
            double x = 0;
            int k = 1;
            bool writed = false;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (!IsOperator(input[i]))
                {
                    writed = false;
                    x += (input[i] - 48) * k;
                    k *= 10;
                }
                else
                {
                    k = 1;
                    if (input[i] == '-')
                    {
                        x *= -1;
                        Values.Add(x);
                            if (!IsOperator(input[i - 1]))
                            {
                                Values.Add('+');

                            }
                        else writed = true;
                    }
                    else
                    {
                        if (!writed)
                        {
                            Values.Add(x);
                        }
                        Values.Add(input[i]);
                    }
                    x = 0;
                }
                if (!IsOperator(input[i]) && i == 0)
                {
                    Values.Add(x);
                }
            }
            return Values;
        }

        private string RedactInput(string input)
        {
            if (IsOperator(input[^1]))
            {
                if (FirstQOperator(input[^1])) input = input.Substring(0, input.Length - 1);
                else if (IsOperator(input[^2])) input = input.Substring(0, input.Length - 2);
                else input = input.Substring(0, input.Length - 1);
            }
            if (input[0] == '-')
            {
                input = "0" + input;
            }
            return input;
        }

        private bool FirstQOperator(char value)
        {
            if (value == '*' || value == '/') return true;
            else return false;
        }

        private bool SecondQOperator(char value)
        {
            if (value == '-' || value == '+') return true;
            else return false;
        }

        private bool IsOperator(char value)
        {
            if (value == '+' || value == '*' || value == '/' || value == '-') return true;
            else return false;
        }

        public string Culc(string input)
        {
            input = RedactInput(input);
            double res = 0;
            ArrayList Expression = StringToExpression(input);
            for (int i = Expression.Count - 1; i >= 0; i--)
            {
                if (Expression[i].ToString() == "*")
                {
                    i--;
                    Expression[i] = Convert.ToDouble(Expression[i]) * Convert.ToDouble(Expression[i + 2]);
                    Expression[i + 2] = 0;
                }
                if (Expression[i].ToString() == "/")
                {
                    i--;
                    double y = Convert.ToInt32(Expression[i]);
                    double x = Convert.ToInt32(Expression[i + 2]);
                    if (y == 0) return "Input Error (x/0)";
                    double z = x / y;
                    Expression[i] = z;
                    Expression[i + 2] = 0;
                }
            }
            for (int i = Expression.Count - 1; i >= 0; i--)
            {
                if (!(Expression[i].ToString() == "+" || Expression[i].ToString() == "*" || Expression[i].ToString() == "/" || Expression[i].ToString() == "-"))
                {
                    res += Convert.ToDouble(Expression[i]);
                }
            }
            return res.ToString();
        }

        public bool BadValue(string input)
        {
            if (input == "Input Error (x/0)") return true;
            if (input.Contains(',')) return true;
            return false;
        }

        public bool IsRepOperators(string input)
        {
            if (input.Length > 1)
            {
                if (IsOperator(input[^1])) return true;
                else return false;
            }
            else return false;
        }

        public bool IsDoubleMinus(string input)
        {
            if (input.Length > 1)
            {
                if (input[^1] == '-') return true;
                else return false;
            }
            else return false;
        }

        public bool IsPlusMinus(string input)
        {
            if (input.Length > 1)
            {
                if (input[^1] == '+') return true;
                else return false;
            }
            else return false;
        }
    }
}
