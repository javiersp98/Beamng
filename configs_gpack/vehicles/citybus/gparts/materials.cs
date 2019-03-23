
singleton Material(citybus_cape_earth)
{
    mapTo = "citybus_cape_earth";
    diffuseMap[0] = "vehicles/citybus/gparts/cape/citybus_cape_earth.dds";
    specularMap[0] = "vehicles/citybus/citybus_cape_s.dds";
    normalMap[0] = "vehicles/citybus/citybus_cape_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
    dynamicCubemap = true;
};

singleton Material("citybus.skin.bisd")
{
    mapTo = "citybus.skin.bisd";
    OverlayMap[2] = "vehicles/citybus/gparts/skins/citybus_skin_fisd.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_c.dds";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    normalMap[2] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_d.dds";
    specularMap[1] = "vehicles/citybus/citybus_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/citybus/citybus_n.dds";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
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