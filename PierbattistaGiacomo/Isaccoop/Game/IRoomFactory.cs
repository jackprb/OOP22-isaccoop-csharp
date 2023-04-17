using Isaccoop.Game.Common;

namespace Isaccoop.Game 
{
    /// <summary>
    /// A façade interface to simplify the creation of <see cref="IRoom"/>, using <see cref="RoomBuilder"/>.
    /// </summary>
    public interface IRoomFactory
    {
        /// <summary> 
        /// Build a <see cref="RoomType.Start"/> room.
        /// </summary>
        /// <param name="coordInsideLevel">the coordinate of this room inside the level </param> 
        /// <returns>the room where the player starts the game</returns>
        public IRoom BuildStartRoom(Point2D coordInsideLevel);

        /// <summary> 
        /// Build a <see cref="RoomType.Standard"/> room.
        /// </summary>
        /// <param name="coordInsideLevel">the coordinate of this room inside the level </param> 
        /// <returns>a room with enemies and items</returns>
        public IRoom BuildStandardRoom(Point2D coordInsideLevel);

        /// <summary> 
        /// Build a <see cref="RoomType.Shop"/> room.
        /// </summary>
        /// <param name="coordInsideLevel">the coordinate of this room inside the level </param> 
        /// <returns>a room where you can ONLY buy powerups using the collected money </returns>.
        public IRoom BuildShopRoom(Point2D coordInsideLevel);

        /// <summary> 
        /// Build a <see cref="RoomType.Boss"/> room.
        /// </summary>
        /// <param name="coordInsideLevel">the coordinate of this room inside the level </param> 
        /// <returns>the room with the final boss </returns>.
        public IRoom BuildBossRoom(Point2D coordInsideLevel);

        /// <summary> 
        /// Build a <see cref="RoomType.Treasure"/> room.
        /// </summary>
        /// <param name="coordInsideLevel">the coordinate of this room inside the level </param> 
        /// <returns> the room where you can find a free powerup </returns>.
        public IRoom BuildTreasureRoom(Point2D coordInsideLevel);

        /// <summary>
        /// Build a room in the proper order, that is, each time this method is called, will return a room of
        /// the proper <see cref="RoomType"/>. The FIRST will be a <see cref="RoomType.Start"/> room, 
        /// the LAST will be a <see cref="RoomType.Boss"/>, the others will be created randomly among 
        /// <see cref="RoomType.Shop"/> (only ONE),  <see cref="RoomType.Treasure"/> (only ONE) and 
        /// <see cref="RoomType.Standard"/> (all the remaing ones).
        /// </summary>
        /// <param name="coordInsideLevel">the coordinate of this room inside the level </param> 
        /// <returns>a room of the proper <see cref="RoomType"/></returns>
        public IRoom BuildRoomInProperOrder(Point2D coordInsideLevel);
    }
}
