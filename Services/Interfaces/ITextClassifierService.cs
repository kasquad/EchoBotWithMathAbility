using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Console_EchoBot.Services.Interfaces
{
    public interface ITextClassifierService
    {
        /// <summary>
        /// Checks if a string is a simple expression e.g. 4+2, -5+6
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Task<bool> IsSimpleMathExpression(string text);
    }
}
