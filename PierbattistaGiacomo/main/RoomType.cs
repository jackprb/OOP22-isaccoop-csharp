using Isaccoop.Model.Room;

namespace Isaccoop.Model.Common
{

	/// <summary>
	/// This enum lists all possible types of <see cref="IRoom"/> inside a <see cref="ILevel"/>.
	/// </summary>
	public enum RoomType 
	{
		/// <summary>
		/// An empty room where the player starts.
		/// </summary>
		Start,

		/// <summary>
		/// A room with enemies and obstacles.
		/// </summary>
		Standard,

		/// <summary>
		/// A room where you can buy power ups.
		/// </summary>
		Shop,

		/// <summary>
		/// A room with the final boss.
		/// </summary>
		Boss,

		/// <summary>
		/// A room that contains a free power up.
		/// </summary>
		Treasure
	}
}
