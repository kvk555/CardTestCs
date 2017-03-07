using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTestCs
{
    /// <summary>
    /// Main game class
    /// </summary>
    public class Game
    {
        PackManager manager;

        /// <summary>
        /// Launch the game
        /// </summary>
        public void Start()
        {
            manager = new PackManager();
            //InitUI();
        }

        public void CreateCardPack_Click(CardType type)
        {
            manager.CreatePack(type);          
        }
         
        public void GetAllPacksList_Click()
        {
            manager.GetPacksList(); 
        }

        public void ReplaceCardFromPack_Click(string clickPackOut, int clickCard, string clickPackIn)
        {
            manager.TakeAndAdd(clickPackOut, clickCard, clickPackIn);
        }

        public void ShowSelectedCard_Click(string clickPack, int clickCard)
        {
            manager.ShowSelectedCard(clickPack, clickCard);
        }

        public void ShowRandomCardFromPack_Click(string clickPack)
        {
            manager.ShowRandomCard(clickPack);
        }

        public void ShowAllCardsFromPack_Click(string clickPack)
        {
            manager.ShowPack(clickPack);
        }

        public void ShufflePack_Click(string clickPack)
        {
            manager.ShufflePack(clickPack);
        }
    }
}
