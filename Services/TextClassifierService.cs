using Console_EchoBot.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console_EchoBot.Services
{
    internal class TextClassifierService : ITextClassifierService
{
        protected readonly string _mathPattern = @"^[+-]?\d+?[-+*/%](\d+)?";
        public Task<bool> IsSimpleMathExpression(string text)
        {
            var matches = Regex.Matches(text, _mathPattern);
            if (matches.Count == 1 && matches[0].Length == text.Length)
                return Task.FromResult(true);
            return Task.FromResult(false);
        }
}
}
