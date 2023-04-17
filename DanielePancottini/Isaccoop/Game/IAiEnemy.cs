namespace Isaccoop.Game;

public interface IAiEnemy
{
    public void UpdateEnemies(MapElement player);

    public List<Enemy> GetControlledEnemies();
}