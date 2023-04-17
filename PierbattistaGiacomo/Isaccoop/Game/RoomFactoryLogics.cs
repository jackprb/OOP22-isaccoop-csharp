namespace Isaccoop.Game
{
    /// <summary>
    /// Delegated class that contains the logic to check conditions while creating rooms.
    /// </summary>
    public class RoomFactoryLogics
    {
        private readonly int _totalNumberOfRooms;
        private bool _alreadyCreatedBossRoom = false;
        private bool _alreadyCreatedStartRoom = false;
        private bool _alreadyCreatedTreasureRoom = false;
        private bool _alreadyCreatedShopRoom = false;

        /// <summary>
        /// Constructor. Requires the total number of rooms to be created
        /// </summary>
        /// <param name="totalNumberOfRooms">the total number of rooms to be created</param>
        internal RoomFactoryLogics(int totalNumberOfRooms) => _totalNumberOfRooms = totalNumberOfRooms;

        /// <summary>
        /// Check if the next room to generate can be a START room.
        /// </summary>
        /// <param name="roomCount">the number of rooms currently generated (0-based count)</param> 
        /// <returns> true if can build START room (i.e.: if this is the FIRST room - with roomCount = 0), 
        /// false otherwise</returns>
        public bool CanBuildStartRoom(int roomCount) => roomCount == 0;

        /// <summary>
        /// Check if the next room to generate can be a BOSS room.
        /// </summary>
        /// <param name="roomCount">the number of rooms currently generated (0-based count)</param> 
        /// <returns> true if can build BOSS room (i.e.: if this is the LAST room - 
        /// with roomCount = totalNumberOfRooms - 1), false otherwise</returns>
        public bool CanBuildBossRoom(int roomCount) => roomCount == _totalNumberOfRooms - 1;

        /// <summary>
        /// Check if the next room to generate can be a NON BOSS or NON START room.
        /// </summary>
        /// <param name="roomCount">the number of rooms currently generated (0-based count)</param> 
        /// <returns> true if can build a NON BOSS or NON START room (i.e.: if this is not the FIRST or LAST room),
        /// false otherwise</returns>
        public bool CanBuildNonBossNonStartRoom(int roomCount) => roomCount < _totalNumberOfRooms;

        /// <summary>
        /// Check if has already been created a START room.
        /// </summary>
        /// <returns> true if a START has already been created, false otherwise</returns>
        public bool HasAlreadyBuiltStartRoom() => _alreadyCreatedStartRoom;

        /// <summary>
        /// Check if has already been created a BOSS room.
        /// </summary>
        /// <returns>true if a BOSS has already been created, false otherwise </returns> 
        public bool HasAlreadyBuiltBossRoom() => _alreadyCreatedBossRoom;

        /// <summary>
        /// Check if has already been created a SHOP room.
        /// </summary>
        /// <returns>true if a SHOP has already been created, false otherwise</returns> 
        public bool HasAlreadyBuiltShopRoom() => _alreadyCreatedShopRoom;

        /// <summary>
        /// Check if has already been created a TREASURE room.
        /// </summary>
        /// <returns>true if a TREASURE has already been created, false otherwise</returns> 
        public bool HasAlreadyBuiltTreasureRoom() => _alreadyCreatedTreasureRoom;

        /// <summary>
        /// Set that has already been created a START room.
        /// </summary>
        public void SetAlreadyBuiltStartRoom() => _alreadyCreatedStartRoom = true;

        /// <summary>
        /// Set that has already been created a SHOP room.
        /// </summary>
        public void SetAlreadyBuiltShopRoom() => _alreadyCreatedShopRoom = true;

        /// <summary>
        /// Set that has already been created a TREASURE room.
        /// </summary>
        public void SetAlreadyBuiltTreasuretRoom() => _alreadyCreatedTreasureRoom = true;

        /// <summary>
        /// Set that has already been created a BOSS room.
        /// </summary>
        public void SetAlreadyBuiltBossRoom() => _alreadyCreatedBossRoom = true;
    }
}
