using UnityEngine;
using System.Collections;
using Game;

public enum particleEmitterNames : int{		// all emitters used for effects are enumerated by name for convenience
	smokeGray,
	sparklesBlinking,
	splashBlue,
	sparklesFleeing,
	sparklesFleeing2,
	sparklesFleeing3,
	sparklesFleeingFast,
	electroMist,
	electroMist2,
	electroMist3,
	splashBlueHorizontal,
	splashBlueHorizontal2,
	zapsToGround,
	sparklesFleeingCircle,
	electroSparklesFleeing,
	electroSplashBlue,
	electroSplashBlueBeamy,
	splashBlueCircle,
	splashBlueMist,
	beamsBlue,
	beamsBlue2,
	lightnings,
	lightnings2,
	lightningsFromCenter,
	electroSplashBlueBigger,
	electricEnergyWaves,
	electricEnergyWaves2,
	electricEnergyWavesH,
	splashBlueGlow,
	splashBlueGlow2,
	splashBlueGlow3,
	splashBlueGlow4,
	splashBlueGlow5,
	nova,
	beamsCircle,
	zapsFromCenter,
	electroSplashBlueMedium,
	smokeGraySmallToBig,
	zapToGround,
	lightningsFromCenterSmall,
	lightningBolt,
	beamsGoo,
	gooDropsFleeing,
	gooDropsFleeingBigger,
	gooDropsFleeingBigger2,
	gooDropsFleeingBigger3,
	gooGasExpansion,
	gooGasExpansion2,
	gooGasExpansion3,
	gooDropsFleeingLonger,
	gooDropsFleeingLonger2,
	gooDropsFleeingLonger3,
	gooDropsFleeingLonger4,
	gooDropsFleeingSlower,
	gooDropsFleeingSlower2,
	gooGasCloud,
	gooGasCloud2,
	beamsGooBrighter,
	gooGasExpansionBrighter,
	gooDropsFleeingBrighter,
	gooFountain,
	gooBeamsFountain,
	gooFog,
	gooFog2,
	gooSplash,
	gooDropsFleeingYellow,
	acidStormCloud,
	gooAcidRain,
	mudFountain,
	mudFountainSplashes,
	mudMist,
	mudSquirts,
	mudGroundSplash,
	mudFountainSplash,
	mudSquirtsPoint,
	mudSplashSoft,
	mudBurst,
	mudBurst360,
	flareSplash,
	mudSquirts360,
	mudGasExpansion,
	mudDropsFleeingLonger,
	mudGasExpansionBig,
	mudFountainVertical,
	mudWaveHorizontal,
	mudBeamyWaves,
	mudBubbles,
	mudGas,
	bloodSplash,
	bloodFog,
	bloodWave,
	bloodDropsFleeingLonger,
	bloodDropsFleeing,
	bloodBurst360,
	bloodGuts,
	bloodWaveSmaller,
	bloodFountainVertical,
	bloodFountainGas,
	bloodBeams,
	bloodStormClouds,
	bloodRain,
	bloodSquirts,
	bloodBubbles,
	bloodSquirtsBigger,
	bloodFogClouds,
	bloodDropsFleeingCircle,
	bloodBurstCircle,
	bloodSprayThick,
	bloodDrops,
	bloodSprayFog,
	dustWave,
	dustCloud,
	dustWaveSmallerInVolume,
	dustCloudsVolumous,
	dustEruption,
	dustGasFountain,
	dustPreEruption,
	dustCloudSlower,
	dustEruptionFinalization,
	dustVortex,
	dustJet,
	dustCloudSlowerRotating,
	steamColumnDispl,
	steamColumnSlow,
	steamColumnDisplVert,
	steamColumn,
	steamColumnDisplSlow,
	steamColumnSlower,
	flareSplashRedder,
	smokeExpanding,
	flareWave,
	smokeExpandingCenter,
	smokeCloudBig,
	smokeCircleWaves,
	smokeSparkles,
	smokeCloudBigRound,
	smokeColumnBigRound,
	smokeColumnBig,
	sparklesFleeingOrange,
	fireGlow,
	fireGlow2,
	fireGlow3,
	fireGlow4,
	fireGlow5,
	fireGlowHoriz,
	fireGlowHoriz2,
	fireGlowHoriz3,
	candleFireSprite,
	candleFire,
	fireCandleGlow,
	torchFire,
	fireSmokeColumn,
	candleFireSpriteExhaust,
	candleFireExhaust,
	fireGasWeldBlue,
	coalUnderCampFire,
	campFire,
	campFireSparkles,
	campFireSmoke,
	campFireArea,
	coalArea,
	torchFireArea,
	fireSmokeColumnArea,
	campFireSparklesArea,
	candleFireSpriteBlue,
	coalStick,
	campFireStick,
	beamsWeldingThin,
	fireWeldingSparkles,
	fireWeldingFlare,
	fireWeldingGlow,
	fireWeldingDrops,
	fireWeldSmoke,
	nukeInitialBall,
	nukeBallAdd,
	nukeBallSecond,
	nukeBallThird,
	nukeBall4,
	nukeGlow,
	nukeSmokeColumn,
	nukeWaveHorizontal,
	nukeCoalArea,
	vacuumGas,
	vacuumGasIgnition,
	vacuumImplosionFlash,
	vacuumGasLateBurning,
	siegeExplosionTails,
	siegeExplosion,
	siegeGlow,
	siegeLateBurning,
	siegeGlowVolumous,
	siegeSmoke,
	siegeDarkerSmoke,
	siegeDarkerBall,
	siegeDarkerGlow,
	siegeDarkerTails,
	fireImpactBall,
	fireExplBeams,
	fireImpactBeamyBall,
	fireImpactBeamySmoke,
	fireExplBigSmoke,
	fireExplBigWave,
	fireExplBigFlame,
	fireExplBigSleeves,
	fireExplBigBall,
	fireExplMedFlameUp,
	fireExplMedFlameMid,
	fireExplMedSparkles,
	fireExplMedBall,
	fireExplMedDrops,
	fireworks,
	fireworksGlow,
	fireCloud,
	fireRain,
	sparklesFlash,
	sparklesFlashGlow,
	sparklesFlashBeams,
	sparklesVolumeSplashes,
	sparklesVolumeSparkels,
	sparklesVolumeGlows,
	greeenSplashBeams,
	greenSplashWave,
	greenSplash,
	greenFireworks,
	bengalFireStick,
	bengalFireBeamsThin,
	bengalFireGlow,
	bengalFireSparkles,
	bengalFireSparklesTaily,
	bengalFireStickDone,
	sparkleFountain,
	sparklesExplosion,
	flareLight,
	flareLightGlow,
	flareFire,
	flareFireGlow,
	flareElectricity,
	flareZapGlow,
	flareSmoke,
	flareSmokeGlow,
	flareSparkles,
	flareSparklesGlow,
	flareMagic,
	flareMagicGlow,
	magicDarkCircleSmoke,
	magicDarkVerticalSmoke,
	magicDarkFlame,
	magicDarkFlameVertical,
	magicDarkRedWaves,
	magicDarkSphereBlack,
	magicDarkSphereSmoke,
	magicDarkSphereBright,
	magicDarkFlareHoriz,
	magicDarkFlareVert,
	magicDarkGlow,
	magicDarkBlackSpot,
	magicDarkBlackCloudGrow,
	magicDarkBlackCloudBurst,
	magicDarkRedWavesIn,
	magicDarkGlowSlow,
	magicDarkRedSpotsIn,
	magicDarkGlowWhite,
	magicDarkFlies,
	magicDeathFlowers,
	magicDarkSplashGreen,
	magicDarkAsh,
	magicDarkGreenGlow,
	magicDarkAshFront,
	magicDarkUndergroundLight,
	magicDarkUndergroundGlow,
	magicDarkUndergroundEscape,
	magicDarkCloudFocusing,
	magicDarkGlowFocusing,
	magicDarkEnergyOut,
	magicDarkPikes,
	magicDarkEnergyWaveOut,
	magicDarkGlowBigger,
	magicLight,
	magicLightGlow,
	magicLightBlinksBlue,
	magicLightBlinksRed,
	magicLightGlowBillboard,
	magicLightTall,
	magicLightTallThin,
	magicLightGlowColumn,
	magicLightTallLines,
	mudBubblesOrange,
	mudBubblesGreen,
	mudBubblesPurple,
	magicLightSnakes,
	magicLightGlowBubbles,
	magicLightFlies,
	magicLightLeaves,
	magicNatureLeaves,
	magicNatureGrass,
	magicLightGreen,
	magicLightBlinksGreeen,
	magicLightFlower,
	chainLightning,
	waterDropsDispl,
	waterDropsColor,
	waterDropsSplashes,
	waterDropsMist,
	waterShowerDispl,
	waterShowerDrops,
	waterRainCloud,
	boilingDrops,
	boilingSteam,
	boilingDispl,
	waterWaves,
	plasmShining,
	plasmGlowShining,
	plasmGlowShiningFast,
	plasmWave,
	plasmWaveOuter,
	plasmWaves,
	plasmShiningOutside,
	plasmShiningOutSlow,
	plasmColumn,
	plasmColumnImpact,
	plasmColumnGlow,
	plasmColumnGlowBB,
	plasmColumnLight,
	plasmAmplifier,
	plasmCircleBlue,
	plasmColumnJet,
	plasmGlowAmplifier,
	plasmWaveSplash,
	plasmWavesSplash,
	plasmCloud,
	explRocksFleeingMed,
	explFireTails,
	explFireTentacles,
	explFlash,
	explFlashHoriz,
	explDustTentacles,
	explDust,
	explDustSlow,
	explWaveHoriz,
	explRocksFleeingSmall,
	explDustSettles,
	explFlame,
	explWaveHorizFire,
	explFlashHorizFire,
	explFireTailsFast,
	explFlashFire,
	explFlameSlow,
	explSparks,
	explDustFountSettles,
	explDustColumnSettles,
	explFlashLight,
	explFlashDirt,
	explDustSphere,
	explRocksSmall,
	explDustCircle,
	explWaveHorizDust,
	explFlameSlowAir,
	explFireTailsAir,
	explFireBall,
	explFireWave,
	explFireSparksSmall,
	explFireTailsFastSphere,
	explFlashFire2,
	rockRainCloud,
	rockRainBigRocks,
	bigRockFall,
	lavaFall,
	lavaFountain,
	lavaFountainDrop,
	lavaFountainDropR,
	lavaRockFall,
	iceRockFall,
	iceLights,
	icePikes,
	iceGround,
	iceImpactWave,
	iceRain,
	iceCloud,
	iceCloudCold,
	snowFlakes,
	snowCloud,
	lightGlow,
	lightWave,
	lightBeams,
	lightsWhite,
	lightsRedBlue,
	lightsTealSalt,
	lightsYellowOrange,
	lightBeamsFocused,
	lightBeamsFromSky,
	lightGlow2,
	stormLightnings,
	stormCloudFront,
	stormCloudBack,
	starDustInitialCloud,
	starDustFocusingBG,
	starDustFocusing,
	starInitialGlow,
	starGlowExpl,
	starWaveExpl,
	starExplFumes,
	starDustInitialCloudMove,
	starDustOut,
	starMainGlow,
	star,
	starFinalGlow,
	starDustCircle1,
	starDustCircle2,
	starDustCircle3,

	size
}

public enum visualEffectNames : int{	// effects are enumerated by name, and can be spawned like this: visEffects.createEffect((int)visualEffectNames.vacuumExplosion, coordinates);
	electricSplashSparklesSmoke,
	electricZapsToGround,
	electricExplosion,
	electricLightningsExplosion,
	electricExplosiveNova,
	electricBurningSharp,
	electricChargeExplosion,
	electricWelding,
	electricLightningStrike,
	electricChainLightning,
	lightningBolt,
	gooSplashGround,
	gooExplosion,
	gooFountain,
	gooFog,
	gooAcidSplash,
	gooAcidStorm,
	mudBoiling,
	mudGroundSplash,
	mudExplosion,
	mudFountain,
	mudWaves,
	bloodExplosion,
	bloodAndGutsExplosion,
	bloodFountain,
	bloodRain,
	bloodBoiling,
	bloodImpact,
	dustExplosion,
	dustVolumousExplosions,
	dustFountain,
	dustTornado,
	steamSlow,
	steamFast,
	steamCloud,
	smokeExplosionWithFlash,
	smokeScreen,
	smokeColumn,
	smokeFromSparkles,
	fireCandleSprite,
	fireCandle,
	fireTorch,
	fireReactiveExhaust,
	gasWelding,
	campFire,
	burningSoil,
	gasBurner,
	fireColumn,
	fireWelding,
	nuke,
	vacuumExplosion,
	siegeExplosion,
	siegeExplosionDarker,
	fireImpact,
	fireImpactBeamy,
	fireExplBig,
	fireExplMed,
	fireworks,
	fireRain,
	sparklesSplash,
	sparklesVolume,
	greenSplash,
	bengalFire,
	sparkleFountain,
	sparklesExplosion,
	flareLight,
	flareFire,
	flareElectricity,
	flareSmoke,
	flareSparkles,
	flareMagic,
	magicDarkCircleCreation,
	magicDarkSphereCreation,
	magicDarkCloudCreation,
	magicDarkFlies,
	magicDeathFlowers,
	magicDarkSplashGreen,
	magicDarkUndergroundEscape,
	magicDarkCloudFocusing,
	magicLightShining,
	magicLightOverlighting,
	magicLightColumn,
	magicLightBubbles,
	magicLightSnakes,
	magicLightFlies,
	magicLightLeaves,
	magicNatureLeaves,
	magicNatureGrass,
	magicLightFlower,
	waterSplash,
	waterRain,
	waterBoiling,
	plasmCloud,
	plasmExplosion,
	plasmColumn,
	plasmAmplifier,
	explosionGround1,
	explosionGround2,
	explosionGroundDirt,
	explosion1,
	rockRain,
	rockFall,
	lavaFall,
	lavaFountain,
	lavaRockFall,
	iceRockFall,
	icePikes,
	iceRain,
	snowFlakes,
	lightSplash,
	lights,
	lightBeamFocused,
	lightningStorm,
	starInception,

	size
}

public struct particleEmitters{						// this struct contains links to object and particle system of the instantiated emitter prefabs
	GameObject pGO;
	public ParticleSystem ps;
	public void initEmitter(GameObject psPrefab){
		pGO = GameObject.Instantiate(psPrefab);
        GameObject single = GameManager._instance.gameObject;
        Transform empty = single.transform.GetChild(1);
        pGO.transform.SetParent(empty);
        ps = pGO.GetComponent<ParticleSystem>();
	}
	public void emitParticles(Vector3 p, int n){
		pGO.transform.position = p;
		ps.Emit(n);
	}
}

public struct visEffectComponent{					// each visual effect contains some of these components, each one will emit one emitter's particles
	public int emitterN;							// number (name) of emitter
	public int amount;								// number of particles to emit
	public Vector3 offset;							// offset from effect center
	public float delay;								// delay from effect start
}

public struct visEffect{							// this structure describes the effects as an array of components
	public visEffectComponent[] veComponents;		// array of effect components
	public bool ground;								// if ground, it's better to run effect at zero height
	public float scaleFactor;						// this scale factor can be set per effect in the visEffects.initEmitters(), where all effects are initialized
	public int nComponents;
	public void init(){
		int i;
		veComponents = new visEffectComponent[visEffects.maxComponentsNumber];
		ground = false;
		scaleFactor = 1;
		i = 0;
		while (i < veComponents.Length) {
			veComponents[i].emitterN = -1;
			veComponents[i].amount = 0;
			veComponents[i].offset = Vector3.zero;
			veComponents[i].delay = 0;
			i++;
		}
	}
	public void addComponent(int n, int a, float d = 0, Vector3 v = default(Vector3)){
		if (nComponents >= visEffects.maxComponentsNumber)
			return;
		if (n < 0 || n >= (int)particleEmitterNames.size)
			return;
		veComponents[nComponents].emitterN = n;
		veComponents[nComponents].amount = a;
		veComponents[nComponents].offset = v;
		veComponents[nComponents].delay = d;
		nComponents++;
	}
	public void createEffect(int veNumber, Vector3 pos){						// actually creates visual effect in the game world
		int i = 0;
		while (i < nComponents) {
			if (veComponents[i].delay < 0.01f) {
				visEffects.emitters[veComponents[i].emitterN].emitParticles(pos + veComponents[i].offset, veComponents[i].amount);
			}
			else {
				visEffects.evTimers.startTimer(veComponents[i].delay, veNumber, i, pos + veComponents[i].offset);
			}
			i++;
		}
	}
}

