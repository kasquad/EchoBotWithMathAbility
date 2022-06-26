using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EchoBot.DTOs
{
    public class MathExpDTo
    {
        public int Left,
                   Right;
        public double Result;
        public string Op;
        public bool IsValid;
        public string Error;

        public override string ToString()
        {
            if (IsValid)
                return $"Первое число -> {Left}\nВторое число -> {Right}\nАрифмитический оператор -> {Op}\nРезультат = {Result}";
            return $"Ошибка математической операции: {Error}";
        }
    }
}
