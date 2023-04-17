using System.Collections.Generic;
using System.Linq;

using Isaccoop.Game.Common;

namespace Isaccoop.Game
{
    /// <summary>
    /// SpawnOrdered class that implements <see cref="ISpawn"/>, it models an ordered spawn.
    /// </summary>
    public class SpawnOrdered : ISpawn
    {
        /// <summary>
        /// Method that sets the positions of the <see cref="MapElement"/> inside the room, in an ordered way.
        /// </summary>
        /// <param name="elementsToSpawn"></param>
        /// <param name="width"> of room</param>
        /// <param name="height"> of room</param>
        public void SetPosition(List<MapElement> elementsToSpawn, int width, int height)
        {
            if (elementsToSpawn.Count == 1)
            {
                elementsToSpawn[0].Coords = new Point2D(width / 2.0, height / 2.0);
            }
            else
            {
                elementsToSpawn.Select((element, index) =>
                {
                    double yCoord = (height / (elementsToSpawn.Count + 1.0)) * (index + 1);
                    return new { Element = element, YCoord = yCoord };
                }).ToList().ForEach(pair =>
                {
                    pair.Element.Coords = new Point2D(width / 2.0, pair.YCoord);
                });
            }
        }
    }
}