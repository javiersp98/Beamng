
singleton Material("pessima_interior.skin_interior.gtz")
{
    mapTo = "pessima_interior.skin_interior.gtz";
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

singleton Material("pessima_seats.skin_interior.gtz")
{
    mapTo = "pessima_seats.skin_interior.gtz";
    diffuseMap[0] = "vehicles/pessima/pessima_seats_d.dds";
    specularMap[0] = "vehicles/pessima/pessima_seats_s.dds";
    normalMap[0] = "vehicles/pessima/pessima_seats_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "0.2 0.2 0.2 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};