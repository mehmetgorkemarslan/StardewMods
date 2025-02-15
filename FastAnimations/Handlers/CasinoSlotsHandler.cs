using Pathoschild.Stardew.FastAnimations.Framework;
using StardewValley;
using StardewValley.Minigames;

namespace Pathoschild.Stardew.FastAnimations.Handlers;

/// <summary>Handles the casino slots minigame spin animation.</summary>
/// <remarks>See game logic in <see cref="Slots"/>.</remarks>
internal sealed class CasinoSlotsHandler : BaseAnimationHandler
{
    /*********
    ** Public methods
    *********/
    /// <inheritdoc />
    public CasinoSlotsHandler(float multiplier)
        : base(multiplier) { }

    /// <inheritdoc />
    public override bool TryApply(int playerAnimationId)
    {
        return
            Game1.currentMinigame is Slots { spinning: true } minigame
            && this.ApplySkipsWhile(() =>
            {
                minigame.tick(Game1.currentGameTime);

                return minigame.spinning;
            });
    }
}
