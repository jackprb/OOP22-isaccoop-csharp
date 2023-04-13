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
	}
}
