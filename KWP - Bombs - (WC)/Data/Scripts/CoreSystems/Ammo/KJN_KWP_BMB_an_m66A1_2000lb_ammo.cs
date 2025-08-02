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
        private AmmoDef KJN_KWP_BMB_an_m66A1_2000lb_Ammo => new AmmoDef // Your ID, for slotting into the Weapon CS
        {
            AmmoMagazine = "KJN_KWP_BMB_an_m66A1_2000lb_magazine",
            AmmoRound = "KJN_KWP_BMB_an_m66A1_2000lb_Ammo",
            TerminalName = "AN-M66A1 2000lb HE Bomb",
            BaseDamage = 1,
            BaseDamageCutoff = 0,
            Mass = 996.3f,
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
                Fragments = 300,
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
                    Shape = Diamond,
                },
                EndOfLife = new EndOfLifeDef
                {
                    Enable = true,
                    Radius = 13.5f,
                    Damage = 808500f,
                    Depth = 6.5f,
                    MaxAbsorb = 808500f,
                    Falloff = Curve,
                    ArmOnlyOnHit = false,
                    MinArmingTime = 90,
                    NoVisuals = false,
                    NoSound = false,
                    ParticleScale = 1,
                    CustomParticle = "KJN_KWP_2000lb_ExplosionEffect",
                    CustomSound = "KJN_KWP_2000lb_ExplosionSound",
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
            },
            AmmoGraphics = new GraphicDef
            {
                ModelName = "\\Models\\Cubes\\small\\KJN_KWP_BMB_an_m66A1_2000lb_ammo.mwm",
                VisualProbability = 1f,
                ShieldHitDraw = false,
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
