using Console_EchoBot.DTOs;
using Console_EchoBot.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Console_EchoBot.Services
{
    internal class MathService : IMathService
{
        protected readonly char[] _mathOperators =new char[] {'+','-','*','/','%'};
        public Task<MathExpDTo> Compute(string expression)
        {
            int left = 0,
                right = 0;
            double result = 0;

            var operands = expression.Split(_mathOperators, StringSplitOptions.RemoveEmptyEntries);
            var operators = expression.Split(operands, StringSplitOptions.RemoveEmptyEntries);
            MathExpDTo mathExp;

            try
            {
                string leftStr = operators.Length == 1 ? operands[0] :operators[0] + operands[0];
                left = int.Parse(leftStr);
                right = int.Parse(operands[1]);
                switch (operators.Last())
                {
                    case "+":
                        result = left + right;
                        break;
                    case "-":
                        result = left - right;
                        break;
                    case "*":
                        result = left * right;
                        break;
                    case "/":
                        if(right == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result = (double)left / right;
                        break;
                    case "%":
                        if (right == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result = (double)left % right;
                        break;
                }
                mathExp = new MathExpDTo() { Left = left, Right = right, Op = operators.Last(), Result = result, IsValid = true };
            }
            catch(Exception ex)
            {
                mathExp = new MathExpDTo() { IsValid = false, Error = ex.Message };
            }
            
            return Task.FromResult(mathExp);
        }    
}
}
