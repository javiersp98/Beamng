
singleton Material(pessima)
{
    mapTo = "pessima";
    diffuseMap[2] = "vehicles/pessima/pessima_c.dds";
    specularMap[2] = "vehicles/pessima/pessima_s.dds";
    normalMap[2] = "vehicles/pessima/pessima_n.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_d.dds";
    specularMap[1] = "vehicles/pessima/pessima_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/pessima/pessima_s.dds";
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

singleton Material("pessima_interior.skin_interior.nspec")
{
    mapTo = "pessima_interior.skin_interior.nspec";
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

singleton Material("hatch.skin.nspec")
{
    mapTo = "hatch.skin.nspec";
	colorPaletteMap[2] = "vehicles/hatch/nspec/looks/hatch_skin_NSPEC_uv1.dds";
    overlayMap[2] = "vehicles/hatch/nspec/looks/hatch_skin_NSPEC.dds";
    diffuseMap[2] = "vehicles/hatch/hatch_c_alt.dds";
    specularMap[2] = "vehicles/hatch/hatch_s_alt.dds";
    normalMap[2] = "vehicles/hatch/hatch_n.dds";
    diffuseMap[1] = "vehicles/hatch/hatch_d_alt.dds";
    specularMap[1] = "vehicles/hatch/hatch_s_alt.dds";
    normalMap[1] = "vehicles/hatch/hatch_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/hatch/hatch_n.dds";
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

singleton Material("hatch_gauges.skin_interior.nspec")
{
    mapTo = "hatch_gauges.skin_interior.nspec";
    diffuseMap[0] = "vehicles/hatch/nspec/looks/hatch_gauges_d_N.dds";
    specularMap[0] = "vehicles/hatch/hatch_gauges_s.dds";
    normalMap[0] = "vehicles/hatch/hatch_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "0.75 0.75 0.75 1";
};

singleton Material("hatch_gauges_on.skin_interior.nspec")
{
    mapTo = "hatch_gauges_on.skin_interior.nspec";
    diffuseMap[1] = "vehicles/hatch/nspec/looks/hatch_gauges_g_N.dds";
    specularMap[1] = "vehicles/hatch/hatch_gauges_s.dds";
    normalMap[1] = "vehicles/hatch/hatch_gauges_n.dds";
    diffuseMap[0] = "vehicles/hatch/nspec/looks/hatch_gauges_d_N.dds";
    specularMap[0] = "vehicles/hatch/hatch_gauges_s.dds";
    normalMap[0] = "vehicles/hatch/hatch_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "0.75 0.75 0.75 1";
    diffuseColor[1] = "0.5 1.7 1.3 1";
};



singleton Material("pessima_interior.skin_interior.brown")
{
    mapTo = "pessima_interior.skin_interior.brown";
    reflectivityMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_interior_n.dds";
    reflectivityMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[0] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_interior_n.dds";
    diffuseColor[1] = "0.80 0.645 0.53 1";
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

singleton Material("pessima_interior.skin_interior.black")
{
    mapTo = "pessima_interior.skin_interior.black";
    reflectivityMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_interior_n.dds";
    reflectivityMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[0] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_interior_n.dds";
    diffuseColor[1] = "0.25 0.26 0.27 1";
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

singleton Material("pessima_interior.skin_interior.blue")
{
    mapTo = "pessima_interior.skin_interior.blue";
    reflectivityMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_interior_n.dds";
    reflectivityMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[0] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_interior_n.dds";
    diffuseColor[1] = "0.24 0.32 0.41 1";
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

singleton Material("pessima_interior.skin_interior.red")
{
    mapTo = "pessima_interior.skin_interior.red";
    reflectivityMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_interior_n.dds";
    reflectivityMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[0] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_interior_n.dds";
    diffuseColor[1] = "0.51 0.255 0.265 1";
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

singleton Material(pessima_interior)
{
    mapTo = "pessima_interior";
    reflectivityMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[1] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_interior_n.dds";
    reflectivityMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    diffuseMap[0] = "vehicles/pessima/pessima_interior_d.dds";
    specularMap[0] = "vehicles/pessima/pessima_interior_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_interior_n.dds";
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

singleton Material("hatch.skin.zxi_2")
{
    mapTo = "hatch.skin.zxi_2";
	colorPaletteMap[2] = "vehicles/hatch/gparts/skins/hatch_skin_zxi_uv1.png";
    diffuseMap[2] = "vehicles/hatch/hatch_c_alt.dds";
    specularMap[2] = "vehicles/hatch/hatch_s_alt.dds";
    normalMap[2] = "vehicles/hatch/hatch_n.dds";
    diffuseMap[1] = "vehicles/hatch/hatch_d_alt.dds";
    specularMap[1] = "vehicles/hatch/hatch_s_alt.dds";
    normalMap[1] = "vehicles/hatch/hatch_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/hatch/hatch_n.dds";
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
