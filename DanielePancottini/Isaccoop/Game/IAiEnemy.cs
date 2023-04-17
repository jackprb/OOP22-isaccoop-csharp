using Isaccoop.Game.Common;

namespace Isaccoop.Game;

public interface IAiEnemy
{
    public void UpdateEnemies(IMapElement player);

    public List<IEnemy> GetControlledEnemies();
}