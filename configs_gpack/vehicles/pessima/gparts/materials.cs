
singleton Material(pessima_taillightaft)
{
    mapTo = "pessima_taillightaft";
};

singleton Material(pessima_brakelightaft)
{
    mapTo = "pessima_brakelightaft";
};

singleton Material(pessima_lights_on_intenser)
{
    mapTo = "pessima_lights_on_intenser";
    diffuseMap[2] = "vehicles/pessima/pessima_lights_g.dds";
    specularMap[2] = "vehicles/pessima/pessima_lights_s.dds";
    normalMap[2] = "vehicles/pessima/pessima_lights_n.dds";
    diffuseMap[1] = "vehicles/pessima/pessima_lights_d.dds";
    specularMap[1] = "vehicles/pessima/pessima_lights_s.dds";
    normalMap[1] = "vehicles/pessima/pessima_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pessima/pessima_lights_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.75";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    glow[2] = "1";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};