public struct veTimer{		// timer class is needed to spawn particles with time offset
	float t;				// delay timer
	int veN;				// visual effect number
	int vecN;				// visual effect component number
	Vector3 p;				// this vector is being set on timer start as effect coordinate + component offset
	public void init(){
		t = -1;
	}
	public void turnOn(float dt, int n, int cn, Vector3 pos){
		t = dt;
		veN = n;
		vecN = cn;
		p = pos;
	}
	public void tick(float dt){
		if (!isOn())
			return;
		t -= dt;
		if (t < 0)
			visEffects.emitFromTimer(veN, vecN, p);
	}
	public bool isOn(){
		return t >= 0;
	}
}

public struct timersStruct{							// this calss handles all timers
	public const int timersMaxAmount = 1000;		// this should be big enough to never reach max capacity
	veTimer[] timers;								// array of timers
	int nTimers;									// amount of active timers to tick through
	public void init(){
		int i;
		timers = new veTimer[timersMaxAmount];
		i = 0;
		while (i < timers.Length) {
			timers[i].init();
			i++;
		}
	}
	public void tickAll(float dt){
		int i = 0;
		while (i < nTimers){
			timers[i].tick(dt);
			if (!timers[i].isOn()) {
				timers[i] = timers[nTimers - 1];
				--nTimers;
				--i;
			}
			i++;
		}
	}
	public void startTimer(float dt, int n, int cn, Vector3 pos){
		if (nTimers >= timersMaxAmount)
			return;
		timers[nTimers++].turnOn(dt, n, cn, pos);
	}
}

