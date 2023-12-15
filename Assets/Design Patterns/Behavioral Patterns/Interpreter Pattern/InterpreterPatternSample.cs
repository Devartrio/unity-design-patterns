using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

namespace DesignPatterns.Interpreter
{
    public class InterpreterPatternSample : MonoBehaviour
    {
        private void OnEnable()
        {
            string calculate = "1 + 2 + 3 - 4";
            CalculatorContext context = new CalculatorContext(calculate);
            Debug.Log($"{calculate} = {context.Evaluate()}");
        }
    }

    public interface IExpression
    {
        int Interpret();
    }

    public class Number : IExpression
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return number;
        }
    }

    public class Plus : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Plus(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }

    public class Minus : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Minus(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }

    public class CalculatorContext
    {
        private string expression;

        public CalculatorContext(string expression)
        {
            this.expression = expression;
        }

        public int Evaluate()
        {
            IExpression result = null;

            Stack<IExpression> stack = new Stack<IExpression>();

            string[] tokens = expression.Split(' ');

            for (int count = 0; count < tokens.Length; count++)
            {
                if (tokens[count].Equals("+"))
                {
                    IExpression rightExpression = new Number(int.Parse(tokens[++count]));
                    IExpression leftExpression = stack.Pop();
                    result = new Plus(leftExpression, rightExpression);
                    stack.Push(result);
                }
                else if (tokens[count].Equals("-"))
                {
                    IExpression rightExpression = new Number(int.Parse(tokens[++count]));
                    IExpression leftExpression = stack.Pop();
                    result = new Minus(leftExpression, rightExpression);
                    stack.Push(result);
                }
                else
                {
                    stack.Push(new Number(int.Parse(tokens[count])));
                }
            }


            return result.Interpret();
        }
    }
}
