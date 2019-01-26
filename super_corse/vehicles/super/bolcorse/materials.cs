
singleton Material(engtex_crs)
{
    mapTo = "engtex_crs";
    diffuseMap[1] = "vehicles/super/bolcorse/eng_d.dds";
    specularMap[1] = "vehicles/super/bolcorse/eng_s.dds";
    normalMap[1] = "vehicles/super/bolcorse/eng_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/super/bolcorse/eng_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("super.skin.corserace")
{
    mapTo = "super.skin.corserace";
    colorPaletteMap[2] = "vehicles/super/bolcorse/corse_skin_race_palette_uv1.dds";
    overlayMap[2] = "vehicles/super/bolcorse/corse_skin_race.dds";
    diffuseMap[2] = "vehicles/super/super_c.dds";
    specularMap[2] = "vehicles/super/super_s.dds";
    normalMap[2] = "vehicles/super/super_n.dds";
    diffuseMap[1] = "vehicles/super/super_d.dds";
    specularMap[1] = "vehicles/super/super_s.dds";
    normalMap[1] = "vehicles/super/super_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/super/super_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("super.skin.corsegt")
{
    mapTo = "super.skin.corsegt";
    colorPaletteMap[2] = "vehicles/super/bolcorse/corse_skin_gt_palette_uv1.dds";
    overlayMap[2] = "vehicles/super/bolcorse/corse_skin_gt.dds";
    diffuseMap[2] = "vehicles/super/super_c.dds";
    specularMap[2] = "vehicles/super/super_s.dds";
    normalMap[2] = "vehicles/super/super_n.dds";
    diffuseMap[1] = "vehicles/super/super_d.dds";
    specularMap[1] = "vehicles/super/super_s.dds";
    normalMap[1] = "vehicles/super/super_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/super/super_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(super_glass_yellow)
{
    mapTo = "super_glass_yellow";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/super/bolcorse/super_glass_yellow_d.dds";
    opacityMap[0] = "vehicles/super/bolcorse/super_glass_yellow_d.dds";
    diffuseMap[1] = "vehicles/super/super_glass_da.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};
