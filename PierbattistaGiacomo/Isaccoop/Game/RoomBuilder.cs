using Isaccoop.Game.Common;
using System;

namespace Isaccoop.Game
{
    /// <summary>
    /// Class to model the Builder pattern, to build a <see cref="IRoom"/> using the "fluent" style.
    /// </summary>
    public class RoomBuilder
    {
        // messages used when an exception is thrown
        private static readonly string ItemsInStandardRoom = "only STANDARD rooms can have items";
        private static readonly string EnemiesBossStandardRoom = "only STANDARD and BOSS rooms can have enemies";
        private static readonly string PowerUpsShopTreasureRoom = "only SHOP and TREASURE room can have powerups";
        private static readonly string IncorrectRoomConfig = "the room cannot be built: some required fields are not set";

        /// <summary>
        /// Inner class to actually implement the <see cref="RoomBuilder"/>.
        /// </summary>
        public class Builder
        {
            //basic and minimal fields (set with constructor)
            private readonly int _width;
            private readonly int _height;

            // other basic field (set with their dedicated methods)
            private Point2D _coord;
            private RoomType? _roomType;

            // to access utility methods
            private RoomBuilderUtils _builderUtils;

            /// <summary>
            /// To build a Room, use <see cref="IRoomFactory"/> instead. 
            /// It is required to call this constructor first, then the REQUIRED methods.
            /// At the end, call the method build().
            /// </summary>
            /// <param name="width">the horizontal dimension of this room</param>
            /// <param name="height">the vertical dimension of this room</param> 
            public Builder(int width, int height)
            {
                _width = width;
                _height = height;
            }

            /// <summary>
            /// Method to set the coordinate of this room inside the level, REQUIRED for ALL rooms.
            /// </summary>
            /// <param name="coord">the coordinate of this room inside the level</param>
            /// <returns>this builder</returns>
            public Builder PutCoord(Point2D coord)
            {
                _coord = coord;
                return this;
            }

            /// <summary>
            /// Method to set the room type, REQUIRED for ALL rooms.
            /// </summary>
            /// <param name="roomType"> the type of room to be created</param>
            /// <returns>this builder</returns>
            public Builder RoomType(RoomType roomType)
            {
                _roomType = roomType;
                _builderUtils = new RoomBuilderUtils(roomType);
                return this;
            }
            
            /// <summary>
            /// Method to put items inside this room. ONLY for STANDARD rooms.
            /// </summary>
            /// <returns>this builder</returns>
            /// <exception cref="InvalidOperationException"> if called on NON STANDARD rooms</exception>
            public Builder PutItems()
            {
                if (_builderUtils.CanRoomHaveItems())
                {
                    return this;
                }
                throw new InvalidOperationException(ItemsInStandardRoom);
            }

            /// <summary>
            /// Method to put the enemies inside this room (according to roomType). 
            /// REQUIRED ONLY for STANDARD and BOSS rooms.
            /// </summary>
            /// <returns>this builder</returns>
            /// <exception cref="InvalidOperationException"> if called on NON STANDARD or NON BOSS rooms</exception>
            public Builder PutEnemies()
            {
                if (_builderUtils.CanRoomHaveEnemies())
                {
                    return this;
                }
                throw new InvalidOperationException(EnemiesBossStandardRoom);
            }

            /// <summary>
            /// Method to put the powerups inside this room. ONLY for the SHOP and TREASURE rooms.
            /// </summary>
            /// <returns>this builder</returns>
            /// <exception cref="InvalidOperationException">if called on NON SHOP or NON TREASURE rooms</exception>
            public Builder PutPowerUps()
            {
                if (_builderUtils.CanRoomHavePowerUps())
                {
                    return this;
                }
                throw new InvalidOperationException(PowerUpsShopTreasureRoom);
            }

            /// <summary>
            /// Method to build the Room. First, call the constructor, then the REQUIRED methods to set this Room's fields.
            /// After that, you can call this method.
            /// </summary>
            /// <exception cref="InvalidOperationException">if current Room has some REQUIRED fields unset.</exception>
            /// <returns>the built Room</returns> 
            public Room Build()
            {
                if (AreThereMinimumRequirements())
                {
                    return new Room(_width, _height, _roomType.Value, _coord);
                }
                throw new InvalidOperationException(IncorrectRoomConfig);
            }

            /// <summary>
            /// Method to check if the minimum requirements are satisfied.
            /// </summary>
            /// <returns> true if the minimum requirements are satisfied</returns>
            private bool AreThereMinimumRequirements() => _coord != null && _roomType.HasValue;
        }
    }
}
