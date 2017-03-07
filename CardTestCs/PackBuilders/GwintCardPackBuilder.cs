using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /// <summary>
    /// Класс для создания колоды карт Gwint. В обычной колоде Gwint 40 карт.Каждая карта содержит описание силы, способности и стоимости.
    /// </summary>
    public class GwintCardPackBuilder : ICardPackBuilder
    {
        private readonly int amountCard = 40;    // количество карт в колоде
        private readonly int maxStrong = 13;    // показатель силы может быть от 0 до 12
        private readonly int amountWorth = 4;  // имеется 4 показателя стоимости (белый, синий, фиоллетовый, оранжевый)
        public  readonly string[] Worth = new string[] {"белый", "синий", "фиолетовый", "оранжевый"};

        public List<ICard> GenerateCardPack()
        {
            List<ICard> packGwint = new List<ICard>();
            Random rnd = new Random();
            for (int i = 0; i < amountCard; i++)
            {
                string abilityText = "sometext " + i;       // генерируем уникальный текст с описанием способности
                int randomStrong = rnd.Next(0, maxStrong); // генерируем показатель силы в пределах 0..12
                int randomWorth = rnd.Next(0, amountWorth); // выбираем цвет способности из 4 имеющихся вариантов
                packGwint.Add(new GwintCard(new Picture(i), randomStrong, abilityText, Worth[randomWorth])); // создаем и добавляем карту в колоду
            }

            return packGwint;
        }
    }
}
