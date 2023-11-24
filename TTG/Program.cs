
using System.Globalization;

using var game = new TTG.MyGame();
game.Run();


/* todo
 * solar panels could be the currency generators (sunflowers in PVZ)
 * wind mills can deal the damage (pea shooters in PVZ)
 * electric cars at the end (like lawn mowers int PVZ)
 * 
 * Enemies
 * leaving drought tiles on the board increases the rate at which enemies come 
 * fixing a drought tile costs energy
 * drought tiles cannot have anything placed on them, until fixed
 * Enemies can put oil rigs on the tile they are on. no way to remove this. Tile is dead
 * 
 * Features
 * if co2 gets too high all tiles become drought, any improvements get removed (almost certain fail)
 * 
 * End Condition
 * game ends once rainstorm comes in (timer) 
 * if fossil fuels reach the end the world is doomed
 * 
 * 
 */