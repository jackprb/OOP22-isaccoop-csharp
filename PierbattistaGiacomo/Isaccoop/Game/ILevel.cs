using System;
using System.Collections.Generic;

namespace Isaccoop.Game
{
    /// <summary>
    /// Interface to model a level, which contains many <see cref="IRoom"/>.
    /// A level can be figured as a 2D grid; each room has its coordinate(i, j), that is, the indices of the
    /// <see cref="IRoom"/> itself as an element of the grid.
    /// </summary>
    public interface ILevel 
    {

        /// <summary>
        /// Inserts the specified rooms in this level.
        /// </summary>
        /// <param name="roomList">the room list to be added to this level</param> 
        /// <exception cref="InvalidOperationException">if this method is called and the level has already a room list</exception> 
        /// <exception cref="ArgumentException">if the number of rooms in roomList < 5</exception> 
        public void PutRooms(IList<IRoom> roomList);

        /// <summary>
        /// Get an unmodifiable copy of the list of all rooms in this level.
        /// </summary>
        /// <returns>an unmodifiable copy of the list containing all the rooms in this level</returns> 
        public List<IRoom> GetRooms();

        /// <summary>
        /// Get the room where the player begins.
        /// </summary>
        /// <returns> the room where the player begins</returns>
        public IRoom GetStartRoom();
    }
}
