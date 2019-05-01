singleton Material(coupe_ute_bumper_R)
{
    mapTo = "coupe_ute_bumper_R";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_bumper_R_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_bumper_R_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_bumper_R_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.1 0.1 0.1 1.2";
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

singleton Material(coupe_tailgate)
{
    mapTo = "coupe_tailgate";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_color_c.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_color_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_tailgate_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_tailgate_n.dds";
    specularPower[0] = "32";
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
    dynamicCubemap = true;
	instanceDiffuse[1] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_carbonfibre_GTwing)
{
   mapTo = "coupe_carbonfibre_GTwing";
    detailMap[2] = "vehicles/common/carbonfibre.dds";
    diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
	normalMap[1] = "vehicles/coupe/coupe_GTwing_n.dds";
	specularMap[1] = "vehicles/coupe/coupe_GTwing_s.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
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
	detailScale[2] = 1;
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst)
{
   mapTo = "sunburst";
   diffuseMap[2] = "vehicles/sunburst/sunburst_c.dds";
   specularMap[2] = "vehicles/sunburst/sunburst_s.dds";
   normalMap[2] = "vehicles/sunburst/sunburst_n.dds";
   diffuseMap[1] = "vehicles/sunburst/sunburst_d.dds";
   specularMap[1] = "vehicles/sunburst/sunburst_s.dds";
   normalMap[1] = "vehicles/sunburst/sunburst_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/sunburst/sunburst_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   diffuseColor[2] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   instanceDiffuse[2] = true;
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_carbonfibre)
{
   mapTo = "sunburst_carbonfibre";
   diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
   detailMap[1] = "vehicles/common/carbonfibre.dds";
   specularMap[1] = "vehicles/sunburst/sunburst_s.dds";
   normalMap[1] = "vehicles/sunburst/sunburst_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/sunburst/sunburst_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   detailScale[1] = "30";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_carbonfibre_rs)
{
   mapTo = "sunburst_carbonfibre_rs";
   diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
   detailMap[1] = "vehicles/common/carbonfibre.dds";
   specularMap[1] = "vehicles/sunburst/sunburst_s.dds";
   normalMap[1] = "vehicles/sunburst/sunburst_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/sunburst/sunburst_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   detailScale[1] = "100";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_rearpanel_180SX)
{
   mapTo = "coupe_rearpanel_180SX";
   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_d_180SX.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_s.dds";
   normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_n.dds";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_rearpanel_200SX)
{
   mapTo = "coupe_rearpanel_200SX";
   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_d_200SX.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_s.dds";
   normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_n.dds";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_rearpanel_240SX)
{
   mapTo = "coupe_rearpanel_240SX";
   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_d_240SX.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_s.dds";
   normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_n.dds";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_rearpanel_RPS13)
{
   mapTo = "coupe_rearpanel_RPS13";
   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_d_RPS13.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_s.dds";
   normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_rearpanel_n.dds";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_dark)
{
    mapTo = "coupe_lights_dark";
    diffuseMap[1] = "vehicles/coupe/coupe_lights_d.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.3 0 0 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
	diffuseColor[1] = "0.3 0 0 1";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_on_dark)
{
    mapTo = "coupe_lights_on_dark";
    diffuseMap[2] = "vehicles/coupe/coupe_lights_g.dds";
    specularMap[2] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[2] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[1] = "vehicles/coupe/coupe_lights_d.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.5 0.1 0.1 1";
    diffuseColor[2] = "0.5 0.1 0.1 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_on_intense_dark)
{
    mapTo = "coupe_lights_on_intense_dark";
    diffuseMap[2] = "vehicles/coupe/coupe_lights_g.dds";
    specularMap[2] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[2] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[1] = "vehicles/coupe/coupe_lights_d.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.5 0.1 0.1 1";
    diffuseColor[2] = "0.5 0.1 0.1 0.20";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_dmg_dark)
{
    mapTo = "coupe_lights_dmg_dark";
    diffuseMap[1] = "vehicles/coupe/coupe_lights_dmg_d.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_dmg_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_dmg_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_dmg_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.3 0 0 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "0.3 0 0 1";
    cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_sx_taillight)
{
   mapTo = "coupe_sx_taillight";
   diffuseMap[1] = "vehicles/B_13/180sx_taillights.dds";
   specularMap[1] = "vehicles/common/null.dds";
   normalMap[1] = "vehicles/common/null.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/common/null.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   diffuseColor[1] = "1.5 1.5 1.5 1";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_chrome)
{
   mapTo = "coupe_chrome";
   normalMap[0] = "vehicles/coupe/coupe_n.dds";
   diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/Black.dds";
   specularMap[0] = "vehicles/coupe/coupe_s.dds";
   diffuseColor[0] = "1 1 1 1";
   specular[0] = "0.1 0.1 0.1 1";
   specularPower[0] = "10";
   useAnisotropic[0] = "1";
   castShadows = "1";
   translucent = "0";
   translucentBlendOp = "None";
   detailScale[0] = "20";
   alphaTest = "0";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_glass_hood)
{
   mapTo = "coupe_glass_hood";
   reflectivityMap[0] = "vehicles/common/glass_base.dds";
   diffuseMap[0] = "vehicles/coupe/coupe_d.dds";
   specularMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/coupe/coupe_d.dds";
   specularMap[1] = "vehicles/coupe/coupe_d.dds";
   specularPower[0] = "128";
   pixelSpecular[0] = "1";
   specularPower[1] = "128";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 0.75";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "0";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize)
{
    mapTo = "fullsize";
    //diffuseMap[3] = "vehicles/fullsize/fullsize_police.dds";
    //specularMap[3] = "vehicles/fullsize/fullsize_s.dds";
    //normalMap[3] = "vehicles/fullsize/fullsize_n.dds";
    diffuseMap[2] = "vehicles/fullsize/fullsize_c.dds";
    specularMap[2] = "vehicles/fullsize/fullsize_s.dds";
    normalMap[2] = "vehicles/fullsize/fullsize_n.dds";
    diffuseMap[1] = "vehicles/fullsize/fullsize_d.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_n.dds";
    //diffuseMap[3] = "vehicles/fullsize/fullsize_dirt.dds";
    //normalMap[3] = "vehicles/fullsize/fullsize_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 0.95";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    //diffuseColor[3] = "0 0.3 0.9 1";
    //diffuseColor[3] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_black_plastic)
{
   mapTo = "coupe_black_plastic";
    diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
    specularMap[1] = "vehicles/common/null.dds";
	normalMap[1] = "vehicles/coupe/coupe_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
	normalMap[0] = "vehicles/coupe/coupe_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "0.6 0.6 0.6 1.7";
    diffuseColor[1] = "0.6 0.6 0.6 1.7";
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

singleton Material(coupe_custom_color)
{
   mapTo = "coupe_custom_color";
    diffuseMap[1] = "vehicles/common/null2.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_n.dds";
	diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
	normalMap[0] = "vehicles/coupe/coupe_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
	diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1.2";
	useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[1] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_custom_color_2)
{
   mapTo = "coupe_custom_color_2";
    diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
    specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_engine_i6_red)
{
   mapTo = "coupe_engine_i6_red";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_engine_d_red_i6.dds";
    specularMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_engine_s_i6.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_engine_n_i6.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_carbonfibre_2)
{
    mapTo = "coupe_carbonfibre_2";
    detailMap[2] = "vehicles/common/carbonfibre.dds";
    diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
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
	detailScale[2] = 7;
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_carbonfibre_3)
{
    mapTo = "coupe_carbonfibre_3";
    detailMap[2] = "vehicles/common/carbonfibre.dds";
    diffuseMap[1] = "vehicles/common/carbonfibre_d.dds";
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
    diffuseColor[2] = "0.7 0.7 0.7 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
	detailScale[2] = 2;
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_black_2)
{
   mapTo = "coupe_black_2";
   diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
   specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";
   normalMap[2] = "vehicles/coupe/coupe_n.dds";
   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";
   normalMap[1] = "vehicles/coupe/coupe_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/coupe/coupe_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "0 0 0 1";
   diffuseColor[2] = "0 0 0 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(Metal_Black)
{
   mapTo = "Metal_Black";
   diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
   specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";

   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";

   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";

   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "0 0 0 1.3";
   diffuseColor[2] = "0 0 0 1.3";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(Metal)
{
   mapTo = "Metal";
   diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
   specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";

   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_s.dds";

   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";

   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "0.2 0.2 0.2 1.1";
   diffuseColor[2] = "0.2 0.2 0.2 1.1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_sbr)
{
    mapTo = "coupe_sbr";
    diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_c.dds";
    specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_s.dds";
    normalMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
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
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pigeon)
{
    mapTo = "pigeon";
    diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_c.dds";
    specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_s.dds";
    normalMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
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
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pigeon_600)
{
   mapTo = "pigeon_600";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_engine_600_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_engine_600_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_engine_600_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/pigeon_engine_600_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
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
    materialTag0 = "beamng"; materialTag1 = "object";
};

singleton Material(sunburst_seats)
{
    mapTo = "sunburst_seats";
    normalMap[0] = "vehicles/sunburst/sunburst_seats_n.dds";
    diffuseMap[0] = "vehicles/sunburst/sunburst_seats_d.dds";
    specularMap[0] = "vehicles/sunburst/sunburst_seats_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "16";
    specularPower[1] = "16";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_interior)
{
    mapTo = "sunburst_interior";
    normalMap[0] = "vehicles/sunburst/sunburst_interior_n.dds";
    diffuseMap[0] = "vehicles/sunburst/sunburst_interior_d.dds";
    specularMap[0] = "vehicles/sunburst/sunburst_interior_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "16";
    specularPower[1] = "16";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_glass)
{
    mapTo = "sunburst_glass";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/sunburst/sunburst_glass_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/sunburst/sunburst_glass_da.dds";
    specularMap[1] = "vehicles/sunburst/sunburst_glass_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_glass_int)
{
    mapTo = "sunburst_glass_int";
    diffuseMap[0] = "vehicles/sunburst/sunburst_glass_d.dds";
    specularMap[0] = "vehicles/sunburst/sunburst_glass_s.dds";
    diffuseMap[1] = "vehicles/sunburst/sunburst_glass_da.dds";
    specularMap[1] = "vehicles/sunburst/sunburst_glass_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_glass_dmg)
{
    mapTo = "sunburst_glass_dmg";
    diffuseMap[0] = "vehicles/sunburst/sunburst_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/sunburst/sunburst_glass_dmg_da.dds";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "32";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sunburst_seats)
{
    mapTo = "sunburst_seats";
    normalMap[0] = "vehicles/sunburst/sunburst_seats_n.dds";
    diffuseMap[0] = "vehicles/sunburst/sunburst_seats_d.dds";
    specularMap[0] = "vehicles/sunburst/sunburst_seats_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "16";
    specularPower[1] = "16";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_ute_bed)
{
   mapTo = "coupe_ute_bed";
   diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/color_c.dds";
   specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pickup_s.dds";
   normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/pickup_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/pickup_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "0.1 0.1 0.1 1.2";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(moonhawk)
{
    mapTo = "moonhawk";
    //black out the chrome
    /*
    diffuseMap[3] = "vehicles/moonhawk/moonhawk_chrome.dds";
    specularMap[3] = "vehicles/moonhawk/moonhawk_s.dds";
    normalMap[3] = "vehicles/moonhawk/moonhawk_n.dds";
    specularColor[3] = "0.2 0.2 0.2 0.2";
    diffuseColor[3] = "0.1 0.1 0.1 1.2";
    */

    diffuseMap[2] = "vehicles/moonhawk/moonhawk_c.dds";
    specularMap[2] = "vehicles/moonhawk/moonhawk_s.dds";
    normalMap[2] = "vehicles/moonhawk/moonhawk_n.dds";
    diffuseMap[1] = "vehicles/moonhawk/moonhawk_d.dds";
    specularMap[1] = "vehicles/moonhawk/moonhawk_s.dds";
    normalMap[1] = "vehicles/moonhawk/moonhawk_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/moonhawk/moonhawk_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
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
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(moonhawk_drag)
{
    mapTo = "moonhawk_drag";
    diffuseMap[1] = "vehicles/moonhawk/moonhawk_drag_d.dds";
    specularMap[1] = "vehicles/moonhawk/moonhawk_drag_d.dds";
    normalMap[1] = "vehicles/moonhawk/moonhawk_drag_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/moonhawk/moonhawk_drag_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
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

singleton Material(sbr_engine)
{
    mapTo = "sbr_engine";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_engine_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_engine_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_engine_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_engine_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
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
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr)
{
    mapTo = "sbr";
    diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_c.dds";
    specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_s.dds";
    normalMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
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
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(moonhawk_engines)
{
    mapTo = "moonhawk_engines";
    diffuseMap[1] = "vehicles/moonhawk/moonhawk_engines_d.dds";
    specularMap[1] = "vehicles/moonhawk/moonhawk_engines_s.dds";
    normalMap[1] = "vehicles/moonhawk/moonhawk_engines_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/moonhawk/moonhawk_engines_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
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

singleton Material(van_seats)
{
    mapTo = "van_seats";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/van_seats_d.dds";
    specularMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/van_seats_s.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/van_seats_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
};

singleton Material(coupe_custom_lettering)
{
   mapTo = "coupe_custom_lettering";
    specularMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_custom_lettering_s.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_custom_lettering_n.dds";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_custom_lettering_d.dds";
    reflectivityMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_custom_lettering_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    //translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
    //translucentZWrite = "1";
};

singleton Material(fullsize_signal_L)
{
    mapTo = "fullsize_signal_L";
};

singleton Material(fullsize_signal_R)
{
    mapTo = "fullsize_signal_R";
};

singleton Material(fullsize_headlight)
{
    mapTo = "fullsize_headlight";
};

singleton Material(fullsize_parkinglight)
{
    mapTo = "fullsize_parkinglight";
};

singleton Material(fullsize_lights_on)
{
    mapTo = "fullsize_lights_on";
    diffuseMap[2] = "vehicles/fullsize/fullsize_lights_g.dds";
    specularMap[2] = "vehicles/fullsize/fullsize_lights_s.dds";
    normalMap[2] = "vehicles/fullsize/fullsize_lights_n.dds";
    diffuseMap[1] = "vehicles/fullsize/fullsize_lights_d.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_lights_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_lights_n.dds";
    //diffuseMap[3] = "vehicles/fullsize/fullsize_lights_dirt.dds";
    //normalMap[3] = "vehicles/fullsize/fullsize_lights_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    //diffuseColor[3] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[2] = "1";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_lights_on_intense)
{
    mapTo = "fullsize_lights_on_intense";
    diffuseMap[2] = "vehicles/fullsize/fullsize_lights_g.dds";
    specularMap[2] = "vehicles/fullsize/fullsize_lights_s.dds";
    normalMap[2] = "vehicles/fullsize/fullsize_lights_n.dds";
    diffuseMap[1] = "vehicles/fullsize/fullsize_lights_d.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_lights_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_lights_n.dds";
    //diffuseMap[3] = "vehicles/fullsize/fullsize_lights_dirt.dds";
    //normalMap[3] = "vehicles/fullsize/fullsize_lights_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.20";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    //diffuseColor[3] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[2] = "1";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_lights_dmg)
{
    mapTo = "fullsize_lights_dmg";
    diffuseMap[1] = "vehicles/fullsize/fullsize_lights_dmg_d.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_lights_dmg_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_lights_dmg_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_lights_dmg_n.dds";
    //diffuseMap[2] = "vehicles/fullsize/fullsize_lights_dirt.dds";
    //normalMap[2] = "vehicles/fullsize/fullsize_lights_dmg_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    //diffuseColor[2] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_lights)
{
    mapTo = "fullsize_lights";
    diffuseMap[1] = "vehicles/fullsize/fullsize_lights_d.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_lights_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_lights_n.dds";
    //diffuseMap[2] = "vehicles/fullsize/fullsize_lights_dirt.dds";
    //normalMap[2] = "vehicles/fullsize/fullsize_lights_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    //diffuseColor[2] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_glass)
{
    mapTo = "fullsize_glass";
    diffuseMap[0] = "vehicles/fullsize/fullsize_glass_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_glass_s.dds";
    diffuseMap[1] = "vehicles/fullsize/fullsize_glass_da.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_glass_s.dds";
    specularPower[0] = "128";
   pixelSpecular[0] = "1";
   specularPower[1] = "128";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "0";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_fullsize_glass_dmg)
{
    mapTo = "coupe_fullsize_glass_dmg";
    diffuseMap[0] = "vehicles/fullsize/fullsize_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/fullsize/fullsize_glass_dmg_da.dds";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "32";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(hatch_interior)
{
    mapTo = "hatch_interior";
    diffuseMap[0] = "vehicles/hatch/hatch_interior_d.dds";
    normalMap[0] = "vehicles/hatch/hatch_interior_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    specularMap[0] = "hatch_interior_s.dds";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "0.8 0.8 0.8 1";
};

singleton Material(coupe_lights_new)
{
    mapTo = "coupe_lights_new";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_custom_d.png";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_new_on)
{
    mapTo = "coupe_lights_new_on";
    diffuseMap[2] = "vehicles/coupe/coupe_lights_g.dds";
    specularMap[2] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[2] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_custom_d.png";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_new_on_intense)
{
    mapTo = "coupe_lights_new_on_intense";
    diffuseMap[2] = "vehicles/coupe/coupe_lights_g.dds";
    specularMap[2] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[2] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_custom_d.png";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.20";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_new_dmg)
{
    mapTo = "coupe_lights_new_dmg";
    diffuseMap[1] = "vehicles/coupe/coupe_lights_dmg_d.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_dmg_s.dds";
    normalMap[1] = "vehicles/coupe/coupe_lights_dmg_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/coupe_lights_dmg_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_sbr_seats)
{
    mapTo = "coupe_sbr_seats";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_seats_n.dds";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_seats_d.dds";
    specularMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/sbr_seats_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(super)
{
    mapTo = "super";
    diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/super_c.dds";
    specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/super_s.dds";
    normalMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/super_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/super_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/super_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/super_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/super_n.dds";
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
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_ute_glass)
{
    mapTo = "coupe_ute_glass";
	 reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_d.png";
    opacityMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_d.png";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_da.png";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_ute_glass_int)
{
    mapTo = "coupe_ute_glass_int";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_d.png";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    doubleSided = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_ute_glass_dmg)
{
    mapTo = "coupe_ute_glass_dmg";
	diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dmg_d.png";
    opacityMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dmg_d.png";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dmg_d.png";
    specularMap[1] = "vehicles/common/glass_dmg_s.dds";
    normalMap[1] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "128";
    specularPower[1] = "128";
    diffuseColor[0] = "1 1 1 1.5";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_ute_glass_dark)
{
    mapTo = "coupe_ute_glass_dark";
	
	reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_d.png";
    opacityMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_d.png";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dark_da.png";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_ute_glass_dark_int)
{
    mapTo = "coupe_ute_glass_dark_int";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_d.png";
    opacityMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_d.png";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dark_int_da.png";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_ute_glass_dmg_dark)
{
    mapTo = "coupe_ute_glass_dmg_dark";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dmg_d.png";
    opacityMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dmg_d.png";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_ute_rearwindowglass_dmg_d.png";
    specularMap[1] = "vehicles/common/glass_dmg_s.dds";
    normalMap[1] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "128";
    specularPower[1] = "128";
    diffuseColor[0] = "1 1 1 1.5";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_glass_int_dark)
{
    mapTo = "coupe_glass_int_dark";
    diffuseMap[0] = "vehicles/coupe/coupe_glass_d.dds";
    specularMap[0] = "vehicles/coupe/coupe_glass_s.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_glass_dark_int_da.dds";
    specularMap[1] = "vehicles/coupe/coupe_glass_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    doubleSided = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_glass_dark)
{
    mapTo = "coupe_glass_dark";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/coupe/coupe_glass_d.dds";
    specularMap[0] = "vehicles/coupe/coupe_glass_s.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_glass_dark_da.png";
    specularMap[1] = "vehicles/coupe/coupe_glass_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_glass_dmg_dark)
{
    mapTo = "coupe_glass_dmg_dark";
    diffuseMap[0] = "vehicles/coupe/coupe_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_glass_dmg_dark_da.png";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "32";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_windshield_dmg_dark)
{
    mapTo = "coupe_windshield_dmg_dark";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/coupe/coupe_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_glass_dmg_dark_da.png";
    normalMap[0] = "vehicles/common/windshield_dmg_n.dds";
    specularPower[0] = "32";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_headlightlens_yellow)
{
    mapTo = "coupe_headlightlens_yellow";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_yellow_d.png";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[0] = "vehicles/coupe/coupe_lights_s.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_yellow_d.png";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "1";
    alphaRef = "40";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_headlightlens_off_yellow)
{
    mapTo = "coupe_headlightlens_off_yellow";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_yellow_d.png";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[0] = "vehicles/coupe/coupe_lights_s.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_yellow_d.png";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "1";
    alphaRef = "40";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_headlightlens_on_yellow)
{
    mapTo = "coupe_headlightlens_on_yellow";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_yellow_d.png";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[0] = "vehicles/coupe/coupe_lights_s.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_yellow_d.png";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    emissive[0] = "1";
    emissive[1] = "1";
    emissive[2] = "1";
    castShadows = "0";
    translucent = "1";
	translucentBlendOp = "addAlpha";
    alphaTest = "1";
    alphaRef = "40";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_headlightlens_dmg_yellow)
{
    mapTo = "coupe_headlightlens_dmg_yellow";
    diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_dmg_yellow_d.png";
    normalMap[0] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[0] = "vehicles/coupe/coupe_lights_s.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_dmg_yellow_d.png";
    normalMap[1] = "vehicles/coupe/coupe_lights_n.dds";
    specularMap[1] = "vehicles/coupe/coupe_lights_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "1";
    alphaRef = "40";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(boostgauge)
{
   mapTo = "boostgauge";
	diffuseMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/Boost_gauge.png";
    diffuseColor[0] = "1 1 1 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   translucentBlendOp = "1";
   alphaTest = "1";
   alphaRef = "0";
   translucent = "1";
};

singleton Material(coupe_lights_ute)
{
    mapTo = "coupe_lights_ute";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
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
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_ute_on)
{
    mapTo = "coupe_lights_ute_on";
    diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_g.dds";
    specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_s.dds";
    normalMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_ute_on_intense)
{
    mapTo = "coupe_lights_ute_on_intense";
    diffuseMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_g.dds";
    specularMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_s.dds";
    normalMap[2] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.20";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    glow[0] = "0";
    glow[1] = "0";
    glow[2] = "1";
    emissive[0] = "0";
    emissive[1] = "0";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(coupe_lights_ute_dmg)
{
    mapTo = "coupe_lights_ute_dmg";
    diffuseMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_dmg_d.dds";
    specularMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_dmg_s.dds";
    normalMap[1] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_dmg_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/coupe/DTroxx_Parts/Materials/coupe_lights_ute_dmg_n.dds";
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
    diffuseColor[1] = "1.5 1.5 1.5 1";
    cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};