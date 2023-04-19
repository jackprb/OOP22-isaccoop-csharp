
using Isaccoop.Game;
using NUnit.Framework;

namespace Isaccoop.Test;

public class AiEnemyTest
{
    
    private const int MaxEnemies = 5;

    [Test]
    public void EnemiesCreation()
    {
        Assert.AreEqual(MaxEnemies, GetNEnemies(MaxEnemies).Count);
    }

    
    [Test]
    public void AiEnemyCreation()
    {
        Assert.NotNull(new ConcreteAiEnemy(GetNEnemies(MaxEnemies)));
    }

    [Test]
    public void RemoveAllEnemies()
    {
        var enemies = GetNEnemies(MaxEnemies);
        var ai = new ConcreteAiEnemy(enemies);
        enemies.ToList().ForEach(enemy => ai.Remove(enemy));
        Assert.AreEqual(0, ai.GetControlledEnemies().Count);
    }

    private IList<NonShootingEnemy> GetNEnemies(int maxEnemies) => Enumerable.Range(1, maxEnemies).Select(_ => new NonShootingEnemy()).ToList();

}