using Isaccoop.Game.Common;

namespace Isaccoop.Game
{
    /// <summary>
    ///  Delegated class that contains utility methods to help <see cref="RoomBuilder"/> creating a room.
    /// </summary>
    public class RoomBuilderUtils
    {
        private readonly RoomType _roomType;

        /// <summary>
        /// Create a RoomBuilderUtils object, to access utility methods.
        /// </summary>
        /// <param name="roomType">the type of the room</param> 
        public RoomBuilderUtils(RoomType roomType) => _roomType = roomType;

        /// <summary>
        /// Check if the current room to build can have the Player object.
        /// </summary>
        /// <returns>true if the room can have the Player object, false otherwise</returns>
        public bool CanRoomHavePlayer() => _roomType == RoomType.Start;

        /// <summary>
        /// Check if the current room to build can have enemies.
        /// </summary>
        /// <returns>true if the room can have enemies, false otherwise</returns> 
        public bool CanRoomHaveEnemies() => _roomType == RoomType.Standard || _roomType == RoomType.Boss;

        /// <summary>
        /// Check if the current room to build can have powerups.
        /// </summary>
        /// <returns>true if the room can have powerups, false otherwise</returns> 
        public bool CanRoomHavePowerUps() => _roomType == RoomType.Shop || _roomType == RoomType.Treasure;

        /// <summary>
        /// Check if the current room to build can have items.
        /// </summary>
        /// <returns>true if the room can have items, false otherwise</returns> 
        public bool CanRoomHaveItems() => _roomType == RoomType.Standard;
    }
}
