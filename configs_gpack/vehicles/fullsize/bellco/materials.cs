
singleton Material(fullsize_gauges_bellco)
{
    mapTo = "fullsize_gauges_bellco";
    diffuseMap[0] = "vehicles/fullsize/bellco/fullsize_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/bellco/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/bellco/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
};

singleton Material(fullsize_gauges_on_bellco)
{
    mapTo = "fullsize_gauges_on_bellco";
    diffuseMap[1] = "vehicles/fullsize/bellco/fullsize_gauges_g.dds";
    specularMap[1] = "vehicles/fullsize/bellco/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/bellco/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/bellco/fullsize_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/bellco/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/bellco/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "0 1.0 1.25 0.8";
};



singleton Material("fullsize.skin.fbc")
{
    mapTo = "fullsize.skin.fbc";
    colorPaletteMap[2] = "vehicles/fullsize/fullsize_skin_twotone_uv1.dds";
    diffuseMap[2] = "vehicles/fullsize/bellco/fullsize_c_altS.dds";
    specularMap[2] = "vehicles/fullsize/bellco/fullsize_s_altS.dds";
    normalMap[2] = "vehicles/fullsize/fullsize_n.dds";
    diffuseMap[1] = "vehicles/fullsize/bellco/fullsize_d_altS.dds";
    specularMap[1] = "vehicles/fullsize/bellco/fullsize_s_altS.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_n.dds";
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

//ROAD CRUISER


//interior skins

singleton Material("fullsize_interior.skin_interior.raider")
{
    mapTo = "fullsize_interior.skin_interior.raider";
    reflectivityMap[1] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_s.dds";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_d.dds";
    specularMap[1] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_s.dds";
    normalMap[1] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_n.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_s.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_d.dds";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_s.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_interior_n.dds";
    diffuseColor[1] = "0.3 0.3 0.3 1";
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

singleton Material("fullsize_intcarpet.skin_interior.raider")
{
    mapTo = "fullsize_intcarpet.skin_interior.raider";
    diffuseMap[0] = "vehicles/fullsize/fullsize_intcarpet_d.dds";
    diffuseColor[0] = "0.3 0.3 0.3 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_interior.skin_interior.rc")
{
    mapTo = "fullsize_interior.skin_interior.rc";
    reflectivityMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 1";
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

singleton Material("fullsize_intcarpet.skin_interior.rc")
{
    mapTo = "fullsize_intcarpet.skin_interior.rc";
    diffuseMap[0] = "vehicles/fullsize/fullsize_intcarpet_d.dds";
    diffuseColor[0] = "0.5 0.5 0.5 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};


singleton Material("fullsize_interior.skin_interior.redrc")
{
    mapTo = "fullsize_interior.skin_interior.redrc";
    reflectivityMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    diffuseColor[1] = "0.7 0.3 0.33 1";
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

singleton Material("fullsize_intcarpet.skin_interior.redrc")
{
    mapTo = "fullsize_intcarpet.skin_interior.redrc";
    diffuseMap[0] = "vehicles/fullsize/fullsize_intcarpet_d.dds";
    diffuseColor[0] = "0.7 0.3 0.33 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_interior.skin_interior.bluerc")
{
    mapTo = "fullsize_interior.skin_interior.bluerc";
    reflectivityMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    diffuseColor[1] = "0.56 0.675 0.765 1";
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

singleton Material("fullsize_intcarpet.skin_interior.bluerc")
{
    mapTo = "fullsize_intcarpet.skin_interior.bluerc";
    diffuseMap[0] = "vehicles/fullsize/fullsize_intcarpet_d.dds";
    diffuseColor[0] = "0.56 0.675 0.765 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_interior.skin_interior.blackrc")
{
    mapTo = "fullsize_interior.skin_interior.blackrc";
    reflectivityMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    diffuseColor[1] = "0.3 0.3 0.3 1";
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

singleton Material("fullsize_intcarpet.skin_interior.blackrc")
{
    mapTo = "fullsize_intcarpet.skin_interior.blackrc";
    diffuseMap[0] = "vehicles/fullsize/fullsize_intcarpet_d.dds";
    diffuseColor[0] = "0.3 0.3 0.3 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_interior.skin_interior.tanrc")
{
    mapTo = "fullsize_interior.skin_interior.tanrc";
    reflectivityMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_d.dds";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_s.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_interior_n.dds";
    diffuseColor[1] = "0.89 0.76 0.64 1";
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

singleton Material("fullsize_intcarpet.skin_interior.tanrc")
{
    mapTo = "fullsize_intcarpet.skin_interior.tanrc";
    diffuseMap[0] = "vehicles/fullsize/fullsize_intcarpet_d.dds";
    diffuseColor[0] = "0.89 0.76 0.64 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

//lettering

singleton Material(rc_lettering)
{
    mapTo = "rc_lettering";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_gl.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_n_gl.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_d_gl.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_gl.dds";
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

singleton Material(rc_lettering_gls)
{
    mapTo = "rc_lettering_gls";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_gls.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_n_gls.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_d_gls.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_gls.dds";
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

singleton Material(rc_lettering_glx)
{
    mapTo = "rc_lettering_glx";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_glx.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_n_glx.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_d_glx.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_glx.dds";
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

singleton Material(rc_lettering_exe)
{
    mapTo = "rc_lettering_exe";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_exe.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_n_exe.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_d_exe.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_exe.dds";
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

singleton Material(rc_lettering_cla)
{
    mapTo = "rc_lettering_cla";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_cla.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_n_cla.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_d_cla.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_cla.dds";
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

singleton Material(rc_lettering_pol)
{
    mapTo = "rc_lettering_pol";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_pol.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_n_pol.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_d_pol.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_lettering_s_pol.dds";
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

singleton Material(rcS_lettering)
{
    mapTo = "rcS_lettering";
    specularMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_lettering_s.dds";
    normalMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_lettering_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_lettering_d.dds";
    reflectivityMap[0] = "vehicles/fullsize/gparts/roadcruiser/rcS_lettering_s.dds";
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

//skins

singleton Material("fullsize.skin.rc_raider")
{
    mapTo = "fullsize.skin.rc_raider";
    colorPaletteMap[2] = "vehicles/fullsize/gparts/roadcruiser/fullsize_skin_raider_uv1.png";
    overlayMap[2] = "vehicles/fullsize/gparts/roadcruiser/fullsize_skin_raider_overlay.png";
    diffuseMap[2] = "vehicles/fullsize/gparts/roadcruiser/fullsize_c_altS.png";
    specularMap[2] = "vehicles/fullsize/gparts/roadcruiser/fullsize_s_altS.dds";
    normalMap[2] = "vehicles/fullsize/fullsize_n.dds";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/fullsize_d_altS.dds";
    specularMap[1] = "vehicles/fullsize/gparts/roadcruiser/fullsize_s_altS.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_n.dds";
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

//instrument panels

singleton Material("fullsize_gauges.skin_interior.raider")
{
    mapTo = "fullsize_gauges.skin_interior.raider";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/raider_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_gauges_on.skin_interior.raider")
{
    mapTo = "fullsize_gauges_on.skin_interior.raider";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/raider_gauges_d.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/raider_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "3 3 3 1";
};

singleton Material("fullsize_gauges.skin_interior.rc")
{
    mapTo = "fullsize_gauges.skin_interior.rc";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_gauges_on.skin_interior.rc")
{
    mapTo = "fullsize_gauges_on.skin_interior.rc";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 0 0 1";
};

singleton Material("fullsize_gauges.skin_interior.redrc")
{
    mapTo = "fullsize_gauges.skin_interior.redrc";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_gauges_on.skin_interior.redrc")
{
    mapTo = "fullsize_gauges_on.skin_interior.redrc";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 0 0 1";
};

singleton Material("fullsize_gauges.skin_interior.blackrc")
{
    mapTo = "fullsize_gauges.skin_interior.blackrc";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_gauges_on.skin_interior.blackrc")
{
    mapTo = "fullsize_gauges_on.skin_interior.blackrc";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 0 0 1";
};

singleton Material("fullsize_gauges.skin_interior.tanrc")
{
    mapTo = "fullsize_gauges.skin_interior.tanrc";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_gauges_on.skin_interior.tanrc")
{
    mapTo = "fullsize_gauges_on.skin_interior.tanrc";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 0 0 1";
};

singleton Material("fullsize_gauges.skin_interior.bluerc")
{
    mapTo = "fullsize_gauges.skin_interior.bluerc";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_gauges_on.skin_interior.bluerc")
{
    mapTo = "fullsize_gauges_on.skin_interior.bluerc";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 0 0 1";
};

singleton Material("fullsize_gauges.skin_interior.blackrc")
{
    mapTo = "fullsize_gauges.skin_interior.blackrc";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("fullsize_gauges_on.skin_interior.blackrc")
{
    mapTo = "fullsize_gauges_on.skin_interior.blackrc";
    diffuseMap[1] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[1] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[1] = "vehicles/fullsize/fullsize_gauges_n.dds";
    diffuseMap[0] = "vehicles/fullsize/gparts/roadcruiser/rc_gauges_d_on.dds";
    specularMap[0] = "vehicles/fullsize/fullsize_gauges_s.dds";
    normalMap[0] = "vehicles/fullsize/fullsize_gauges_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    diffuseColor[1] = "1.5 0 0 1";
};