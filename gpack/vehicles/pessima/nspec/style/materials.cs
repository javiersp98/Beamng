
singleton Material("pessima.skin.NSPEC")
{
    mapTo = "pessima.skin.NSPEC";
    colorPaletteMap[2] = "vehicles/pessima/nspec/style/pessima_skin_NSPEC_uv1.dds";
    overlayMap[2] = "vehicles/pessima/nspec/style/pessima_skin_NSPEC.dds";
    diffuseMap[2] = "vehicles/pessima/pessima_c_alt.dds";
    specularMap[2] = "vehicles/pessima/pessima_s_alt.dds";
    normalMap[2] = "vehicles/pessima/pessima_n.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_d_alt.dds";
    specularMap[1] = "vehicles/pessima/pessima_s_alt.dds";
    normalMap[1] = "vehicles/pessima/pessima_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/pessima/pessima_s_alt.dds";
    normalMap[0] = "vehicles/pessima/pessima_n.dds";
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

singleton Material(pessima_interior_N)
{
    mapTo = "pessima_interior_N";
    reflectivityMap[1] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    diffuseMap[1] = "vehicles/pessima/nspec/style/pessima_interior_d_N.dds";
    specularMap[1] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    normalMap[1] = "vehicles/pessima/nspec/style/pessima_interior_n_N.dds";
    reflectivityMap[0] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    diffuseMap[0] = "vehicles/pessima/nspec/style/pessima_interior_d_N.dds";
    specularMap[0] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    normalMap[0] = "vehicles/pessima/nspec/style/pessima_interior_n_N.dds";
    diffuseColor[1] = "0.39 0.41 0.43 1";
    specularPower[1] = "32";
    useAnisotropic[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("pessima_interior.skin_interior.NSPEC")
{
    mapTo = "pessima_interior.skin_interior.NSPEC";
    reflectivityMap[1] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    diffuseMap[1] = "vehicles/pessima/nspec/style/pessima_interior_d_N.dds";
    specularMap[1] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    normalMap[1] = "vehicles/pessima/nspec/style/pessima_interior_n_N.dds";
    reflectivityMap[0] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    diffuseMap[0] = "vehicles/pessima/nspec/style/pessima_interior_d_N.dds";
    specularMap[0] = "vehicles/pessima/nspec/style/pessima_interior_s_N.dds";
    normalMap[0] = "vehicles/pessima/nspec/style/pessima_interior_n_N.dds";
    diffuseColor[1] = "0.39 0.41 0.43 1";
    specularPower[1] = "32";
    useAnisotropic[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("pessima_seats.skin_interior.NSPEC")
{
    mapTo = "pessima_seats.skin_interior.NSPEC";
    diffuseMap[0] = "vehicles/pessima/nspec/style/pessima_seats_d_N.dds";
    specularMap[0] = "vehicles/pessima/pessima_seats_s.dds";
    normalMap[0] = "vehicles/pessima//pessima_seats_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "0.45 0.475 0.5 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("pessima_gauges.skin_interior.NSPEC")
{
    mapTo = "pessima_gauges.skin_interior.NSPEC";
    diffuseMap[0] = "vehicles/pessima/nspec/style/pessima_gauges_d_N.dds";
    specularMap[0] = "vehicles/pessima/pessima_gauges_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_gauges_n.dds";
    specularPower[0] = "64";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "0.75 0.75 0.75 1";
};

singleton Material("pessima_gauges_on.skin_interior.NSPEC")
{
    mapTo = "pessima_gauges_on.skin_interior.NSPEC";
    diffuseMap[1] = "vehicles/pessima/nspec/style/pessima_gauges_g_N.dds";
    specularMap[1] = "vehicles/pessima/pessima_gauges_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_gauges_n.dds";
    diffuseMap[0] = "vehicles/pessima/nspec/style/pessima_gauges_d_N.dds";
    specularMap[0] = "vehicles/pessima/pessima_gauges_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_gauges_n.dds";
    specularPower[0] = "64";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "0.75 0.75 0.75 1";
    diffuseColor[1] = "1 1 1 1";
};

singleton Material(pessima_lettering_N)
{
    mapTo = "pessima_lettering_N";
	specularMap[1] = "vehicles/pessima/nspec/style/pessima_lettering_s_N.dds";
    normalMap[1] = "vehicles/pessima/nspec/style/pessima_lettering_n_N.dds";
    diffuseMap[1] = "vehicles/pessima/nspec/style/pessima_lettering_d_N.dds";
    specularMap[0] = "vehicles/pessima/nspec/style/pessima_lettering_s_N.dds";
    normalMap[0] = "vehicles/pessima/nspec/style/pessima_lettering_n_N.dds";
    diffuseMap[0] = "vehicles/pessima/nspec/style/pessima_lettering_d_N.dds";
    reflectivityMap[0] = "vehicles/pessima/nspec/style/pessima_lettering_s_N.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
	specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    //translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
    //translucentZWrite = "1";
};