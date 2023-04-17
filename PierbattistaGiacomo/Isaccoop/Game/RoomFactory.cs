using Isaccoop.Game.Common;
using System;

namespace Isaccoop.Game
{
    /// <summary>
    /// Implementation of <see cref="IRoomFactory"/>.
    /// </summary>
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
                    && !_rFactoryLogics.HasAlreadyBuiltStartRoom())
            {
                IncrementRoomCount();
                _rFactoryLogics.SetAlreadyBuiltStartRoom();
                return new RoomBuilder.Builder(_width, _height)
                        .RoomType(RoomType.Start)
                        .PutCoord(coordInsideLevel)
                        .Build();
            }
            throw new InvalidOperationException(StartRoomMustBeTheFirst);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public IRoom BuildStandardRoom(Point2D coordInsideLevel)
        {
            if (_rFactoryLogics.CanBuildNonBossNonStartRoom(_roomCount))
            {
                IncrementRoomCount();
                return new RoomBuilder.Builder(_width, _height)
                        .RoomType(RoomType.Standard)
                        .PutCoord(coordInsideLevel)
                        .PutEnemies()
                        .PutItems()
                        .Build();
            }
            throw new InvalidOperationException(AlreadyGeneratedAllRooms);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public IRoom BuildShopRoom(Point2D coordInsideLevel)
        {
            if (_rFactoryLogics.CanBuildNonBossNonStartRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltShopRoom())
            {
                IncrementRoomCount();
                _rFactoryLogics.SetAlreadyBuiltShopRoom();
                return new RoomBuilder.Builder(_width, _height)
                        .RoomType(RoomType.Shop)
                        .PutCoord(coordInsideLevel)
                        .PutPowerUps()
                        .Build();
            }
            throw new InvalidOperationException(AlreadyGeneratedAllRooms);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public IRoom BuildBossRoom(Point2D coordInsideLevel)
        {
            if (_rFactoryLogics.CanBuildBossRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltBossRoom())
            {
                IncrementRoomCount();
                _rFactoryLogics.SetAlreadyBuiltBossRoom();
                return new RoomBuilder.Builder(_width, _height)
                        .RoomType(RoomType.Boss)
                        .PutCoord(coordInsideLevel)
                        .PutEnemies()
                        .Build();
            }
            throw new InvalidOperationException(BossRoomMustBeTheLast);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public IRoom BuildTreasureRoom(Point2D coordInsideLevel)
        {
            if (_rFactoryLogics.CanBuildNonBossNonStartRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltTreasureRoom())
            {
                IncrementRoomCount();
                _rFactoryLogics.SetAlreadyBuiltTreasuretRoom();
                return new RoomBuilder.Builder(_width, _height)
                        .RoomType(RoomType.Treasure)
                        .PutCoord(coordInsideLevel)
                        .PutPowerUps()
                        .Build();
            }
            throw new InvalidOperationException(AlreadyGeneratedAllRooms);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public IRoom BuildRoomInProperOrder(Point2D coordInsideLevel)
        {
            if (_rFactoryLogics.CanBuildStartRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltStartRoom())
            {
                return BuildStartRoom(coordInsideLevel);
            }
            if (_rFactoryLogics.CanBuildBossRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltBossRoom())
            {
                return BuildBossRoom(coordInsideLevel);
            }
            if (_rFactoryLogics.CanBuildNonBossNonStartRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltShopRoom())
            {
                return BuildShopRoom(coordInsideLevel);
            }
            if (_rFactoryLogics.CanBuildNonBossNonStartRoom(_roomCount)
                    && !_rFactoryLogics.HasAlreadyBuiltTreasureRoom())
            {
                return BuildTreasureRoom(coordInsideLevel);
            }
            if (_rFactoryLogics.CanBuildNonBossNonStartRoom(_roomCount))
            {
                return BuildStandardRoom(coordInsideLevel);
            }
            throw new InvalidOperationException(CannotCreateMoreRooms);
        }

        /// <summary>
        /// Increments the room count. Useful to check if a specified room can be generated in that index.
        /// (START room must alway be the first, BOSS room the last)
        /// </summary>
        private void IncrementRoomCount() => _roomCount++;
    }
}
