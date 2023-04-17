using Isaccoop.Game.Common;

namespace Isaccoop.Game
{
    /// <summary>
    /// Implementation of <see cref="IRoom"/>.
    /// </summary>
    public class Room : IRoom
    {
        private readonly RoomType _roomType;
        private readonly int _width;
        private readonly int _height;

        /// <summary>
        /// Use <see cref="RoomFactory"/> to create a new <see cref="IRoom"/>.
        /// </summary>
        /// <param name="width"> horizontal dimension of this room</param> 
        /// <param name="height"> vertical dimension of this room</param>
        /// <param name="roomType"> type of this room</param> 
        public Room(int width, int height, RoomType roomType)
        {
            _roomType = roomType;
            _width = width;
            _height = height;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public RoomType GetRoomType() => _roomType;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public int GetWidth() => _width;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public int GetHeight() => _height;
    }
}
