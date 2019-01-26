
singleton Material(v8_supercharger)
{
    mapTo = "v8_supercharger";
    diffuseMap[1] = "vehicles/common/gparts/superchargers/gavril_v8_d.dds";
    specularMap[1] = "vehicles/common/gparts/superchargers/gavril_v8_s.dds";
    normalMap[1] = "vehicles/common/gparts/superchargers/gavril_v8_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/gparts/superchargers/gavril_v8_n.dds";
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
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(mappu_screen)
{
    mapTo = "mappu_screen";
    diffuseMap[0] = "@mappu_screen";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    emissive[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};