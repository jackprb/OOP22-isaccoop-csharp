using System;
using System.Collections.Generic;

namespace Isaccoop.Model.Room
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
		void PutRooms(IList<IRoom> roomList);

		/// <summary>
		/// Get an unmodifiable copy of the list of all rooms in this level.
		/// </summary>
		/// <returns>an unmodifiable copy of the list containing all the rooms in this level</returns> 
		IList<IRoom> GetRooms();

		/// <summary>
		/// Check if this level is complete.
		/// A level is complete if all its room are complete.
		/// </summary>
		/// <returns>true if this level is complete, false otherwise</returns> 
		bool IsLevelComplete();

		/// <summary>
		/// Get the room where the player begins.
		/// </summary>
		/// <returns> the room where the player begins</returns>
		IRoom GetStartRoom();

		/// <summary>
		/// Get the room where the player currently is.
		/// </summary>
		/// <returns> the room where the player currently is</returns>
		IRoom GetCurrentRoom();

		/// <summary>
		/// Get a map containing the rooms near the current one and the direction to reach them.
		/// This map associates a <see cref="IRoom"/> to the <see cref="Direction"/> to take to reach it.
		/// </summary>
		/// <returns>a map containing the rooms near the current one and the direction to reach them</returns> 
		IDictionary<Direction, IRoom> GetNearRooms();

		/// <summary>
		/// Get the player.
		/// </summary>
		/// <returns>the player</returns>
		Player GetPlayer();

		/// <summary>
		/// Check if the current room is "completed", that is, if there are no more
		/// enemies to defeat (STANDARD room), or if the boss has been defeated (BOSS room).
		/// </summary>
		/// <returns>always true for NON-STANDARD and NON-BOSS rooms, true if all enemies in STANDARD room
		/// or the final boss in BOSS room have been defeated, false otherwise</returns> 
		bool IsCurrentRoomComplete();

		/// <summary>
		/// Return an umodifiable map of rooms where the player can go, associated with the <see cref="Direction"/>
		/// to reach them. Player can go to a room that is UP, DOWN, LEFT, RIGHT of current room.
		/// </summary>
		/// <returns>an umodifiable map of accessible rooms, near the room where the player is, and the direction
		/// to reach them</returns> 
		IDictionary<Direction, IRoom> GetAccessibleRooms();

		/// <summary>
		/// Move to the previous room.
		/// </summary>
		void MoveToPreviousRoom();

		/// <summary>
		/// Move to the next room.
		/// </summary>
		void MoveToNextRoom();
	}
}
