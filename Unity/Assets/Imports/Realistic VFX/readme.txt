This asset contains particle emitter prefabs, textures and materials, and the code to spawn VFX build of those assets.
Main purpose of the asset is to create short visual effects in your game.
Most effects are good to visualize impact effects of weapons and spells, but also contains some environment visuals.

You don't have to care about garbage collector, because pooling is used.
Init method creates everythying in memory for once and doesn't use any more memory when you spawn effects.
You also don't have to care about graphical performance, because, for example, 20 instances of the same effect will use
the same amount of draw calls as 1 instance. Because the same particle system is used for each instance of the effect.

How to use the asset:

1. Add visEffects.cs into your project.
2. Add visEffects.staticInit (); into your project initialization routines
3. Use visEffects.createEffect(int effectIndex, Vector3 effectCoord);

	"effecIndex" parameter is a number of effect which are listed in enum particleEmitterNames
	"effectCoord" is a coordinate where the effect should happen

Example: visEffects.createEffect((int)visualEffectNames.vacuumExplosion, new Vector3(0, 1, 0));
This will create "vacuumExplosion" effect at (0, 1, 0) point.

"visualEffectNames" is enum, which contains all effect names.

To scale all effects, you need to change visEffects.scaleFactor variable BEFORE calling visEffects.staticInit ().

To scale a single effect, you need to go to visEffects.initVisEffects() method, and change effect's scale factor.

Example:
vEffects[(int)visualEffectNames.vacuumExplosion].scaleFactor = 0.5f;
This line will reduce the size of vacuumExplosion by factor of two.


Demo scene is included in the project. It allows you to see how all effects look one by one.