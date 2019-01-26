

singleton Material(coupe_lettering_PF)
{
    mapTo = "coupe_lettering_PF";
    specularMap[1] = "vehicles/coupe/PF/lettering/PF_lettering_s.dds";
    normalMap[1] = "vehicles/coupe/PF/lettering/PF_lettering_n.dds";
    diffuseMap[1] = "vehicles/coupe/PF/lettering/PF_lettering_d.dds";
    specularMap[0] = "vehicles/coupe/PF/lettering/PF_lettering_s.dds";
    normalMap[0] = "vehicles/coupe/PF/lettering/PF_lettering_n.dds";
    diffuseMap[0] = "vehicles/coupe/PF/lettering/PF_lettering_d.dds";
    reflectivityMap[0] = "vehicles/coupe/PF/lettering/PF_lettering_s.dds";
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

singleton Material(coupe_ktrp)
{
    mapTo = "coupe_ktrp";
    diffuseMap[2] = "vehicles/coupe/coupe_c.dds";
    specularMap[2] = "vehicles/coupe/coupe_s.dds";
    normalMap[2] = "vehicles/coupe/coupe_n.dds";
    diffuseMap[1] = "vehicles/coupe/coupe_d.dds";
    specularMap[1] = "vehicles/coupe/coupe_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_n.dds";
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

singleton Material(coupe_ktrp_bc)
{
    mapTo = "coupe_ktrp_bc";
    diffuseMap[2] = "vehicles/coupe/coupe_c_alt.dds";
    specularMap[2] = "vehicles/coupe/coupe_s.dds";
    normalMap[2] = "vehicles/coupe/coupe_n.dds";
    diffuseMap[1] = "vehicles/coupe/coupe_d_alt.dds";
    specularMap[1] = "vehicles/coupe/coupe_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_n.dds";
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