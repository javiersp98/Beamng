
singleton Material(autobello_fartcan_)
{
    mapTo = "autobello_fartcan_";
	reflectivityMap[0] = "vehicles/autobello/fartcan/fartcan_r.dds";
    diffuseMap[0] = "vehicles/autobello/fartcan/autobello_fartcan_d.dds";
    normalMap[0] = "vehicles/autobello/fartcan/fartcan_n.dds";
    useAnisotropic[0] = "1";
   specular[0] = "1 1 1 1";
   specularPower[0] = "50";
    dynamicCubemap = true;
   translucentBlendOp = "None";
};

singleton Material(autobello_spoilerr)
{
    mapTo = "autobello_spoilerr";
    diffuseMap[2] = "vehicles/autobello/c.dds";
    normalMap[2] = "vehicles/autobello/spoiler_n.dds";
    diffuseMap[1] = "vehicles/autobello/d.dds";
    normalMap[1] = "vehicles/autobello/spoiler_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/autobello/spoiler_n.dds";
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

singleton Material(autobello_engine_ohv)
{
    mapTo = "autobello_engine_ohv";
	reflectivityMap[0] = "vehicles/autobello/engine_ohv_r.dds";
    diffuseMap[0] = "vehicles/autobello/engine_ohv_d.dds";
    normalMap[0] = "vehicles/autobello/engine_ohv_n.dds";
	specularMap[0] = "vehicles/autobello/engine_ohv_s.dds";
    useAnisotropic[0] = "1";
   specular[0] = "1 1 1 1";
   specularPower[0] = "50";
    dynamicCubemap = true;
   translucentBlendOp = "None";
};

singleton Material(ab_tc4b)
{
    mapTo = "ab_tc4b";
	reflectivityMap[0] = "vehicles/autobello/tc4b_r.dds";
    diffuseMap[0] = "vehicles/autobello/tc4b_d.dds";
    normalMap[0] = "vehicles/autobello/tc4b_n.dds";
	specularMap[0] = "vehicles/autobello/tc4b_s.dds";
    useAnisotropic[0] = "1";
   specular[0] = "1 1 1 1";
   specularPower[0] = "50";
    dynamicCubemap = true;
   translucentBlendOp = "None";
};
