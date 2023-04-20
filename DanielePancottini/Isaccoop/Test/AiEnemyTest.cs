
using Isaccoop.Game;
using NUnit.Framework;

namespace Isaccoop.Test;

/// <summary>
/// AI Enemy test class 
/// </summary>
public class AiEnemyTest
{
    
    private const int MaxEnemies = 5;

    /// <summary>
    /// Check if enemies are created without errors.
    /// </summary>
    [Test]
    public void EnemiesCreation()
    {
        Assert.AreEqual(MaxEnemies, GetNEnemies(MaxEnemies).Count);
    }


    /// <summary>
    /// Check if ConcreteAiEnemy instance is created without errors.
    /// </summary>
    [Test]
    public void AiEnemyCreation()
    {
        Assert.NotNull(new ConcreteAiEnemy(GetNEnemies(MaxEnemies)));
    }

    /// <summary>
    /// Check if the remove all enemies stored into an AI goes without errors.
    /// </summary>
    [Test]
    public void RemoveAllEnemies()
    {
        var enemies = GetNEnemies(MaxEnemies);
        var ai = new ConcreteAiEnemy(enemies);
        enemies.ToList().ForEach(enemy => ai.Remove(enemy));
        Assert.AreEqual(0, ai.GetControlledEnemies().Count);
    }

    /// <summary>
    /// Create a NonShootingEnemy collection with N elements.
    /// </summary>
    /// <param name="maxEnemies">number of elements to create</param>
    /// <returns>NonShootingEnemy collection populated with 'maxEnemies' elements</returns>
    private IList<NonShootingEnemy> GetNEnemies(int maxEnemies) => Enumerable.Range(1, maxEnemies).Select(_ => new NonShootingEnemy()).ToList();

}