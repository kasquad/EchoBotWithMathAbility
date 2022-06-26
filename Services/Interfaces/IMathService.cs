using Console_EchoBot.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Console_EchoBot.Services.Interfaces
{
    public interface IMathService
    {
        /// <summary>
        /// Compute result of simple math expression
        /// </summary>
        /// <param name="expression">Simple expression of two operands and one operator</param>
        /// <returns></returns>
        public Task<MathExpDTo> Compute(string expression);
    }
}
