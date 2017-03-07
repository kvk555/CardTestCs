using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    public interface ICardPackBuilder
    {
        /// <summary>
        /// Генерирует колоду и помещает ее в контейнер
        /// </summary>
        /// <returns>List of cards</returns>
        List<ICard> GenerateCardPack();
    }
}
