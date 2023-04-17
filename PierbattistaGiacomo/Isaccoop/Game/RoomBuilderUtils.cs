using Isaccoop.Game.Common;

namespace Isaccoop.Game {
    /// <summary>
    ///  Delegated class that contains utility methods to help <see cref="RoomBuilder"/> creating a room.
    /// </summary>
    public class RoomBuilderUtils
    {
        private readonly RoomType _roomType;

        /**
         * Create a RoomBuilderUtil object, to access utility methods.
         * @param roomType the type of the room
         */
        public RoomBuilderUtils(RoomType roomType) => _roomType = roomType;

        /**
         * Check if the current room to build can have the Player object.
         * @return true if the room can have the Player object, false otherwise
         */
        public bool CanRoomHavePlayer() => _roomType == RoomType.Start;

        /**
         * Check if the current room to build can have enemies.
         * @return true if the room can have enemies, false otherwise
         */
        public bool CanRoomHaveEnemies() => _roomType == RoomType.Standard || _roomType == RoomType.Boss;

        /**
         * Check if the current room to build can have powerups.
         * @return true if the room can have powerups, false otherwise
         */
        public bool CanRoomHavePowerUps() => _roomType == RoomType.Shop || _roomType == RoomType.Treasure;

        /**
         * Check if the current room to build can have items.
         * @return true if the room can have items, false otherwise
         */
        public bool CanRoomHaveItems() => _roomType == RoomType.Standard;
    }
}
