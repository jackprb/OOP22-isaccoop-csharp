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
        private readonly Point2D _coord;

        /// <summary>
        /// Use <see cref="RoomFactory"/> to create a new <see cref="IRoom"/>.
        /// </summary>
        /// <param name="width"> horizontal dimension of this room</param> 
        /// <param name="height"> vertical dimension of this room</param>
        /// <param name="roomType"> type of this room</param> 
        /// <param name="coord"> the coodinate of this room </param>
        public Room(int width, int height, RoomType roomType, Point2D coord)
        {
            _roomType = roomType;
            _width = width;
            _height = height;
            _coord = coord;
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
