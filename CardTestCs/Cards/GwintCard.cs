using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /* Карта Gwint содержит уникальное изображение, показатель силы (от 0 до 12), описание способности (уникальный текст)
     * и стоимость (в виде обозначения четырех цветов (белый, синий, фиолетовый,оранжевый))
     */
    public class GwintCard : ICard
    {

        private Picture picture;
        private int strong;
        private string ability;
        private string worth; 

        public GwintCard(Picture picture, int strong, string ability, string worth)
        {
            this.picture = picture;
            this.strong = strong;
            this.ability = ability;
            this.worth = worth;
        }

        public int Picture
        {
            get
            {
                return picture.Id;
            }
        }


        public int Strong
        {
            get
            {
                return strong;
            }
        }

        public string Ability
        {
            get
            {
                return ability;
            }
        }

        public string Worth
        {
            get
            {
                return worth;
            }
        }

        /* При демонстрации карты показываем изображение на ней (условно ID), показатель
		силы, описание способности и стоимость (цвет) */

    public string showCard()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("id gwint picture#").Append(this.Picture).Append(" - сила: ").Append(this.Strong).Append(", способность: ").Append(this.Ability).Append(", стоимость: ").Append(this.Worth);

            return sb.ToString();
        }
    }

}
