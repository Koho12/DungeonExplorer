using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        private List<string> items;

        /// <summary>
        /// Initialises the Room with a description and a list of items
        /// </summary>
        public Room(string description, List<string> items)
        {
            this.description = description;
            this.items = items;
        }

        /// <summary>
        /// Gives a description of the room
        /// </summary>
        public string GetDescription()
        {
            if (items.Count == 0)
            {
                description = "The room is cold and musty, a rusted iron cage sits in the corner, empty but unsettling. There is nothing of note here, what will you do?";
            }
            else
            {
                description = "The room is cold and musty, a rusted iron cage sits in the corner, empty but unsettling. There is a" + string.Join(",", items) + "on the floor";
            }
            return description;
        }

        /// <summary>
        /// Adds an item to the room
        /// </summary>
        public void RemoveItems(string item)
        {
            items.Remove(item);
        }

        /// <summary>
        /// Removes the item from the room when picked up by the player
        /// </summary>
        public List<string> GetItems()
        {
            return items;
        }
    }

    
}