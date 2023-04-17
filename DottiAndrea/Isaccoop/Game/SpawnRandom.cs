using System;
using System.Collections.Generic;

using Isaccoop.Game.Common;

namespace Isaccoop.Game
{
    /// <summary>
    /// SpawnOrdered class that implements <see cref="ISpawn"/>, it models a random spawn.
    /// </summary>
    public class SpawnRandom : ISpawn
    {
        /// <summary>
        /// Method that sets the positions of the <see cref="MapElement"/> inside the room, in a random way.
        /// </summary>
        /// <param name="elementsToSpawn"></param>
        /// <param name="width"> of room</param>
        /// <param name="height"> of room</param>
        public void SetPosition(List<MapElement> elementsToSpawn, int width, int height)
        {
            Random random = new Random();
            elementsToSpawn.ForEach(e => {
                double radius = ((CircleBoundingBox)e.GetBox()).GetRadius();
                e.SetCoords(new Point2D(
                random.NextDouble(radius + radius / 2, width - (radius + radius / 2)),
                random.NextDouble(radius + radius / 2, height - (radius + radius / 2))
                ));
            });
        }
    }
}