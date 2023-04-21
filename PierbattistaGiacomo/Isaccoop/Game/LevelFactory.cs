using Isaccoop.Game.Common;
using System;
using System.Collections.Generic;

namespace Isaccoop.Game 
{
    /// <summary>
    /// Implementation of <see cref="ILevelFactory"/>.
    /// </summary>
    public class LevelFactory : ILevelFactory
    {
        private static readonly int MaxNumberOfRooms = 10;
        private static readonly int MinNumberOfRooms = 6;
        private readonly LevelFactoryUtils _lvlFactoryUtils = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public ILevel CreateLevel()
        {
            int numberOfRooms = new Random().Next(MaxNumberOfRooms - MinNumberOfRooms) + MinNumberOfRooms;
            IList<Point2D> roomCoords = _lvlFactoryUtils.GenerateRoomCoordinates(numberOfRooms);
            IList<IRoom> rooms = CreateRooms(roomCoords);
            ILevel lvl = new Level();
            lvl.PutRooms(rooms);
            return lvl;
        }

        /// <summary>
        /// Method to associate rooms to their coordinates.
        /// </summary>
        /// <param name="coordsList">the list of coordinates assigned to the rooms</param>
        /// <returns>the list of created rooms</returns>
        private IList<IRoom> CreateRooms(IList<Point2D> coordsList)
        {
            IRoomFactory rFactory = new RoomFactory(coordsList.Count);
            IList<IRoom> rooms = new List<IRoom>();
            foreach (Point2D coord in coordsList)
            {
                rooms.Add(rFactory.BuildRoomInProperOrder(coord));
            }
            return rooms;
        }
    }
}
