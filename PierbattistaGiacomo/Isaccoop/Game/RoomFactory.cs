using Isaccoop.Game.Common;
using System;

namespace Isaccoop.Game
{
    public class RoomFactory : IRoomFactory
    {
        private static readonly int RoomWidth = 300;
        private static readonly int RoomHeight = 200;

        // messages when an exception is thrown
        private static readonly string AlreadyGeneratedAllRooms = "you have already generated all the required rooms";
        private static readonly string StartRoomMustBeTheFirst = "the START room must be the FIRST to be generated";
        private static readonly string BossRoomMustBeTheLast = "the BOSS room must be the LAST to be generated";
        private static readonly string CannotCreateMoreRooms = "cannot create more rooms";

        private readonly int _width;
        private readonly int _height;
        private int _roomCount;
		private readonly RoomFactoryLogics _rFactoryLogics;

        /// <summary>
        /// Constructor. Requires the total number of rooms to be created.
        /// </summary>
        /// <param name="totalNumberOfRooms">the total number of rooms to be created</param> 
        public RoomFactory(int totalNumberOfRooms)
        {
            _width = RoomWidth;
            _height = RoomHeight;
            _roomCount = 0;
            _rFactoryLogics = new RoomFactoryLogics(totalNumberOfRooms);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public IRoom BuildStartRoom(Point2D coordInsideLevel)
        {
            if (_rFactoryLogics.CanBuildStartRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltStartRoom()) {
                incrementRoomCount();
                _rFactoryLogics.SetAlreadyBuiltStartRoom();
                return new RoomBuilder.Builder(_width, _height)
                        .roomType(RoomType.Start)
                        .putCoord(coordInsideLevel)
                        .build();
            }
            throw new InvalidOperationException(StartRoomMustBeTheFirst);
        }

        
    }
}
