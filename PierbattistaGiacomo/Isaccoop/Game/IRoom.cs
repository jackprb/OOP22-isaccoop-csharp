using Isaccoop.Game.Common;

namespace Isaccoop.Game
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
        public RoomType GetRoomType();

        /// <summary>
        /// return width of this room.
        /// </summary>
        ///  <returns> the width of this room </returns> 
        public int GetWidth();

        /// <summary>
        /// return height of this room.
        /// </summary>
        ///  <returns>the height of this room </returns>
        public int GetHeight();
    }
}
