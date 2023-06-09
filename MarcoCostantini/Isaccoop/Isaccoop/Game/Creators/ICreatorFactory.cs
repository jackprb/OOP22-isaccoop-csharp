﻿using Isaccoop.Game;

namespace Isaccop.Game
{
    /// <summary>
    /// CreatorFactory interface to model a factory of creator concept.
    /// </summary>
    public interface ICreatorFactory
    {

        /// <summary>
        /// Method to get a shop power up creator.
        /// </summary>
        ICreator<PowerUp> CreateShopPowerUps();

        /// <summary>
        /// Method to get a treasure power up creator.
        /// </summary>
        ICreator<PowerUp> CreateTreasurePowerUps();

        /// <summary>
        /// Method to get an items creator.
        /// </summary>
        ICreator<IItem> CreateItems();

    }
}

