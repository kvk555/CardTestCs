using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /// <summary>
    /// Класс для создания колоды Таро. Колода Таро состоит из 78 карт. 22 карты - "козыри"(старшие арканы) - содеоржат уникальное изображение и название, 56 карт(младшиие арканы) - имеют 4 масти и 14 достоинств каждой масти - содержат уникальное изображение, масть и достоинство
    /// </summary>
    public class TaroCardPackBuilder : ICardPackBuilder
    {
        public readonly string[] Rank = new string[] { "двойка", "тройка", "четверка", "пятерка", "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "принц", "дама", "король", "туз" };
        public readonly string[] Suit = new string[] { "ЖЕЗЛЫ", "МЕЧИ", "КУБКИ", "МОНЕТЫ" };
        public readonly string[] Trumps = new string[] { "шут", "маг", "жрица", "императрица", "император", "иерофант", "влюблённые",
            "колесница", "справедливость", "отшельник", "колесо Фортуны", "сила", "повешенный", "смерть", "умеренность", "дьявол", "башня",
            "звезда", "луна", "солнце", "суд", "мир" };

        public List<ICard> GenerateCardPack() 
        {
            List<ICard> packTaro = new List<ICard>();
            int i;                                 // используем  таккже как генератор значений для условных ID изображений
            for (i = 0; i < Trumps.Length; i++)        // присваваем козырям названия из имеющегося массива
            {
                packTaro.Add(new TaroCard((new Picture(i)), Trumps[i])); // создаем и добавляем карту в колоду
            }
            for (int j = 0; j < Suit.Length; j++)     // назначаем младшим арканам масти из имеющегося массива
            {
                for (int k = 0; k < Rank.Length; k++) // назначаем младшим арканам достоинства из имеющегося массива
                {
                    packTaro.Add(new TaroCard(new Picture(i++), Suit[j], Rank[k])); // создаем и добавляем карту в колоду
                }
            }

            return packTaro;
        }
    }
}

