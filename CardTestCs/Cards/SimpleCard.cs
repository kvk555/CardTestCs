using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /* Обычная Игралья карта содержит уникальное изображение, масть и достоинство.*/

    class SimpleCard : ICard
    {
        private Picture picture;
        private string rank;
        private string suit;

        public SimpleCard(Picture picture, string rank, string suit)
        {
            this.picture = picture;
            this.rank = rank;
            this.suit = suit;
        }

        public int Picture
        {
            get
            {
                return picture.Id;
            }
        }

        public string Rank
        {
            get
            {
                return rank;
            }
        }

        public string Suit
        {
            get
            {
                return suit;
            }
        }

        public string showCard()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("id игральная карта picture#").Append(this.Picture).Append(" - достоинство: ").Append(this.Rank)
                    .Append(", масть: ").Append(this.Suit);
            return sb.ToString();
        }
    }
}
