#region USINGS
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AmmoDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EjectionDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EjectionDef.SpawnType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.ShapeDef.Shapes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.CustomScalesDef.SkipMode;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.FragmentDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.PatternDef.PatternModes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.FragmentDef.TimedSpawnDef.PointTypes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.Conditions;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.UpRelativeTo;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.FwdRelativeTo;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.ReInitCondition;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.RelativeTo;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.ConditionOperators;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef.StageEvents;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.ApproachDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.TrajectoryDef.GuidanceType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.ShieldDef.ShieldType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.DeformDef.DeformTypes;
using static Scripts.Structure.WeaponDefinition.AmmoDef.AreaOfDamageDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.AreaOfDamageDef.Falloff;
using static Scripts.Structure.WeaponDefinition.AmmoDef.AreaOfDamageDef.AoeShape;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef.EwarMode;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef.EwarType;
using static Scripts.Structure.WeaponDefinition.AmmoDef.EwarDef.PushPullDef.Force;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.FactionColor;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.TracerBaseDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.LineDef.Texture;
using static Scripts.Structure.WeaponDefinition.AmmoDef.GraphicDef.DecalDef;
using static Scripts.Structure.WeaponDefinition.AmmoDef.DamageScaleDef.DamageTypes.Damage;
#endregion USINGS

namespace Scripts
{ // Don't edit above this line
    partial class Parts
    {
        private AmmoDef KJN_KWP_BMB_an_m64A1_500lb_Ammo => new AmmoDef // Your ID, for slotting into the Weapon CS
        {
            AmmoMagazine = "KJN_KWP_BMB_an_m64A1_500lb_magazine",
            AmmoRound = "KJN_KWP_BMB_an_m64A1_500lb_Ammo",
            TerminalName = "AN-M64A1 500lb HE Bomb",
            BaseDamage = 1,
            BaseDamageCutoff = 0,
            Mass = 242.6f,
            Health = 10,
            BackKickForce = 0f,
            HardPointUsable = true,
            HybridRound = false,
            IgnoreWater = false,
            IgnoreVoxels = false,
            NpcSafe = true,
            NoGridOrArmorScaling = false,
            
            ObjectsHit = new ObjectsHitDef
            {
                MaxObjectsHit = 0,
                CountBlocks = false,
            },
            Fragment = new FragmentDef
            {
                AmmoRound = "KJN_KWP_BMB_Shrapnel_Ammo",
                Fragments = 200,
                Degrees = 360,
                Reverse = true,
                DropVelocity = true,
                Offset = -2f,
                Radial = 0f,
                MaxChildren = 0,
                IgnoreArming = true,
                ArmWhenHit = true,
                AdvOffset = Vector(x: 0, y: 0, z: 0),
            },
            DamageScales = new DamageScaleDef
            {
                MaxIntegrity = 0f,
                DamageVoxels = false,
                SelfDamage = false,
                HealthHitModifier = 1,
                VoxelHitModifier = 0.01f,
                Characters = 1f, 
                
                FallOff = new FallOffDef
                {
                    Distance = 0f,
                    MinMultipler = 1f,
                },
                Grids = new GridSizeDef
                {
                    Large = 1f,
                    Small = 0.0339f,
                },
                Armor = new ArmorDef
                {
                    Armor = -1f,
                    Light = -1f,
                    Heavy = -1f,
                    NonArmor = -1f,
                },
                Shields = new ShieldDef
                {
                    Modifier = 3f,
                    Type = Default,
                    BypassModifier = -1f,
                    HeatModifier = 1,
                },
                DamageType = new DamageTypes
                {
                    Base = Kinetic,
                    AreaEffect = Energy,
                    Detonation = Energy,
                    Shield = Energy,
                },
                Deform = new DeformDef
                {
                    DeformType = HitBlock,
                    DeformDelay = 30,
                },
            },
            AreaOfDamage = new AreaOfDamageDef
            {
                ByBlockHit = new ByBlockHitDef
                {
                    Enable = false,
                    Radius = 0f,
                    Damage = 0f,
                    Depth = 0f,
                    MaxAbsorb = 0f,
                    Falloff = Pooled,
                    //.NoFalloff applies the same damage to all blocks in radius
                    //.Linear drops evenly by distance from center out to max radius
                    //.Curve drops off damage sharply as it approaches the max radius
                    //.InvCurve drops off sharply from the middle and tapers to max radius
                    //.Squeeze does little damage to the middle, but rapidly increases damage toward max radius
                    //.Pooled damage behaves in a pooled manner that once exhausted damage ceases.
                    //.Exponential drops off exponentially.  Does not scale to max radius
                    Shape = Diamond, // Round or Diamond shape.  Diamond is more performance friendly.
                },
                EndOfLife = new EndOfLifeDef
                {
                    Enable = true,
                    Radius = 5.5f,
                    Damage = 148500f,
                    Depth = 2.75f,
                    MaxAbsorb = 148500f,
                    Falloff = Curve, 
                    //.NoFalloff applies the same damage to all blocks in radius
                    //.Linear drops evenly by distance from center out to max radius
                    //.Curve drops off damage sharply as it approaches the max radius
                    //.InvCurve drops off sharply from the middle and tapers to max radius
                    //.Squeeze does little damage to the middle, but rapidly increases damage toward max radius
                    //.Pooled damage behaves in a pooled manner that once exhausted damage ceases.
                    //.Exponential drops off exponentially.  Does not scale to max radius
                    ArmOnlyOnHit = false,
                    MinArmingTime = 90,
                    NoVisuals = false,
                    NoSound = false,
                    ParticleScale = 1,
                    CustomParticle = "KJN_KWP_500lb_ExplosionEffect",
                    CustomSound = "KJN_KWP_500lb_ExplosionSound",
                    Shape = Diamond,
                },
            },
            Trajectory = new TrajectoryDef
            {
                Guidance = None,
                GravityMultiplier = 1f,
                DesiredSpeed = 0, // Muzzle Velocity m/s
                AccelPerSec = 0f,
                MaxLifeTime = 3900,
                MaxTrajectory = 20000,
                // SpeedVariance = Random(start: 0, end: 0),
                // RangeVariance = Random(start: 0, end: 0),
            },
            AmmoGraphics = new GraphicDef
            {
                ModelName = "\\Models\\Cubes\\small\\KJN_KWP_BMB_an_m64A1_500lb_ammo.mwm",
                VisualProbability = 1f,
                ShieldHitDraw = false,
                // Lines = new LineDef
                // {
                //     Tracer = new TracerBaseDef
                //     {
                //         Enable = true,
                //         Length = 10f,
                //         Width = 0.1f,
                //         Color = Color(red: 5, green: 2, blue: 1f, alpha: 1),
                //         Textures = new[] {"ProjectileTrailLine",},
                //     },
                // },
            },
            AmmoAudio = new AmmoAudioDef
            {
                TravelSound = "MediumShellFlightSound",
                HitSound = "",
                ShotSound = "",
                ShieldHitSound = "",
                PlayerHitSound = "",
                VoxelHitSound = "",
                FloatingHitSound = "",
                HitPlayChance = 0f,
                HitPlayShield = true,
            },
        };
    }
}
