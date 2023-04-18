using Isaccoop.Game.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Isaccoop.Game 
{
    /// <summary>
    /// Implementation of <see cref="ILevel"/>
    /// </summary>
    public class Level : ILevel
    {
        private readonly List<IRoom> _rooms = new List<IRoom>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public void PutRooms(IList<IRoom> roomList)
        {
            if (!roomList.Any() || roomList.Count < Enum.GetValues(typeof(RoomType)).Length)
            {
                throw new ArgumentException("This level must have at least " + Enum.GetValues(typeof(RoomType)).Length
                        + " rooms");
            }
            if (!_rooms.Any())
            {
                _rooms.AddRange(roomList);
            }
            else
            {
                throw new InvalidOperationException("This level already has a room list");
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public List<IRoom> GetRooms() => _rooms;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public IRoom GetStartRoom() => _rooms.Find(r => r.GetRoomType() == RoomType.Start);
    }
}
