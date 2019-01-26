
singleton Material(sbr_gauges_jdm)
{
    mapTo = "sbr_gauges_jdm";
    diffuseMap[0] = "vehicles/sbr/rhd/materials/sbr_gauges_d_jdm.dds";
    specularMap[0] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[0] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
};



singleton Material(sbr_gauges_on_jdm)
{
    mapTo = "sbr_gauges_on_jdm";
    diffuseMap[1] = "vehicles/sbr/rhd/materials/sbr_gauges_g_jdm.dds";
    specularMap[1] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseMap[0] = "vehicles/sbr/rhd/materials/sbr_gauges_d_jdm.dds";
    specularMap[0] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[0] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    specularPower[1] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
    emissive[1] = "1";
    diffuseColor[1] = "1 1 1 0.8";
    useAnisotropic[1] = "1";
};



singleton Material("sbr_gauges_on_jdm.skin_interior.nomi")
{
    mapTo = "sbr_gauges_on_jdm.skin_interior.nomi";
    diffuseMap[1] = "vehicles/sbr/rhd/materials/sbr_gauges_galt.dds";
    specularMap[1] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseMap[0] = "vehicles/sbr/rhd/materials/sbr_gauges_d_jdm.dds";
    specularMap[0] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[0] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    specularPower[1] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
    emissive[1] = "1";
    diffuseColor[1] = "1 1 1 0.8";
    useAnisotropic[1] = "1";
};

singleton Material("sbr.skin.g1")
{
    mapTo = "sbr.skin.g1";
	colorPaletteMap[2] = "vehicles/sbr/gparts/skins/sbr_skin_g1_uv1.dds";
    diffuseMap[2] = "vehicles/sbr/sbr_c.dds";
    specularMap[2] = "vehicles/sbr/sbr_s.dds";
    normalMap[2] = "vehicles/sbr/sbr_n.dds";
    diffuseMap[1] = "vehicles/sbr/sbr_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    specularColor[0] = "1 1 1 1";
    specularColor[1] = "1 1 1 1";
    specularColor[2] = "1 1 1 1";
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
