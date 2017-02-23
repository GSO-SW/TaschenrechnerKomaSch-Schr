using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Calculator
    {
        public Calculator()
        {
            OperationTask = new StringBuilder();
        }
        /// <summary>
        /// Our current result, of the previous calculation
        /// </summary>
        public double Ans { get; private set; }
        /// <summary>
        /// Your current OperationTask should look like 4 + 4 or 4 + ( 4 * 3 )
        /// </summary>
        public StringBuilder OperationTask { get; set; }
        public void AppendOperation(string op)
        {
            OperationTask.Append(op);
        }
        public void EraseLastOperation()
        {
            if(OperationTask.Length > 0)
                OperationTask.Remove(OperationTask.Length,1);
        }

        public string Calculate()
        {
           Ans = Evaluate(OperationTask.ToString());
           OperationTask.Clear();
           OperationTask.Append(Ans.ToString());
           return Ans.ToString();
        }

        public double Evaluate(string input)
        {
            String expr = "(" + input + ")";
            Stack<String> ops = new Stack<String>();
            Stack<Double> vals = new Stack<Double>();

            for (int i = 0; i < expr.Length; i++)
            {
                String s = expr.Substring(i, 1);
                if (s.Equals("(")) { }
                else if (s.Equals("+")) ops.Push(s);
                else if (s.Equals("-")) ops.Push(s);
                else if (s.Equals("*")) ops.Push(s);
                else if (s.Equals("/")) ops.Push(s);
                else if (s.Equals("sqrt")) ops.Push(s);
                else if (s.Equals(")"))
                {
                    int count = ops.Count;
                    while (count > 0)
                    {
                        String op = ops.Pop();
                        double v = vals.Pop();
                        if (op.Equals("+")) v = vals.Pop() + v;
                        else if (op.Equals("-")) v = vals.Pop() - v;
                        else if (op.Equals("*")) v = vals.Pop() * v;
                        else if (op.Equals("/")) v = vals.Pop() / v;
                        else if (op.Equals("sqrt")) v = Math.Sqrt(v);
                        vals.Push(v);

                        count--;
                    }
                }
                else vals.Push(Double.Parse(s));
            }
            return vals.Pop();
        }
    }
}
