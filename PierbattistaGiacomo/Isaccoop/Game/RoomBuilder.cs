using Isaccoop.Game.Common;
using System;
using System.Collections.Generic;

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

            // optional fields (to set with their dedicated methods)
            private List<Item> _items;
            private List<PowerUp> _powerups;
            private List<Enemy> _enemies;
            private readonly Player? _player;
            private AIEnemy? _roomAI;

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

            
        }
    }
}
