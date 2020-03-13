using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core_of_Rick_s_uni_project
{
    class progress
    {
        // I have assumed to put the cards or projects that the player has into these arrays. If you have another way in mind, do it in that other way and explain in the comment mode how you did.
        string[] cards = new string ["Number of cards"];
        string [,] projects = new string [ "number of diseases" , 2];
        static void Main(string[] args)
        {
            //The players chooses a name and his/her character

            // A) The player has the ability to set a card to project
           
            // B) The player has the ability to either request for a card from the other player or request for a VISIBLE project from the other player.

            // C) The player can declare the turn fininished.

            //All A, B, C, actions can be done in all turns, but B action cannot be executed in the final turn (the 70th turn).
            // After action C, action A or B cannot be executed till the next turn.
          
        
        }

        // giveGameInfo is a method which 1.clears the whole console at the beginning of a turn 2.shows all of the data of the player at first and next all of the data of the opponent (this game has only two players!)  
        static void giveGameInfo()
        {
        
        
        
        }

        // Here write down a code that receives the data of other players. 
        // this data includes: cards, number of projects, info of projects (if the project is visible), character (if it is revealed),
        //This data definitely be transferred into giveGameInfo method as well.
        
    }
}
