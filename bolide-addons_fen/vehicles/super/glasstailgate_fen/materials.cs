singleton Material(glass_tailgate_fen)
{
    mapTo = "glass_tailgate_fen";
    reflectivityMap[0] = "vehicles/common/glass_base.png";
    diffuseMap[0] = "vehicles/super/glasstailgate_fen/super_glass_d_fen.png";
    opacityMap[0] = "vehicles/super/glasstailgate_fen/super_glass_d_fen.png";
    diffuseMap[1] = "vehicles/super/glasstailgate_fen/super_glass_da_fen.png";
    specularMap[0] = "vehicles/common/null.png";
    normalMap[0] = "vehicles/common/null_n.png";
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

singleton Material(glass_tailgate_int_fen)
{
    mapTo = "glass_tailgate_int_fen";
    diffuseMap[0] = "vehicles/super/glasstailgate_fen/super_glass_d_fen.png";
    specularMap[0] = "vehicles/common/null.png";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    doubleSided = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(super_tailgate_fen_dmg)
{
    mapTo = "super_tailgate_fen_dmg";
    diffuseMap[0] = "vehicles/super/glasstailgate_fen/super_glass_dmg_d_fen.png";
    opacityMap[0] = "vehicles/super/glasstailgate_fen/super_glass_dmg_d_fen.png";
    specularMap[0] = "vehicles/common/glass_dmg_s.png";
    normalMap[0] = "vehicles/common/glass_dmg_n.png";
    diffuseMap[1] = "vehicles/super/glasstailgate_fen/super_glass_dmg_d_fen.png";
    specularMap[1] = "vehicles/common/glass_dmg_s.png";
    normalMap[1] = "vehicles/common/glass_dmg_n.png";
    specularPower[0] = "128";
    specularPower[1] = "128";
    diffuseColor[0] = "1 1 1 1.5";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};