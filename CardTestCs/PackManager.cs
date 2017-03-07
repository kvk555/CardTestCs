using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /// <summary>
    /// Класс для управления колодами
    /// </summary>
    public class PackManager
    {
        #region Fields
        private Dictionary<string, List<ICard>> listPacks = new Dictionary<string, List<ICard>>(); //контейнер для всех созданных колод
        private int count;    //счетчик-регистратор созданных колод
        
        
        Random random = new Random();

        //Builders
        private SimpleCardPackBuilder simpleBuilder;
        private TaroCardPackBuilder taroBuilder;
        private GwintCardPackBuilder gwintBuilder;
        private HearthstoneCardPackBuilder hearthstoneBuilder;

        #endregion

        public PackManager()
        {
            simpleBuilder= new SimpleCardPackBuilder();
            taroBuilder=new TaroCardPackBuilder();
            gwintBuilder=new GwintCardPackBuilder();
            hearthstoneBuilder=new HearthstoneCardPackBuilder();
        }

        /// <summary>
        /// Создать колоду определенного типа
        /// </summary>
        /// <param name="cardType"></param>
        public void CreatePack(CardType cardType)
        {
            List<ICard> cards=null;
            switch (cardType)
            {
                case CardType.Simple:
                    cards= simpleBuilder.GenerateCardPack();
                    break;
                case CardType.Taro:
                    cards=taroBuilder.GenerateCardPack();
                    break;
                case CardType.Gwint:
                    cards=gwintBuilder.GenerateCardPack();
                    break;
                case CardType.Hearthstone:
                    cards=hearthstoneBuilder.GenerateCardPack();
                    break;
            }
            if(cards==null) return;
            count++;
            string key = $"{count}-{cardType}";
            listPacks[key] = cards;
        }

        /// <summary>
        ///  показать список всех созданных колод
        /// </summary>
        public void GetPacksList()
        {
            foreach (KeyValuePair<string, List<ICard>> pair in listPacks)
            {
                string key = pair.Key;
                Console.WriteLine(key + " колода");
            }
        }

        /// <summary>
        /// показать случайную карту из выбранной колоды
        /// </summary>
        /// <param name="namePack"></param>
        public void ShowRandomCard(string namePack)
        {
            if (listPacks.ContainsKey(namePack))
            {
                if (listPacks[namePack].Count == 0)
                {
                    Console.WriteLine("Колода пуста");
                }
                else
                {
                    int randomCard = (int)(random.Next(0, listPacks[namePack].Count));
                    Console.WriteLine(listPacks[namePack][randomCard].showCard());
                }
            }
            else
            {
                Console.WriteLine("Неверное название колоды");
            }
        }

        /// <summary>
        /// показать выбранную игроком карту (в выбранной колоде)
        /// </summary>
        /// <param name="namePack"></param>
        /// <param name="cardNumber"></param>
        public void ShowSelectedCard(string namePack, int cardNumber)
        {
            if (listPacks.ContainsKey(namePack))
            {
                if (listPacks[namePack].Count == 0)
                {
                    Console.WriteLine("Колода пуста");
                }
                else
                {
                    if (cardNumber < 0 || cardNumber > listPacks[namePack].Count - 1)
                    {
                        Console.WriteLine("Выберите другую карту!");
                    }
                    else
                    {
                        Console.WriteLine(listPacks[namePack][cardNumber].showCard());
                    }
                }
            }
            else
            {
                Console.WriteLine("Неверное название колоды");
            }
        }

        /// <summary>
        /// показать все карты выбранной колоды
        /// </summary>
        /// <param name="namePack"></param>
        public void ShowPack(string namePack)
        {
            if (listPacks.ContainsKey(namePack))
            {
                foreach (ICard card in listPacks[namePack])
                {
                    Console.WriteLine(card.showCard());
                }
            }
            else
            {
                Console.WriteLine("Неверное название колоды");
            }
        }

        /// <summary>
        /// добавить карту в указанную колоду (перед этим игрок должен выбрать эту карту из другой колоды такого же вида)
        /// </summary>
        /// <param name="namePackOut"></param>
        /// <param name="numberCard"></param>
        /// <param name="namePackIn"></param>
        public void TakeAndAdd(string namePackOut, int numberCard, string namePackIn)
        {
            if (listPacks.ContainsKey(namePackOut))
            {
                if (numberCard >= 0 && numberCard < listPacks[namePackOut].Count)
                {
                    if ((listPacks.ContainsKey(namePackIn)) && namePackOut.Substring(4).EndsWith(namePackIn.Substring(4), StringComparison.Ordinal))
                    {
                        listPacks[namePackIn].Add(listPacks[namePackOut][numberCard]);
                        Console.WriteLine("Карта " + listPacks[namePackOut][numberCard].showCard() + " добавлена в колоду - " + namePackIn);
                        if (listPacks[namePackOut][numberCard] != null)
                        {
                            listPacks[namePackOut].RemoveAt(numberCard);
                            Console.WriteLine("Карта удалена из колоды - " + namePackOut);
                        }
                        else
                        {
                            Console.WriteLine("Карта из колоды не удалена");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такой колоды не существует или неверно выбрана колода для перемещения");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный номер карты!");
                }
            }
            else
            {
                Console.WriteLine("Неверное название колоды");
            }
        }

        /// <summary>
        /// перетасовать выбранную колоду
        /// </summary>
        /// <param name="namePack"></param>
        public void ShufflePack(string namePack)
        {
            if (listPacks.ContainsKey(namePack))
            {
                List<ICard> newList = new List<ICard>();
                while (listPacks[namePack].Count > 0)
                {
                    int cardToMove = random.Next(listPacks[namePack].Count);
                    newList.Add(listPacks[namePack][cardToMove]);
                    listPacks[namePack].RemoveAt(cardToMove);
                }
                listPacks[namePack] = newList;
                this.ShowPack(namePack);
            }
            else
            {
                Console.WriteLine("Неверное название колоды");
            }
        }
       
    }
}
