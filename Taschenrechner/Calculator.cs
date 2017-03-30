﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Calculator
    {
        public Calculator()
        {
            Expression = new StringBuilder();
        }
        /// <summary>
        /// Our current result, of the previous calculation
        /// </summary>
        public double Ans;
        /// <summary>
        /// Your current OperationTask should look like 4 + 4 or 4 + ( 4 * 3 )
        /// </summary>
        public StringBuilder Expression { get; set; }
        public void AppendOperation(string op)
        {
            Expression.Append(op);
        }
        public void EraseLastOperation()
        {
            if(Expression.Length > 0)
                Expression.Remove(Expression.Length - 1, 1);
        }
        public void ClearCurrentExpression()
        {
            Expression.Clear();
        }
        public string Calculate()
        {
            MathParser parser = new MathParser();
            bool isRadians = false;
            string toCalculate = Expression.ToString();
            Ans = parser.Parse(toCalculate, isRadians);

            Expression.Clear();
            Expression.Append(Ans.ToString());
            return Ans.ToString();
        }
    }
}
