using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CardTestCs
{
    /* Колода Таро состоит из 78 карт. 22 карты - "козыри"(старшие арканы) - содержат уникальное изображение и название,
     * 56 карт (младшиие арканы) - имеют 4 масти и 14 достоинств каждой масти - содержат уникальное изображение,
     * масть и достоинство
     */
    class TaroCard : ICard 
        {
        private Picture picture;
        private string trump; //назвние казыря
        private string suit; //название масти
        private string rank; // достоинство

        public TaroCard(Picture picture, string trump)  //конструктор для карты "козырь"
        {                                  
            this.picture = picture;
            this.trump = trump;
        }

        public TaroCard(Picture picture, string suit, string rank)  //конструктор для карты из младшего аркана
        {                                  
            this.picture = picture;
            this.suit = suit;
            this.rank = rank;
        }

        public int Picture
        {
            get
            {
                return picture.Id;
            }
        }

        public virtual string Trump
        {
            get
            {
                return trump;
            }
        }

        public virtual string Suit
        {
            get
            {
                return suit;
            }
        }

        public virtual string Rank
        {
            get
            {
                return rank;
            }
        }

        /* При демонстрации карты "козыря" показываем изображение на ней (условно ID) и его название,
		 при демонстрации карты младшего акркана показываем изображение, масть и достоинство*/

        public virtual string showCard()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.ReferenceEquals(this.trump, null))
            {
                sb.Append("id taro picture#").Append(this.Picture).Append(" - ").Append(this.Trump);
            }
            else
            {
                sb.Append("id taro picture#").Append(this.Picture).Append(" - ").Append(this.Suit).Append(" ").Append(this.Rank);
            }
            return sb.ToString();
        }
    }
}
