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
		START,

		/// <summary>
		/// A room with enemies and obstacles.
		/// </summary>
		STANDARD,

		/// <summary>
		/// A room where you can buy power ups.
		/// </summary>
		SHOP,

		/// <summary>
		/// A room with the final boss.
		/// </summary>
		BOSS,

		/// <summary>
		/// A room that contains a free power up.
		/// </summary>
		TREASURE
	}
}
