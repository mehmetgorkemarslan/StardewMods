﻿**Horse Flute Anywhere** is a [Stardew Valley](http://stardewvalley.net/) mod that lets you summon
your horse anywhere (even indoors or in caves/dungeons) at the press of a button or by using the
[horse flute](https://stardewvalleywiki.com/Horse_Flute).

![](screenshots/indoors.png)  
![](screenshots/dungeon.png)

## Contents
* [Install](#install)
* [Use](#use)
* [Configure](#configure)
* [Compatibility](#compatibility)
* [Troubleshooting](#troubleshooting)
* [See also](#see-also)

## Install
1. [Install the latest version of SMAPI](https://smapi.io/).
2. [Install this mod from Nexus mods](https://www.nexusmods.com/stardewvalley/mods/7500).
3. Run the game using SMAPI.

## Use
You can summon your horse by...

* using the [horse flute](https://stardewvalleywiki.com/Horse_Flute) item;
* pressing `H` if you have a horse flute in your inventory;
* pressing `H` without a horse flute if `RequireHorseFlute` is disable in the [config](#configure).

This will work anywhere, even in the deepest mines.

## Configure
If you install [Generic Mod Config Menu][], you can click the cog button (⚙) on the title screen
or the "mod options" button at the bottom of the in-game menu to configure the mod. Hover the
cursor over a field for details.

> ![](screenshots/generic-config-menu.png)

## Compatibility
Horse Flute Anywhere is compatible with Stardew Valley 1.5.5+ on Linux/macOS/Windows, both
single-player and multiplayer.

Due to limitations on macOS, playing the flute directly might not summon the horse indoors. You can
use the hotkey (`H` by default) instead in that case.

## Troubleshooting
### "You do not own a horse"
That's an issue with the vanilla game, not Horse Flute Anywhere. Make sure you built a stable, and
that you were the first player to ride the new horse (which marks you as the owner).

You can also reset horse ownership if needed:

1. Run this command in the SMAPI console window:
   ```
   reset_horses
   ```
2. That will reset **all** horses in the game. Each player should then interact with their horse to
   name it and take ownership.

## See also
* [Release notes](release-notes.md)
* [Nexus mod](https://www.nexusmods.com/stardewvalley/mods/7500)

[Generic Mod Config Menu]: https://www.nexusmods.com/stardewvalley/mods/5098
