singleton Material(pickup_van)
{
    mapTo = "pickup_van";
    diffuseMap[2] = "vehicles/common/pickup/pickup_c.dds";
    specularMap[2] = "vehicles/common/pickup/pickup_s.dds";
    normalMap[2] = "vehicles/common/pickup/pickup_n.dds";
    diffuseMap[1] = "vehicles/common/pickup/pickup_d.dds";
    specularMap[1] = "vehicles/common/pickup/pickup_s.dds";
    normalMap[1] = "vehicles/common/pickup/pickup_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/pickup/pickup_n.dds";
    //diffuseMap[3] = "vehicles/common/pickup/pickup_dirt.dds";
    //normalMap[3] = "vehicles/common/pickup/pickup_n.dds";
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
    //diffuseColor[3] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(van_semi_frame)
{
    mapTo = "semi_frame";
    diffuseMap[1] = "vehicles/semi/semi_frame_d.dds";
    specularMap[1] = "vehicles/semi/semi_frame_s.dds";
    normalMap[1] = "vehicles/semi/semi_frame_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/semi/semi_frame_n.dds";
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
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(vanL)
{
    mapTo = "vanL";
    diffuseMap[2] = "vehicles/van/van_c.dds";
    specularMap[2] = "vehicles/van/van_s.dds";
    normalMap[2] = "vehicles/van/van_n.dds";
    diffuseMap[1] = "vehicles/van/van_d.dds";
    specularMap[1] = "vehicles/van/van_s.dds";
    normalMap[1] = "vehicles/van/van_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/van/van_n.dds";
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

singleton Material(van_spotlight)
{
   mapTo = "van_spotlight";
};

singleton Material(van_foglight)
{
   mapTo = "van_foglight";
};



singleton Material(van_decals_ar162b)
{
    mapTo = "van_decals_ar162b";
    diffuseMap[1] = "vehicles/van/van_decals_Gavril.png";
    specularMap[1] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "0 0 0 0";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    //translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
    translucentZWrite = "1";
};




singleton Material(van_moonhawk_engines_AR162b)
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
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(van_semi_engine)
{
   mapTo = "semi_engine";
   diffuseMap[1] = "vehicles/semi/semi_engine_d.dds";
   specularMap[1] = "vehicles/semi/semi_engine_s.dds";
   normalMap[1] = "vehicles/semi/semi_engine_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/semi/semi_engine_n.dds";
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
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(van_haybale)
{
    mapTo = "haybale";
    diffuseMap[0] = "vehicles/haybale/haybale_d.dds";
    specularMap[0] = "vehicles/haybale/haybale_s.dds";
    normalMap[0] = "vehicles/haybale/haybale_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "64";
    materialTag0 = "beamng"; materialTag1 = "object";
};

singleton Material(van_haybale2)
{
    mapTo = "haybale2";
    diffuseMap[0] = "vehicles/haybale/haybale2_d.dds";
    specularMap[0] = "vehicles/haybale/haybale_s.dds";
    normalMap[0] = "vehicles/haybale/haybale_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "64";
    //subSurface[0] = "1";
    //subSurfaceColor[0] = "0.996078 0.992157 0.992157 1";
    //subSurfaceRolloff[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "object";
};

singleton Material(van_haybale3)
{
    mapTo = "haybale3";
    diffuseMap[0] = "vehicles/haybale/haybale3_d.dds";
    specularMap[0] = "vehicles/haybale/haybale_s.dds";
    normalMap[0] = "vehicles/haybale/haybale_n.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "64";
    subSurface[0] = "1";
    subSurfaceColor[0] = "0.996078 0.992157 0.992157 1";
    subSurfaceRolloff[0] = "0.4";
    materialTag0 = "beamng"; materialTag1 = "object";
    doubleSided = "1";
};

singleton Material(van_glass_chrome)
{
    mapTo = "van_glass_chrome";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/van/van_glass_d.dds";
    specularMap[0] = "vehicles/van/van_glass_s.dds";
    diffuseMap[1] = "vehicles/van/van_glass_da.dds";
    specularMap[1] = "vehicles/van/van_glass_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "2 2 2 0.4";
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

singleton Material(van_glass_dmg_chrome)
{
    mapTo = "van_glass_dmg_chrome";
    diffuseMap[0] = "vehicles/van/van_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/van/van_glass_da.dds";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "32";
    diffuseColor[0] = "1.5 1.5 1.5 0.4";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(van_barstow_interior)
{
    mapTo = "barstow_interior";
    diffuseMap[1] = "vehicles/barstow/barstow_interior_d.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[1] = "vehicles/barstow/barstow_interior_s.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/barstow/barstow_interior_n.dds";
    normalMap[1] = "vehicles/barstow/barstow_interior_n.dds";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    useAnisotropic[1] = "1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
    diffuseColor[0] = "1 1 1 1";
    specular[0] = "0.2 0.2 0.2 1";
    specular[1] = "0.2 0.2 0.2 1";
};
singleton Material(van_barstow_stitches)
{
    mapTo = "barstow_stitches";
    diffuseMap[0] = "vehicles/barstow/barstow_stitches_d.dds";
	specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
	alphaTest = "1";
    alphaRef = "50";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 0.8";
	specular[0] = "0.2 0.2 0.2 1";
};
singleton Material(van_barstow_seats)
{
    mapTo = "barstow_seats";
    diffuseMap[1] = "vehicles/barstow/barstow_seats_d.dds";
    specularMap[1] = "vehicles/barstow/barstow_seats_s.dds";
    normalMap[1] = "vehicles/barstow/barstow_seats_n.dds";
	diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/barstow/barstow_seats_s.dds";
    normalMap[0] = "vehicles/barstow/barstow_seats_n.dds";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    useAnisotropic[1] = "1";
	specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
	cubemap = "global_cubemap_metalblurred";
    diffuseColor[0] = "1 1 1 1";
};
singleton Material(van_barstow_gauges)
{
    mapTo = "barstow_gauges";
    diffuseMap[0] = "vehicles/barstow/barstow_gauges_d.dds";
    specularMap[0] = "vehicles/barstow/barstow_gauges_s.dds";
    normalMap[0] = "vehicles/barstow/barstow_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
};
singleton Material(barstow_gauges_on)
{
    mapTo = "barstow_gauges_on";
    diffuseMap[1] = "vehicles/barstow/barstow_gauges_d.dds";
    specularMap[1] = "vehicles/barstow/barstow_gauges_s.dds";
    normalMap[1] = "vehicles/barstow/barstow_gauges_n.dds";
    diffuseMap[0] = "vehicles/barstow/barstow_gauges_d.dds";
    specularMap[0] = "vehicles/barstow/barstow_gauges_s.dds";
    normalMap[0] = "vehicles/barstow/barstow_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "0 2 1.3 0.5";
};

singleton Material(van_barstow)
{
   mapTo = "barstow";
    diffuseMap[2] = "vehicles/barstow/barstow_c.dds";
    specularMap[2] = "vehicles/barstow/barstow_s.dds";
    normalMap[2] = "vehicles/barstow/barstow_n.dds";
    diffuseMap[1] = "vehicles/barstow/barstow_d.dds";
    specularMap[1] = "vehicles/barstow/barstow_s.dds";
    normalMap[1] = "vehicles/barstow/barstow_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/barstow/barstow_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
     specular[0] = "0.2 0.2 0.2 1";
    specular[1] = "0.2 0.2 0.2 1";
    specular[2] = "0.2 0.2 0.2 1";
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

singleton Material(snorkeltube_black)
{
    mapTo = "snorkeltube_black";
    diffuseMap[1] = "vehicles/common/null.dds";
    specularMap[1] = "vehicles/common/null.dds";
    normalMap[1] = "vehicles/common/null_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "0.1 0.1 0.1 0.9";
    diffuseColor[1] = "0.1 0.1 0.1 0.9";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};



singleton Material(van_metal_box)
{
    mapTo = "metal_box";
    diffuseMap[1] = "vehicles/metal_box/metal_box_D.dds";
    specularMap[1] = "vehicles/metal_box/metal_box_S.dds";
    normalMap[1] = "vehicles/metal_box/metal_box_N.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/metal_box/metal_box_N.dds";
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

singleton Material(van_metal_box_decals)
{
    mapTo = "metal_box_decals";
    diffuseMap[1] = "vehicles/metal_box/metal_box_decals.dds";
    specularMap[1] = "vehicles/common/null.dds";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "0 0 0 0";
    diffuseColor[1] = "1 1 1 0.6";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
    translucentZWrite = "1";
};



singleton Material(barstow_engine_v8)
{
    mapTo = "barstow_engine_v8";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/barstow/barstow_engine_v8_d.dds";
    normalMap[1] = "vehicles/barstow/barstow_engine_v8_n.dds";
    normalMap[0] = "vehicles/barstow/barstow_engine_v8_n.dds";
    specularMap[1] = "vehicles/barstow/barstow_engine_v8_s.png";
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
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(van_ambu_roof_AR162B)
{
    mapTo = "van_ambu_roof_AR162B";
    diffuseMap[2] = "vehicles/van/van_materials_AR162b/van_ambu_AR162B_roof_C.dds";
    specularColor[2] = "0.02 0.02 0.02 1";
    normalMap[2] = "vehicles/van/van_materials_AR162b/van_ambu_AR162B_roof_N.dds";
    diffuseMap[1] = "vehicles/van/van_materials_AR162b/van_ambu_AR162B_roof_D.dds";
    specularColor[1] = "0.02 0.02 0.02 1";
    normalMap[1] = "vehicles/van/van_materials_AR162b/van_ambu_AR162B_roof_N.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/van/van_materials_AR162b/van_ambu_AR162B_roof_N.dds";
    //diffuseMap[3] = "vehicles/common/pickup/pickup_dirt.dds";
    //normalMap[3] = "vehicles/common/pickup/pickup_n.dds";
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

