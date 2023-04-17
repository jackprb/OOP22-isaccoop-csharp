using System.Collections.Generic;

using Isaccoop.Game.Common;

namespace Isaccoop.Game
{
    /// <summary>
    /// Spawn interface to model entities delegates to spawn other entities.
    /// </summary>
    public interface ISpawn
    {
        /// <summary>
        /// Method that sets the positions of the <see cref="MapElement"/> inside the room.
        /// </summary>
        /// <param name="elementsToSpawn"></param>
        /// <param name="width"> of room</param>
        /// <param name="height"> of room</param>
        void SetPosition(List<MapElement> elementsToSpawn, int width, int height);
    }
}