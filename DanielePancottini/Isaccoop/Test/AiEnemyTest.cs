
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
    public void CreateEnemies() => Assert.AreEqual(MaxEnemies, GetNEnemies(MaxEnemies).Count);

    /// <summary>
    /// Check if ConcreteAiEnemy instance is created without errors.
    /// </summary>
    [Test]
    public void CreateAiEnemy() => Assert.NotNull(new ConcreteAiEnemy(GetNEnemies(MaxEnemies)));

        /// <summary>
    /// Check if the AI method to get controlled enemies works properly
    /// </summary>
    [Test]
    public void GetAiEnemies()
    {
        var ai = GetAiWithEnemies(MaxEnemies);
        Assert.AreEqual(MaxEnemies, ai.GetControlledEnemies().Count);
    }

    /// <summary>
    /// Check if the remove all enemies stored into an AI goes without errors.
    /// </summary>
    [Test]
    public void RemoveAllAiEnemies()
    {
        var ai = GetAiWithEnemies(MaxEnemies);
        ai.GetControlledEnemies().ForEach(enemy => ai.Remove(enemy));
        Assert.AreEqual(0, ai.GetControlledEnemies().Count);
    }

    /// <summary>
    /// Get a new ai enemy populated with "maxEnemies" enemies.
    /// </summary>
    /// <param name="maxEnemies">number of enemies to attach to AI</param>
    /// <returns></returns>
    private IAiEnemy GetAiWithEnemies(int maxEnemies) => new ConcreteAiEnemy(GetNEnemies(maxEnemies));

    /// <summary>
    /// Create a NonShootingEnemy collection with N elements.
    /// </summary>
    /// <param name="maxEnemies">number of enemies to create</param>
    /// <returns>NonShootingEnemy collection populated with 'maxEnemies' elements</returns>
    private IList<NonShootingEnemy> GetNEnemies(int maxEnemies) => Enumerable.Range(1, maxEnemies).Select(_ => new NonShootingEnemy()).ToList();

}