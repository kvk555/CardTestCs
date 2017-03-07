using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            game.CreateCardPack_Click(CardType.Simple);
            game.CreateCardPack_Click(CardType.Simple);
            game.CreateCardPack_Click(CardType.Taro);
            game.CreateCardPack_Click(CardType.Taro);
            game.CreateCardPack_Click(CardType.Gwint);
            game.CreateCardPack_Click(CardType.Hearthstone);

            game.GetAllPacksList_Click();
            game.ShufflePack_Click("3-Taro");
            game.ShowSelectedCard_Click("5-Gwint", 8);
            game.ShowRandomCardFromPack_Click("6-Hearthstone");
            game.ReplaceCardFromPack_Click("3-Taro", 11, "4-Taro");
            game.ShowAllCardsFromPack_Click("5-Gwint");
                
            Console.ReadKey();

        }
    }
}
