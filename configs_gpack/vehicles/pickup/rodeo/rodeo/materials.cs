
singleton Material("pickup.skin.rodeo")
{
    mapTo = "pickup.skin.rodeo";
    colorPaletteMap[2] = "vehicles/pickup/rodeo/rodeo/pickup_skin_rodeo_uv1.dds";
	overlayMap[2] = "vehicles/pickup/rodeo/rodeo/pickup_skin_rodeo.dds";
    diffuseMap[2] = "vehicles/common/pickup/pickup_c.dds";
    specularMap[2] = "vehicles/common/pickup/pickup_s.dds";
    normalMap[2] = "vehicles/common/pickup/pickup_n.dds";
    diffuseMap[1] = "vehicles/common/pickup/pickup_d.dds";
    specularMap[1] = "vehicles/common/pickup/pickup_s.dds";
    normalMap[1] = "vehicles/common/pickup/pickup_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/pickup/pickup_n.dds";
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

singleton Material(pickup_rodeo)
{
    mapTo = "pickup_rodeo";
    diffuseMap[2] = "vehicles/common/pickup/pickup_c.dds";
    specularMap[2] = "vehicles/pickup/rodeo/rodeo/rodeo_s.dds";
    normalMap[2] = "vehicles/common/pickup/pickup_n.dds";
    diffuseMap[1] = "vehicles/pickup/rodeo/rodeo/rodeo_d.dds";
    specularMap[1] = "vehicles/pickup/rodeo/rodeo/rodeo_s.dds";
    normalMap[1] = "vehicles/common/pickup/pickup_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/pickup/pickup_n.dds";
    //diffuseMap[3] = "vehicles/common/pickup/pickup_dirt.dds";
    //normalMap[3] = "vehicles/common/pickup/pickup_n.dds";
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
    //diffuseColor[3] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(rodeo_grille)
{
    mapTo = "rodeo_grille";
    diffuseMap[2] = "vehicles/pickup/rodeo/rodeo/rodeo_grille_c.dds";
    specularMap[2] = "vehicles/pickup/rodeo/rodeo/rodeo_grille_s.dds";
    normalMap[2] = "vehicles/pickup/rodeo/rodeo/rodeo_grille_n.dds";
    diffuseMap[1] = "vehicles/pickup/rodeo/rodeo/rodeo_grille_d.dds";
    specularMap[1] = "vehicles/pickup/rodeo/rodeo/rodeo_grille_s.dds";
    normalMap[1] = "vehicles/pickup/rodeo/rodeo/rodeo_grille_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pickup/rodeo/rodeo/rodeo_grille_n.dds";
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


singleton Material(rodeo_badge)
{
    mapTo = "rodeo_badge";
    specularMap[0] = "vehicles/pickup/rodeo/rodeo/rodeo_lettering_s.dds";
    normalMap[0] = "vehicles/pickup/rodeo/rodeo/rodeo_lettering_n.dds";
    diffuseMap[0] = "vehicles/pickup/rodeo/rodeo/rodeo_lettering_d.dds";
    reflectivityMap[0] = "vehicles/pickup/rodeo/rodeo/rodeo_lettering_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    //translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
    //translucentZWrite = "1";
};

