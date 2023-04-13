using System.Collections.Generic;

namespace Isaccoop.Model.Room 
{

	/// <summary>
	/// Interface to model the concept of Room inside the game.
	/// </summary>
	public interface IRoom 
	{

		/// <summary>
		///  Get the <see cref="RoomType"/> of the room, that is, the type of the room itself.
		/// </summary>
		///  <returns> the type of ths room </returns>
		RoomType GetRoomType();

		/// <summary>
		///  Get the <see cref="AIEnemy"/> attached to this <see cref="IRoom"/>.
		///  </summary>
		///  <returns> <see cref="AIEnemy"/> attached to this <see cref="IRoom"/>, or null
		///  if there is not an <see cref="AIEnemy"/> in this room </returns> 
		AIEnemy GetRoomAI();

		/// <summary>
		///  Get the list of <see cref="Item"/>s in this room.
		/// </summary>
		///  <returns> the list of items in this room, or null
		///  if there is not a list of <see cref="Item"/>s in this room. </returns>
		IList<Item> GetItems();

		/// <summary>
		///  Get the list of <see cref="PowerUp"/> in this room.
		/// </summary>
		///  <returns>the list of <see cref="PowerUp"/>s in this room, or null
		///  if there is not a list of <see cref="PowerUp"/>s in this room. </returns> 
		IList<PowerUp> GetPowerUps();

		/// <summary>
		///  Get the <see cref="Player"/>.
		/// </summary>
		///  <returns> the player, or null
		///  if the <see cref="Player"/>} is not in this room. </returns> 
		Player GetPlayer();

		/// <summary>
		///  Get the list of <see cref="Enemy"/>.
		/// </summary>
		///  <returns> the list of <see cref="Enemy"/>, or null
		///  if there are no <see cref="Enemy"/> in this room. </returns>
		IList<Enemy> GetEnemies();

		/// <summary>
		/// return width of this room.
		/// </summary>
		///  <returns> the width of this room </returns> 
		int GetWidth();

		/// <summary>
		/// return height of this room.
		/// </summary>
		///  <returns>the height of this room </returns>
		int GetHeight();

		/// <summary>
		///  Check if this room is complete.
		///  A room is complete if all enemies in there are defeated.
		///  Rooms with neither enemies nor boss are already complete.
		/// </summary>
		///  <returns> true if this room is complete, false otherwise </returns>
		bool IsComplete();

		/// <summary>
		///  Put the player inside this room. To be used together with <see cref="RemovePlayer"/>
		///  to move a player from a Room to another.
		/// </summary>
		///  <param name="player">the player to be placed in this room.</param>
		///  <returns> true if the player has been placed successfully in this room, false otherwise </returns>
		bool AddPlayer(Player player);

		/// <summary>
		///  Remove the player from this room. To be used together with <see cref="AddPlayer"/>
		///  to move a player from a Room to another.
		/// </summary>
		///  <returns> true if the player has been removed successfully from this room, false otherwise </returns>
		bool RemovePlayer();
	}
}
