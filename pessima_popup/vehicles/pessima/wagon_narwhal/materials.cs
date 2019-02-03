
singleton Material(pessima_wagon_popupsignals_L)
{
   mapTo = "popupsignals_L";
   diffuseColor[0] = "0.24 0.24 0.24 1";
   specular[0] = "1.16414e-010 1.16414e-010 1.16414e-010 1";
   specularPower[0] = "50";
   translucentBlendOp = "None";
};

singleton Material(pessima_wagon_pessima_001)
{
   mapTo = "pessima_001";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "50 50 50 1";
   specularPower[0] = "50";
   translucentBlendOp = "None";
};

singleton Material(pessima_wagon_pessimacoupe_signalflat)
{
   mapTo = "pessima_coupe_signalflat";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "5.8207e-011 5.8207e-011 5.8207e-011 1";
   specularPower[0] = "50";
   translucentBlendOp = "None";
};

singleton Material(pessima_wagon_popupsignals_R)
{
   mapTo = "popupsignals_R";
   diffuseColor[0] = "0.241569 0.241569 0.241569 1";
   specular[0] = "50 50 50 1";
   specularPower[0] = "50";
   translucentBlendOp = "None";
};

singleton Material(pessima_coupe_signalflat)
{
    mapTo = "pessima_coupe_signalflat";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/signalflat_d.dds";
    specularMap[1] = "vehicles/pessima_coupe/lights/signalflat_s.dds";
    //normalMap[1] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    //normalMap[0] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
	specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(signalflat_on)
{
    mapTo = "signalflat_on";
	diffuseMap[2] = "vehicles/pessima_coupe/lights/signalflat_g.dds";
    specularMap[2] = "vehicles/pessima_coupe/lights/signalflat_s.dds";
    normalMap[2] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/signalflat_d.dds";
    specularMap[1] = "vehicles/pessima_coupe/lights/signalflat_s.dds";
    normalMap[1] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
	specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1 1 1 0.15";
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

singleton Material(signalflat_on_intense)
{
    mapTo = "signalflat_on_intense";
	diffuseMap[2] = "vehicles/pessima_coupe/lights/signalflat_g.dds";
    specularMap[2] = "vehicles/pessima_coupe/lights/signalflat_s.dds";
    normalMap[2] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/signalflat_d.dds";
    specularMap[1] = "vehicles/pessima_coupe/lights/signalflat_s.dds";
    normalMap[1] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pessima_coupe/lights/signalflat_n.dds";
	specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1 1 1 0.25";
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

singleton Material(signalflat_dmg)
{
    mapTo = "signalflat_dmg";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/signalflat_dmg_d.dds";
    specularMap[1] = "vehicles/pessima_coupe/lights/signalflat_dmg_s.dds";
    normalMap[1] = "vehicles/pessima_coupe/lights/signalflat_dmg_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pessima_coupe/lights/signalflat_dmg_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
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
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(popupsignals)
{
    mapTo = "popupsignals";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/popupsignals_d.dds";
    specularMap[1] = "vehicles/pessima_coupe/lights/popupsignals_s.dds";
    normalMap[1] = "vehicles/pessima_coupe/lights/popupsignals_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pessima_coupe/lights/popupsignals_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
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
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(popupsignals_on)
{
    mapTo = "popupsignals_on";
    diffuseMap[2] = "vehicles/pessima_coupe/lights/popupsignals_g.dds";
    specularMap[2] = "vehicles/pessima_coupe/lights/popupsignals_s.dds";
    normalMap[2] = "vehicles/pessima_coupe/lights/popupsignals_n.dds";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/popupsignals_d.dds";
    specularMap[1] = "vehicles/pessima_coupe/lights/popupsignals_s.dds";
    normalMap[1] = "vehicles/pessima_coupe/lights/popupsignals_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pessima_coupe/lights/popupsignals_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 0.15";
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

singleton Material(popupsignals_dmg)
{
    mapTo = "popupsignals_dmg";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/popupsignals_dmg_d.dds";
    specularMap[1] = "vehicles/pessima_coupe/lights/popupsignals_dmg_s.dds";
    normalMap[1] = "vehicles/pessima_coupe/lights/popupsignals_dmg_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/pessima_coupe/lights/popupsignals_dmg_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
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
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(popup_lights)
{
    mapTo = "popup_lights";
    diffuseMap[1] = "vehicles/pessima_coupe/lights/signal_plastic_shiny.png";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
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
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe)
{
    mapTo = "coupe";
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