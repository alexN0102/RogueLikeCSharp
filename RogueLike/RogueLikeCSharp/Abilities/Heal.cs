using System;
using RogueLikeCSharp.Core;
using RogueSharpRLNetSamples.Core;
using RogueSharpV3Tutorial;

namespace RogueSharpRLNetSamples.Abilities
{
    public class Heal : Ability
    {
        private readonly int _amountToHeal;

        public Heal(int amountToHeal)
        {
            Name = "Heal Self";
            TurnsToRefresh = 60;
            TurnsUntilRefreshed = 0;
            _amountToHeal = amountToHeal;
        }

        protected override bool PerformAbility()
        {
            Player player = Game.Player;

            player.Health = Math.Min(player.MaxHealth, player.Health + _amountToHeal);

            return true;
        }
    }
}
