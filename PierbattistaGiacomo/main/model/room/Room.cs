using Isaccoop.Model.Common;
using System.Collections.Generic;

namespace Isaccoop.Model.Room {
	/// <summary>
	/// Implementation of <see cref="IRoom"/>.
	/// </summary>
	public class Room : IRoom
	{

		private readonly RoomType _roomType;
		private readonly AIEnemy? _roomAi;
		private readonly IList<Item>? _items;
		private readonly IList<PowerUp>? _powerups;
		private Player? _player;
		private readonly int _width;
		private readonly int _height;

		/// <summary>
		/// Use <see cref="RoomFactory"/> to create a new <see cref="IRoom"/>.
		/// </summary>
		/// <param name="width"> horizontal dimension of this room</param> 
		/// <param name="height"> vertical dimension of this room</param>
		/// <param name="coord"> coordinates of this room inside the level</param> 
		/// <param name="roomType"> type of this room</param> 
		/// <param name="roomAI"> the AiEnemy for this room</param> 
		/// <param name="items">the items in this room</param> 
		/// <param name="powerups">the powerups in this room</param> 
		/// <param name="player">the player</param> 
		public Room(int width, int height, Point2D coord, RoomType roomType,
				AIEnemy? roomAI, IList<Item>? items, IList<PowerUp>? powerups, Player? player) 
		{
			//super(width, height);
			//super.setCoords(coord);
			_roomType = roomType;
			_roomAi = roomAI;
			_items = items;
			_powerups = powerups;
			_player = player;
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
		public AIEnemy GetRoomAI() => _roomAi;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		public IList<Item> GetItems() => _items;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		public IList<PowerUp> GetPowerUps() => _powerups;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		public Player GetPlayer() => _player;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		public IList<Enemy> GetEnemies() 
		{
			if (_roomAi.HasValue) {
				return _roomAi.GetValueOrDefault();
			}
			return _roomAi.Value.getControlledEnemies();
		}

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

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		public bool IsComplete() => false;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		public bool AddPlayer(Player player) => false;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		public bool RemovePlayer() => false;
	}
}
