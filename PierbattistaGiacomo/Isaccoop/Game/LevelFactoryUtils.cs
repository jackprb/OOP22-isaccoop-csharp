using System.Collections.Generic;
using Isaccoop.Game.Common;

namespace Isaccoop.Game
{
    /// <summary>
    /// Delegated class that contains utility methods to help <see cref="LevelFactory"/> creating a room.
    /// </summary>
    public class LevelFactoryUtils
    {
        /// <summary>
        /// Generates dynamically the coordinates that will be used as positions
        /// for the rooms in this level.
        /// </summary>
        /// <param name="numberOfRooms">the number of rooms that will be in this level</param> 
        /// <returns>the list of coordinates to be assigned to the rooms</returns> 
        public IList<Point2D> GenerateRoomCoordinates(int numberOfRooms)
        {
            // initial position for the first room of the level
            Point2D roomPos = new(0.0, 0.0);
            IList<Point2D> list = new List<Point2D>();

            for (int i = 0; i < numberOfRooms; i++)
            {
                if (IsValidCoord(roomPos) && !list.Contains(roomPos))
                {
                    list.Add(roomPos);
                    roomPos = GetNewCoordinateAlongDirection(roomPos, Direction.Right());
                }
            }
            return list;
        }

        /// <summary>
        /// Get a new coordinate from the current coordinate coord, along the specified direction dir.
        /// @param coord the current coordinate from which calculate the new coordinate
        /// @param dir the direction along which the coordinate has to ben calculated
        /// @return the new coordinate calculated from coordinate coord along direction dir
        /// <summary>
        public Point2D GetNewCoordinateAlongDirection(Point2D coord, Direction dir) => 
            new(coord.X + dir.X, coord.Y + dir.Y);

        /// <summary>
        /// check if specified coordinate is valid (inside the grid).
        /// @param coord the coordinate to be checked
        /// @return true if the coordinate is valid (inside the grid), false otherwise
        /// <summary>
        public bool IsValidCoord(Point2D coord) => coord.X >= 0 && coord.Y >= 0;

        /// <summary>
        /// Get the coordinates of all neighbor rooms of specified room.
        /// A neighbor room is a room that is UP, DOWN, LEFT or RIGHT of the specified room.
        /// @param coord the current room coordinate
        /// @return a list of coordinates of neighbor rooms
        /// <summary>
        public IList<Point2D> GetNeighborRooms(Point2D coord)
        {
            IList<Point2D> res = new List<Point2D>();
            IList<Direction> directions = Direction.ToList();
            
            foreach (Direction dir in directions)
            {
                Point2D newCoord = GetNewCoordinateAlongDirection(coord, dir);
                if (IsValidCoord(newCoord) && !res.Contains(newCoord))
                {
                    res.Add(newCoord);
                }
            }
            return res;
        }
    }
}
