﻿using AmeisenBotX.Core.Engines.Character.Inventory.Objects;

namespace AmeisenBotX.Core.Engines.Character.Comparators
{
    public class ItemLevelComparator : IItemComparator
    {
        public bool IsBetter(IWowInventoryItem current, IWowInventoryItem item)
        {
            return current == null || current.ItemLevel < item.ItemLevel;
        }

        public bool IsBlacklistedItem(IWowInventoryItem item)
        {
            return false;
        }
    }
}