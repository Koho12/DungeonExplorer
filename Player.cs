using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get;  set; }
        public int Health { get;  set; }
        private List<string> inventory = new List<string>();

        /// <summary>
        /// Initializes the player with a name and health value
        /// </summary>
        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }

        /// <summary>
        /// Method to pick up an item and add it to the player's inventory
        /// </summary>
        public void addItem(string item)
        {
            inventory.Add(item);
            Console.WriteLine($"{item} added to inventory.");
        }

        /// <summary>
        /// Function which shows the contents of the player's inventory 
        /// </summary>
        public void showInv()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Empty"); 
            }
            else
            {
                Console.WriteLine("Inventory:");
                foreach (string item in inventory)
                {
                    Console.WriteLine($"-{item}");
                } 
            }
        }

        /// <summary>
        /// Displays the player's health
        /// </summary>       
        public void ShowHealth()
        {
            Console.WriteLine($"Your health is {Health}.");
        }
    }
}