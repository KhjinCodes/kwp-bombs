namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // naming convention: WeaponDefinition Name
            //
            // Enable your definitions using the follow syntax:
            // PartDefinitions(Your1stDefinition, Your2ndDefinition, Your3rdDefinition);
            // PartDefinitions includes both weapons and phantoms
            PartDefinitions(
                // G.P Bombs             
                KJN_KWP_BMB_an_m30A1_100lb_Weapon,
                KJN_KWP_BMB_an_m57A1_250lb_Weapon,
                KJN_KWP_BMB_an_m64A1_500lb_Weapon,
                KJN_KWP_BMB_an_m65A1_1000lb_Weapon,
                KJN_KWP_BMB_an_m66A1_2000lb_Weapon,
                // A.P Bombs
                KJN_KWP_BMB_pc1000_1000kg_Weapon,
                KJN_KWP_BMB_pc1600_1600kg_Weapon);
            // ArmorDefinitions(Armor1, Armor2);
            // SupportDefinitions(ArmorEnhancer1A);
            // UpgradeDefinitions(Upgrade75a, Upgrade75b);
        }
    }
}
