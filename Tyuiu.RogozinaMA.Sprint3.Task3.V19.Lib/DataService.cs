using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task3.V19.Lib
{
    public class DataService: ISprint3Task3V19
    {
        public string ReplaceXOnTwo(string value)
        {
            // Создаем StringBuilder для эффективной работы со строками
            StringBuilder result = new StringBuilder();

            // Используем цикл foreach для перебора каждого символа в строке
            foreach (char ch in value)
            {
                // Если символ равен 'x', заменяем на '2', иначе оставляем как есть
                if (ch == 'x')
                {
                    result.Append('2');
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}