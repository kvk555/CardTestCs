using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /// <summary>
    /// Класс для создания колоды Hearthstone. В обычной колоде Hearthstone 30 карт.Карта Hearthstone содержит уникальное изображение, показатели от 0 до 12 атаки. защиты и стоимости.
    /// </summary>
    public class HearthstoneCardPackBuilder : ICardPackBuilder
    {
        private readonly int amountCard = 30;
        private readonly int maxValue = 11; //максимальная величина показателей для генерации случайных значений

        public List<ICard> GenerateCardPack()
        {
            List<ICard> packHearthstone = new List<ICard>();
            Random rnd = new Random();
            for (int i = 0; i < amountCard; i++)
            {
                int randomAttack = rnd.Next(0, maxValue); //генеруем покзатель атаки
                int randomDefense = rnd.Next(0, maxValue); //генеруем покзатель защиты
                int randomWorth = rnd.Next(0, maxValue); //генеруем покзатель стоимости
                packHearthstone.Add(new HearthstoneCard(new Picture(i), randomAttack, randomDefense, randomWorth));
                    // создаем и добавляем карту в колоду
            }

            return packHearthstone;
        }
    }
}
