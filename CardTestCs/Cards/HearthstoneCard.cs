using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /* Карта Hearthstone содержит уникальное изображение, показатели от 0 до 12 атаки, защиты и стоимости.  */
     
    class HearthstoneCard : ICard
    {
        private Picture picture;
        private int attack;
        private int defense;
        private int worth;

        public HearthstoneCard(Picture picture, int attack, int defense, int worth)
        {
            this.picture = picture;
            this.attack = attack;
            this.defense = defense;
            this.worth = worth;
        }

        public int Picture
        {
            get
            {
                return picture.Id;
            }
        }

        public int Attack
        {
            get
            {
                return attack;
            }
        }

        public int Defense
        {
            get
            {
                return defense;
            }
        }

        public int Worth
        {
            get
            {
                return worth;
            }
        }

        /* При демонстрации карты показываем изображение на ней (условно ID), показатель
       атаки, защиты и стоимости*/

    public virtual string showCard()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("id hearthstone picture#").Append(this.Picture).Append(" - атака: ").Append(this.Attack).Append(", защита: ").Append(this.Defense).Append(", стоимость: ").Append(this.Worth);

            return sb.ToString();
        }
    }
}
