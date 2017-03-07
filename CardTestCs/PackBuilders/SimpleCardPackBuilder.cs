using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /// <summary>
    /// Класс для создания колоды обычных игральных карт. В обычной колоде игральных карт 52 карты(4 масти и 13 достоинств каждой масти). Игральная карта содержит уникальное изображение  масть и достоинство
    /// </summary>
    public class SimpleCardPackBuilder : ICardPackBuilder
    {
        public readonly string[] Suit = new string[] { "черви", "пики", "бубны", "трефы" };
        public readonly string[] Rank = new string[] { "двойка", "тройка", "четверка", "пятерка", "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };
        public List<ICard> GenerateCardPack()
        {
            List<ICard> packPlayingCard = new List<ICard>();
            int k = 0;                                                   // генератор условных ID изображений
            for (int i = 0; i < Suit.Length; i++)             //перечисляем масти
            {
                for (int j = 0; j < Rank.Length; j++)        //присваиваем каждой масти список всех достоинств
                {
                    packPlayingCard.Add(new SimpleCard(new Picture(k++), Rank[j], Suit[i])); // создаем и добавляем карту в колоду
                }
            }

            return packPlayingCard;
        }
    }
}