public static class visEffects {					// this class contains all effects, describes them at init and spawns by createEffect() method
	public const int maxComponentsNumber = 128;		// so each effect will contain up to 8 components
	static public float scaleFactor = 1.0f;			// scale factor for all effects
	static public particleEmitters[] emitters;		// array of all emitters
	static public bool[] emittersToAffect;			// array of bools to populate when figuring out which emitters to scale for per effect scale
	static visEffect[] vEffects;					// array of all effects' descriptions
	static public timersStruct evTimers;
	public static void staticInit () {
        emitters = new particleEmitters[(int)particleEmitterNames.size];
		emittersToAffect = new bool[(int)particleEmitterNames.size];
		initEmitters();
		vEffects = new visEffect[(int)visualEffectNames.size];
		initVisEffects();
		scaleAllEmitters();		// scales all emitters based on visEffects.scaleFactor
		scaleAllEffects();		// scales all effects' emitters based on each effect's scaleFactor
		evTimers.init();
	}
	static void initEmitters(){
		//emitters[(int)particleEmitterNames.smokeGray].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/smokeGray"));
		//emitters[(int)particleEmitterNames.sparklesBlinking].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/sparklesBlinking"));
		//emitters[(int)particleEmitterNames.splashBlue].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlue"));
		//emitters[(int)particleEmitterNames.sparklesFleeing].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/sparklesFleeing"));
		//emitters[(int)particleEmitterNames.sparklesFleeing2].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/sparklesFleeing2"));
		//emitters[(int)particleEmitterNames.sparklesFleeing3].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/sparklesFleeing3"));
		//emitters[(int)particleEmitterNames.sparklesFleeingFast].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/sparklesFleeingFast"));
		//emitters[(int)particleEmitterNames.electroMist].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroMist"));
		//emitters[(int)particleEmitterNames.electroMist2].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroMist2"));
		//emitters[(int)particleEmitterNames.electroMist3].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroMist3"));
		//emitters[(int)particleEmitterNames.splashBlueHorizontal].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueHorizontal"));
		//emitters[(int)particleEmitterNames.splashBlueHorizontal2].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueHorizontal2"));
		//emitters[(int)particleEmitterNames.zapsToGround].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/zapsToGround"));
		//emitters[(int)particleEmitterNames.sparklesFleeingCircle].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/sparklesFleeingCircle"));
		//emitters[(int)particleEmitterNames.electroSparklesFleeing].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroSparklesFleeing"));
		//emitters[(int)particleEmitterNames.electroSplashBlue].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroSplashBlue"));
		//emitters[(int)particleEmitterNames.electroSplashBlueBeamy].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroSplashBlueBeamy"));
		//emitters[(int)particleEmitterNames.splashBlueCircle].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueCircle"));
		//emitters[(int)particleEmitterNames.splashBlueMist].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueMist"));
		//emitters[(int)particleEmitterNames.beamsBlue].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/beamsBlue"));
		//emitters[(int)particleEmitterNames.beamsBlue2].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/beamsBlue2"));
		//emitters[(int)particleEmitterNames.lightnings].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/lightnings"));
		//emitters[(int)particleEmitterNames.lightnings2].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/lightnings2"));
		//emitters[(int)particleEmitterNames.lightningsFromCenter].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/lightningsFromCenter"));
		//emitters[(int)particleEmitterNames.electroSplashBlueBigger].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroSplashBlueBigger"));
		//emitters[(int)particleEmitterNames.electricEnergyWaves].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electricEnergyWaves"));
		//emitters[(int)particleEmitterNames.electricEnergyWaves2].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electricEnergyWaves2"));
		//emitters[(int)particleEmitterNames.electricEnergyWavesH].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electricEnergyWavesH"));
		//emitters[(int)particleEmitterNames.splashBlueGlow].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueGlow"));
		//emitters[(int)particleEmitterNames.splashBlueGlow2].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueGlow2"));
		//emitters[(int)particleEmitterNames.splashBlueGlow3].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueGlow3"));
		//emitters[(int)particleEmitterNames.splashBlueGlow4].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueGlow4"));
		//emitters[(int)particleEmitterNames.splashBlueGlow5].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/splashBlueGlow5"));
		//emitters[(int)particleEmitterNames.nova].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/nova"));
		//emitters[(int)particleEmitterNames.beamsCircle].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/beamsCircle"));
		//emitters[(int)particleEmitterNames.zapsFromCenter].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/zapsFromCenter"));
		//emitters[(int)particleEmitterNames.electroSplashBlueMedium].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/electroSplashBlueMedium"));
		//emitters[(int)particleEmitterNames.smokeGraySmallToBig].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/smokeGraySmallToBig"));
		//emitters[(int)particleEmitterNames.zapToGround].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/zapToGround"));
		//emitters[(int)particleEmitterNames.lightningsFromCenterSmall].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/lightningsFromCenterSmall"));
		//emitters[(int)particleEmitterNames.beamsGoo].initEmitter(Resources.Load<GameObject>("Emitters/Goo/beamsGoo"));
		//emitters[(int)particleEmitterNames.gooDropsFleeing].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeing"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingBigger].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingBigger"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingBigger2].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingBigger2"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingBigger3].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingBigger3"));
		//emitters[(int)particleEmitterNames.gooGasExpansion].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooGasExpansion"));
		//emitters[(int)particleEmitterNames.gooGasExpansion2].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooGasExpansion2"));
		//emitters[(int)particleEmitterNames.gooGasExpansion3].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooGasExpansion3"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingLonger].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingLonger"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingLonger2].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingLonger2"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingLonger3].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingLonger3"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingLonger4].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingLonger4"));
		//emitters[(int)particleEmitterNames.gooGasCloud].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooGasCloud"));
		//emitters[(int)particleEmitterNames.gooGasCloud2].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooGasCloud2"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingSlower].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingSlower"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingSlower2].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingSlower2"));
		//emitters[(int)particleEmitterNames.beamsGooBrighter].initEmitter(Resources.Load<GameObject>("Emitters/Goo/beamsGooBrighter"));
		//emitters[(int)particleEmitterNames.gooGasExpansionBrighter].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooGasExpansionBrighter"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingBrighter].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingBrighter"));
		//emitters[(int)particleEmitterNames.gooFountain].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooFountain"));
		//emitters[(int)particleEmitterNames.gooBeamsFountain].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooBeamsFountain"));
		//emitters[(int)particleEmitterNames.gooFog].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooFog"));
		//emitters[(int)particleEmitterNames.gooFog2].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooFog2"));
		//emitters[(int)particleEmitterNames.gooSplash].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooSplash"));
		//emitters[(int)particleEmitterNames.gooDropsFleeingYellow].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooDropsFleeingYellow"));
		//emitters[(int)particleEmitterNames.acidStormCloud].initEmitter(Resources.Load<GameObject>("Emitters/Goo/acidStormCloud"));
		//emitters[(int)particleEmitterNames.gooAcidRain].initEmitter(Resources.Load<GameObject>("Emitters/Goo/gooAcidRain"));
		//emitters[(int)particleEmitterNames.mudFountain].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudFountain"));
		//emitters[(int)particleEmitterNames.mudFountainSplashes].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudFountainSplashes"));
		//emitters[(int)particleEmitterNames.mudMist].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudMist"));
		//emitters[(int)particleEmitterNames.mudSquirts].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudSquirts"));
		//emitters[(int)particleEmitterNames.mudGroundSplash].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudGroundSplash"));
		//emitters[(int)particleEmitterNames.mudFountainSplash].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudFountainSplash"));
		//emitters[(int)particleEmitterNames.mudSquirtsPoint].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudSquirtsPoint"));
		//emitters[(int)particleEmitterNames.mudSplashSoft].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudSplashSoft"));
		//emitters[(int)particleEmitterNames.mudBurst].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudBurst"));
		//emitters[(int)particleEmitterNames.mudBurst360].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudBurst360"));
		//emitters[(int)particleEmitterNames.flareSplash].initEmitter(Resources.Load<GameObject>("Emitters/Mud/flareSplash"));
		//emitters[(int)particleEmitterNames.mudSquirts360].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudSquirts360"));
		//emitters[(int)particleEmitterNames.mudGasExpansion].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudGasExpansion"));
		//emitters[(int)particleEmitterNames.mudDropsFleeingLonger].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudDropsFleeingLonger"));
		//emitters[(int)particleEmitterNames.mudGasExpansionBig].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudGasExpansionBig"));
		//emitters[(int)particleEmitterNames.mudFountainVertical].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudFountainVertical"));
		//emitters[(int)particleEmitterNames.mudWaveHorizontal].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudWaveHorizontal"));
		//emitters[(int)particleEmitterNames.mudBeamyWaves].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudBeamyWaves"));
		//emitters[(int)particleEmitterNames.mudBubbles].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudBubbles"));
		//emitters[(int)particleEmitterNames.mudGas].initEmitter(Resources.Load<GameObject>("Emitters/Mud/mudGas"));
		emitters[(int)particleEmitterNames.bloodSplash].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodSplash"));
		emitters[(int)particleEmitterNames.bloodFog].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodFog"));
		emitters[(int)particleEmitterNames.bloodWave].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodWave"));
		emitters[(int)particleEmitterNames.bloodDropsFleeingLonger].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodDropsFleeingLonger"));
		emitters[(int)particleEmitterNames.bloodDropsFleeing].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodDropsFleeing"));
		emitters[(int)particleEmitterNames.bloodBurst360].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodBurst360"));
		emitters[(int)particleEmitterNames.bloodGuts].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodGuts"));
		emitters[(int)particleEmitterNames.bloodWaveSmaller].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodWaveSmaller"));
		emitters[(int)particleEmitterNames.bloodFountainVertical].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodFountainVertical"));
		emitters[(int)particleEmitterNames.bloodFountainGas].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodFountainGas"));
		emitters[(int)particleEmitterNames.bloodBeams].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodBeams"));
		emitters[(int)particleEmitterNames.bloodStormClouds].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodStormClouds"));
		emitters[(int)particleEmitterNames.bloodRain].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodRain"));
		emitters[(int)particleEmitterNames.bloodSquirts].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodSquirts"));
		emitters[(int)particleEmitterNames.bloodBubbles].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodBubbles"));
		emitters[(int)particleEmitterNames.bloodSquirtsBigger].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodSquirtsBigger"));
		emitters[(int)particleEmitterNames.bloodFogClouds].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodFogClouds"));
		emitters[(int)particleEmitterNames.bloodDropsFleeingCircle].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodDropsFleeingCircle"));
		emitters[(int)particleEmitterNames.bloodBurstCircle].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodBurstCircle"));
		emitters[(int)particleEmitterNames.bloodSprayThick].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodSprayThick"));
		emitters[(int)particleEmitterNames.bloodDrops].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodDrops"));
		emitters[(int)particleEmitterNames.bloodSprayFog].initEmitter(Resources.Load<GameObject>("Emitters/Blood/bloodSprayFog"));
		//emitters[(int)particleEmitterNames.dustWave].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustWave"));
		//emitters[(int)particleEmitterNames.dustCloud].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustCloud"));
		//emitters[(int)particleEmitterNames.dustWaveSmallerInVolume].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustWaveSmallerInVolume"));
		//emitters[(int)particleEmitterNames.dustCloudsVolumous].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustCloudsVolumous"));
		//emitters[(int)particleEmitterNames.dustEruption].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustEruption"));
		//emitters[(int)particleEmitterNames.dustGasFountain].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustGasFountain"));
		//emitters[(int)particleEmitterNames.dustPreEruption].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustPreEruption"));
		//emitters[(int)particleEmitterNames.dustCloudSlower].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustCloudSlower"));
		//emitters[(int)particleEmitterNames.dustEruptionFinalization].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustEruptionFinalization"));
		//emitters[(int)particleEmitterNames.dustVortex].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustVortex"));
		//emitters[(int)particleEmitterNames.dustJet].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustJet"));
		//emitters[(int)particleEmitterNames.dustCloudSlowerRotating].initEmitter(Resources.Load<GameObject>("Emitters/Dust/dustCloudSlowerRotating"));
		//emitters[(int)particleEmitterNames.steamColumnDispl].initEmitter(Resources.Load<GameObject>("Emitters/Steam/steamColumnDispl"));
		//emitters[(int)particleEmitterNames.steamColumnSlow].initEmitter(Resources.Load<GameObject>("Emitters/Steam/steamColumnSlow"));
		//emitters[(int)particleEmitterNames.steamColumnDisplVert].initEmitter(Resources.Load<GameObject>("Emitters/Steam/steamColumnDisplVert"));
		//emitters[(int)particleEmitterNames.steamColumn].initEmitter(Resources.Load<GameObject>("Emitters/Steam/steamColumn"));
		//emitters[(int)particleEmitterNames.steamColumnDisplSlow].initEmitter(Resources.Load<GameObject>("Emitters/Steam/steamColumnDisplSlow"));
		//emitters[(int)particleEmitterNames.steamColumnSlower].initEmitter(Resources.Load<GameObject>("Emitters/Steam/steamColumnSlower"));
		//emitters[(int)particleEmitterNames.flareSplashRedder].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/flareSplashRedder"));
		//emitters[(int)particleEmitterNames.smokeExpanding].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeExpanding"));
		//emitters[(int)particleEmitterNames.flareWave].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/flareWave"));
		//emitters[(int)particleEmitterNames.smokeExpandingCenter].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeExpandingCenter"));
		//emitters[(int)particleEmitterNames.smokeCloudBig].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeCloudBig"));
		//emitters[(int)particleEmitterNames.smokeCircleWaves].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeCircleWaves"));
		//emitters[(int)particleEmitterNames.smokeSparkles].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeSparkles"));
		//emitters[(int)particleEmitterNames.smokeCloudBigRound].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeCloudBigRound"));
		//emitters[(int)particleEmitterNames.smokeColumnBigRound].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeColumnBigRound"));
		//emitters[(int)particleEmitterNames.smokeColumnBig].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/smokeColumnBig"));
		//emitters[(int)particleEmitterNames.sparklesFleeingOrange].initEmitter(Resources.Load<GameObject>("Emitters/Smoke/sparklesFleeingOrange"));
		//emitters[(int)particleEmitterNames.candleFireSprite].initEmitter(Resources.Load<GameObject>("Emitters/Fire/candleFireSprite"));
		//emitters[(int)particleEmitterNames.fireGlow].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlow"));
		//emitters[(int)particleEmitterNames.fireGlow2].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlow2"));
		//emitters[(int)particleEmitterNames.fireGlow3].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlow3"));
		//emitters[(int)particleEmitterNames.fireGlow4].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlow4"));
		//emitters[(int)particleEmitterNames.fireGlow5].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlow5"));
		//emitters[(int)particleEmitterNames.fireGlowHoriz].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlowHoriz"));
		//emitters[(int)particleEmitterNames.fireGlowHoriz2].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlowHoriz2"));
		//emitters[(int)particleEmitterNames.fireGlowHoriz3].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGlowHoriz3"));
		//emitters[(int)particleEmitterNames.candleFire].initEmitter(Resources.Load<GameObject>("Emitters/Fire/candleFire"));
		//emitters[(int)particleEmitterNames.fireCandleGlow].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireCandleGlow"));
		//emitters[(int)particleEmitterNames.torchFire].initEmitter(Resources.Load<GameObject>("Emitters/Fire/torchFire"));
		//emitters[(int)particleEmitterNames.fireSmokeColumn].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireSmokeColumn"));
		//emitters[(int)particleEmitterNames.candleFireSpriteExhaust].initEmitter(Resources.Load<GameObject>("Emitters/Fire/candleFireSpriteExhaust"));
		//emitters[(int)particleEmitterNames.candleFireExhaust].initEmitter(Resources.Load<GameObject>("Emitters/Fire/candleFireExhaust"));
		//emitters[(int)particleEmitterNames.fireGasWeldBlue].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireGasWeldBlue"));
		//emitters[(int)particleEmitterNames.coalUnderCampFire].initEmitter(Resources.Load<GameObject>("Emitters/Fire/coalUnderCampFire"));
		//emitters[(int)particleEmitterNames.campFire].initEmitter(Resources.Load<GameObject>("Emitters/Fire/campFire"));
		//emitters[(int)particleEmitterNames.campFireSparkles].initEmitter(Resources.Load<GameObject>("Emitters/Fire/campFireSparkles"));
		//emitters[(int)particleEmitterNames.campFireSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Fire/campFireSmoke"));
		//emitters[(int)particleEmitterNames.campFireArea].initEmitter(Resources.Load<GameObject>("Emitters/Fire/campFireArea"));
		//emitters[(int)particleEmitterNames.coalArea].initEmitter(Resources.Load<GameObject>("Emitters/Fire/coalArea"));
		//emitters[(int)particleEmitterNames.torchFireArea].initEmitter(Resources.Load<GameObject>("Emitters/Fire/torchFireArea"));
		//emitters[(int)particleEmitterNames.fireSmokeColumnArea].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireSmokeColumnArea"));
		//emitters[(int)particleEmitterNames.campFireSparklesArea].initEmitter(Resources.Load<GameObject>("Emitters/Fire/campFireSparklesArea"));
		//emitters[(int)particleEmitterNames.candleFireSpriteBlue].initEmitter(Resources.Load<GameObject>("Emitters/Fire/candleFireSpriteBlue"));
		//emitters[(int)particleEmitterNames.coalStick].initEmitter(Resources.Load<GameObject>("Emitters/Fire/coalStick"));
		//emitters[(int)particleEmitterNames.campFireStick].initEmitter(Resources.Load<GameObject>("Emitters/Fire/campFireStick"));
		//emitters[(int)particleEmitterNames.beamsWeldingThin].initEmitter(Resources.Load<GameObject>("Emitters/Fire/beamsWeldingThin"));
		//emitters[(int)particleEmitterNames.fireWeldingSparkles].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireWeldingSparkles"));
		//emitters[(int)particleEmitterNames.fireWeldingFlare].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireWeldingFlare"));
		//emitters[(int)particleEmitterNames.fireWeldingGlow].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireWeldingGlow"));
		//emitters[(int)particleEmitterNames.fireWeldingDrops].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireWeldingDrops"));
		//emitters[(int)particleEmitterNames.fireWeldSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireWeldSmoke"));
		//emitters[(int)particleEmitterNames.nukeInitialBall].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeInitialBall"));
		//emitters[(int)particleEmitterNames.nukeBallAdd].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeBallAdd"));
		//emitters[(int)particleEmitterNames.nukeBallSecond].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeBallSecond"));
		//emitters[(int)particleEmitterNames.nukeBallThird].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeBallThird"));
		//emitters[(int)particleEmitterNames.nukeBall4].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeBall4"));
		//emitters[(int)particleEmitterNames.nukeGlow].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeGlow"));
		//emitters[(int)particleEmitterNames.nukeSmokeColumn].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeSmokeColumn"));
		//emitters[(int)particleEmitterNames.nukeWaveHorizontal].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeWaveHorizontal"));
		//emitters[(int)particleEmitterNames.nukeCoalArea].initEmitter(Resources.Load<GameObject>("Emitters/Fire/nukeCoalArea"));
		//emitters[(int)particleEmitterNames.vacuumGas].initEmitter(Resources.Load<GameObject>("Emitters/Fire/vacuumGas"));
		//emitters[(int)particleEmitterNames.vacuumGasIgnition].initEmitter(Resources.Load<GameObject>("Emitters/Fire/vacuumGasIgnition"));
		//emitters[(int)particleEmitterNames.vacuumImplosionFlash].initEmitter(Resources.Load<GameObject>("Emitters/Fire/vacuumImplosionFlash"));
		//emitters[(int)particleEmitterNames.vacuumGasLateBurning].initEmitter(Resources.Load<GameObject>("Emitters/Fire/vacuumGasLateBurning"));
		//emitters[(int)particleEmitterNames.siegeExplosionTails].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeExplosionTails"));
		//emitters[(int)particleEmitterNames.siegeExplosion].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeExplosion"));
		//emitters[(int)particleEmitterNames.siegeGlow].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeGlow"));
		//emitters[(int)particleEmitterNames.siegeLateBurning].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeLateBurning"));
		//emitters[(int)particleEmitterNames.siegeGlowVolumous].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeGlowVolumous"));
		//emitters[(int)particleEmitterNames.siegeSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeSmoke"));
		//emitters[(int)particleEmitterNames.siegeDarkerSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeDarkerSmoke"));
		//emitters[(int)particleEmitterNames.siegeDarkerBall].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeDarkerBall"));
		//emitters[(int)particleEmitterNames.siegeDarkerGlow].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeDarkerGlow"));
		//emitters[(int)particleEmitterNames.siegeDarkerTails].initEmitter(Resources.Load<GameObject>("Emitters/Fire/siegeDarkerTails"));
		//emitters[(int)particleEmitterNames.fireImpactBall].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireImpactBall"));
		//emitters[(int)particleEmitterNames.fireExplBeams].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplBeams"));
		//emitters[(int)particleEmitterNames.fireImpactBeamyBall].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireImpactBeamyBall"));
		//emitters[(int)particleEmitterNames.fireImpactBeamySmoke].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireImpactBeamySmoke"));
		//emitters[(int)particleEmitterNames.fireExplBigSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplBigSmoke"));
		//emitters[(int)particleEmitterNames.fireExplBigWave].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplBigWave"));
		//emitters[(int)particleEmitterNames.fireExplBigFlame].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplBigFlame"));
		//emitters[(int)particleEmitterNames.fireExplBigSleeves].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplBigSleeves"));
		//emitters[(int)particleEmitterNames.fireExplBigBall].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplBigBall"));
		//emitters[(int)particleEmitterNames.fireExplMedFlameUp].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplMedFlameUp"));
		//emitters[(int)particleEmitterNames.fireExplMedFlameMid].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplMedFlameMid"));
		//emitters[(int)particleEmitterNames.fireExplMedSparkles].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplMedSparkles"));
		//emitters[(int)particleEmitterNames.fireExplMedBall].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplMedBall"));
		//emitters[(int)particleEmitterNames.fireExplMedDrops].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireExplMedDrops"));
		//emitters[(int)particleEmitterNames.fireworks].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/fireworks"));
		//emitters[(int)particleEmitterNames.fireworksGlow].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/fireworksGlow"));
		//emitters[(int)particleEmitterNames.fireCloud].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireCloud"));
		//emitters[(int)particleEmitterNames.fireRain].initEmitter(Resources.Load<GameObject>("Emitters/Fire/fireRain"));
		//emitters[(int)particleEmitterNames.sparklesFlash].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparklesFlash"));
		//emitters[(int)particleEmitterNames.sparklesFlashGlow].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparklesFlashGlow"));
		//emitters[(int)particleEmitterNames.sparklesFlashBeams].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparklesFlashBeams"));
		//emitters[(int)particleEmitterNames.sparklesVolumeSplashes].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparklesVolumeSplashes"));
		//emitters[(int)particleEmitterNames.sparklesVolumeSparkels].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparklesVolumeSparkels"));
		//emitters[(int)particleEmitterNames.sparklesVolumeGlows].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparklesVolumeGlows"));
		//emitters[(int)particleEmitterNames.greeenSplashBeams].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/greeenSplashBeams"));
		//emitters[(int)particleEmitterNames.greenSplashWave].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/greenSplashWave"));
		//emitters[(int)particleEmitterNames.greenSplash].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/greenSplash"));
		//emitters[(int)particleEmitterNames.greenFireworks].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/greenFireworks"));
		//emitters[(int)particleEmitterNames.bengalFireStick].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/bengalFireStick"));
		//emitters[(int)particleEmitterNames.bengalFireBeamsThin].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/bengalFireBeamsThin"));
		//emitters[(int)particleEmitterNames.bengalFireGlow].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/bengalFireGlow"));
		//emitters[(int)particleEmitterNames.bengalFireSparkles].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/bengalFireSparkles"));
		//emitters[(int)particleEmitterNames.bengalFireSparklesTaily].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/bengalFireSparklesTaily"));
		//emitters[(int)particleEmitterNames.bengalFireStickDone].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/bengalFireStickDone"));
		//emitters[(int)particleEmitterNames.sparkleFountain].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparkleFountain"));
		//emitters[(int)particleEmitterNames.sparklesExplosion].initEmitter(Resources.Load<GameObject>("Emitters/Sparkles/sparklesExplosion"));
		//emitters[(int)particleEmitterNames.flareLight].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareLight"));
		//emitters[(int)particleEmitterNames.flareLightGlow].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareLightGlow"));
		//emitters[(int)particleEmitterNames.flareFire].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareFire"));
		//emitters[(int)particleEmitterNames.flareFireGlow].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareFireGlow"));
		//emitters[(int)particleEmitterNames.flareElectricity].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareElectricity"));
		//emitters[(int)particleEmitterNames.flareZapGlow].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareZapGlow"));
		//emitters[(int)particleEmitterNames.flareSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareSmoke"));
		//emitters[(int)particleEmitterNames.flareSmokeGlow].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareSmokeGlow"));
		//emitters[(int)particleEmitterNames.flareSparkles].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareSparkles"));
		//emitters[(int)particleEmitterNames.flareSparklesGlow].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareSparklesGlow"));
		//emitters[(int)particleEmitterNames.flareMagic].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareMagic"));
		//emitters[(int)particleEmitterNames.flareMagicGlow].initEmitter(Resources.Load<GameObject>("Emitters/Flare/flareMagicGlow"));
		//emitters[(int)particleEmitterNames.magicDarkCircleSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkCircleSmoke"));
		//emitters[(int)particleEmitterNames.magicDarkVerticalSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkVerticalSmoke"));
		//emitters[(int)particleEmitterNames.magicDarkFlame].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkFlame"));
		//emitters[(int)particleEmitterNames.magicDarkFlameVertical].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkFlameVertical"));
		//emitters[(int)particleEmitterNames.magicDarkRedWaves].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkRedWaves"));
		//emitters[(int)particleEmitterNames.magicDarkSphereBlack].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkSphereBlack"));
		//emitters[(int)particleEmitterNames.magicDarkSphereSmoke].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkSphereSmoke"));
		//emitters[(int)particleEmitterNames.magicDarkSphereBright].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkSphereBright"));
		//emitters[(int)particleEmitterNames.magicDarkFlareHoriz].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkFlareHoriz"));
		//emitters[(int)particleEmitterNames.magicDarkFlareVert].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkFlareVert"));
		//emitters[(int)particleEmitterNames.magicDarkGlow].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkGlow"));
		//emitters[(int)particleEmitterNames.magicDarkBlackSpot].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkBlackSpot"));
		//emitters[(int)particleEmitterNames.magicDarkBlackCloudGrow].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkBlackCloudGrow"));
		//emitters[(int)particleEmitterNames.magicDarkBlackCloudBurst].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkBlackCloudBurst"));
		//emitters[(int)particleEmitterNames.magicDarkRedWavesIn].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkRedWavesIn"));
		//emitters[(int)particleEmitterNames.magicDarkGlowSlow].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkGlowSlow"));
		//emitters[(int)particleEmitterNames.magicDarkRedSpotsIn].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkRedSpotsIn"));
		//emitters[(int)particleEmitterNames.magicDarkGlowWhite].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkGlowWhite"));
		//emitters[(int)particleEmitterNames.magicDarkFlies].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkFlies"));
		//emitters[(int)particleEmitterNames.magicDeathFlowers].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDeathFlowers"));
		//emitters[(int)particleEmitterNames.magicDarkSplashGreen].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkSplashGreen"));
		//emitters[(int)particleEmitterNames.magicDarkAsh].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkAsh"));
		//emitters[(int)particleEmitterNames.magicDarkGreenGlow].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkGreenGlow"));
		//emitters[(int)particleEmitterNames.magicDarkAshFront].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkAshFront"));
		//emitters[(int)particleEmitterNames.magicDarkUndergroundLight].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkUndergroundLight"));
		//emitters[(int)particleEmitterNames.magicDarkUndergroundGlow].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkUndergroundGlow"));
		//emitters[(int)particleEmitterNames.magicDarkUndergroundEscape].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkUndergroundEscape"));
		//emitters[(int)particleEmitterNames.magicDarkCloudFocusing].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkCloudFocusing"));
		//emitters[(int)particleEmitterNames.magicDarkGlowFocusing].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkGlowFocusing"));
		//emitters[(int)particleEmitterNames.magicDarkEnergyOut].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkEnergyOut"));
		//emitters[(int)particleEmitterNames.magicDarkPikes].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkPikes"));
		//emitters[(int)particleEmitterNames.magicDarkEnergyWaveOut].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkEnergyWaveOut"));
		//emitters[(int)particleEmitterNames.magicDarkGlowBigger].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicDarkGlowBigger"));
		emitters[(int)particleEmitterNames.magicLight].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLight"));
		emitters[(int)particleEmitterNames.magicLightGlow].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightGlow"));
		emitters[(int)particleEmitterNames.magicLightBlinksBlue].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightBlinksBlue"));
		emitters[(int)particleEmitterNames.magicLightBlinksRed].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightBlinksRed"));
		emitters[(int)particleEmitterNames.magicLightGlowBillboard].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightGlowBillboard"));
		emitters[(int)particleEmitterNames.magicLightTall].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightTall"));
		emitters[(int)particleEmitterNames.magicLightTallThin].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightTallThin"));
		emitters[(int)particleEmitterNames.magicLightGlowColumn].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightGlowColumn"));
		emitters[(int)particleEmitterNames.magicLightTallLines].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightTallLines"));
		//emitters[(int)particleEmitterNames.mudBubblesGreen].initEmitter(Resources.Load<GameObject>("Emitters/Magic/mudBubblesGreen"));
		//emitters[(int)particleEmitterNames.mudBubblesOrange].initEmitter(Resources.Load<GameObject>("Emitters/Magic/mudBubblesOrange"));
		//emitters[(int)particleEmitterNames.mudBubblesPurple].initEmitter(Resources.Load<GameObject>("Emitters/Magic/mudBubblesPurple"));
		emitters[(int)particleEmitterNames.magicLightSnakes].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightSnakes"));
		emitters[(int)particleEmitterNames.magicLightGlowBubbles].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightGlowBubbles"));
		emitters[(int)particleEmitterNames.magicLightFlies].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightFlies"));
		emitters[(int)particleEmitterNames.magicLightLeaves].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightLeaves"));
		emitters[(int)particleEmitterNames.magicNatureLeaves].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicNatureLeaves"));
		emitters[(int)particleEmitterNames.magicNatureGrass].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicNatureGrass"));
		emitters[(int)particleEmitterNames.magicLightGreen].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightGreen"));
		emitters[(int)particleEmitterNames.magicLightBlinksGreeen].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightBlinksGreeen"));
		emitters[(int)particleEmitterNames.magicLightFlower].initEmitter(Resources.Load<GameObject>("Emitters/Magic/magicLightFlower"));
		//emitters[(int)particleEmitterNames.chainLightning].initEmitter(Resources.Load<GameObject>("Emitters/Magic/chainLightning"));
		//emitters[(int)particleEmitterNames.lightningBolt].initEmitter(Resources.Load<GameObject>("Emitters/Electricity/lightningBolt"));
		//emitters[(int)particleEmitterNames.waterDropsDispl].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterDropsDispl"));
		//emitters[(int)particleEmitterNames.waterDropsColor].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterDropsColor"));
		//emitters[(int)particleEmitterNames.waterDropsSplashes].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterDropsSplashes"));
		//emitters[(int)particleEmitterNames.waterDropsMist].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterDropsMist"));
		//emitters[(int)particleEmitterNames.waterShowerDispl].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterShowerDispl"));
		//emitters[(int)particleEmitterNames.waterShowerDrops].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterShowerDrops"));
		//emitters[(int)particleEmitterNames.waterRainCloud].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterRainCloud"));
		//emitters[(int)particleEmitterNames.boilingDrops].initEmitter(Resources.Load<GameObject>("Emitters/Water/boilingDrops"));
		//emitters[(int)particleEmitterNames.boilingSteam].initEmitter(Resources.Load<GameObject>("Emitters/Water/boilingSteam"));
		//emitters[(int)particleEmitterNames.boilingDispl].initEmitter(Resources.Load<GameObject>("Emitters/Water/boilingDispl"));
		//emitters[(int)particleEmitterNames.waterWaves].initEmitter(Resources.Load<GameObject>("Emitters/Water/waterWaves"));
		//emitters[(int)particleEmitterNames.plasmShining].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmShining"));
		//emitters[(int)particleEmitterNames.plasmGlowShining].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmGlowShining"));
		//emitters[(int)particleEmitterNames.plasmGlowShiningFast].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmGlowShiningFast"));
		//emitters[(int)particleEmitterNames.plasmWave].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmWave"));
		//emitters[(int)particleEmitterNames.plasmWaveOuter].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmWaveOuter"));
		//emitters[(int)particleEmitterNames.plasmWaves].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmWaves"));
		//emitters[(int)particleEmitterNames.plasmShiningOutside].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmShiningOutside"));
		//emitters[(int)particleEmitterNames.plasmShiningOutSlow].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmShiningOutSlow"));
		//emitters[(int)particleEmitterNames.plasmColumn].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmColumn"));
		//emitters[(int)particleEmitterNames.plasmColumnImpact].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmColumnImpact"));
		//emitters[(int)particleEmitterNames.plasmColumnGlow].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmColumnGlow"));
		//emitters[(int)particleEmitterNames.plasmColumnGlowBB].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmColumnGlowBB"));
		//emitters[(int)particleEmitterNames.plasmColumnLight].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmColumnLight"));
		//emitters[(int)particleEmitterNames.plasmAmplifier].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmAmplifier"));
		//emitters[(int)particleEmitterNames.plasmCircleBlue].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmCircleBlue"));
		//emitters[(int)particleEmitterNames.plasmColumnJet].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmColumnJet"));
		//emitters[(int)particleEmitterNames.plasmGlowAmplifier].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmGlowAmplifier"));
		//emitters[(int)particleEmitterNames.plasmWaveSplash].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmWaveSplash"));
		//emitters[(int)particleEmitterNames.plasmWavesSplash].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmWavesSplash"));
		//emitters[(int)particleEmitterNames.plasmCloud].initEmitter(Resources.Load<GameObject>("Emitters/Plasm/plasmCloud"));
		//emitters[(int)particleEmitterNames.explRocksFleeingMed].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explRocksFleeingMed"));
		//emitters[(int)particleEmitterNames.explFireTails].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireTails"));
		//emitters[(int)particleEmitterNames.explFireTentacles].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireTentacles"));
		//emitters[(int)particleEmitterNames.explFlash].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlash"));
		//emitters[(int)particleEmitterNames.explFlashHoriz].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlashHoriz"));
		//emitters[(int)particleEmitterNames.explDustTentacles].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDustTentacles"));
		//emitters[(int)particleEmitterNames.explDust].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDust"));
		//emitters[(int)particleEmitterNames.explDustSlow].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDustSlow"));
		//emitters[(int)particleEmitterNames.explWaveHoriz].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explWaveHoriz"));
		//emitters[(int)particleEmitterNames.explRocksFleeingSmall].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explRocksFleeingSmall"));
		//emitters[(int)particleEmitterNames.explDustSettles].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDustSettles"));
		//emitters[(int)particleEmitterNames.explFlame].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlame"));
		//emitters[(int)particleEmitterNames.explWaveHorizFire].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explWaveHorizFire"));
		//emitters[(int)particleEmitterNames.explFlashHorizFire].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlashHorizFire"));
		//emitters[(int)particleEmitterNames.explFireTailsFast].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireTailsFast"));
		//emitters[(int)particleEmitterNames.explFlashFire].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlashFire"));
		//emitters[(int)particleEmitterNames.explFlameSlow].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlameSlow"));
		//emitters[(int)particleEmitterNames.explSparks].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explSparks"));
		//emitters[(int)particleEmitterNames.explDustFountSettles].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDustFountSettles"));
		//emitters[(int)particleEmitterNames.explDustColumnSettles].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDustColumnSettles"));
		//emitters[(int)particleEmitterNames.explFlashLight].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlashLight"));
		//emitters[(int)particleEmitterNames.explFlashDirt].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlashDirt"));
		//emitters[(int)particleEmitterNames.explDustSphere].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDustSphere"));
		//emitters[(int)particleEmitterNames.explRocksSmall].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explRocksSmall"));
		//emitters[(int)particleEmitterNames.explDustCircle].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explDustCircle"));
		//emitters[(int)particleEmitterNames.explWaveHorizDust].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explWaveHorizDust"));
		//emitters[(int)particleEmitterNames.explFlameSlowAir].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlameSlowAir"));
		//emitters[(int)particleEmitterNames.explFireTailsAir].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireTailsAir"));
		//emitters[(int)particleEmitterNames.explFireBall].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireBall"));
		//emitters[(int)particleEmitterNames.explFireWave].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireWave"));
		//emitters[(int)particleEmitterNames.explFireSparksSmall].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireSparksSmall"));
		//emitters[(int)particleEmitterNames.explFireTailsFastSphere].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFireTailsFastSphere"));
		//emitters[(int)particleEmitterNames.explFlashFire2].initEmitter(Resources.Load<GameObject>("Emitters/Explosions/explFlashFire2"));
		//emitters[(int)particleEmitterNames.rockRainCloud].initEmitter(Resources.Load<GameObject>("Emitters/Rocks/rockRainCloud"));
		//emitters[(int)particleEmitterNames.rockRainBigRocks].initEmitter(Resources.Load<GameObject>("Emitters/Rocks/rockRainBigRocks"));
		//emitters[(int)particleEmitterNames.bigRockFall].initEmitter(Resources.Load<GameObject>("Emitters/Rocks/bigRockFall"));
		//emitters[(int)particleEmitterNames.lavaFall].initEmitter(Resources.Load<GameObject>("Emitters/Lava/lavaFall"));
		//emitters[(int)particleEmitterNames.lavaFountain].initEmitter(Resources.Load<GameObject>("Emitters/Lava/lavaFountain"));
		//emitters[(int)particleEmitterNames.lavaFountainDrop].initEmitter(Resources.Load<GameObject>("Emitters/Lava/lavaFountainDrop"));
		//emitters[(int)particleEmitterNames.lavaFountainDropR].initEmitter(Resources.Load<GameObject>("Emitters/Lava/lavaFountainDropR"));
		//emitters[(int)particleEmitterNames.lavaRockFall].initEmitter(Resources.Load<GameObject>("Emitters/Lava/lavaRockFall"));
		//emitters[(int)particleEmitterNames.iceRockFall].initEmitter(Resources.Load<GameObject>("Emitters/Ice/iceRockFall"));
		//emitters[(int)particleEmitterNames.iceLights].initEmitter(Resources.Load<GameObject>("Emitters/Ice/iceLights"));
		//emitters[(int)particleEmitterNames.icePikes].initEmitter(Resources.Load<GameObject>("Emitters/Ice/icePikes"));
		//emitters[(int)particleEmitterNames.iceGround].initEmitter(Resources.Load<GameObject>("Emitters/Ice/iceGround"));
		//emitters[(int)particleEmitterNames.iceImpactWave].initEmitter(Resources.Load<GameObject>("Emitters/Ice/iceImpactWave"));
		//emitters[(int)particleEmitterNames.iceRain].initEmitter(Resources.Load<GameObject>("Emitters/Ice/iceRain"));
		//emitters[(int)particleEmitterNames.iceCloud].initEmitter(Resources.Load<GameObject>("Emitters/Ice/iceCloud"));
		//emitters[(int)particleEmitterNames.iceCloudCold].initEmitter(Resources.Load<GameObject>("Emitters/Ice/iceCloudCold"));
		//emitters[(int)particleEmitterNames.snowFlakes].initEmitter(Resources.Load<GameObject>("Emitters/Ice/snowFlakes"));
		//emitters[(int)particleEmitterNames.snowCloud].initEmitter(Resources.Load<GameObject>("Emitters/Ice/snowCloud"));
		//emitters[(int)particleEmitterNames.lightGlow].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightGlow"));
		//emitters[(int)particleEmitterNames.lightWave].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightWave"));
		//emitters[(int)particleEmitterNames.lightBeams].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightBeams"));
		//emitters[(int)particleEmitterNames.lightsWhite].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightsWhite"));
		//emitters[(int)particleEmitterNames.lightsRedBlue].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightsRedBlue"));
		//emitters[(int)particleEmitterNames.lightsTealSalt].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightsTealSalt"));
		//emitters[(int)particleEmitterNames.lightsYellowOrange].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightsYellowOrange"));
		//emitters[(int)particleEmitterNames.lightBeamsFocused].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightBeamsFocused"));
		//emitters[(int)particleEmitterNames.lightBeamsFromSky].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightBeamsFromSky"));
		//emitters[(int)particleEmitterNames.lightGlow2].initEmitter(Resources.Load<GameObject>("Emitters/Light/lightGlow2"));
		//emitters[(int)particleEmitterNames.stormLightnings].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/stormLightnings"));
		//emitters[(int)particleEmitterNames.stormCloudBack].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/stormCloudBack"));
		//emitters[(int)particleEmitterNames.stormCloudFront].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/stormCloudFront"));
		//emitters[(int)particleEmitterNames.starDustInitialCloud].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustInitialCloud"));
		//emitters[(int)particleEmitterNames.starDustFocusingBG].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustFocusingBG"));
		//emitters[(int)particleEmitterNames.starDustFocusing].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustFocusing"));
		//emitters[(int)particleEmitterNames.starInitialGlow].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starInitialGlow"));
		//emitters[(int)particleEmitterNames.starGlowExpl].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starGlowExpl"));
		//emitters[(int)particleEmitterNames.starWaveExpl].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starWaveExpl"));
		//emitters[(int)particleEmitterNames.starExplFumes].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starExplFumes"));
		//emitters[(int)particleEmitterNames.starDustInitialCloudMove].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustInitialCloudMove"));
		//emitters[(int)particleEmitterNames.starDustOut].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustOut"));
		//emitters[(int)particleEmitterNames.starMainGlow].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starMainGlow"));
		//emitters[(int)particleEmitterNames.star].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/star"));
		//emitters[(int)particleEmitterNames.starFinalGlow].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starFinalGlow"));
		//emitters[(int)particleEmitterNames.starDustCircle1].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustCircle1"));
		//emitters[(int)particleEmitterNames.starDustCircle2].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustCircle2"));
		//emitters[(int)particleEmitterNames.starDustCircle3].initEmitter(Resources.Load<GameObject>("Emitters/Atmospheric/starDustCircle3"));
	}
	static void initVisEffects(){
		int i = 0, j;
		while (i < vEffects.Length) {
			vEffects[i].init();
			i++;
		}
		//// now we're defining each effect by adding components to it
		//i = (int)visualEffectNames.electricSplashSparklesSmoke;
		////vEffects[i].scaleFactor = 0.5f;									// this is example of how a particular effect should be scaled on per effect basis
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlue, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGray, 5);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing, 18);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingFast, 30);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesBlinking, 14);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesBlinking, 12, 0.11f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesBlinking, 10, 0.22f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesBlinking, 9, 0.33f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesBlinking, 5, 0.4f);
		////
		//i = (int)visualEffectNames.electricZapsToGround;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist, 12, 0.1f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist, 12, 0.3f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist, 12, 0.5f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist, 12, 0.7f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 2, 0.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 1, 0.15f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 2, 0.25f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 1, 0.35f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 2, 0.45f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 1, 0.55f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 2, 0.65f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 1, 0.75f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 2, 0.85f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 0.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 1, 0.95f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 1.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 2, 1.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 3, 1.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 1, 1.15f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapsToGround, 2, 1.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.0f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.05f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.1f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.15f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.2f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.25f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.3f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.35f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.4f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.45f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.5f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.55f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.6f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.65f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.7f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.75f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.8f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.85f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 0.9f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 0.95f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 1.0f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 1.05f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 2, 1.1f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal, 1, 1.15f, new Vector3(0, 0.06f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 8, 0.0f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 5, 0.1f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 8, 0.2f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 5, 0.3f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 8, 0.4f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 5, 0.5f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 8, 0.6f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 5, 0.7f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 8, 0.8f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 5, 0.9f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 8, 1.0f, new Vector3(0, 0.01f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingCircle, 5, 1.1f, new Vector3(0, 0.01f, 0));
		////
		//i = (int)visualEffectNames.electricExplosion;
		//vEffects[i].addComponent((int)particleEmitterNames.electroSparklesFleeing, 36);
		//vEffects[i].addComponent((int)particleEmitterNames.electroSplashBlue, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueCircle, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueMist, 8);
		//vEffects[i].addComponent((int)particleEmitterNames.beamsBlue, 16);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing, 40, 0.1f);
		////
		//i = (int)visualEffectNames.electricLightningsExplosion;
		//vEffects[i].addComponent((int)particleEmitterNames.lightningsFromCenter, 1, 0.45f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightningsFromCenter, 1, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.beamsBlue2, 9, 0.45f);
		//vEffects[i].addComponent((int)particleEmitterNames.beamsBlue2, 7, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.beamsBlue2, 5, 0.55f);
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist2, 2, 0.3f);
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist2, 4, 0.35f);
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist2, 6, 0.4f);
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist2, 8, 0.45f);
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist2, 12, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 1, 0.0f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 1, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 1, 0.15f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 1, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 2, 0.25f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 2, 0.3f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 3, 0.35f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 5, 0.4f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 10, 0.45f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 10, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 8, 0.55f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 6, 0.6f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 2, 0.65f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings, 1, 0.7f);
		//vEffects[i].addComponent((int)particleEmitterNames.electroSplashBlueBigger, 1, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWaves, 2, 0.45f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWaves, 1, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWaves, 1, 0.55f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWaves, 1, 0.6f);
		////
		//i = (int)visualEffectNames.electricExplosiveNova;
		//vEffects[i].addComponent((int)particleEmitterNames.nova, 80);
		//vEffects[i].addComponent((int)particleEmitterNames.beamsCircle, 50);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWavesH, 2);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWavesH, 1, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWavesH, 1, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWavesH, 1, 0.15f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 4);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 4, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 2, 0.15f);
		////
		//i = (int)visualEffectNames.electricBurningSharp;
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist3, 6);
		//vEffects[i].addComponent((int)particleEmitterNames.electroMist3, 6, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWaves2, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWaves2, 1, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.electricEnergyWaves2, 1, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueMist, 3);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueMist, 2, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueMist, 1, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueMist, 1, 0.15f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueMist, 1, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing2, 16);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing2, 12, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing2, 11, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing2, 10, 0.15f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing2, 8, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 4);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 2, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 2, 0.15f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 2, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 2, 0.25f);
		////
		//i = (int)visualEffectNames.electricChargeExplosion;
		//vEffects[i].addComponent((int)particleEmitterNames.electroSplashBlueBeamy, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.electroSplashBlueMedium, 1);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueMist, 20);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings2, 18, 0.04f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings2, 12, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings2, 8, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.lightnings2, 5, 0.3f);
		////
		//i = (int)visualEffectNames.electricWelding;
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow3, 1, 0.0f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow3, 1, 0.12f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow3, 1, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow3, 1, 0.32f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow3, 1, 0.41f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow3, 1, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow3, 1, 0.61f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 2);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 1, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 2, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 1, 0.3f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 2, 0.4f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 1, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 2, 0.6f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 1, 0.7f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 5);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.3f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.4f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 3, 0.6f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 2, 0.7f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 24, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 18, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 12, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 10, 0.25f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 12, 0.35f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 10, 0.4f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 10, 0.5f);
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing3, 10, 0.5f);
		////
		//i = (int)visualEffectNames.electricLightningStrike;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueHorizontal2, 1, 0.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow4, 1, 0.0f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueGlow5, 1, 0.0f, new Vector3(0, 0.6f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.zapToGround, 1, 0, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeing, 50, 0);
		//vEffects[i].addComponent((int)particleEmitterNames.lightningsFromCenterSmall, 20, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.nova, 20, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.smokeGraySmallToBig, 2, 0);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlue, 1, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.splashBlueCircle, 1, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.zapsFromCenter, 1, 0.05f);
		////
		//i = (int)visualEffectNames.electricChainLightning;
		//vEffects[i].addComponent((int)particleEmitterNames.chainLightning, 3, 0, new Vector3(0, 0.1f, 0));
		////
		//i = (int)visualEffectNames.gooSplashGround;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.beamsGoo, 10, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeing, 30, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingBigger, 100, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingLonger, 50, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingSlower, 50, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasExpansion, 4, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasCloud, 4, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasCloud, 5, 0, new Vector3(0, 0.35f, 0));
		////
		//i = (int)visualEffectNames.gooExplosion;
		//vEffects[i].addComponent((int)particleEmitterNames.beamsGooBrighter, 20, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingBrighter, 24, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingBigger2, 120, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingLonger2, 50, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingSlower2, 50, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasExpansionBrighter, 4, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasCloud2, 5, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasCloud2, 7, 0, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.gooFountain;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 12, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 10, 0.05f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 12, 0.1f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 10, 0.15f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 11, 0.2f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 9, 0.25f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 11, 0.3f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 9, 0.35f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 10, 0.4f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 9, 0.45f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 10, 0.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 8, 0.55f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 9, 0.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 4, 0.65f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 3, 0.7f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 3, 0.75f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFountain, 3, 0.8f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooBeamsFountain, 12, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooBeamsFountain, 12, 0.12f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooBeamsFountain, 12, 0.24f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooBeamsFountain, 12, 0.36f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooBeamsFountain, 12, 0.48f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooBeamsFountain, 12, 0.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooBeamsFountain, 12, 0.72f, new Vector3(0, 0.1f, 0));
		////
		//i = (int)visualEffectNames.gooFog;
		//vEffects[i].addComponent((int)particleEmitterNames.gooFog, 5, 0.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooFog2, 5, 0.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasExpansion2, 1, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingLonger3, 80, 0, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.gooAcidSplash;
		//vEffects[i].addComponent((int)particleEmitterNames.gooSplash, 8);
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingBigger3, 20);
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingYellow, 50);
		//vEffects[i].addComponent((int)particleEmitterNames.gooDropsFleeingLonger4, 25);
		//vEffects[i].addComponent((int)particleEmitterNames.gooGasExpansion3, 3);
		////
		//i = (int)visualEffectNames.gooAcidStorm;
		//vEffects[i].addComponent((int)particleEmitterNames.acidStormCloud, 36, 0, new Vector3(0, 0.5f, 0));
		//j = 0;
		//while (j < 40) {
		//	vEffects[i].addComponent((int)particleEmitterNames.gooAcidRain, 16, 0.2f + j * 0.05f, new Vector3(0, 0.5f, 0));
		//	j++;
		//}
		////
		//i = (int)visualEffectNames.mudBoiling;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 7, 0, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 5, 0.1f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 8, 0.2f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 6, 0.3f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 7, 0.4f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 6, 0.5f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 6, 0.6f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 8, 0.7f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountain, 6, 0.8f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplashes, 3, 0, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplashes, 5, 0.1f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplashes, 3, 0.21f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplashes, 5, 0.35f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplashes, 3, 0.48f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplashes, 3, 0.6f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudMist, 23, 0, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudMist, 21, 0.2f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudMist, 23, 0.4f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudMist, 20, 0.6f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudMist, 18, 0.8f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 7, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 5, 0.1f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 7, 0.2f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 5, 0.3f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 8, 0.4f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 5, 0.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 6, 0.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 8, 0.7f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 5, 0.8f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts, 6, 0.9f, new Vector3(0, 0.1f, 0));
		////
		//i = (int)visualEffectNames.mudGroundSplash;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.mudGroundSplash, 2, 0.0f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 30, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 30, 0.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirtsPoint, 3, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSplashSoft, 3, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBurst, 8, 0, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.mudExplosion;
		//vEffects[i].addComponent((int)particleEmitterNames.mudBurst360, 12);
		//vEffects[i].addComponent((int)particleEmitterNames.flareSplash, 2);
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirts360, 24);
		//vEffects[i].addComponent((int)particleEmitterNames.mudGasExpansion, 4);
		//vEffects[i].addComponent((int)particleEmitterNames.mudDropsFleeingLonger, 50);
		//vEffects[i].addComponent((int)particleEmitterNames.mudGasExpansionBig, 4);
		////
		//i = (int)visualEffectNames.mudFountain;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.mudDropsFleeingLonger, 50);
		//vEffects[i].addComponent((int)particleEmitterNames.mudBurst, 4, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBurst, 4, 0.15f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBurst, 4, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBurst, 4, 0.45f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 50, 0, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 50, 0.15f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 50, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 50, 0.45f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirtsPoint, 5, 0.0f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirtsPoint, 3, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirtsPoint, 5, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirtsPoint, 3, 0.3f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudSquirtsPoint, 4, 0.4f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 20);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 18, 0.05f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 19, 0.1f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 17, 0.15f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 20, 0.2f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 18, 0.25f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 19, 0.3f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 17, 0.35f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 19, 0.4f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 16, 0.45f);
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainVertical, 15, 0.5f);
		////
		//i = (int)visualEffectNames.mudWaves;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 8, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 16, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 10, 0.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudFountainSplash, 6, 1.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudGas, 12, 0, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudGas, 12, 0.15f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudGas, 12, 0.3f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudGas, 12, 0.45f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudGas, 12, 0.6f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubbles, 2, 0, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubbles, 1, 0.2f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubbles, 3, 0.4f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubbles, 1, 0.6f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubbles, 2, 0.8f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubbles, 1, 1.0f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudWaveHorizontal, 2, 0, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudWaveHorizontal, 2, 0.15f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudWaveHorizontal, 2, 0.3f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudWaveHorizontal, 2, 0.45f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudWaveHorizontal, 2, 0.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudWaveHorizontal, 2, 0.75f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudWaveHorizontal, 2, 0.9f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 4, 0.2f, new Vector3(0, 0.11f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 3, 0.3f, new Vector3(0, 0.11f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 5, 0.4f, new Vector3(0, 0.11f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 3, 0.5f, new Vector3(0, 0.11f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 4, 0.6f, new Vector3(0, 0.11f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 3, 0.7f, new Vector3(0, 0.11f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 5, 0.8f, new Vector3(0, 0.11f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBeamyWaves, 3, 0.9f, new Vector3(0, 0.11f, 0));
		////
		i = (int)visualEffectNames.bloodExplosion;
		vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingLonger, 36, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeing, 50, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodSplash, 3, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodFog, 5, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodWave, 3, 0.0f);
		//
		i = (int)visualEffectNames.bloodAndGutsExplosion;
		vEffects[i].addComponent((int)particleEmitterNames.bloodWaveSmaller, 1, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodFog, 3, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodBurst360, 8, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodGuts, 12, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeing, 30, 0.0f);
		vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingLonger, 10, 0.0f);
        //
        //i = (int)visualEffectNames.bloodFountain;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 9);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 7, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 8, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 7, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 9, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 6, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 8, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 6, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 7, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainVertical, 5, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainGas, 13, 0, new Vector3(0, -0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainGas, 11, 0.15f, new Vector3(0, -0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainGas, 12, 0.3f, new Vector3(0, -0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainGas, 11, 0.45f, new Vector3(0, -0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainGas, 12, 0.6f, new Vector3(0, -0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainGas, 10, 0.75f, new Vector3(0, -0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFountainGas, 10, 0.9f, new Vector3(0, -0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 12, 0);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 11, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 12, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 10, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 12, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 11, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 11, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 9, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 10, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBeams, 8, 0.9f);
        ////
        //i = (int)visualEffectNames.bloodRain;
        //vEffects[i].addComponent((int)particleEmitterNames.bloodStormClouds, 16, 0.0f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.0f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.1f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.2f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.3f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.4f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.5f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.6f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.7f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.8f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodRain, 16, 0.9f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 0.6f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 0.7f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 0.8f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 0.9f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 1.0f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 1.1f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 1.2f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 1.3f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 1.4f, new Vector3(0, -0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirts, 10, 1.5f, new Vector3(0, -0.5f, 0));
        ////
        //i = (int)visualEffectNames.bloodBoiling;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBurstCircle, 12, 0.0f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBurstCircle, 9, 0.2f, new Vector3(0, 0.03f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBurstCircle, 10, 0.4f, new Vector3(0, 0.06f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBurstCircle, 9, 0.6f, new Vector3(0, 0.01f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBurstCircle, 11, 0.8f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBurstCircle, 9, 1.0f, new Vector3(0, 0.03f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingCircle, 12, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingCircle, 9, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingCircle, 10, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingCircle, 9, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingCircle, 8, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodDropsFleeingCircle, 9, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFogClouds, 24, 0.0f, new Vector3(0, 0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodFogClouds, 18, 0.6f, new Vector3(0, 0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 8, 0.0f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 5, 0.1f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 7, 0.2f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 5, 0.4f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 7, 0.5f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 8, 0.6f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 6, 0.8f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 5, 1.0f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSquirtsBigger, 6, 1.1f, new Vector3(0, 0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 3, 0.0f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 2, 0.1f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 2, 0.2f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 2, 0.4f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 2, 0.5f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 3, 0.6f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 2, 0.8f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bloodBubbles, 2, 0.95f, new Vector3(0, -0.1f, 0));
        ////
        //i = (int)visualEffectNames.bloodImpact;
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSprayThick, 20);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodDrops, 20);
        //vEffects[i].addComponent((int)particleEmitterNames.bloodSprayFog, 6);
        ////
        //i = (int)visualEffectNames.dustExplosion;
        //vEffects[i].addComponent((int)particleEmitterNames.dustWave, 2);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloud, 5);
        ////
        //i = (int)visualEffectNames.dustVolumousExplosions;
        //vEffects[i].addComponent((int)particleEmitterNames.dustWaveSmallerInVolume, 6);
        //vEffects[i].addComponent((int)particleEmitterNames.dustWaveSmallerInVolume, 5, 0.15f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustWaveSmallerInVolume, 4, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustWaveSmallerInVolume, 4, 0.45f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustWaveSmallerInVolume, 3, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustWaveSmallerInVolume, 3, 0.75f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 5);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 6, 0.15f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 7, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 6, 0.45f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 8, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 9, 0.75f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 5, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 4, 0.85f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudsVolumous, 3, 0.9f);
        ////
        //i = (int)visualEffectNames.dustFountain;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.dustPreEruption, 15, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustPreEruption, 12, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustPreEruption, 10, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustPreEruption, 8, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustPreEruption, 5, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustGasFountain, 8, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustGasFountain, 8, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustGasFountain, 8, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustGasFountain, 8, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustGasFountain, 8, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustGasFountain, 8, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustEruption, 10, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustEruption, 30, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustEruption, 25, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustEruption, 20, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudSlower, 3, 0.7f, new Vector3(0, 0.85f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudSlower, 5, 0.9f, new Vector3(0, 0.7f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloud, 2, 1.1f, new Vector3(0, 0.7f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustEruptionFinalization, 25, 1.6f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustEruptionFinalization, 20, 1.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustEruptionFinalization, 16, 1.8f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.dustTornado;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.dustJet, 10, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustJet, 10, 0.15f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustJet, 10, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustJet, 10, 0.45f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustJet, 10, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustJet, 10, 0.75f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustJet, 10, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.05f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.15f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.25f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.35f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.45f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.55f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.65f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.75f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.85f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustVortex, 4, 0.95f);
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudSlowerRotating, 1, 0.8f, new Vector3(0, 0.7f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudSlowerRotating, 1, 0.9f, new Vector3(0, 0.8f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudSlowerRotating, 1, 1.0f, new Vector3(0, 0.9f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudSlowerRotating, 2, 1.1f, new Vector3(0, 0.95f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.dustCloudSlowerRotating, 1, 1.2f, new Vector3(0, 1.0f, 0));
        ////
        //i = (int)visualEffectNames.steamSlow;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 1.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 1.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 1.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 1.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 1.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 1.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDispl, 1, 1.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 2, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 2, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 2, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 1.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 2, 1.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 3, 1.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlow, 2, 1.3f);
        ////
        //i = (int)visualEffectNames.steamFast;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 3, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 3, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 3, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 1.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 1.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 3, 1.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplVert, 2, 1.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 12, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 10, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 14, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 8, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 11, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 10, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 12, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 9, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 12, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 10, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 14, 1.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 8, 1.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 12, 1.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 10, 1.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumn, 11, 1.4f);
        ////
        //i = (int)visualEffectNames.steamCloud;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplSlow, 1, 0.0f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplSlow, 1, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnDisplSlow, 1, 0.1f, new Vector3(0, -0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlower, 2, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.steamColumnSlower, 6, 0.2f, new Vector3(0, 0.2f, 0));
        ////
        //i = (int)visualEffectNames.smokeExplosionWithFlash;
        //vEffects[i].addComponent((int)particleEmitterNames.flareSplashRedder, 3, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.flareWave, 1, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeExpanding, 12, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeExpandingCenter, 8, 0.0f);
        ////
        //i = (int)visualEffectNames.smokeScreen;
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCircleWaves, 2, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCircleWaves, 2, 0.04f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCircleWaves, 3, 0.08f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCircleWaves, 4, 0.12f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCircleWaves, 6, 0.16f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCircleWaves, 8, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCircleWaves, 8, 0.25f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeSparkles, 4, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeSparkles, 3, 0.04f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeSparkles, 3, 0.08f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeSparkles, 4, 0.12f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeSparkles, 6, 0.16f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeSparkles, 8, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeSparkles, 8, 0.25f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCloudBig, 22, 0.16f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCloudBigRound, 1, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCloudBigRound, 3, 0.04f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeCloudBigRound, 3, 0.10f);
        ////
        //i = (int)visualEffectNames.smokeColumn;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 0.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 0.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 4, 0.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 0.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 5, 0.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 0.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 4, 0.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 0.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 5, 0.8f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 0.9f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 4, 1.0f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 1.1f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 5, 1.2f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 1.3f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 4, 1.4f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 1.5f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 5, 1.6f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 3, 1.7f);
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBigRound, 4, 1.8f);
        ////
        //i = (int)visualEffectNames.smokeFromSparkles;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 4, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 0.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 0.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 0.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 0.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 0.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 0.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 0.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 0.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 0.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 1.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 1.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 1.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 1.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 1.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 2, 1.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 1.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.smokeColumnBig, 3, 1.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 12, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 11, 0.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 8, 0.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 10, 0.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 9, 0.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 8, 0.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 9, 0.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 8, 0.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 6, 0.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 8, 0.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 12, 1.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 12, 1.15f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 11, 1.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 10, 1.45f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFleeingOrange, 8, 1.6f, new Vector3(0, 0.1f, 0));
        ////
        //i = (int)visualEffectNames.fireCandleSprite;
        //vEffects[i].ground = true;
        //j = 0;
        //while (j < 72) {
        //	vEffects[i].addComponent((int)particleEmitterNames.fireGlow, 1, 0.1f + j * 0.05f, new Vector3(0, 0.3f, 0));
        //	j++;
        //}
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 0.2f, new Vector3(0, 0.01f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 0.6f, new Vector3(0, 0.01f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 1.2f, new Vector3(0, 0.01f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 1.6f, new Vector3(0, 0.01f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 1.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 2.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 2.2f, new Vector3(0, 0.01f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 2.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 2.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 2.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 3.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 3.2f, new Vector3(0, 0.01f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 3.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSprite, 1, 3.6f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.fireCandle;
        //vEffects[i].ground = true;
        //j = 0;
        //while (j < 10) {
        //	vEffects[i].addComponent((int)particleEmitterNames.fireCandleGlow, 1, 0.2f + j * 0.3f, new Vector3(0, 0.35f, 0));
        //	j++;
        //}
        //j = 0;
        //while (j < 100) {
        //	vEffects[i].addComponent((int)particleEmitterNames.candleFire, 1, j * 0.03f, new Vector3(0, 0.1f, 0));
        //	j++;
        //}
        ////
        //i = (int)visualEffectNames.fireTorch;
        //vEffects[i].ground = true;
        //j = 0;
        //while (j < 16) {
        //	vEffects[i].addComponent((int)particleEmitterNames.fireGlow2, 1, 0.15f + j * 0.15f, new Vector3(0, 0.37f, 0));
        //	j++;
        //}
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 5, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 4, 0.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 5, 0.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 4, 0.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 5, 1.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 4, 1.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 5, 1.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumn, 4, 2.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 0.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 0.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 0.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 0.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 0.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 0.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 0.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 0.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 0.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 1.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 1.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 1.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 1.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 1.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 1.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 1.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 1.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 1.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 1.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 2.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 2.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 2.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 1, 2.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 2.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.torchFire, 2, 2.5f, new Vector3(0, 0.1f, 0));
        ////
        //i = (int)visualEffectNames.fireReactiveExhaust;
        //vEffects[i].ground = true;
        //j = 0;
        //while (j < 67) {
        //	vEffects[i].addComponent((int)particleEmitterNames.candleFireExhaust, 3, j * 0.03f, new Vector3(0, 0.35f, 0));
        //	j++;
        //}
        //j = 0;
        //while (j < 20) {
        //	vEffects[i].addComponent((int)particleEmitterNames.fireGlow3, 1, j * 0.1f, new Vector3(0, 0.15f, 0));
        //	j++;
        //}
        //j = 0;
        //while (j < 21) {
        //	vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteExhaust, 2, j * 0.1f, new Vector3(0, 0.1f, 0));
        //	j++;
        //}
        ////
        //i = (int)visualEffectNames.gasWelding;
        //vEffects[i].ground = true;
        //j = 0;
        //while (j < 81) {
        //	vEffects[i].addComponent((int)particleEmitterNames.fireGasWeldBlue, 2, j * 0.03f, new Vector3(0, 0.1f, 0));
        //	j++;
        //}
        //j = 0;
        //while (j < 27) {
        //	vEffects[i].addComponent((int)particleEmitterNames.fireGlow4, 1, j * 0.09f, new Vector3(0, 0.4f, 0));
        //	j++;
        //}
        ////
        //i = (int)visualEffectNames.campFire;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.fireGlowHoriz, 2, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireGlow5, 1, 0.0f, new Vector3(0, 0.4f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.coalUnderCampFire, 40, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 10, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 0.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 0.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 8, 0.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 10, 0.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 0.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 0.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 8, 0.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 10, 0.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 0.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 1.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 8, 1.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 10, 1.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 1.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 1.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 8, 1.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 10, 1.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 1.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 1.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 8, 1.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 10, 2.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 2.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 2.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 2.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 8, 2.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 10, 2.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 2.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 2.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 9, 2.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFire, 8, 2.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 0.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 7, 0.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 0.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 0.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 0.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 7, 0.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 0.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 0.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 0.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 1.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 1.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 7, 1.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 1.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 1.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 1.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 7, 1.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 1.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 1.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 6, 1.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 2.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 8, 2.1f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 2.2f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 2.3f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 2.4f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 2.5f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 8, 2.6f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 4, 2.7f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 2.8f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSparkles, 5, 2.9f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 0.0f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 0.1f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 0.2f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 0.3f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 0.4f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 0.5f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 0.6f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 0.7f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 0.8f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 0.9f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 1.0f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 1.1f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 1.2f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 1.3f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 1.4f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 1.5f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 1.6f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 1.7f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 1.8f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 1.9f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 2.0f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 2.1f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 2.2f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 2.3f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 3, 2.4f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireSmoke, 4, 2.5f, new Vector3(0, 0.2f, 0));
        ////
        //i = (int)visualEffectNames.burningSoil;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.fireGlowHoriz2, 1, 0.0f, new Vector3(0, 0.12f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.coalArea, 80, 0.0f, new Vector3(0, 0.05f, 0));
        //j = 0;
        //while (j < 27) {
        //	vEffects[i].addComponent((int)particleEmitterNames.campFireArea, 16, j * 0.09f, new Vector3(0, -0.1f, 0));
        //	j++;
        //}
        //j = 0;
        //while (j < 27) {
        //	vEffects[i].addComponent((int)particleEmitterNames.torchFireArea, 6, j * 0.09f, new Vector3(0, 0.0f, 0));
        //	j++;
        //}
        //j = 0;
        //while (j < 27) {
        //	vEffects[i].addComponent((int)particleEmitterNames.campFireSparklesArea, 16, j * 0.09f, new Vector3(0, -0.2f, 0));
        //	j++;
        //}
        //j = 0;
        //while (j < 27) {
        //	vEffects[i].addComponent((int)particleEmitterNames.fireSmokeColumnArea, 3, j * 0.09f, new Vector3(0, 0.1f, 0));
        //	j++;
        //}
        ////
        //i = (int)visualEffectNames.gasBurner;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.fireGlowHoriz3, 2, 0.15f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.0f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.125f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.25f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.375f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.5f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.625f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.750f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 0.875f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.0f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.125f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.25f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.375f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.5f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.625f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.750f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 1.875f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.0f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.125f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.25f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.375f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.5f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.625f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.750f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.candleFireSpriteBlue, 1, 2.875f, new Vector3(0, 0.05f, 0));
        ////
        //i = (int)visualEffectNames.fireColumn;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.coalStick, 120, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 0.0f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.05f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 0.1f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.15f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 0.2f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 0.25f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 0.3f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.35f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 0.4f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.45f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 0.5f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 0.55f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.6f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.65f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 0.7f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.75f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 0.8f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 0.85f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.9f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 0.95f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 1.0f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.05f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 1.1f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 1.15f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 1.2f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.25f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 1.3f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.35f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 1.4f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 1.45f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.5f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.55f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 1.6f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.65f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 1.7f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 1.75f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 1.8f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.85f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 1.9f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 1.95f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 2.0f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 2.05f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 2.1f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 2.15f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 2.2f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 2.25f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 15, 2.3f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 12, 2.35f, new Vector3(0, 0.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.campFireStick, 10, 2.4f, new Vector3(0, 0.2f, 0));
        ////
        //i = (int)visualEffectNames.fireWelding;
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldSmoke, 5, 1.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 5, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 4, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 5, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 4, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 5, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingDrops, 7, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingFlare, 1, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 9, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 8, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 9, 0.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 8, 0.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 9, 0.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 7, 0.55f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 9, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.65f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 8, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.75f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 9, 0.85f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 8, 0.95f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 9, 1.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 6, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 7, 1.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 7, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 10, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 10, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 10, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 10, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 10, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 10, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 10, 1.2f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.nuke;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.nukeCoalArea, 100, 0.3f, new Vector3(0, 0.04f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeGlow, 8, 0.0f, new Vector3(0, 0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeWaveHorizontal, 2, 0.1f, new Vector3(0, 0.12f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeInitialBall, 20, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeBallAdd, 16, 0.25f, new Vector3(0, 0.12f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeBallSecond, 16, 0.4f, new Vector3(0, 0.21f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeBallThird, 36, 0.55f, new Vector3(0, 0.33f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeBall4, 32, 0.6f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 0.75f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 0.85f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 0.95f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 5, 1.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 4, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.nukeSmokeColumn, 3, 1.45f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.vacuumExplosion;
        //vEffects[i].addComponent((int)particleEmitterNames.vacuumGas, 20, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.vacuumGasIgnition, 25, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 16, 1.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 1.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.vacuumImplosionFlash, 16, 1.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.vacuumGasLateBurning, 28, 1.7f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.siegeExplosion;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.siegeExplosionTails, 7, 0.0f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeExplosion, 5, 0.1f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeGlow, 3, 0.0f, new Vector3(0, 0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeGlowVolumous, 3, 0.0f, new Vector3(0, 0.15f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeLateBurning, 20, 0.0f, new Vector3(0, 0.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeSmoke, 12, 0.0f, new Vector3(0, 0.1f, 0));
        ////
        //i = (int)visualEffectNames.siegeExplosionDarker;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.siegeDarkerSmoke, 4, 0.05f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeDarkerBall, 3, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeDarkerGlow, 6, 0.05f, new Vector3(0, 0.12f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeDarkerTails, 8, 0.0f, new Vector3(0, 0.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.siegeSmoke, 4, 0.0f, new Vector3(0, 0.15f, 0));
        ////
        //i = (int)visualEffectNames.fireImpact;
        //vEffects[i].addComponent((int)particleEmitterNames.fireImpactBall, 6, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 5, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 5, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.fireImpactBeamy;
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.beamsWeldingThin, 8, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplBeams, 15, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireImpactBall, 3, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireImpactBeamyBall, 5, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireImpactBeamySmoke, 8, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.fireExplBig;
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplBigSmoke, 6, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplBigWave, 3, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplBigFlame, 50, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingSparkles, 10, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplBeams, 8, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireWeldingGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplBigSleeves, 8, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplBigBall, 6, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.fireExplMed;
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplMedFlameUp, 8, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplMedFlameMid, 24, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplMedSparkles, 36, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplMedBall, 6, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireExplMedDrops, 32, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.fireRain;
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 0.1f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 0.2f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 1, 0.3f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 0.4f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 0.5f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 1, 0.6f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 0.7f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 0.8f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 0.9f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 1, 1.0f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 1.1f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 1.2f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 1, 1.3f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 1.4f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 1.5f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 1.6f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 1, 1.7f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 1.8f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 1.9f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireRain, 2, 2.0f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.0f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.05f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.1f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.15f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.2f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.25f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.3f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.35f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.4f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.45f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.5f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.55f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.6f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.65f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.7f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.75f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.8f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.85f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.9f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 0.95f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.0f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.05f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.1f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.15f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.2f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.25f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.3f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.35f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.4f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.45f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.5f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.55f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.6f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.65f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.7f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.75f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.8f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.85f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.9f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 1.95f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 2.0f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 2.05f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 2.1f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 2.15f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 2.2f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 2.3f, new Vector3(0, 0.5f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireCloud, 20, 2.4f, new Vector3(0, 0.5f, 0));
        ////
        //i = (int)visualEffectNames.fireworks;
        //vEffects[i].addComponent((int)particleEmitterNames.fireworksGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.fireworks, 120, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.sparklesSplash;
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFlashGlow, 4, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFlashBeams, 24, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesFlash, 60, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.sparklesVolume;
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.55f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.65f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.75f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.85f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 0.95f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 1.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 4, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSplashes, 3, 1.15f, new Vector3(0, 0.0f, 0));

        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 4, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 2, 0.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 5, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 2, 0.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 4, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 2, 0.55f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 5, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.65f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.75f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 4, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 2, 0.85f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 0.95f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 5, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 1.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 3, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeSparkels, 2, 1.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.55f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.65f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.75f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.85f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 0.95f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 1.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesVolumeGlows, 1, 1.15f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.greenSplash;
        //vEffects[i].addComponent((int)particleEmitterNames.greeenSplashBeams, 30, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.greenSplashWave, 10, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.greenSplash, 2, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.greenFireworks, 50, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.bengalFire;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireStick, 200, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 0.0f, new Vector3(0, 1.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 0.1f, new Vector3(0, 1.17f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 0.2f, new Vector3(0, 1.14f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 0.3f, new Vector3(0, 1.11f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 0.4f, new Vector3(0, 1.08f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 0.5f, new Vector3(0, 1.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 0.6f, new Vector3(0, 1.02f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 0.7f, new Vector3(0, 0.99f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 0.8f, new Vector3(0, 0.96f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 0.9f, new Vector3(0, 0.93f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 1.0f, new Vector3(0, 0.9f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 1.1f, new Vector3(0, 0.87f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 1.2f, new Vector3(0, 0.84f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 1.3f, new Vector3(0, 0.81f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 1.4f, new Vector3(0, 0.78f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 1.5f, new Vector3(0, 0.75f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 1.6f, new Vector3(0, 0.72f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 1.7f, new Vector3(0, 0.69f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 19, 1.8f, new Vector3(0, 0.66f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireBeamsThin, 16, 1.9f, new Vector3(0, 0.63f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.0f, new Vector3(0, 1.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.1f, new Vector3(0, 1.17f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.2f, new Vector3(0, 1.14f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.3f, new Vector3(0, 1.11f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.4f, new Vector3(0, 1.08f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.5f, new Vector3(0, 1.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.6f, new Vector3(0, 1.02f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.7f, new Vector3(0, 0.99f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.8f, new Vector3(0, 0.96f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 0.9f, new Vector3(0, 0.93f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.0f, new Vector3(0, 0.9f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.1f, new Vector3(0, 0.87f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.2f, new Vector3(0, 0.84f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.3f, new Vector3(0, 0.81f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.4f, new Vector3(0, 0.78f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.5f, new Vector3(0, 0.75f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.6f, new Vector3(0, 0.72f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.7f, new Vector3(0, 0.69f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.8f, new Vector3(0, 0.66f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireGlow, 1, 1.9f, new Vector3(0, 0.63f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.0f, new Vector3(0, 1.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.1f, new Vector3(0, 1.17f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.2f, new Vector3(0, 1.14f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.3f, new Vector3(0, 1.11f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.4f, new Vector3(0, 1.08f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.5f, new Vector3(0, 1.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.6f, new Vector3(0, 1.02f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.7f, new Vector3(0, 0.99f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.8f, new Vector3(0, 0.96f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 0.9f, new Vector3(0, 0.93f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.0f, new Vector3(0, 0.9f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.1f, new Vector3(0, 0.87f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.2f, new Vector3(0, 0.84f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.3f, new Vector3(0, 0.81f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.4f, new Vector3(0, 0.78f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.5f, new Vector3(0, 0.75f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.6f, new Vector3(0, 0.72f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.7f, new Vector3(0, 0.69f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.8f, new Vector3(0, 0.66f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparkles, 20, 1.9f, new Vector3(0, 0.63f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.0f, new Vector3(0, 1.2f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.1f, new Vector3(0, 1.17f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.2f, new Vector3(0, 1.14f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.3f, new Vector3(0, 1.11f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.4f, new Vector3(0, 1.08f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.5f, new Vector3(0, 1.05f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.6f, new Vector3(0, 1.02f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.7f, new Vector3(0, 0.99f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.8f, new Vector3(0, 0.96f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 0.9f, new Vector3(0, 0.93f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.0f, new Vector3(0, 0.9f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.1f, new Vector3(0, 0.87f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.2f, new Vector3(0, 0.84f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.3f, new Vector3(0, 0.81f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.4f, new Vector3(0, 0.78f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.5f, new Vector3(0, 0.75f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.6f, new Vector3(0, 0.72f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.7f, new Vector3(0, 0.69f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.8f, new Vector3(0, 0.66f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireSparklesTaily, 11, 1.9f, new Vector3(0, 0.63f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireStickDone, 20, 0.3f, new Vector3(0, 1.1f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireStickDone, 20, 0.6f, new Vector3(0, 1.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireStickDone, 20, 0.9f, new Vector3(0, 0.9f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireStickDone, 20, 1.2f, new Vector3(0, 0.8f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireStickDone, 20, 1.5f, new Vector3(0, 0.7f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.bengalFireStickDone, 20, 1.8f, new Vector3(0, 0.6f, 0));
        ////
        //i = (int)visualEffectNames.sparkleFountain;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.sparkleFountain, 20, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparkleFountain, 20, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparkleFountain, 20, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparkleFountain, 20, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparkleFountain, 20, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparkleFountain, 20, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.sparkleFountain, 20, 0.6f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.sparklesExplosion;
        //vEffects[i].addComponent((int)particleEmitterNames.sparklesExplosion, 100, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.flareLight;
        //vEffects[i].addComponent((int)particleEmitterNames.flareLight, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareLightGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.flareFire;
        //vEffects[i].addComponent((int)particleEmitterNames.flareFire, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareFireGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.flareElectricity;
        //vEffects[i].addComponent((int)particleEmitterNames.flareElectricity, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareElectricity, 1, 0.02f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareElectricity, 1, 0.04f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareElectricity, 1, 0.06f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareElectricity, 1, 0.08f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareZapGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.flareSmoke;
        //vEffects[i].addComponent((int)particleEmitterNames.flareSmoke, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareSmokeGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.flareSparkles;
        //vEffects[i].addComponent((int)particleEmitterNames.flareSparkles, 32, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareSparklesGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.flareMagic;
        //vEffects[i].addComponent((int)particleEmitterNames.flareMagic, 8, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareMagic, 3, 0.06f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.flareMagicGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDarkCircleCreation;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkCircleSmoke, 60, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkVerticalSmoke, 36, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlame, 2, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlame, 2, 0.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlame, 2, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlame, 4, 0.55f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlame, 6, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlame, 8, 0.65f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlame, 10, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlameVertical, 4, 0.55f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlameVertical, 6, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlameVertical, 8, 0.65f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlameVertical, 10, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlameVertical, 12, 0.75f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlameVertical, 16, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWaves, 1, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWaves, 1, 0.55f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWaves, 2, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWaves, 3, 0.65f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWaves, 2, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWaves, 1, 0.75f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWaves, 1, 0.8f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDarkSphereCreation;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkSphereBlack, 180, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkSphereSmoke, 100, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkSphereBright, 16, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlareHoriz, 1, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlareVert, 1, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkGlow, 1, 1.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkBlackSpot, 9, 1.2f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDarkCloudCreation;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkBlackCloudGrow, 15, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkBlackCloudBurst, 20, 2.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 1.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 1, 2.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedWavesIn, 2, 2.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 3, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 3, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 3, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 3, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 4, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 4, 0.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 4, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 4, 0.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 5, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 5, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 5, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 5, 1.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 6, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 6, 1.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 6, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 6, 1.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 7, 1.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 7, 1.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 7, 1.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 7, 1.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 8, 2.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 4, 2.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 4, 2.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 4, 2.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 5, 2.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 5, 2.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 5, 2.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 6, 2.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 6, 2.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 7, 2.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkRedSpotsIn, 8, 2.5f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkGlowSlow, 1, 1.7f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkGlowWhite, 2, 2.45f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDarkFlies;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkFlies, 20, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDeathFlowers;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDeathFlowers, 7, 0.0f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDarkSplashGreen;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkGreenGlow, 1, 0.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkAshFront, 100, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkSplashGreen, 12, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkAsh, 80, 0.8f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDarkUndergroundEscape;
        //vEffects[i].ground = true;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkUndergroundLight, 72, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkUndergroundGlow, 2, 0.0f, new Vector3(0, 0.12f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkUndergroundEscape, 20, 0.2f, new Vector3(0, 0.0f, 0));
        ////
        //i = (int)visualEffectNames.magicDarkCloudFocusing;
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkCloudFocusing, 72, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkGlowFocusing, 1, 0.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 6, 1.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 5, 1.95f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 4, 2.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 4, 2.05f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 3, 2.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 3, 2.15f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 3, 2.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 2, 2.25f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 2, 2.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 2, 2.35f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 1, 2.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyOut, 1, 2.45f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkPikes, 24, 2.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkEnergyWaveOut, 1, 1.9f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicDarkGlowBigger, 1, 1.9f, new Vector3(0, 0.0f, 0));
        ////
        i = (int)visualEffectNames.magicLightShining;
        vEffects[i].ground = true;
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 5, 0.0f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.05f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.1f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 0.15f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.2f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.25f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.3f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 0.35f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.4f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.45f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.5f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 0.55f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.6f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.65f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.7f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 0.75f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.8f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.85f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 0.9f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 0.95f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.0f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.05f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.1f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 1.15f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.2f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.25f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.3f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 1.35f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.4f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.45f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.5f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 1.55f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.6f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 5, 1.65f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.7f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 1.75f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.8f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 5, 1.85f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 3, 1.9f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLight, 4, 1.95f, new Vector3(0, 0.0f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 3, 0.0f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.1f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.2f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.3f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.4f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.5f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.6f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.7f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.8f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 0.9f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 3, 1.0f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.1f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.2f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.3f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.4f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.5f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.6f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.7f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.8f, new Vector3(0, 0.15f, 0));
        vEffects[i].addComponent((int)particleEmitterNames.magicLightGlow, 2, 1.9f, new Vector3(0, 0.15f, 0));
        //
        //i = (int)visualEffectNames.magicLightOverlighting;
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 16, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 16, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 12, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 12, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 12, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 12, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 10, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 10, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 12, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 12, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 10, 1.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 10, 1.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 10, 1.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 10, 1.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 12, 2.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 12, 2.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 10, 2.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 10, 2.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 10, 2.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 10, 2.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 10, 2.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 12, 2.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 12, 2.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 10, 2.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 10, 3.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 10, 3.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksBlue, 4, 3.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksRed, 4, 3.1f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 5, 0.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 4, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 5, 1.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 4, 1.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 5, 2.3f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 7, 0.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 3, 0.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 3, 0.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 5, 0.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 3, 0.8f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 3, 1.0f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 5, 1.2f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 3, 1.4f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 3, 1.6f, new Vector3(0, 0.0f, 0));
        //vEffects[i].addComponent((int)particleEmitterNames.magicLightTall, 3, 1.8f, new Vector3(0, 0.0f, 0));
        ////
        i = (int)visualEffectNames.magicLightColumn;
		vEffects[i].ground = true;
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 5, 0.0f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 4, 0.1f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 3, 0.2f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 2, 0.3f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 3, 0.4f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 2, 0.5f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 3, 0.6f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 2, 0.7f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 3, 0.8f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallThin, 2, 0.9f, new Vector3(0, -3, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.0f, new Vector3(0, 0.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.1f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.2f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.3f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.4f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.5f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.6f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.7f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.8f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowColumn, 2, 0.9f, new Vector3(0, 0.15f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 6, 0.0f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 5, 0.1f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 6, 0.2f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 5, 0.3f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 6, 0.4f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 5, 0.5f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 6, 0.6f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 5, 0.7f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 5, 0.8f, new Vector3(0, 1.0f, 0));
		vEffects[i].addComponent((int)particleEmitterNames.magicLightTallLines, 4, 0.9f, new Vector3(0, 1.0f, 0));
		////
		//i = (int)visualEffectNames.magicLightBubbles;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 2, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 1, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 1, 1.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 2, 1.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGlowBillboard, 1, 2.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 0.0f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 0.1f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 0.2f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 0.3f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 0.4f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 0.5f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 0.6f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 0.7f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 0.8f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 0.9f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 1.0f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 1.1f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 1.2f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 1.3f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 1.4f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 1.5f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 1.6f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 1.7f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 1.8f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 1.9f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 2.0f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesOrange, 2, 2.1f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesGreen, 2, 2.2f, new Vector3(0, 0, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.mudBubblesPurple, 1, 2.3f, new Vector3(0, 0, 0));
		////
		//i = (int)visualEffectNames.magicLightSnakes;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightSnakes, 12, 0.0f, new Vector3(0, 0.1f, 0));
		////
		//i = (int)visualEffectNames.magicLightFlies;
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightFlies, 50, 0.0f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.magicLightLeaves;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightLeaves, 8, 0.0f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.magicNatureLeaves;
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 0.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 0.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 0.2f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 0.3f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 0.4f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 0.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 0.6f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 0.7f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 0.8f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 0.9f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 1.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 1.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 1.2f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 1.3f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 1.4f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 1.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 1.6f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 1.7f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 2, 1.8f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureLeaves, 1, 1.9f, new Vector3(0, 0.5f, 0));
		////
		//i = (int)visualEffectNames.magicNatureGrass;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureGrass, 10, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureGrass, 20, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureGrass, 30, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureGrass, 40, 0.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicNatureGrass, 120, 0.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGreen, 10, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGreen, 8, 0.15f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGreen, 8, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGreen, 8, 0.45f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightGreen, 6, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 4, 0.2f, new Vector3(0, 0.3f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 5, 0.3f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 8, 0.4f, new Vector3(0, 0.3f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 8, 0.5f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 7, 0.6f, new Vector3(0, 0.3f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 6, 0.7f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 5, 0.8f, new Vector3(0, 0.3f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 4, 0.9f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 3, 1.0f, new Vector3(0, 0.3f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightBlinksGreeen, 2, 1.1f, new Vector3(0, 0.2f, 0));
		////
		//i = (int)visualEffectNames.magicLightFlower;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.magicLightFlower, 1, 0.4f, new Vector3(0, 0.05f, 0));
		////
		//i = (int)visualEffectNames.lightningBolt;
		//vEffects[i].addComponent((int)particleEmitterNames.lightningBolt, 1, 0.0f, new Vector3(0, 0.05f, 0));
		////
		//i = (int)visualEffectNames.waterSplash;
		//vEffects[i].addComponent((int)particleEmitterNames.waterDropsDispl, 36, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterDropsColor, 72, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterDropsSplashes, 30, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterDropsMist, 45, 0.0f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.waterRain;
		//vEffects[i].addComponent((int)particleEmitterNames.waterRainCloud, 30, 0.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 0.1f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 0.2f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 0.3f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 0.4f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 0.5f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 0.6f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 0.7f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 0.8f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 0.9f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 1.0f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 1.1f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 1.2f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 1.3f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 1.4f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 1.5f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 1.6f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 1.7f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 9, 1.8f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 1.9f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 2.0f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 2.1f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDispl, 8, 2.2f, new Vector3(0, 0.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 10, 0.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.2f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.3f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.4f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.6f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.7f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.8f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 0.9f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.2f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.3f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.4f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.6f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.7f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.8f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 1.9f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 2.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 2.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterShowerDrops, 12, 2.2f, new Vector3(0, 0.5f, 0));
		////
		//i = (int)visualEffectNames.waterBoiling;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 0.0f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 2, 0.1f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 0.2f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 3, 0.3f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 3, 0.4f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 2, 0.5f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 0.6f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 2, 0.7f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 0.8f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 3, 0.9f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 1.0f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 2, 1.1f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 1.2f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 3, 1.3f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 3, 1.4f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 2, 1.5f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 1.6f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 2, 1.7f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 1.8f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 3, 1.9f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 4, 2.0f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDrops, 3, 2.1f, new Vector3(0, -0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.1f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.2f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.3f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.4f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.5f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.6f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.7f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.8f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 0.9f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.1f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.2f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.3f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.4f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.5f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.6f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.7f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.8f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 1.9f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 2.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingSteam, 3, 2.1f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.0f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.1f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.2f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 4, 0.3f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.4f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.5f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.6f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 4, 0.7f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.8f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 0.9f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 1.0f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 4, 1.1f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 1.2f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 1.3f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 1.4f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 4, 1.5f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 1.6f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 1.7f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 1.8f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 4, 1.9f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 2.0f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.boilingDispl, 3, 2.1f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 0.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 0.1f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 0.2f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 0.3f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 0.4f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 0.5f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 0.6f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 0.7f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 0.8f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 0.9f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 1.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 1.1f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 1.2f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 1.3f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 1.4f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 1.5f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 1.6f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 1.7f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 1.8f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 2, 1.9f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 2.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.waterWaves, 3, 2.1f, new Vector3(0, 0.12f, 0));
		////
		//i = (int)visualEffectNames.plasmCloud;
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 0.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 1.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 2.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 2.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 2.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShining, 25, 2.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 0.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 0.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 0.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 0.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 0.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 1.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 1.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 1.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 1.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 1.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 1.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 1.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 1.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 7, 1.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 1.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 2.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 2.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 2.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShining, 6, 2.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 0.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 0.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 0.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 0.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 0.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 1.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 1.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 1.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 1.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 1.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 1.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 1.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 1.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 7, 1.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 1.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 2.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 2.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 2.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowShiningFast, 6, 2.3f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.plasmExplosion;
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWave, 3, 0.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWave, 2, 0.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWave, 2, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWave, 1, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWave, 1, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWave, 1, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaveOuter, 2, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaveOuter, 1, 0.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaveOuter, 1, 0.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaveOuter, 1, 0.15f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaves, 1, 0.15f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaves, 1, 0.25f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaves, 1, 0.35f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaves, 1, 0.45f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaves, 1, 0.55f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaves, 1, 0.65f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutside, 5, 0.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutside, 8, 0.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutside, 12, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutside, 16, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutside, 12, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutside, 8, 0.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutside, 5, 0.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutSlow, 3, 0.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutSlow, 5, 0.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutSlow, 7, 0.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutSlow, 5, 0.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmShiningOutSlow, 3, 0.8f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.plasmColumn;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.0f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.1f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.2f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.3f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.4f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.5f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.6f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.7f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.8f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 0.9f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.0f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.1f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.2f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.3f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.4f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.5f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.6f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.7f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.8f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumn, 32, 1.9f, new Vector3(0, 1.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.2f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.3f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.4f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.5f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.6f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.7f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.8f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 0.9f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.0f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.1f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.2f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.3f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.4f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.5f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.6f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.7f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.8f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 1.9f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 2.0f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnImpact, 50, 2.1f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 0.2f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 0.4f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 0.6f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 0.8f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 1.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 1.2f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 1.4f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 1.6f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 1.8f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlow, 1, 2.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 0.2f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 0.4f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 0.6f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 0.8f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 1.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 1.2f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 1.4f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 1.6f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 1.8f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnGlowBB, 1, 2.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnLight, 16, 0.2f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnLight, 4, 0.4f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnLight, 4, 0.6f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnLight, 4, 0.8f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnLight, 4, 1.0f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnLight, 4, 1.2f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnLight, 4, 1.4f, new Vector3(0, -0.1f, 0));
		////
		//i = (int)visualEffectNames.plasmAmplifier;
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCloud, 12, 6.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWaveSplash, 1, 5.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWavesSplash, 1, 5.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWavesSplash, 1, 5.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWavesSplash, 1, 5.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWavesSplash, 1, 6.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWavesSplash, 1, 6.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWavesSplash, 1, 6.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmWavesSplash, 1, 6.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 4.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 4.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 5.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 5.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 5.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 5.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 5.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 5.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 2, 5.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 5.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmGlowAmplifier, 1, 6.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 4, 2.4f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 6, 2.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 8, 2.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 10, 2.7f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 12, 2.8f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 14, 2.9f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 16, 3.0f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 18, 3.1f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 20, 3.2f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 24, 3.3f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 28, 3.4f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 32, 3.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 36, 3.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 40, 3.7f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 45, 3.8f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 50, 3.9f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 55, 4.0f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 60, 4.1f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 65, 4.2f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 70, 4.3f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 75, 4.4f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 80, 4.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 85, 4.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 90, 4.7f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 95, 4.8f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 100, 4.9f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 100, 5.0f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 55, 5.05f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 55, 5.1f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 60, 5.15f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 60, 5.2f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 65, 5.25f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 65, 5.3f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 70, 5.35f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 75, 5.4f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 80, 5.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 85, 5.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 90, 5.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 90, 5.65f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmColumnJet, 80, 5.7f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 8, 1.65f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 8, 1.65f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 12, 2.2f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 12, 2.2f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 20, 2.75f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 20, 2.75f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 30, 3.3f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 30, 3.3f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 45, 3.85f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 45, 3.85f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 60, 4.4f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 60, 4.4f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 70, 4.95f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 70, 4.95f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 80, 5.0f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 80, 5.0f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 30, 5.1f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 30, 5.1f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 40, 5.2f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 40, 5.2f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 50, 5.3f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 50, 5.3f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 60, 5.4f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 60, 5.4f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 67, 5.5f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 67, 5.5f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 72, 5.6f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 72, 5.6f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 75, 5.7f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 75, 5.7f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 50, 5.75f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 50, 5.75f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 55, 5.8f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 55, 5.8f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 35, 5.85f, new Vector3(0, 0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmCircleBlue, 35, 5.85f, new Vector3(0, -0.15f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 32, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 32, 1.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 32, 1.65f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 48, 2.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 32, 2.57f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 32, 2.94f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 56, 3.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 56, 3.575f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 56, 3.85f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 56, 4.125f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 64, 4.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 64, 4.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 64, 4.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 72, 4.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 72, 4.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 86, 4.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 86, 5.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 92, 5.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 92, 5.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 102, 5.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 108, 5.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 112, 5.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 64, 5.55f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 70, 5.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 80, 5.65f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 70, 5.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.plasmAmplifier, 50, 5.75f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.explosionGround1;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.explFlash, 1, 0.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFlashHoriz, 1, 0.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explWaveHoriz, 1, 0.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDustTentacles, 8, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDust, 6, 0.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDustSlow, 6, 0.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explRocksFleeingMed, 7, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explRocksFleeingSmall, 32, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDustSettles, 32, 0.0f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.explosionGround2;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.explFireTentacles, 8, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFireTails, 7, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFlame, 20, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explWaveHorizFire, 1, 0.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFlashHorizFire, 1, 0.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFlashFire, 1, 0.0f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFireTailsFast, 7, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFlameSlow, 32, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explSparks, 24, 0.0f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.explosionGroundDirt;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.explFlashLight, 1, 0.0f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFlashDirt, 1, 0.07f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDustSphere, 90, 0.04f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explRocksSmall, 32, 0.04f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDustCircle, 70, 0.02f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explWaveHorizDust, 1, 0.02f, new Vector3(0, 0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDustFountSettles, 90, 0.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explDustColumnSettles, 90, 0.05f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.explosion1;
		//vEffects[i].addComponent((int)particleEmitterNames.explFlameSlowAir, 12, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFireTailsAir, 10, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFireBall, 3, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFireWave, 9, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFireSparksSmall, 50, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFireTailsFastSphere, 5, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.explFlashFire2, 1, 0.0f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.rockRain;
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainCloud, 20, 0.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainCloud, 15, 0.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainCloud, 15, 1.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainCloud, 25, 1.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainCloud, 15, 2.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 1, 0.3f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 1, 0.4f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 2, 0.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 2, 0.6f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 3, 0.7f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 3, 0.8f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 3, 0.9f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 4, 1.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 3, 1.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 3, 1.2f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 4, 1.3f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 3, 1.4f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 4, 1.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 4, 1.6f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 5, 1.7f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 4, 1.8f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 5, 1.9f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 3, 2.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 6, 2.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 7, 2.2f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 5, 2.3f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 5, 2.4f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 6, 2.5f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 5, 2.6f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 8, 2.7f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 7, 2.8f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 5, 2.9f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 8, 3.0f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 9, 3.1f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 9, 3.2f, new Vector3(0, 0.5f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.rockRainBigRocks, 5, 3.3f, new Vector3(0, 0.5f, 0));
		////
		//i = (int)visualEffectNames.rockFall;
		//vEffects[i].addComponent((int)particleEmitterNames.bigRockFall, 1, 0.0f, new Vector3(0, 0.6f, 0));
		////
		//i = (int)visualEffectNames.lavaFall;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.0f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.05f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.1f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.15f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.2f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.25f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.3f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.35f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.4f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.45f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.5f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.55f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.6f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.65f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.7f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.75f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.8f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.85f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.9f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 0.95f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.0f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.05f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.1f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.15f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.2f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.25f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.3f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.35f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.4f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.45f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.5f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.55f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.6f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.65f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.7f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.75f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.8f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.85f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.9f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFall, 1, 1.95f, new Vector3(0, 1.2f, 0));
		////
		//i = (int)visualEffectNames.lavaFountain;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.03f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.06f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.09f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.12f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.15f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.18f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.21f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.24f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.27f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.30f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.33f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.36f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.39f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.42f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.45f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.48f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.51f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.54f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.57f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.60f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.63f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.66f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.69f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.72f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.75f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.78f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountain, 1, 0.81f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.03f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.06f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.09f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.12f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.15f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.18f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.21f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.24f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.27f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.30f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.33f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.36f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.39f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.42f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.45f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.48f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.51f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.54f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.57f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.60f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.63f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.66f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.69f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.72f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.75f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.78f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDrop, 2, 0.81f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.0f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.03f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.06f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.09f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.12f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.15f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.18f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.21f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.24f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.27f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.30f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.33f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.36f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.39f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.42f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.45f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.48f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.51f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.54f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.57f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.60f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.63f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.66f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.69f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.72f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.75f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 5, 0.78f, new Vector3(0, 0.05f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lavaFountainDropR, 3, 0.81f, new Vector3(0, 0.05f, 0));
		////
		//i = (int)visualEffectNames.lavaRockFall;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.lavaRockFall, 1, 0.0f, new Vector3(0, 1.2f, 0));
		////
		//i = (int)visualEffectNames.iceRockFall;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.iceRockFall, 1, 0.0f, new Vector3(0, 1.2f, 0));
		////
		//i = (int)visualEffectNames.icePikes;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.iceImpactWave, 90, 0.0f, new Vector3(0, 0.07f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceGround, 70, 0.1f, new Vector3(0, 0.03f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.icePikes, 50, 0.15f, new Vector3(0, -0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.35f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.4f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.45f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.5f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.55f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.6f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.65f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.7f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.75f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.8f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.85f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.9f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 0.95f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 1.0f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 1.05f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 1.1f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 1.15f, new Vector3(0, 0.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceLights, 5, 1.2f, new Vector3(0, 0.1f, 0));
		////
		//i = (int)visualEffectNames.iceRain;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloud, 64, 0.0f, new Vector3(0, 1.2f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 0.1f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 0.2f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 4, 0.3f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 0.4f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 0.5f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 4, 0.6f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 0.7f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 0.8f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 4, 0.9f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 1.0f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 1.1f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 1.2f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 4, 1.3f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 1.4f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 1.5f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 4, 1.6f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 1.7f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 1.8f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 4, 1.9f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceCloudCold, 3, 2.0f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.1f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.15f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.2f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.25f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.3f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.35f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.4f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.45f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.5f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.55f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.6f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.65f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.7f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.75f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.8f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.85f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.9f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 0.95f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.0f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.05f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.1f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.15f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.2f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.25f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.3f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.35f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.4f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 2, 1.45f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.5f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.55f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.6f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.65f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.7f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.75f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.8f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.85f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.9f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 1.95f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.0f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.05f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.1f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.15f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.2f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.25f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.3f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.35f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.4f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.45f, new Vector3(0, 1.1f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.iceRain, 3, 2.5f, new Vector3(0, 1.1f, 0));
		////
		//i = (int)visualEffectNames.snowFlakes;
		//vEffects[i].ground = true;
		//vEffects[i].addComponent((int)particleEmitterNames.snowCloud, 36, 0.0f, new Vector3(0, 1.1f, 0));
		//j = 0;
		//while (j < 125) {
		//	vEffects[i].addComponent((int)particleEmitterNames.snowFlakes, 20, j * 0.05f, new Vector3(0, 1.0f, 0));
		//	j++;
		//}
		////
		//i = (int)visualEffectNames.lightSplash;
		//vEffects[i].addComponent((int)particleEmitterNames.lightGlow, 1, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lightWave, 1, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lightBeams, 50, 0.0f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.lights;
		//j = 0;
		//while (j < 40) {
		//	vEffects[i].addComponent((int)particleEmitterNames.lightsRedBlue, 2, j * 0.06f, new Vector3(0, 0.0f, 0));
		//	j++;
		//}
		//j = 0;
		//while (j < 40) {
		//	vEffects[i].addComponent((int)particleEmitterNames.lightsYellowOrange, 2, j * 0.06f, new Vector3(0, 0.0f, 0));
		//	j++;
		//}
		//j = 0;
		//while (j < 40) {
		//	vEffects[i].addComponent((int)particleEmitterNames.lightsTealSalt, 2, j * 0.06f, new Vector3(0, 0.0f, 0));
		//	j++;
		//}
		////
		//i = (int)visualEffectNames.lightBeamFocused;
		//vEffects[i].addComponent((int)particleEmitterNames.lightBeamsFromSky, 300, 0.0f, new Vector3(0, -0.12f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lightBeamsFocused, 300, 0.05f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.lightGlow2, 1, 0.1f, new Vector3(0, 0.0f, 0));
		////
		//i = (int)visualEffectNames.lightningStorm;
		//vEffects[i].addComponent((int)particleEmitterNames.stormCloudBack, 12, 0.0f, new Vector3(0, 0.5f, 0));
		//j = 0;
		//while (j < 64) {
		//	vEffects[i].addComponent((int)particleEmitterNames.stormCloudBack, 2, j * 0.1f, new Vector3(0, 0.5f, 0));
		//	j++;
		//}
		//j = 0;
		//while (j < 11) {
		//	vEffects[i].addComponent((int)particleEmitterNames.stormLightnings, 1 + Random.Range(0, 2), 0.4f + Random.Range(-0.35f, 0.35f) + j * 0.8f, new Vector3(0, 0.4f, 0));
		//	j++;
		//}
		//vEffects[i].addComponent((int)particleEmitterNames.stormCloudFront, 2, 0.0f, new Vector3(0, 0.5f, 0));
		//j = 0;
		//while (j < 32) {
		//	vEffects[i].addComponent((int)particleEmitterNames.stormCloudFront, 1, j * 0.2f, new Vector3(0, 0.5f, 0));
		//	j++;
		//}
		////
		//i = (int)visualEffectNames.starInception;
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloud, 32, 0.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 0.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 1.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 1.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 1.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 2.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 2.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 2.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustInitialCloudMove, 8, 3.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustFocusingBG, 24, 1.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustFocusing, 12, 1.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starInitialGlow, 1, 2.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starGlowExpl, 1, 3.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starWaveExpl, 1, 3.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starExplFumes, 18, 4.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustCircle1, 120, 4.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustCircle2, 145, 4.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustCircle3, 180, 4.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starDustOut, 120, 3.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 3.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 4.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 4.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 4.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 4.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 4.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 4.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 5.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 5.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starMainGlow, 1, 5.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.starFinalGlow, 1, 6.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 3.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 3.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 4.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 5.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 6.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 7.9f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.0f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.1f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.2f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.3f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.4f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.5f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.6f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.7f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.8f, new Vector3(0, 0.0f, 0));
		//vEffects[i].addComponent((int)particleEmitterNames.star, 1, 8.9f, new Vector3(0, 0.0f, 0));
	}
	static public void scaleAllEmitters(){					// applies scaleFactor to all registered emitters
		if (scaleFactor < 1.01f && scaleFactor > 0.99f)		// if it's around 1.0
			return;
		int i = 0, j;
		while (i < emitters.Length) {
			scaleEmitter(emitters[i].ps, scaleFactor);
			i++;
		}
		i = 0;
		while (i < vEffects.Length) {
			j = 0;
			while (j < vEffects[i].nComponents) {
				vEffects[i].veComponents[j].offset *= scaleFactor;
				j++;
			}
			i++;
		}
	}
	static public void scaleEmitter(ParticleSystem ps, float scale){
		ParticleSystem.ShapeModule sh;
		if (ps.subEmitters.enabled) {
            for (int i = 0; i < ps.subEmitters.subEmittersCount; i++)
            {
                scaleEmitter(ps.subEmitters.GetSubEmitterSystem(i), scale);
            }
		}
        var main = ps.main;
        main.startSize = new ParticleSystem.MinMaxCurve(scale, main.startSize.curve);
		main.startSpeed = new ParticleSystem.MinMaxCurve(scale, main.startSpeed.curve);
        main.gravityModifier = new ParticleSystem.MinMaxCurve(scale, main.gravityModifier.curve);
        sh = ps.shape;
		sh.radius *= scale;
		sh.length *= scale;
	}
	static public void emitFromTimer(int e, int c, Vector3 p){		// when delay timer is done, he runs this to emit his particles
		emitters[vEffects[e].veComponents[c].emitterN].emitParticles(p, vEffects[e].veComponents[c].amount);
	}
	static public void update () {
		evTimers.tickAll(Time.deltaTime);
	}
	static public void createEffect(int eN, Vector3 pos){
		vEffects[eN].createEffect(eN, pos);
	}
	static public bool effectIsGround(int eNumber){
		return vEffects[eNumber].ground;
	}
	static public void scaleAllEffects(){
		int i = 0;
		while (i < vEffects.Length) {
			if (vEffects[i].scaleFactor > 1.01f || vEffects[i].scaleFactor < 0.99f)
				scaleEffect(i);
			i++;
		}
	}
	static public void scaleEffect(int effectToScale){
		cleanEmittersToAffect();
		paintEmittersToAffect(effectToScale);
		scalePaintedEmitters(effectToScale);
	}
	static public void cleanEmittersToAffect(){
		int i = 0;
		while (i < emittersToAffect.Length) {
			emittersToAffect[i] = false;
			i++;
		}
	}
	static public void paintEmittersToAffect(int effectUnderScale){		// sets true for the emitters used in the effect as a component
		int i = 0;
		while (i < vEffects[effectUnderScale].nComponents) {
			emittersToAffect[vEffects[effectUnderScale].veComponents[i].emitterN] = true;
			i++;
		}
	}
	static public void scalePaintedEmitters(int effectToScale){
		float eScaleFactor = vEffects[effectToScale].scaleFactor;
		int i = 0;
		while (i < emittersToAffect.Length) {
			if (emittersToAffect[i] == true)
				scaleEmitter(emitters[i].ps, eScaleFactor);
			i++;
		}
	}
}