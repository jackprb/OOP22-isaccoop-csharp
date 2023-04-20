using Isaccoop.Game.Common;

namespace Isaccoop.Game;

/// <summary>
/// ConcreteAIEnemy which is a base AIEnemy implementation.
/// </summary>
public class ConcreteAiEnemy : IAiEnemy
{

    private readonly List<IEnemy> _controlledEnemies;

    public ConcreteAiEnemy (IEnumerable<IEnemy> enemies) => _controlledEnemies = new List<IEnemy>(enemies);

    public void UpdateEnemies(IMapElement player) 
    {
        _controlledEnemies.ForEach(enemy => {
            enemy.Move(player.GetCoords());
            enemy.Hit(player.GetCoords());
            (enemy.GetWeaponShots() ?? new List<IWeaponShot>()).ForEach(shot => shot.TickShot());
        });
    }
    
    public List<IEnemy> GetControlledEnemies() => _controlledEnemies.ToList();

    public void Remove(IMapElement e) => _controlledEnemies.Remove((IEnemy) e);
    
}