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
        private AmmoDef KJN_KWP_BMB_PenShrapnel_Ammo => new AmmoDef // Your ID, for slotting into the Weapon CS
        {
            AmmoMagazine = "",
            AmmoRound = "KJN_KWP_BMB_PenShrapnel_Ammo",
            BaseDamage = 2600f,
            BaseDamageCutoff = 0,
            Mass = 200f,
            Health = 0,
            BackKickForce = 0f,
            HardPointUsable = false,
            HybridRound = false,
            IgnoreWater = false,
            IgnoreVoxels = false,
            NpcSafe = false,
            NoGridOrArmorScaling = false,
            
            ObjectsHit = new ObjectsHitDef
            {
                MaxObjectsHit = 0,
                CountBlocks = false,
            },
            Fragment = new FragmentDef
            {
                AmmoRound = "",
                Fragments = 0,
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
                MaxIntegrity = 2500f,
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
                    Large = 1.5f,
                    Small = 0.6461f,
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
                    AreaEffect = Kinetic,
                    Detonation = Kinetic,
                    Shield = Kinetic,
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
                    Enable = true,
                    Radius = 0.5f,
                    Damage = 2600f,
                    Depth = 0f,
                    MaxAbsorb = 0f,
                    Falloff = Pooled,
                    Shape = Diamond,
                },
                EndOfLife = new EndOfLifeDef
                {
                    Enable = true,
                    Radius = 0.5f,
                    Damage = 400f,
                    Depth = 0,
                    MaxAbsorb = 400f,
                    Falloff = Pooled,
                    ArmOnlyOnHit = false,
                    MinArmingTime = 0,
                    NoVisuals = true,
                    NoSound = true,
                    ParticleScale = 1,
                    CustomParticle = "",
                    CustomSound = "",
                    Shape = Diamond,
                },
            },
            Trajectory = new TrajectoryDef
            {
                Guidance = None,
                GravityMultiplier = 1f,
                DesiredSpeed = 100f, // Muzzle Velocity m/s
                AccelPerSec = 0f,
                MaxLifeTime = 180,
                MaxTrajectory = 25,
                RangeVariance = Random(start: 0, end: 7),
            },
            AmmoGraphics = new GraphicDef
            {
                VisualProbability = 1f,
                Lines = new LineDef
                {
                    Tracer = new TracerBaseDef
                    {
                        Enable = true,
                        Length = 10f,
                        Width = 0.1f,
                        Color = Color(red: 20, green: 5, blue: 5f, alpha: 1),
                        Textures = new[] {"ProjectileTrailLine",},
                    },
                },
            },
            AmmoAudio = new AmmoAudioDef
            {
                TravelSound = "", // SubtypeID for your Sound File. Travel, is sound generated around your Projectile in flight
                HitSound = "WepPlayRifleImpMetal",
                ShotSound = "",
                ShieldHitSound = "WepPlayRifleImpMetal",
                PlayerHitSound = "WepPlayRifleImpGlass",
                VoxelHitSound = "WepPlayRifleImpSoil",
                FloatingHitSound = "",
                HitPlayChance = 1f,
                HitPlayShield = true,
            },
        };
    }
}
