using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            // Используем цикл foreach для замены символов
            string result = "";

            foreach (char ch in value)
            {
                // Если символ равен replaceable, заменяем на replacement
                if (ch == replaceable)
                {
                    result += replacement;
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }
    }
}