//Maya ASCII 2020 scene
//Name: Door_Lock.ma
//Last modified: Tue, Oct 11, 2022 01:08:48 AM
//Codeset: 1252
requires maya "2020";
requires "mtoa" "4.0.0";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2020";
fileInfo "version" "2020";
fileInfo "cutIdentifier" "202004291615-7bd99f0972";
fileInfo "osv" "Microsoft Windows 10 Technical Preview  (Build 19044)\n";
fileInfo "UUID" "264902D4-4B98-9D9A-0BB7-12BA4C01F455";
createNode transform -s -n "persp";
	rename -uid "B09F77B3-4A28-6FE8-ECF3-62BB183FD1F9";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 6.3636815726576499 5.5445478820527958 -3.228324086290677 ;
	setAttr ".r" -type "double3" -30.938352729635788 -248.19999999975664 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "2CA4C7E3-4257-605B-8BB0-7E86BBCEE154";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 8.7496984618741696;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".tp" -type "double3" 0.13572663068771362 1.5725569128990173 2.262487585982015 ;
	setAttr ".hc" -type "string" "viewSet -p %camera";
	setAttr ".ai_translator" -type "string" "perspective";
createNode transform -s -n "top";
	rename -uid "B7EBD12C-4695-4322-1B44-B28AC4DA577F";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 1000.1 0 ;
	setAttr ".r" -type "double3" -90 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "D92A97D7-4B40-94E3-D41E-51AFF5CF4928";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "front";
	rename -uid "25DDE4BD-4BCB-8AE6-53E4-05A3CC9456FC";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "57DE057B-479D-9602-11F6-C7BFBB6680C4";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "side";
	rename -uid "D669AF19-439E-0407-72F7-4E95FA930C9C";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.100461184949 0.96882581077279117 -0.029443418920101883 ;
	setAttr ".r" -type "double3" 0 90 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "E97598F6-4482-E445-2AA1-7BA8B4B9FA61";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.0807442664806;
	setAttr ".ow" 13.743372157705183;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".tp" -type "double3" 0.019716918468475342 1.5725568630557225 0 ;
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -n "pCube1";
	rename -uid "75F2B8E6-49E5-F6BE-BA4F-0284E58F4A41";
	setAttr ".t" -type "double3" 0 1.5725568034510777 0 ;
createNode transform -n "transform3" -p "pCube1";
	rename -uid "B81FBCD5-4011-70FB-4FF3-C8BF12373E25";
	setAttr ".v" no;
createNode mesh -n "pCubeShape1" -p "transform3";
	rename -uid "CCBAF83D-4A23-AB1A-9BC4-9694CE7E5726";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr -s 2 ".iog[0].og";
	setAttr -av ".iog[0].og[0].gid";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.33412925829179585 0.67018236219882965 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".dr" 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCylinder1";
	rename -uid "552189F2-499E-3802-4A4D-40AF6AEE20A1";
	setAttr ".t" -type "double3" 0.28704921467916716 0.9048034713591232 -0.0059607509881939441 ;
	setAttr ".r" -type "double3" 0 0 90 ;
	setAttr ".s" -type "double3" 0.26395373673848693 0.082194948379453847 0.26395373673848693 ;
createNode transform -n "transform2" -p "pCylinder1";
	rename -uid "9A915D5F-477B-396C-5859-C0AB793B057F";
	setAttr ".v" no;
createNode mesh -n "pCylinderShape1" -p "transform2";
	rename -uid "AD2C8EC6-4AAC-6E56-AC6A-C2A79354CEE0";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr -s 2 ".iog[0].og";
	setAttr -av ".iog[0].og[0].gid";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.82920113074942492 0.70432186126708984 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 85 ".pt";
	setAttr ".pt[21]" -type "float3" -0.07257475 0 0.022517925 ;
	setAttr ".pt[22]" -type "float3" -0.062694259 0 0.043035071 ;
	setAttr ".pt[23]" -type "float3" -0.047205176 0 0.059728347 ;
	setAttr ".pt[24]" -type "float3" -0.027483791 0 0.071114503 ;
	setAttr ".pt[25]" -type "float3" -0.0052824062 0 0.076181822 ;
	setAttr ".pt[26]" -type "float3" 0.017426161 0 0.074480079 ;
	setAttr ".pt[27]" -type "float3" 0.038624328 0 0.066160403 ;
	setAttr ".pt[28]" -type "float3" 0.05642844 0 0.051962115 ;
	setAttr ".pt[29]" -type "float3" 0.069256499 0 0.033146773 ;
	setAttr ".pt[30]" -type "float3" 0.075968795 0 0.011386183 ;
	setAttr ".pt[31]" -type "float3" 0.075968809 0 -0.011386114 ;
	setAttr ".pt[32]" -type "float3" 0.069256574 0 -0.033146705 ;
	setAttr ".pt[33]" -type "float3" 0.056428459 0 -0.051962089 ;
	setAttr ".pt[34]" -type "float3" 0.038624395 0 -0.066160403 ;
	setAttr ".pt[35]" -type "float3" 0.017426256 0 -0.074480034 ;
	setAttr ".pt[36]" -type "float3" -0.0052824062 0 -0.076181822 ;
	setAttr ".pt[37]" -type "float3" -0.027483745 0 -0.071114503 ;
	setAttr ".pt[38]" -type "float3" -0.047205139 0 -0.059728362 ;
	setAttr ".pt[39]" -type "float3" -0.062694259 0 -0.043035086 ;
	setAttr ".pt[40]" -type "float3" -0.07257475 0 -0.02251794 ;
	setAttr ".pt[41]" -type "float3" -0.075968809 0 1.2608473e-08 ;
	setAttr ".pt[106]" -type "float3" 0 0.26650077 1.8626451e-09 ;
	setAttr ".pt[107]" -type "float3" 2.9802322e-08 0.26650077 2.6077032e-08 ;
	setAttr ".pt[108]" -type "float3" -1.4551915e-10 0.26650077 -5.3290705e-15 ;
	setAttr ".pt[109]" -type "float3" -1.8626451e-08 0.26650077 -2.9802322e-08 ;
	setAttr ".pt[110]" -type "float3" 1.4901161e-08 0.26650077 0 ;
	setAttr ".pt[111]" -type "float3" -9.3132257e-10 0.26650077 0 ;
	setAttr ".pt[112]" -type "float3" -7.4505806e-09 0.26650077 -7.4505806e-09 ;
	setAttr ".pt[113]" -type "float3" 0 0.26650077 -5.2154064e-08 ;
	setAttr ".pt[114]" -type "float3" 2.2351742e-08 0.26650077 2.9802322e-08 ;
	setAttr ".pt[115]" -type "float3" 2.9802322e-08 0.26650077 1.1175871e-08 ;
	setAttr ".pt[116]" -type "float3" -2.2351742e-08 0.26650077 -4.6566129e-09 ;
	setAttr ".pt[117]" -type "float3" -2.2351742e-08 0.26650077 -3.7252903e-09 ;
	setAttr ".pt[118]" -type "float3" 2.9802322e-08 0.26650077 1.4901161e-08 ;
	setAttr ".pt[119]" -type "float3" -2.9802322e-08 0.26650077 -3.7252903e-09 ;
	setAttr ".pt[120]" -type "float3" 1.8626451e-08 0.26650077 0 ;
	setAttr ".pt[121]" -type "float3" -1.8626451e-09 0.26650077 -2.9802322e-08 ;
	setAttr ".pt[122]" -type "float3" 9.3132257e-10 0.26650077 0 ;
	setAttr ".pt[123]" -type "float3" 1.4901161e-08 0.26650077 2.2351742e-08 ;
	setAttr ".pt[124]" -type "float3" 7.4505806e-09 0.26650077 1.4901161e-08 ;
	setAttr ".pt[125]" -type "float3" 2.9802322e-08 0.26650077 -2.6077032e-08 ;
	setAttr ".pt[126]" -type "float3" 0 0.26650077 1.1175871e-08 ;
	setAttr ".pt[127]" -type "float3" 2.2351742e-08 0.26650077 -8.8817842e-15 ;
	setAttr ".pt[128]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[129]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[130]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[131]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[132]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[133]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[134]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[135]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[136]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[137]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[138]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[139]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[140]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[141]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[142]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[143]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[144]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[145]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[146]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[147]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[148]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[149]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[150]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[151]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[152]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[153]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[154]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[155]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[156]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[157]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[158]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[159]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[160]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[161]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[162]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[163]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[164]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[165]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[166]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[167]" -type "float3" 0 0.09244138 0 ;
	setAttr ".pt[168]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[169]" -type "float3" 0 0.09244138 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pCube2";
	rename -uid "FD13BCFE-4769-145D-808E-D9B89B4C46EE";
	setAttr ".t" -type "double3" 0.46607264095027701 0.91350367569437818 -0.5030095128111356 ;
	setAttr ".s" -type "double3" 0.11076148131912873 0.20570634104161961 0.40756087793055501 ;
	setAttr ".rp" -type "double3" 0 0 0.50317483976346644 ;
	setAttr ".sp" -type "double3" 0 0 1.2346004413338296 ;
	setAttr ".spt" -type "double3" 0 0 -0.73142560157035519 ;
createNode transform -n "transform1" -p "pCube2";
	rename -uid "AAD6FD39-4D2D-D35E-1DFD-CDA6A4CB28EC";
	setAttr ".v" no;
createNode mesh -n "pCubeShape2" -p "transform1";
	rename -uid "4B20DD27-4D86-A283-2488-5BA24FB4E407";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr -s 2 ".iog[0].og";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.78621372580528259 0.2034994950518012 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "Lock";
	rename -uid "BF778F70-4BDD-82C6-410B-7E964C9A7DE2";
	setAttr ".rp" -type "double3" 0.13572663798973067 1.5725568630557225 -0.33633742069720829 ;
	setAttr ".sp" -type "double3" 0.13572663798973067 1.5725568630557225 -0.33633742069720829 ;
createNode mesh -n "LockShape" -p "Lock";
	rename -uid "0C7609DE-498D-4F0D-708D-F483E40A53DF";
	setAttr -k off ".v";
	setAttr -s 2 ".iog[0].og";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.95513772964477539 0.14726626873016357 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 37 ".pt";
	setAttr ".pt[75]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[114]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[146]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[147]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[148]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[149]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[150]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[151]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[152]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[153]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[154]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[155]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[156]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[157]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[158]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[159]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[160]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[161]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".pt[447]" -type "float3" 1.7695129e-08 0 -7.4505806e-09 ;
	setAttr ".pt[448]" -type "float3" 1.7695129e-08 0 -7.4505806e-09 ;
	setAttr ".pt[449]" -type "float3" 1.7695129e-08 0 -7.4505806e-09 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "823AF44F-4440-28C5-5612-BF87135AABB1";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "C662B3D9-424A-DA3D-8242-F89BD9CAE398";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "A61D0E43-4AE3-8DA6-58AC-0383C4C64EC6";
createNode displayLayerManager -n "layerManager";
	rename -uid "7A81BC9E-4DDD-445F-2C92-3F93629FECA7";
createNode displayLayer -n "defaultLayer";
	rename -uid "5E15291A-4AF3-15CC-E36B-8697AA39E9BF";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "A7681BAC-4B41-9CA4-36AF-B5A629E09587";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "313E1E18-41EB-AAB6-687C-039452F7ADB5";
	setAttr ".g" yes;
createNode polyCube -n "polyCube1";
	rename -uid "E96BBB35-43FA-69DD-1716-EFB7BBB76CCB";
	setAttr ".w" 0.5;
	setAttr ".h" 2.5;
	setAttr ".cuv" 4;
createNode polyBevel3 -n "polyBevel1";
	rename -uid "8F4DAC1A-4C46-620F-FC7C-789D98C97C3C";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[2]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.74721731823154003 0 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 0.1;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyBevel3 -n "polyBevel2";
	rename -uid "1F4B374E-4167-AF96-52A0-DBA63C0DCFF1";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[1]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.74721731823154003 0 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 0.1;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyBevel3 -n "polyBevel3";
	rename -uid "7838F56B-403F-CE77-63DC-059B6CD1FB52";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:1]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0.74721731823154003 0 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 0.1;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyTweak -n "polyTweak1";
	rename -uid "0720A25B-4867-AAA4-7053-E6849D98FC0C";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk";
	setAttr ".tk[1]" -type "float3" 0 0 -0.024997253 ;
	setAttr ".tk[3]" -type "float3" 0 0 -0.024997253 ;
	setAttr ".tk[4]" -type "float3" 0 0 0.014999335 ;
	setAttr ".tk[6]" -type "float3" 0 0 0.014999335 ;
	setAttr ".tk[8]" -type "float3" 0 0 -0.024997253 ;
	setAttr ".tk[10]" -type "float3" 0 0 -0.024997253 ;
	setAttr ".tk[13]" -type "float3" 0 0 0.024997253 ;
	setAttr ".tk[15]" -type "float3" 0 0 0.024997253 ;
createNode polySplit -n "polySplit1";
	rename -uid "C26AEF26-4427-1F2F-5296-528957DA60C8";
	setAttr -s 2 ".e[0:1]"  0 0;
	setAttr -s 2 ".d[0:1]"  -2147483647 -2147483631;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit2";
	rename -uid "4DBEA400-44E2-21D7-33F1-8BB0F4033D6C";
	setAttr -s 2 ".e[0:1]"  1 1;
	setAttr -s 2 ".d[0:1]"  -2147483641 -2147483632;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit3";
	rename -uid "78A166E5-44ED-922D-E920-AE824AAE4092";
	setAttr -s 2 ".e[0:1]"  1 0;
	setAttr -s 2 ".d[0:1]"  -2147483645 -2147483630;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit4";
	rename -uid "3E77050A-4741-58CD-E688-27A32C05658B";
	setAttr -s 2 ".e[0:1]"  0 0;
	setAttr -s 2 ".d[0:1]"  -2147483640 -2147483633;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode script -n "uiConfigurationScriptNode";
	rename -uid "9F784D24-4784-4478-44F1-18AEC2764D5F";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $nodeEditorPanelVisible = stringArrayContains(\"nodeEditorPanel1\", `getPanel -vis`);\n\tint    $nodeEditorWorkspaceControlOpen = (`workspaceControl -exists nodeEditorPanel1Window` && `workspaceControl -q -visible nodeEditorPanel1Window`);\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\n\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n"
		+ "            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n"
		+ "            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n"
		+ "            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n"
		+ "            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n"
		+ "            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n"
		+ "            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n"
		+ "            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n"
		+ "            -wireframeOnShaded 1\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n"
		+ "            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n"
		+ "            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1319\n            -height 651\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"ToggledOutliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"ToggledOutliner\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -docTag \"isolOutln_fromSeln\" \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n"
		+ "            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -isSet 0\n            -isSetMember 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            -renderFilterIndex 0\n            -selectionOrder \"chronological\" \n"
		+ "            -expandAttribute 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 0\n            -showReferenceMembers 0\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n"
		+ "            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n"
		+ "            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n"
		+ "                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n"
		+ "                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayValues 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showPlayRangeShades \"on\" \n                -lockPlayRangeShades \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n"
		+ "                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -valueLinesToggle 0\n                -highlightAffectedCurves 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n"
		+ "                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n"
		+ "                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayValues 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n"
		+ "                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"timeEditorPanel\" (localizedPanelLabel(\"Time Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Time Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayValues 0\n                -snapTime \"none\" \n"
		+ "                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayValues 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n"
		+ "                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n"
		+ "\tif ($nodeEditorPanelVisible || $nodeEditorWorkspaceControlOpen) {\n\t\tif (\"\" == $panelName) {\n\t\t\tif ($useSceneConfig) {\n\t\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n"
		+ "                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\t}\n\t\t} else {\n\t\t\t$label = `panel -q -label $panelName`;\n\t\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n"
		+ "                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\tif (!$useSceneConfig) {\n\t\t\t\tpanel -e -l $label $panelName;\n\t\t\t}\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"shapePanel\" (localizedPanelLabel(\"Shape Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tshapePanel -edit -l (localizedPanelLabel(\"Shape Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"posePanel\" (localizedPanelLabel(\"Pose Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tposePanel -edit -l (localizedPanelLabel(\"Pose Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"contentBrowserPanel\" (localizedPanelLabel(\"Content Browser\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Content Browser\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-userCreated false\n\t\t\t\t-defaultImage \"vacantCell.xP:/\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 1\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1319\\n    -height 651\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 1\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1319\\n    -height 651\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 120 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "464595AA-415C-74B1-3587-61A04D4B4AA6";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
createNode polySplit -n "polySplit5";
	rename -uid "82178271-4826-6A0F-5084-E5909858F658";
	setAttr -s 9 ".e[0:8]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5;
	setAttr -s 9 ".d[0:8]"  -2147483648 -2147483646 -2147483622 -2147483621 -2147483634 -2147483636 
		-2147483623 -2147483624 -2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit6";
	rename -uid "36362494-4B2B-B1B9-BD99-10A5C58D498E";
	setAttr -s 9 ".e[0:8]"  0.25 0.25 0.25 0.25 0.75 0.75 0.25 0.25 0.25;
	setAttr -s 9 ".d[0:8]"  -2147483648 -2147483646 -2147483622 -2147483621 -2147483616 -2147483615 
		-2147483623 -2147483624 -2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak2";
	rename -uid "A8A12352-47FC-9E6F-871B-C186A9AC0CD5";
	setAttr ".uopa" yes;
	setAttr -s 16 ".tk";
	setAttr ".tk[1]" -type "float3" 0 0 -2.3969187e-07 ;
	setAttr ".tk[3]" -type "float3" 0 0 -2.3969187e-07 ;
	setAttr ".tk[4]" -type "float3" 0 0 1.6286207e-07 ;
	setAttr ".tk[6]" -type "float3" 0 0 1.6286207e-07 ;
	setAttr ".tk[8]" -type "float3" 0 0 -2.3969187e-07 ;
	setAttr ".tk[10]" -type "float3" 0 0 -2.3969187e-07 ;
	setAttr ".tk[13]" -type "float3" 0 0 2.3969187e-07 ;
	setAttr ".tk[15]" -type "float3" 0 0 2.3969187e-07 ;
	setAttr ".tk[16]" -type "float3" 0 -0.95816177 0 ;
	setAttr ".tk[17]" -type "float3" 0 -0.95816177 0 ;
	setAttr ".tk[18]" -type "float3" 0 -0.98315895 0 ;
	setAttr ".tk[19]" -type "float3" 0 -0.98315895 0 ;
	setAttr ".tk[20]" -type "float3" 0 -0.96316063 0 ;
	setAttr ".tk[21]" -type "float3" 0 -0.96316063 0 ;
	setAttr ".tk[22]" -type "float3" 0 -0.98315895 0 ;
	setAttr ".tk[23]" -type "float3" 0 -0.98315895 0 ;
createNode polySplit -n "polySplit7";
	rename -uid "47EC8AE0-4CA4-37BA-E928-3183730E588E";
	setAttr -s 9 ".e[0:8]"  0.33333299 0.33333299 0.33333299 0.33333299
		 0.66666698 0.66666698 0.33333299 0.33333299 0.33333299;
	setAttr -s 9 ".d[0:8]"  -2147483604 -2147483603 -2147483602 -2147483601 -2147483616 -2147483615 
		-2147483598 -2147483597 -2147483604;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit8";
	rename -uid "D28A2CC5-4DAB-7860-A5B6-BF90BC348163";
	setAttr -s 9 ".e[0:8]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5;
	setAttr -s 9 ".d[0:8]"  -2147483588 -2147483587 -2147483586 -2147483585 -2147483616 -2147483615 
		-2147483582 -2147483581 -2147483588;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyBevel3 -n "polyBevel4";
	rename -uid "51AD3D56-4E43-01C1-BDF3-1F83D1CC6493";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[*]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 1;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyTweak -n "polyTweak3";
	rename -uid "0A0E5918-41F0-6E39-0C5A-7997584CFB72";
	setAttr ".uopa" yes;
	setAttr -s 24 ".tk[24:47]" -type "float3"  0 0.40924093 0 0 0.40924093
		 0 0 0.33424908 0 0 0.33424908 0 0 0.40174243 0 0 0.40174243 0 0 0.33424908 0 0 0.33424908
		 0 0 0.51261091 0 0 0.51261091 0 0 0.46261626 0 0 0.46261626 0 0 0.50761193 0 0 0.50761193
		 0 0 0.46261626 0 0 0.46261626 0 0 0.084916636 0 0 0.084916636 0 0 0.059919089 0 0
		 0.059919089 0 0 0.082417056 0 0 0.082417056 0 0 0.059919089 0 0 0.059919089 0;
createNode polyTweakUV -n "polyTweakUV1";
	rename -uid "ADAB286F-4EDB-B01E-6E96-0F9AE346CC3F";
	setAttr ".uopa" yes;
	setAttr -s 9 ".uvtk";
	setAttr ".uvtk[16]" -type "float2" 2.9903262e-05 8.3025507e-06 ;
	setAttr ".uvtk[17]" -type "float2" 0.00024083127 0.00039881427 ;
	setAttr ".uvtk[32]" -type "float2" 1.5568989e-05 -1.0930547e-05 ;
	setAttr ".uvtk[185]" -type "float2" -0.00010959283 -0.00055366918 ;
	setAttr ".uvtk[186]" -type "float2" -0.00045627236 -0.00031598835 ;
	setAttr ".uvtk[189]" -type "float2" 0.00010400308 -0.0004977599 ;
	setAttr ".uvtk[215]" -type "float2" -2.8775421e-06 -0.0001913756 ;
	setAttr ".uvtk[218]" -type "float2" 0.00052735145 0.0010142492 ;
	setAttr ".uvtk[223]" -type "float2" 0.0005456247 -0.0011045574 ;
createNode polyMergeVert -n "polyMergeVert1";
	rename -uid "F4429832-4422-4707-1A13-728BA8B7CD1D";
	setAttr ".ics" -type "componentList" 3 "vtx[12]" "vtx[18]" "vtx[32]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak4";
	rename -uid "7A09FD9D-4D85-E69C-AD08-B7B22C157950";
	setAttr ".uopa" yes;
	setAttr ".tk[12]" -type "float3"  0 -0.00090050697 0.0027387142;
createNode polyTweakUV -n "polyTweakUV2";
	rename -uid "0B653DA1-4438-2181-A3BE-D69799DE8A2A";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[19]" -type "float2" -0.00012867987 0.001764223 ;
	setAttr ".uvtk[21]" -type "float2" -1.5758218e-05 9.2739838e-06 ;
	setAttr ".uvtk[79]" -type "float2" 4.0367911e-05 0.0015282176 ;
	setAttr ".uvtk[195]" -type "float2" -9.5692913e-06 0.0016500637 ;
	setAttr ".uvtk[197]" -type "float2" 0.00026995633 0.0015873723 ;
	setAttr ".uvtk[214]" -type "float2" -1.577436e-05 0.00041585791 ;
createNode polyMergeVert -n "polyMergeVert2";
	rename -uid "DD3892F7-4121-188C-7DE6-75AD03B6157B";
	setAttr ".ics" -type "componentList" 4 "vtx[14]" "vtx[80]" "vtx[83]" "vtx[135]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak5";
	rename -uid "FC06970B-40DC-8AE0-D027-4ABEFD599236";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[14]" -type "float3" 0 0 0.0010901988 ;
	setAttr ".tk[135]" -type "float3" 0 0 -0.001090169 ;
createNode polyTweakUV -n "polyTweakUV3";
	rename -uid "FC43B577-4856-3114-9419-4A8DC15F5CCE";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[111]" -type "float2" -0.00017290901 0.00054137851 ;
	setAttr ".uvtk[112]" -type "float2" -8.3000486e-06 0.00052092352 ;
	setAttr ".uvtk[118]" -type "float2" 3.9619295e-05 0.00053395802 ;
	setAttr ".uvtk[122]" -type "float2" 0.00034027631 0.0006616051 ;
	setAttr ".uvtk[234]" -type "float2" 8.2786726e-05 -0.00067348633 ;
createNode polyMergeVert -n "polyMergeVert3";
	rename -uid "6DF38B64-460A-47CE-A262-3BBAA16540C2";
	setAttr ".ics" -type "componentList" 4 "vtx[125]" "vtx[128]" "vtx[133]" "vtx[166]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak6";
	rename -uid "ED3203D1-4A6C-AA65-886A-FF97BD67CBFD";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[125]" -type "float3" 0 0 0.0010902286 ;
	setAttr ".tk[166]" -type "float3" 0 0 -0.001090169 ;
createNode polyTweakUV -n "polyTweakUV4";
	rename -uid "DF5B4144-44F4-9BBB-FEF1-EC80BA4EBA7E";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[110]" -type "float2" -0.00019109502 0.00041142904 ;
	setAttr ".uvtk[112]" -type "float2" -1.579582e-05 1.6975304e-06 ;
	setAttr ".uvtk[118]" -type "float2" 0.00023406083 0.00042977824 ;
	setAttr ".uvtk[119]" -type "float2" 7.3537536e-05 0.0004751407 ;
	setAttr ".uvtk[200]" -type "float2" -6.6186483e-05 0.00047631247 ;
	setAttr ".uvtk[231]" -type "float2" -5.9813345e-05 3.1260766e-05 ;
createNode polyMergeVert -n "polyMergeVert4";
	rename -uid "4C778EFD-4556-A3F1-E2D6-6D94A23E3677";
	setAttr ".ics" -type "componentList" 4 "vtx[122]" "vtx[127]" "vtx[129]" "vtx[164]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak7";
	rename -uid "0202E547-45B6-F77C-8BC7-B7A5FC5BBB56";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[122]" -type "float3" 0 0 0.0010902286 ;
	setAttr ".tk[164]" -type "float3" 0 0 -0.001090169 ;
createNode polyTweakUV -n "polyTweakUV5";
	rename -uid "E2818E04-4A14-B456-F0C5-43B0AEEB622D";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[97]" -type "float2" 0.00031442635 -6.4858839e-05 ;
	setAttr ".uvtk[113]" -type "float2" -8.3303537e-05 -1.2969456e-06 ;
	setAttr ".uvtk[119]" -type "float2" 8.9399146e-06 -0.00019040564 ;
	setAttr ".uvtk[137]" -type "float2" -0.0001561839 -0.00012877837 ;
	setAttr ".uvtk[138]" -type "float2" -4.6006194e-06 -0.00018429829 ;
	setAttr ".uvtk[233]" -type "float2" -1.5765234e-05 -0.00020929566 ;
createNode polyMergeVert -n "polyMergeVert5";
	rename -uid "7F7D34DB-4E54-663A-4BE1-0088A21760A7";
	setAttr ".ics" -type "componentList" 4 "vtx[104]" "vtx[154]" "vtx[157]" "vtx[162]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak8";
	rename -uid "8F82F81F-4840-1A58-2321-FD9E3600B6EE";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[104]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[154]" -type "float3" 0 0 0.0010902286 ;
createNode polyTweakUV -n "polyTweakUV6";
	rename -uid "48FBEE8D-468E-DD0A-D299-9493FE798812";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[87]" -type "float2" 4.1848791e-05 0.00039895324 ;
	setAttr ".uvtk[95]" -type "float2" 0.00021881572 -0.00020978623 ;
	setAttr ".uvtk[96]" -type "float2" 6.6122593e-05 -0.00014395268 ;
	setAttr ".uvtk[137]" -type "float2" -4.1561307e-05 -0.00015791009 ;
	setAttr ".uvtk[169]" -type "float2" -0.00015778931 -0.0001238681 ;
createNode polyMergeVert -n "polyMergeVert6";
	rename -uid "D9544297-4312-C239-A7C3-8E90836D8255";
	setAttr ".ics" -type "componentList" 4 "vtx[103]" "vtx[151]" "vtx[156]" "vtx[158]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak9";
	rename -uid "FAAEFB8C-4F1D-8FFB-CEAF-EEAED1FE88E5";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[103]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[151]" -type "float3" 0 0 0.0010902286 ;
createNode polyTweakUV -n "polyTweakUV7";
	rename -uid "E4AF7E86-481A-8F18-25C0-2BA69B7A2BA5";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[52]" -type "float2" 0.00032676494 -0.0050638514 ;
	setAttr ".uvtk[85]" -type "float2" -6.887802e-05 9.576817e-05 ;
	setAttr ".uvtk[88]" -type "float2" -0.00014721687 -0.0051055313 ;
	setAttr ".uvtk[90]" -type "float2" 2.2161114e-06 -0.0051070857 ;
	setAttr ".uvtk[169]" -type "float2" 3.7990871e-05 -0.0050994982 ;
	setAttr ".uvtk[223]" -type "float2" -1.5772624e-05 -0.00013924629 ;
createNode polyMergeVert -n "polyMergeVert7";
	rename -uid "5AEB7D1A-45BE-2D20-7B62-8197F37E8324";
	setAttr ".ics" -type "componentList" 3 "vtx[51]" "vtx[90]" "vtx[97:98]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak10";
	rename -uid "7886AEB1-446C-E1D4-CF77-BDB1D3BFBB94";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[51]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[90]" -type "float3" 0 5.9604645e-08 0.0010901988 ;
createNode polyTweakUV -n "polyTweakUV8";
	rename -uid "F64F030E-403B-6F83-C990-CEA2F6F9DC73";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[51]" -type "float2" 2.0794479e-05 -0.0043848678 ;
	setAttr ".uvtk[53]" -type "float2" -7.295885e-05 -0.0048030042 ;
	setAttr ".uvtk[67]" -type "float2" 0.00011851805 0.0054882262 ;
	setAttr ".uvtk[89]" -type "float2" 0.00010772282 -0.0047854409 ;
	setAttr ".uvtk[152]" -type "float2" 4.5106499e-05 -0.0038939507 ;
createNode polyMergeVert -n "polyMergeVert8";
	rename -uid "A15EBC8A-4918-1644-B71C-758145159304";
	setAttr ".ics" -type "componentList" 3 "vtx[50]" "vtx[91]" "vtx[96:97]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak11";
	rename -uid "C500C75F-4B7F-FE6D-519F-A0A4C2EE83E7";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[50]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[91]" -type "float3" 0 1.1920929e-07 0.0010901988 ;
createNode polyTweakUV -n "polyTweakUV9";
	rename -uid "F40B93EE-4960-DFA4-FEF6-DEA1A606CECE";
	setAttr ".uopa" yes;
	setAttr -s 7 ".uvtk";
	setAttr ".uvtk[49]" -type "float2" 0.00029834747 -2.5880136e-05 ;
	setAttr ".uvtk[151]" -type "float2" 5.6329362e-05 -8.8566405e-05 ;
	setAttr ".uvtk[152]" -type "float2" -0.00038902115 0.00091450615 ;
	setAttr ".uvtk[163]" -type "float2" -0.00029209585 -9.5266456e-05 ;
	setAttr ".uvtk[210]" -type "float2" 0.00043229468 0.00011551405 ;
	setAttr ".uvtk[215]" -type "float2" 0.00031512731 -0.0013349222 ;
	setAttr ".uvtk[216]" -type "float2" -0.00039993241 0.00018588564 ;
createNode polyMergeVert -n "polyMergeVert9";
	rename -uid "92F81A49-4AD9-63DE-508C-E79AFC1A4862";
	setAttr ".ics" -type "componentList" 3 "vtx[47]" "vtx[53]" "vtx[67:68]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak12";
	rename -uid "54EBED32-461F-D73E-4E68-709813D51EED";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[47]" -type "float3" 0 0.0006955862 -0.0024887621 ;
	setAttr ".tk[68]" -type "float3" 0 0.0006955862 0.0024887621 ;
createNode polyTweakUV -n "polyTweakUV10";
	rename -uid "C8E985DE-4FDC-C723-ECC7-1B93DC7FBFCE";
	setAttr ".uopa" yes;
	setAttr -s 9 ".uvtk";
	setAttr ".uvtk[38]" -type "float2" -0.00044532571 0.00036026759 ;
	setAttr ".uvtk[42]" -type "float2" 0.00027688828 0.00035095291 ;
	setAttr ".uvtk[55]" -type "float2" -0.00011289646 0.00066694699 ;
	setAttr ".uvtk[57]" -type "float2" 7.3003801e-05 -3.8433554e-05 ;
	setAttr ".uvtk[58]" -type "float2" 7.3003801e-05 0.00028873634 ;
	setAttr ".uvtk[61]" -type "float2" 0.00041008223 -0.0008171908 ;
	setAttr ".uvtk[157]" -type "float2" 0.00025359 0.00080364913 ;
	setAttr ".uvtk[207]" -type "float2" 0.001042881 0.00011944364 ;
	setAttr ".uvtk[210]" -type "float2" -0.00030308324 -0.0013398448 ;
createNode polyMergeVert -n "polyMergeVert10";
	rename -uid "CF7EDF14-4109-E499-623B-2496E11C7409";
	setAttr ".ics" -type "componentList" 4 "vtx[36]" "vtx[45]" "vtx[56]" "vtx[62]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak13";
	rename -uid "C628E878-4277-C46B-56F9-8C8B789C595A";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[36]" -type "float3" 0 0.0006955862 -0.0024887621 ;
	setAttr ".tk[62]" -type "float3" 0 0.0006955862 0.0024887621 ;
createNode polyTweakUV -n "polyTweakUV11";
	rename -uid "615E9BEE-4F7D-7112-0393-A5804202630A";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[42]" -type "float2" 0.00016846127 -0.00395549 ;
	setAttr ".uvtk[80]" -type "float2" -0.00015609835 -0.0037462253 ;
	setAttr ".uvtk[81]" -type "float2" -0.00024311892 -0.0039333808 ;
	setAttr ".uvtk[150]" -type "float2" 5.0571125e-06 -0.0037438618 ;
	setAttr ".uvtk[212]" -type "float2" -1.9239073e-05 0.0054318588 ;
createNode polyMergeVert -n "polyMergeVert11";
	rename -uid "2362ECA1-47DB-94C9-0B21-B2A2ECAA199D";
	setAttr ".ics" -type "componentList" 4 "vtx[38]" "vtx[84]" "vtx[104]" "vtx[107]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak14";
	rename -uid "133F6F21-43CF-37E1-AE7E-B8980CF0DA53";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[38]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[84]" -type "float3" 0 1.1920929e-07 0.0010901988 ;
createNode polyTweakUV -n "polyTweakUV12";
	rename -uid "6065350C-4874-838C-B8ED-B8824B7C81DD";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[77]" -type "float2" 1.5773396e-05 -4.266275e-06 ;
	setAttr ".uvtk[93]" -type "float2" 5.1306641e-05 -0.0049429624 ;
	setAttr ".uvtk[162]" -type "float2" -0.00024217214 -0.0049744607 ;
	setAttr ".uvtk[164]" -type "float2" 0.00011540568 -0.0039957492 ;
	setAttr ".uvtk[165]" -type "float2" -6.3335363e-05 -0.0049065258 ;
	setAttr ".uvtk[211]" -type "float2" 7.615357e-05 0.0012549413 ;
createNode polyMergeVert -n "polyMergeVert12";
	rename -uid "37E98DDE-4269-C983-C10D-2FB898C7A419";
	setAttr ".ics" -type "componentList" 3 "vtx[41]" "vtx[85]" "vtx[104:105]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak15";
	rename -uid "CBCC64C6-4960-B929-547F-BABD56EB707B";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[41]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[85]" -type "float3" 0 5.9604645e-08 0.0010901988 ;
createNode polyTweakUV -n "polyTweakUV13";
	rename -uid "C20A8EAF-4E8A-22C6-8C24-55B5809F2008";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[94]" -type "float2" -3.783626e-05 -0.0005705264 ;
	setAttr ".uvtk[124]" -type "float2" 0.00014608167 -0.0003162348 ;
	setAttr ".uvtk[125]" -type "float2" 4.1443967e-05 -0.00051784742 ;
	setAttr ".uvtk[161]" -type "float2" -0.00023142394 -0.00063207559 ;
	setAttr ".uvtk[215]" -type "float2" -8.5562075e-05 0.00045439278 ;
createNode polyMergeVert -n "polyMergeVert13";
	rename -uid "D3DE6E2E-4E7E-332D-AE39-688CB752B298";
	setAttr ".ics" -type "componentList" 4 "vtx[98]" "vtx[138]" "vtx[154]" "vtx[157]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak16";
	rename -uid "33B0F58E-4508-E534-6786-71AF3C7DAB74";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[98]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[138]" -type "float3" 0 0 0.0010902286 ;
createNode polyTweakUV -n "polyTweakUV14";
	rename -uid "3ED97ABD-4C47-07E4-C800-D089BC87AEFE";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[103]" -type "float2" 1.5780992e-05 -1.6975342e-06 ;
	setAttr ".uvtk[119]" -type "float2" -8.6068239e-06 -0.00033049181 ;
	setAttr ".uvtk[125]" -type "float2" -1.7794633e-05 -0.00029853272 ;
	setAttr ".uvtk[183]" -type "float2" -0.0003078382 -0.00018804436 ;
	setAttr ".uvtk[185]" -type "float2" 0.00016554089 -0.00016748677 ;
	setAttr ".uvtk[212]" -type "float2" 5.9084086e-05 -9.5994772e-05 ;
createNode polyMergeVert -n "polyMergeVert14";
	rename -uid "4BC30EF1-4FCC-1E2F-ED49-EF89696CE90B";
	setAttr ".ics" -type "componentList" 4 "vtx[101]" "vtx[135]" "vtx[154]" "vtx[158]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak17";
	rename -uid "299A3A42-4E1B-38C0-5B09-7EA938FF81B6";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[101]" -type "float3" 0 0 -0.001090169 ;
	setAttr ".tk[135]" -type "float3" 0 0 0.0010902286 ;
createNode polyTweakUV -n "polyTweakUV15";
	rename -uid "6F874550-45A1-1A15-0072-C289EC8222EE";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[101]" -type "float2" 8.3318257e-05 1.2968997e-06 ;
	setAttr ".uvtk[120]" -type "float2" -6.698526e-05 0.000415691 ;
	setAttr ".uvtk[121]" -type "float2" -0.00026868429 0.0003843017 ;
	setAttr ".uvtk[123]" -type "float2" 4.8847367e-05 0.00039537586 ;
	setAttr ".uvtk[184]" -type "float2" 0.00016036459 0.00042773495 ;
	setAttr ".uvtk[207]" -type "float2" 1.5759833e-05 0.00020101893 ;
createNode polyMergeVert -n "polyMergeVert15";
	rename -uid "8A5CD41F-4D3E-CA7B-946A-0880540DE798";
	setAttr ".ics" -type "componentList" 4 "vtx[109]" "vtx[128]" "vtx[131]" "vtx[152]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak18";
	rename -uid "5A88BB4E-48F4-31C7-8943-CE9A552DA43F";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[109]" -type "float3" 0 0 0.0010902286 ;
	setAttr ".tk[152]" -type "float3" 0 0 -0.001090169 ;
createNode polyTweakUV -n "polyTweakUV16";
	rename -uid "E4A82495-45FE-5AA4-82F0-89B3FE9FFDD6";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[8]" -type "float2" -4.1798165e-05 -0.00062303734 ;
	setAttr ".uvtk[98]" -type "float2" 1.2471552e-05 0.00038378488 ;
	setAttr ".uvtk[121]" -type "float2" -0.00032197832 0.00052400841 ;
	setAttr ".uvtk[175]" -type "float2" -2.1799078e-05 0.00036768627 ;
	setAttr ".uvtk[176]" -type "float2" 0.0002020805 0.00041124166 ;
createNode polyMergeVert -n "polyMergeVert16";
	rename -uid "A126DBBD-4199-F0FC-8FC1-BAABDC916DCB";
	setAttr ".ics" -type "componentList" 4 "vtx[106]" "vtx[129]" "vtx[133]" "vtx[150]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak19";
	rename -uid "FD9430D1-43B9-EBD9-5112-08906495101A";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[106]" -type "float3" 0 0 0.0010902286 ;
	setAttr ".tk[150]" -type "float3" 0 0 -0.001090169 ;
createNode polyTweakUV -n "polyTweakUV17";
	rename -uid "118569A8-4CD7-DCB1-290E-21A6A8C8E9DC";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[6]" -type "float2" 6.8923706e-05 -0.00014701822 ;
	setAttr ".uvtk[65]" -type "float2" 3.433062e-05 0.0017110475 ;
	setAttr ".uvtk[69]" -type "float2" -1.5858004e-05 0.0015110755 ;
	setAttr ".uvtk[115]" -type "float2" -0.00023865321 0.0015789992 ;
	setAttr ".uvtk[175]" -type "float2" 0.00017172399 0.0018070366 ;
	setAttr ".uvtk[181]" -type "float2" 1.5774358e-05 0.00041585718 ;
createNode polyMergeVert -n "polyMergeVert17";
	rename -uid "3503FE0C-4BB2-7453-E3F2-7B8593F4B7E0";
	setAttr ".ics" -type "componentList" 4 "vtx[6]" "vtx[67]" "vtx[72]" "vtx[126]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak20";
	rename -uid "54DD07F8-40E5-4B4A-CD4E-D29B06C405D2";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[6]" -type "float3" 0 0 0.0010901988 ;
	setAttr ".tk[126]" -type "float3" 0 0 -0.001090169 ;
createNode polyTweakUV -n "polyTweakUV18";
	rename -uid "66A68DD9-4A65-C71A-A54D-DFB386703E03";
	setAttr ".uopa" yes;
	setAttr -s 9 ".uvtk";
	setAttr ".uvtk[0]" -type "float2" -0.00024082442 0.00039881319 ;
	setAttr ".uvtk[3]" -type "float2" 1.5430667e-06 -0.00019117302 ;
	setAttr ".uvtk[4]" -type "float2" -3.0437965e-05 8.2863326e-06 ;
	setAttr ".uvtk[10]" -type "float2" 0.00010787717 -0.00055367133 ;
	setAttr ".uvtk[25]" -type "float2" -0.00010570438 -0.00049776549 ;
	setAttr ".uvtk[27]" -type "float2" -1.619328e-05 -1.1263058e-05 ;
	setAttr ".uvtk[169]" -type "float2" 0.0004562877 -0.00031598835 ;
	setAttr ".uvtk[180]" -type "float2" -0.00053065812 0.00098940753 ;
	setAttr ".uvtk[185]" -type "float2" -0.0005401721 -0.0011278468 ;
createNode polyMergeVert -n "polyMergeVert18";
	rename -uid "0CE0FF98-4B86-047B-BF41-6596C9D62D76";
	setAttr ".ics" -type "componentList" 3 "vtx[1]" "vtx[10]" "vtx[21]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak21";
	rename -uid "A4A7F5A8-4F67-C8C6-A562-5AA161687EA7";
	setAttr ".uopa" yes;
	setAttr ".tk[1]" -type "float3"  0 -0.00090050697 0.0027387142;
createNode polyTweakUV -n "polyTweakUV19";
	rename -uid "86077C6A-4C26-669A-0EB7-D6AED867134D";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[2]" -type "float2" -7.437959e-05 -0.0018865587 ;
	setAttr ".uvtk[10]" -type "float2" 3.1309944e-05 0.00046942444 ;
	setAttr ".uvtk[69]" -type "float2" -0.00037596014 0.00061625242 ;
	setAttr ".uvtk[165]" -type "float2" -8.0337712e-05 0.00065838051 ;
	setAttr ".uvtk[167]" -type "float2" 0.00021055188 0.00046897441 ;
createNode polyMergeVert -n "polyMergeVert19";
	rename -uid "BBCAB7BA-42A6-844E-A166-CCB202A9A552";
	setAttr ".ics" -type "componentList" 4 "vtx[3]" "vtx[68]" "vtx[71]" "vtx[123]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak22";
	rename -uid "BBB7E951-4BBD-0717-DDD3-8DB2898B6FDB";
	setAttr ".uopa" yes;
	setAttr -s 2 ".tk";
	setAttr ".tk[3]" -type "float3" 0 0 0.0010901988 ;
	setAttr ".tk[123]" -type "float3" 0 0 -0.001090169 ;
createNode polyTweakUV -n "polyTweakUV20";
	rename -uid "F4350857-4D99-89C8-DA25-B8B190B6A4B7";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[19]" -type "float2" -0.00022032761 0.00047696629 ;
	setAttr ".uvtk[21]" -type "float2" 0.00025770126 0.00047965616 ;
	setAttr ".uvtk[73]" -type "float2" -0.00021540356 0.00062834047 ;
	setAttr ".uvtk[74]" -type "float2" -5.5901008e-05 0.00052796607 ;
	setAttr ".uvtk[178]" -type "float2" -0.0001925306 -0.001850542 ;
createNode polyMergeVert -n "polyMergeVert20";
	rename -uid "E9848C74-4A12-D23F-E7AE-E598E0CFA718";
	setAttr ".ics" -type "componentList" 4 "vtx[16]" "vtx[73]" "vtx[78]" "vtx[117]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak23";
	rename -uid "A2B19D74-4DF5-7F6C-FFC2-78BCD2744A1E";
	setAttr ".uopa" yes;
	setAttr -s 18 ".tk";
	setAttr ".tk[13]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
	setAttr ".tk[45]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[48]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[49]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[63]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
	setAttr ".tk[73]" -type "float3" 0 0 -0.0010901988 ;
	setAttr ".tk[75]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[78]" -type "float3" 0 0 0.001090169 ;
	setAttr ".tk[83]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
	setAttr ".tk[84]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
	setAttr ".tk[92]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[93]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[107]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
	setAttr ".tk[110]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
	setAttr ".tk[113]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[116]" -type "float3" 2.9802322e-08 -3.7252903e-09 -9.5751602e-09 ;
	setAttr ".tk[132]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
	setAttr ".tk[135]" -type "float3" 2.9802322e-08 -3.7252903e-09 9.5751602e-09 ;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "020A804E-4D9C-BB43-E489-B68F7450E370";
	setAttr ".ics" -type "componentList" 1 "f[97]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.25 2.3835549 1.4901161e-08 ;
	setAttr ".rs" 37167;
	setAttr ".tp" 0;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 0.25 2.1992053487162755 -0.39439615607261658 ;
	setAttr ".cbx" -type "double3" 0.25 2.5679046609263585 0.39439618587493896 ;
createNode polyExtrudeFace -n "polyExtrudeFace2";
	rename -uid "094FC65C-43C1-8B05-525B-F8A4BC1E3D7A";
	setAttr ".ics" -type "componentList" 1 "f[152:155]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.25 2.3835549 1.4901161e-08 ;
	setAttr ".rs" 65118;
	setAttr ".lt" -type "double3" 0 4.8292551823033106e-18 0.039433861139927251 ;
	setAttr ".tp" 0;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 0.25 2.1992053487162755 -0.39439615607261658 ;
	setAttr ".cbx" -type "double3" 0.25 2.5679046609263585 0.39439618587493896 ;
createNode polyTweak -n "polyTweak24";
	rename -uid "C2C7E799-4817-A7DF-2AAA-F2AC1FCED2AA";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk";
	setAttr ".tk[13]" -type "float3" 1.0128133e-08 0 3.7252903e-09 ;
	setAttr ".tk[16]" -type "float3" 1.0128133e-08 0 3.7252903e-09 ;
	setAttr ".tk[74]" -type "float3" 1.0128133e-08 0 -3.7252903e-09 ;
	setAttr ".tk[77]" -type "float3" 1.0128133e-08 0 -3.7252903e-09 ;
	setAttr ".tk[146]" -type "float3" 0 -0.03144934 -0.043959249 ;
	setAttr ".tk[147]" -type "float3" 0 -0.03144934 0.043959249 ;
	setAttr ".tk[148]" -type "float3" 0 0.03144934 -0.043959249 ;
	setAttr ".tk[149]" -type "float3" 0 0.03144934 0.043959256 ;
createNode polyBevel3 -n "polyBevel5";
	rename -uid "C2548E5C-4719-B59F-1566-0DABC4F25724";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 4 "e[302]" "e[309]" "e[314]" "e[318]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 0.30000000000000004;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polySplit -n "polySplit9";
	rename -uid "BABE451D-4ACD-20E4-568A-ECA9F48F717D";
	setAttr -s 33 ".e[0:32]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5;
	setAttr -s 33 ".d[0:32]"  -2147483647 -2147483618 -2147483620 -2147483587 -2147483589 -2147483579 
		-2147483581 -2147483388 -2147483386 -2147483359 -2147483357 -2147483439 -2147483437 -2147483551 -2147483553 -2147483563 -2147483565 -2147483536 
		-2147483538 -2147483507 -2147483509 -2147483499 -2147483501 -2147483457 -2147483459 -2147483366 -2147483368 -2147483413 -2147483415 -2147483633 
		-2147483635 -2147483645 -2147483647;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak25";
	rename -uid "682E6A5B-4E0E-0725-A2A4-3F823DE209A2";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk";
	setAttr ".tk[155]" -type "float3" -0.013203433 0 0 ;
	setAttr ".tk[156]" -type "float3" -0.013203433 0 0 ;
	setAttr ".tk[159]" -type "float3" -0.013203433 0 0 ;
	setAttr ".tk[161]" -type "float3" -0.013203433 0 0 ;
createNode polyBevel3 -n "polyBevel6";
	rename -uid "FFFEBA5C-4920-B7FD-3FA3-8DBFB6430C38";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[360:391]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 0.4;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyExtrudeFace -n "polyExtrudeFace3";
	rename -uid "5BBB8B93-4B71-643E-275D-48BAFA01E08D";
	setAttr ".ics" -type "componentList" 10 "f[58:59]" "f[100:101]" "f[112:115]" "f[118:119]" "f[148]" "f[162]" "f[179]" "f[182]" "f[211]" "f[225]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 1.4901161e-08 1.2076069 0 ;
	setAttr ".rs" 60004;
	setAttr ".tp" 0;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.25 1.1769953467707799 -0.5 ;
	setAttr ".cbx" -type "double3" 0.25000002980232239 1.2382183768611119 0.5 ;
createNode polyExtrudeFace -n "polyExtrudeFace4";
	rename -uid "8F0A3A61-4FCF-BC35-394E-C184569E4A23";
	setAttr ".ics" -type "componentList" 12 "f[41]" "f[46]" "f[83]" "f[86]" "f[96:99]" "f[102:103]" "f[150]" "f[160]" "f[174]" "f[178]" "f[213]" "f[223]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 1.4901161e-08 0.58939773 0 ;
	setAttr ".rs" 40931;
	setAttr ".tp" 0;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.25 0.55878622315932969 -0.5 ;
	setAttr ".cbx" -type "double3" 0.25000002980232239 0.62000919364501694 0.5 ;
createNode polyTweak -n "polyTweak26";
	rename -uid "92B464E6-4E4E-E954-7DD2-3A8C13579D59";
	setAttr ".uopa" yes;
	setAttr -s 64 ".tk";
	setAttr ".tk[90]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[91]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[92]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[93]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[94]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[95]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[96]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[97]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[126]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[127]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[128]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[129]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[130]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[131]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[132]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[133]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[134]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[135]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[136]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[137]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[142]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[143]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[144]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[145]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[184]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[185]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[186]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[187]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[212]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[213]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[214]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[215]" -type "float3" 0 -0.034408323 0 ;
	setAttr ".tk[226]" -type "float3" -0.011149168 -0.015518503 0.015233965 ;
	setAttr ".tk[227]" -type "float3" -0.011149168 -0.053298287 0.015233965 ;
	setAttr ".tk[228]" -type "float3" -0.011149168 -0.053298287 -0.015233962 ;
	setAttr ".tk[229]" -type "float3" -0.011149168 -0.015518503 -0.015233962 ;
	setAttr ".tk[230]" -type "float3" 0.011149172 -0.015518503 -0.015233962 ;
	setAttr ".tk[231]" -type "float3" 0.011149172 -0.053298287 -0.015233962 ;
	setAttr ".tk[232]" -type "float3" 0.011149172 -0.053298287 0.015233965 ;
	setAttr ".tk[233]" -type "float3" 0.011149172 -0.015518503 0.015233965 ;
	setAttr ".tk[234]" -type "float3" -0.011149172 -0.015518503 -0.0179643 ;
	setAttr ".tk[235]" -type "float3" -0.0092185326 -0.01551836 -0.019943548 ;
	setAttr ".tk[236]" -type "float3" -0.011149172 -0.053298213 -0.0179643 ;
	setAttr ".tk[237]" -type "float3" -0.0092185326 -0.053298146 -0.019943548 ;
	setAttr ".tk[238]" -type "float3" 0.0092185326 -0.01551836 -0.019943548 ;
	setAttr ".tk[239]" -type "float3" 0.011149172 -0.015518503 -0.0179643 ;
	setAttr ".tk[240]" -type "float3" 0.0092185326 -0.053298146 -0.019943548 ;
	setAttr ".tk[241]" -type "float3" 0.011149172 -0.053298213 -0.0179643 ;
	setAttr ".tk[242]" -type "float3" 0.0092185326 -0.053298146 0.019943548 ;
	setAttr ".tk[243]" -type "float3" 0.011149172 -0.053298213 0.017964296 ;
	setAttr ".tk[244]" -type "float3" 0.0092185326 -0.01551836 0.019943548 ;
	setAttr ".tk[245]" -type "float3" 0.011149172 -0.015518503 0.017964296 ;
	setAttr ".tk[246]" -type "float3" -0.0092185326 -0.01551836 0.019943548 ;
	setAttr ".tk[247]" -type "float3" -0.011149172 -0.015518503 0.017964296 ;
	setAttr ".tk[248]" -type "float3" -0.0092185326 -0.053298146 0.019943548 ;
	setAttr ".tk[249]" -type "float3" -0.011149172 -0.053298213 0.017964296 ;
	setAttr ".tk[250]" -type "float3" 0.0036636253 -0.053298146 -0.019943548 ;
	setAttr ".tk[251]" -type "float3" -0.0036636249 -0.053298146 -0.019943548 ;
	setAttr ".tk[252]" -type "float3" 0.0036636253 -0.01551836 -0.019943548 ;
	setAttr ".tk[253]" -type "float3" -0.0036636249 -0.01551836 -0.019943548 ;
	setAttr ".tk[254]" -type "float3" 0.0036636253 -0.01551836 0.019943548 ;
	setAttr ".tk[255]" -type "float3" -0.0036636249 -0.01551836 0.019943548 ;
	setAttr ".tk[256]" -type "float3" 0.0036636253 -0.053298146 0.019943548 ;
	setAttr ".tk[257]" -type "float3" -0.0036636249 -0.053298146 0.019943548 ;
createNode polyCylinder -n "polyCylinder1";
	rename -uid "3AAC2E29-4E6B-4062-E229-09973B530107";
	setAttr ".h" 1;
	setAttr ".sa" 21;
	setAttr ".sc" 3;
	setAttr ".cuv" 3;
createNode polyExtrudeFace -n "polyExtrudeFace5";
	rename -uid "830C24C7-47DE-518A-A99D-A48E9418F137";
	setAttr ".ics" -type "componentList" 1 "f[105:125]";
	setAttr ".ix" -type "matrix" 0 0.2021669390006581 0 0 -0.062954596970357476 0 0 0
		 0 0 0.2021669390006581 0 0.27917681186107979 0.86166221987203373 -0.0059607509881939441 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.3106541 0.86203855 -0.0059607448 ;
	setAttr ".rs" 53627;
	setAttr ".tp" 0;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 0.31065411034625851 0.75727455583140224 -0.11101848430474168 ;
	setAttr ".cbx" -type "double3" 0.31065411034625851 0.96680256859591651 0.099096994378442368 ;
createNode polyTweak -n "polyTweak27";
	rename -uid "3408A359-445F-7E6D-FC38-C6A4E280C8C8";
	setAttr ".uopa" yes;
	setAttr -s 42 ".tk[0:41]" -type "float3"  0.17839076 0 -0.055349655
		 0.15410426 0 -0.10578147 0.11603173 0 -0.14681397 0.067555882 0 -0.17480147 0.012984369
		 0 -0.1872571 -0.042834099 0 -0.18307419 -0.094939739 0 -0.16262424 -0.13870274 0
		 -0.12772438 -0.17023452 0 -0.081475765 -0.18673363 0 -0.027987549 -0.18673363 0 0.027987426
		 -0.17023456 0 0.081475638 -0.13870277 0 0.12772435 -0.09493985 0 0.16262423 -0.042834174
		 0 0.18307418 0.012984269 0 0.1872571 0.067555837 0 0.17480148 0.11603152 0 0.14681403
		 0.15410426 0 0.10578149 0.17839076 0 0.055349801 0.18673363 0 -1.6789029e-08 0.10645433
		 0 -0.033029787 0.091961339 0 -0.063124783 0.069241598 0 -0.087610863 0.040313825
		 0 -0.10431236 0.0077483845 0 -0.11174519 -0.025561145 0 -0.10924907 -0.056655034
		 0 -0.097045548 -0.082770541 0 -0.076219223 -0.10158707 0 -0.048620433 -0.11143274
		 0 -0.016701497 -0.11143275 0 0.016701421 -0.1015871 0 0.048620347 -0.082770571 0
		 0.076219149 -0.056655124 0 0.097045518 -0.025561202 0 0.109249 0.0077483309 0 0.11174519
		 0.040313788 0 0.10431239 0.069241546 0 0.087610908 0.091961324 0 0.063124835 0.10645433
		 0 0.033029839 0.11143275 0 -1.0018818e-08;
createNode polyBevel3 -n "polyBevel7";
	rename -uid "372664F9-4668-853D-B722-2E9CE42C29E9";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[42:62]";
	setAttr ".ix" -type "matrix" 0 0.2021669390006581 0 0 -0.062954596970357476 0 0 0
		 0 0 0.2021669390006581 0 0.27917681186107979 0.86166221987203373 -0.0059607509881939441 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyTweak -n "polyTweak28";
	rename -uid "E6A183BD-4B48-75C8-F312-88A9A92D0847";
	setAttr ".uopa" yes;
	setAttr -s 22 ".tk[127:148]" -type "float3"  1.110223e-16 -1.26561499 0
		 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0
		 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0
		 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0
		 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0
		 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0
		 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0
		 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0 1.110223e-16 -1.26561499 0;
createNode polyCube -n "polyCube2";
	rename -uid "2A62B477-4702-5E99-72A3-8DB344CB4FC8";
	setAttr ".d" 3;
	setAttr ".sd" 4;
	setAttr ".cuv" 4;
createNode polyExtrudeFace -n "polyExtrudeFace6";
	rename -uid "57BFBD98-40BF-BFBA-F6D1-DD919CE31ECA";
	setAttr ".ics" -type "componentList" 4 "f[3]" "f[7]" "f[11]" "f[15]";
	setAttr ".ix" -type "matrix" 0.11076148131912873 0 0 0 0 0.23719854182490815 0 0
		 0 0 0.40756087793055501 0 0.462168355407302 0.91350367569437818 -0.5030095128111356 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.46216837 0.91350365 -0.93635118 ;
	setAttr ".rs" 51618;
	setAttr ".tp" 0;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 0.40678761474773761 0.79490440478192415 -0.96710278039429132 ;
	setAttr ".cbx" -type "double3" 0.51754909606686639 1.0321029466068323 -0.90559953355975176 ;
createNode polyTweak -n "polyTweak29";
	rename -uid "2A166C28-4BE4-F6BC-CF09-3B94095D6183";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk";
	setAttr ".tk[6]" -type "float3" 0 0 -0.9878034 ;
	setAttr ".tk[7]" -type "float3" 0 0 -0.9878034 ;
	setAttr ".tk[8]" -type "float3" 0 0 -0.38870904 ;
	setAttr ".tk[9]" -type "float3" 0 0 -0.38870904 ;
	setAttr ".tk[14]" -type "float3" 0 0 -0.38870904 ;
	setAttr ".tk[15]" -type "float3" 0 0 -0.38870904 ;
	setAttr ".tk[16]" -type "float3" 0 0 -0.9878034 ;
	setAttr ".tk[17]" -type "float3" 0 0 -0.9878034 ;
createNode polyBevel3 -n "polyBevel8";
	rename -uid "B70F5D71-4063-7FE3-74A1-E18C9EEA8EFF";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:1]";
	setAttr ".ix" -type "matrix" 0.11076148131912873 0 0 0 0 0.23719854182490815 0 0
		 0 0 0.40756087793055501 0 0.462168355407302 0.91350367569437818 -0.5030095128111356 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 0.4;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyTweak -n "polyTweak30";
	rename -uid "42A14F7B-4696-D9CE-F942-9F983A7B5BAE";
	setAttr ".uopa" yes;
	setAttr -s 10 ".tk";
	setAttr ".tk[0]" -type "float3" 9.9651515e-08 2.7939677e-09 2.8871e-08 ;
	setAttr ".tk[1]" -type "float3" 9.9651515e-08 2.7939677e-09 2.8871e-08 ;
	setAttr ".tk[20]" -type "float3" 0.070281096 -0.070281118 -0.010605811 ;
	setAttr ".tk[21]" -type "float3" -0.070281096 -0.070281118 -0.010605811 ;
	setAttr ".tk[22]" -type "float3" -0.070281096 -0.070281118 0.010605811 ;
	setAttr ".tk[23]" -type "float3" 0.070281096 -0.070281118 0.010605811 ;
	setAttr ".tk[24]" -type "float3" 0.070281096 0.070281118 0.010605811 ;
	setAttr ".tk[25]" -type "float3" -0.070281096 0.070281118 0.010605811 ;
	setAttr ".tk[26]" -type "float3" -0.070281096 0.070281118 -0.010605811 ;
	setAttr ".tk[27]" -type "float3" 0.070281096 0.070281118 -0.010605811 ;
createNode polySplit -n "polySplit10";
	rename -uid "ED989B81-48B6-4AA8-1A19-229AFB7E55C0";
	setAttr -s 2 ".e[0:1]"  0 0;
	setAttr -s 2 ".d[0:1]"  -2147483596 -2147483599;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit11";
	rename -uid "A8F6FB7D-408F-8905-F757-ECAD8E748B35";
	setAttr -s 2 ".e[0:1]"  1 1;
	setAttr -s 2 ".d[0:1]"  -2147483597 -2147483630;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyBevel3 -n "polyBevel9";
	rename -uid "CA6A7746-4684-87A4-D070-D7B89EE5FE06";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[*]";
	setAttr ".ix" -type "matrix" 0.11076148131912873 0 0 0 0 0.20570634104161961 0 0
		 0 0 0.40756087793055501 0 0.46008083315716047 0.91350367569437818 -0.5030095128111356 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 1;
	setAttr ".at" 180;
	setAttr ".sn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".sa" 30;
createNode polyCut -n "polyCut1";
	rename -uid "075226AF-4FEF-8AF7-2AE2-29A1C5C0FBF8";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 3 "f[136:167]" "f[252:255]" "f[284:287]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".pc" -type "double3" -0.26144548000000001 2.3192966500000001 -8.0128241899999999 ;
	setAttr ".ro" -type "double3" 179.94990670000001 -88.357081640000004 0 ;
createNode polyTweak -n "polyTweak31";
	rename -uid "49028A12-482E-429B-3FF3-BD87073DEB46";
	setAttr ".uopa" yes;
	setAttr -s 179 ".tk";
	setAttr ".tk[3]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[4]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[5]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[6]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[13]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[14]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[15]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[16]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[66]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[67]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[68]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[69]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[70]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[71]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[72]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[73]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[74]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[75]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[76]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[77]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[90]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[91]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[92]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[93]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[94]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[95]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[96]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[97]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[116]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[117]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[118]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[119]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[126]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[127]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[128]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[129]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[130]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[131]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[132]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[133]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[134]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[135]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[136]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[137]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[142]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[143]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[144]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[145]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[146]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[147]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[150]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[151]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[154]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[155]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[156]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[157]" -type "float3" 0 -0.036190931 0 ;
	setAttr ".tk[162]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[163]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[164]" -type "float3" -2.3283064e-10 -7.4505806e-09 0 ;
	setAttr ".tk[165]" -type "float3" 0 2.2351742e-08 1.8626451e-09 ;
	setAttr ".tk[167]" -type "float3" 0 0 9.3132257e-10 ;
	setAttr ".tk[169]" -type "float3" -2.3283064e-10 0 -9.3132257e-10 ;
	setAttr ".tk[171]" -type "float3" 4.6566129e-10 0 -1.8626451e-09 ;
	setAttr ".tk[172]" -type "float3" 2.3283064e-10 7.4505806e-09 -1.8626451e-09 ;
	setAttr ".tk[173]" -type "float3" 2.3283064e-10 0 0 ;
	setAttr ".tk[174]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[175]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[176]" -type "float3" -2.3283064e-10 -0.036190931 0 ;
	setAttr ".tk[177]" -type "float3" -2.3283064e-10 -0.036190931 0 ;
	setAttr ".tk[178]" -type "float3" -2.3283064e-10 -0.036190916 0 ;
	setAttr ".tk[179]" -type "float3" -2.3283064e-10 -0.036190916 0 ;
	setAttr ".tk[180]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[181]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[182]" -type "float3" -2.3283064e-10 3.7252903e-09 0 ;
	setAttr ".tk[183]" -type "float3" -2.3283064e-10 3.7252903e-09 0 ;
	setAttr ".tk[184]" -type "float3" -2.3283064e-10 0.04443334 0 ;
	setAttr ".tk[185]" -type "float3" -2.3283064e-10 0.04443334 0 ;
	setAttr ".tk[186]" -type "float3" -2.3283064e-10 0.044433344 0 ;
	setAttr ".tk[187]" -type "float3" -2.3283064e-10 0.044433344 0 ;
	setAttr ".tk[188]" -type "float3" -2.3283064e-10 7.4505806e-09 0 ;
	setAttr ".tk[189]" -type "float3" -2.3283064e-10 7.4505806e-09 0 ;
	setAttr ".tk[190]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[191]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[192]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[193]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[195]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[196]" -type "float3" 2.3283064e-10 -1.4901161e-08 0 ;
	setAttr ".tk[197]" -type "float3" 0 -1.4901161e-08 1.8626451e-09 ;
	setAttr ".tk[198]" -type "float3" -2.3283064e-10 0 -9.3132257e-10 ;
	setAttr ".tk[200]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[201]" -type "float3" 2.3283064e-10 0 9.3132257e-10 ;
	setAttr ".tk[202]" -type "float3" 0 -1.4901161e-08 -1.8626451e-09 ;
	setAttr ".tk[203]" -type "float3" 0 -1.4901161e-08 0 ;
	setAttr ".tk[204]" -type "float3" 2.3283064e-10 7.4505806e-09 0 ;
	setAttr ".tk[205]" -type "float3" 0 1.4901161e-08 -1.8626451e-09 ;
	setAttr ".tk[206]" -type "float3" -2.3283064e-10 -7.4505806e-09 0 ;
	setAttr ".tk[207]" -type "float3" -2.3283064e-10 -7.4505806e-09 0 ;
	setAttr ".tk[208]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[209]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[210]" -type "float3" -2.3283064e-10 7.4505806e-09 0 ;
	setAttr ".tk[211]" -type "float3" -2.3283064e-10 7.4505806e-09 0 ;
	setAttr ".tk[212]" -type "float3" -2.3283064e-10 0.044433344 0 ;
	setAttr ".tk[213]" -type "float3" -2.3283064e-10 0.044433344 0 ;
	setAttr ".tk[214]" -type "float3" -2.3283064e-10 0.04443334 0 ;
	setAttr ".tk[215]" -type "float3" -2.3283064e-10 0.04443334 0 ;
	setAttr ".tk[216]" -type "float3" -2.3283064e-10 3.7252903e-09 0 ;
	setAttr ".tk[217]" -type "float3" -2.3283064e-10 3.7252903e-09 0 ;
	setAttr ".tk[218]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[219]" -type "float3" -2.3283064e-10 0 0 ;
	setAttr ".tk[220]" -type "float3" -2.3283064e-10 -0.036190916 0 ;
	setAttr ".tk[221]" -type "float3" -2.3283064e-10 -0.036190916 0 ;
	setAttr ".tk[222]" -type "float3" -2.3283064e-10 -0.036190931 0 ;
	setAttr ".tk[223]" -type "float3" -2.3283064e-10 -0.036190931 0 ;
	setAttr ".tk[224]" -type "float3" -2.3283064e-10 -7.4505806e-09 0 ;
	setAttr ".tk[225]" -type "float3" -2.3283064e-10 -7.4505806e-09 0 ;
	setAttr ".tk[226]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[227]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[228]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[229]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[230]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[231]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[232]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[233]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[234]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[235]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[236]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[237]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[238]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[239]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[240]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[241]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[242]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[243]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[244]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[245]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[246]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[247]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[248]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[249]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[250]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[251]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[252]" -type "float3" 0 0.044433348 0 ;
	setAttr ".tk[253]" -type "float3" 0 0.044433348 0 ;
	setAttr ".tk[254]" -type "float3" 0 0.044433348 0 ;
	setAttr ".tk[255]" -type "float3" 0 0.044433348 0 ;
	setAttr ".tk[256]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[257]" -type "float3" 0 0.044433344 0 ;
	setAttr ".tk[258]" -type "float3" -0.020878116 0.019373419 0.028527377 ;
	setAttr ".tk[259]" -type "float3" -0.020878116 -0.019373581 0.028527377 ;
	setAttr ".tk[260]" -type "float3" -0.020878116 -0.019373581 -0.028527385 ;
	setAttr ".tk[261]" -type "float3" -0.020878116 0.019373419 -0.028527385 ;
	setAttr ".tk[262]" -type "float3" 0.020878114 0.019373419 -0.028527385 ;
	setAttr ".tk[263]" -type "float3" 0.020878114 -0.019373581 -0.028527385 ;
	setAttr ".tk[264]" -type "float3" 0.020878114 -0.019373581 0.028527377 ;
	setAttr ".tk[265]" -type "float3" 0.020878114 0.019373419 0.028527377 ;
	setAttr ".tk[266]" -type "float3" 0.017262783 0.019373586 -0.037346613 ;
	setAttr ".tk[267]" -type "float3" 0.020878114 0.019373419 -0.033640236 ;
	setAttr ".tk[268]" -type "float3" 0.017262783 -0.019373449 -0.037346613 ;
	setAttr ".tk[269]" -type "float3" 0.020878114 -0.019373523 -0.033640236 ;
	setAttr ".tk[270]" -type "float3" -0.020878114 0.019373419 -0.033640236 ;
	setAttr ".tk[271]" -type "float3" -0.017262779 0.019373586 -0.037346613 ;
	setAttr ".tk[272]" -type "float3" -0.020878114 -0.019373523 -0.033640236 ;
	setAttr ".tk[273]" -type "float3" -0.017262779 -0.019373449 -0.037346613 ;
	setAttr ".tk[274]" -type "float3" 0.017262783 0.019373586 0.037346613 ;
	setAttr ".tk[275]" -type "float3" 0.017262783 -0.019373365 0.037346613 ;
	setAttr ".tk[276]" -type "float3" 0.020878114 0.019373419 0.033640236 ;
	setAttr ".tk[277]" -type "float3" 0.020878114 -0.019373523 0.033640236 ;
	setAttr ".tk[278]" -type "float3" -0.020878114 0.019373419 0.033640236 ;
	setAttr ".tk[279]" -type "float3" -0.020878114 -0.019373523 0.033640236 ;
	setAttr ".tk[280]" -type "float3" -0.017262779 0.019373586 0.037346613 ;
	setAttr ".tk[281]" -type "float3" -0.017262779 -0.019373365 0.037346613 ;
	setAttr ".tk[282]" -type "float3" 0.0068605659 -0.019373454 -0.037346616 ;
	setAttr ".tk[283]" -type "float3" -0.0068605635 -0.019373454 -0.037346616 ;
	setAttr ".tk[284]" -type "float3" 0.0068605659 0.019373581 -0.037346616 ;
	setAttr ".tk[285]" -type "float3" -0.0068605635 0.019373581 -0.037346616 ;
	setAttr ".tk[286]" -type "float3" 0.0068605659 0.019373581 0.037346616 ;
	setAttr ".tk[287]" -type "float3" -0.0068605635 0.019373581 0.037346616 ;
	setAttr ".tk[288]" -type "float3" 0.0068605659 -0.019373365 0.037346616 ;
	setAttr ".tk[289]" -type "float3" -0.0068605635 -0.019373365 0.037346616 ;
createNode polyTweak -n "polyTweak32";
	rename -uid "652534B3-4EF4-2B0A-E13B-15A46F8DB6F0";
	setAttr ".uopa" yes;
	setAttr -s 40 ".tk[290:329]" -type "float3"  0.04465498 0 0 0.045279451
		 0 0 0.043618307 0 0 0.042037286 0 0 0.019594774 0 0 0.018039238 0 0 0.017148761 0
		 0 0.016588604 0 0 0.016681833 0 0 0.016735384 0 0 0.01702621 0 0 0.017079759 0 0
		 0.017857969 0 0 0.017911512 0 0 0.018407449 0 0 0.018460996 0 0 0.018592793 0 0 0.019489527
		 0 0 0.020043584 0 0 0.021733381 0 0 0.044284016 0 0 0.045943052 0 0 0.046478391 0
		 0 0.047275074 0 0 0.047142915 0 0 0.047089361 0 0 0.046593428 0 0 0.046539873 0 0
		 0.045761675 0 0 0.045708127 0 0 0.045417301 0 0 0.045363747 0 0 0.018446516 0 0 0.018467017
		 0 0 0.046004876 0 0 0.045984372 0 0 0.019495565 0 0 0.01951522 0 0 0.04605478 0 0
		 0.046035126 0 0;
createNode deleteComponent -n "deleteComponent1";
	rename -uid "193FDD02-4ED5-7500-EAF0-7C9370FBFE0F";
	setAttr ".dc" -type "componentList" 42 "e[273]" "e[275:276]" "e[278:279]" "e[281:282]" "e[284:285]" "e[287:288]" "e[290:291]" "e[293:294]" "e[296:297]" "e[299:300]" "e[302:303]" "e[305:306]" "e[308]" "e[310]" "e[312]" "e[314]" "e[316:317]" "e[319:320]" "e[322:323]" "e[325:326]" "e[328:329]" "e[331:332]" "e[334:335]" "e[337:338]" "e[340]" "e[342]" "e[344]" "e[346]" "e[348:349]" "e[351:352]" "e[354:355]" "e[357:359]" "e[480:481]" "e[483:485]" "e[487:489]" "e[491:493]" "e[495]" "e[560:561]" "e[563:565]" "e[567:569]" "e[571:573]" "e[575]";
createNode deleteComponent -n "deleteComponent2";
	rename -uid "1E2FD258-4A18-E23F-AC97-B6AE08CE5E14";
	setAttr ".dc" -type "componentList" 1 "vtx[0:329]";
createNode polyPlanarProj -n "polyPlanarProj1";
	rename -uid "36487140-49EB-852E-3269-60B3F7E1507E";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[0:255]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 1.5725568034510777 0 1;
	setAttr ".ws" yes;
	setAttr ".pc" -type "double3" 0.019716918468475342 1.5725568532943726 0 ;
	setAttr ".ro" -type "double3" 0 90 0 ;
	setAttr ".ps" -type "double2" 1 2.5000001192092896 ;
	setAttr ".cam" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
createNode polyTweakUV -n "polyTweakUV21";
	rename -uid "D053B105-4828-4EF8-8070-C6BC48D5FC86";
	setAttr ".uopa" yes;
	setAttr -s 250 ".uvtk[0:249]" -type "float2" -0.25653785 0 -0.28125 0
		 -0.28125 0 -0.25628561 0 -0.27002954 0 -0.25046277 0 -0.25628561 0 -0.28125 0 -0.28125
		 0 -0.25628561 0 -0.22170502 0 -0.22184789 0 -0.21991265 0 0.22172439 0 0.22022188
		 0 -0.25653785 0 -0.27002954 0 -0.2505402 0 -0.28125 0 -0.25689882 0 -0.28125 0 -0.28125
		 0 -0.25628561 0 -0.25628561 0 -0.28125 0 -0.22170502 0 -0.22184789 0 -0.22000992
		 0 0.22013727 0 0.22172439 0 0.25651616 0 0.22184786 0 0.25628561 0 0.25116545 0 0.25804764
		 0 0.26917973 0 0.28125 0 0.28125 0 0.25651616 0 0.25689882 0 0.22184786 0 0.25109178
		 0 0.26935321 0 0.25804764 0 0.28125 0 0.28125 0 0.25641623 0 0.28125 0 0.28125 0
		 0.25628561 0 0.26461172 0 0.25394049 0 0.25628561 0 0.28125 0 0.28125 0 0.25628561
		 0 0.22180548 0 0.22184786 0 0.22110984 2.9802322e-08 -0.22180545 0 -0.22114384 2.9802322e-08
		 0.25641623 0 0.26461172 0 0.25398824 0 0.28125 0 0.25628561 0 0.28125 0 0.28125 0
		 0.25628561 0 0.25628561 0 0.28125 0 0.22180548 0 0.22184786 0 0.22114384 2.9802322e-08
		 -0.22110987 2.9802322e-08 -0.22180545 0 -0.2564162 0 -0.22184789 0 -0.25628561 0
		 -0.25398827 0 -0.26461172 0 -0.28125 0 -0.28125 0 -0.2564162 0 -0.25628561 0 -0.22184789
		 0 -0.25394046 0 -0.26480597 0 -0.28125 0 -0.28125 0 -0.22184789 0 -0.22184777 0 0.22184786
		 0 0.25628561 0 0.22184786 0 0.25628561 0 -0.22184789 0 0.22184786 0 -0.22184777 0
		 0.25628561 0 0.25628561 0 0.22184786 0 -0.28125 0 -0.25628561 0 -0.25628561 0 -0.28125
		 0 -0.25628561 0 -0.28125 0 -0.28125 0 -0.25628561 0 -0.22184789 0 -0.22184777 0 -0.20580119
		 0 -0.20580119 0 0.20580119 0 0.20580119 0 0.22184786 0 0.22184786 0 0.28125 0 0.25628561
		 0 0.25628561 0 0.28125 0 0.25628561 0 0.28125 0 0.28125 0 0.25628561 0 0.22184786
		 0 0.22184786 0 0.20580119 0 0.20580119 0 -0.20580119 0 -0.20580119 0 -0.22184789
		 0 -0.22184777 0 -0.25628561 0 -0.28125 0 -0.28125 0 -0.25628561 0 -0.28125 0 -0.25628561
		 0 -0.25628561 0 -0.28125 0 -0.22184777 0 0.22184786 0 -0.22184777 0 0.22184786 0
		 0.28125 0 0.28125 0 0.28125 0 0.28125 0 0.22184786 0 -0.22184777 0 0.22184786 0 -0.22184777
		 0 -0.21327877 0 -0.21327877 0 0.21327874 0 0.21327874 0 0.21327874 0 0.21327874 0
		 -0.21327877 0 -0.21327877 0 -0.19712079 0 0.19712079 0 0.19712079 0 -0.19712079 0
		 0.23736295 0 0.26024252 0 0.26024252 0 0.23736295 0 0.26024252 0 0.23736295 0 0.23736295
		 0 0.26024252 0 -0.26024252 0 -0.26024252 0 -0.23736298 0 -0.23736298 0 -0.23736298
		 0 -0.23736298 0 -0.26024252 0 -0.26024252 0 0.27003175 0 0.24618068 0 0.24618068
		 0 0.27003175 0 0.24618068 0 0.27003175 0 0.27003175 0 0.24618068 0 -0.24618065 0
		 -0.27003181 0 -0.27003181 0 -0.24618065 0 -0.24618065 0 -0.27003181 0 -0.27003181
		 0 -0.24618065 0 -0.19712079 0 0.19712079 0 0.19712079 0 -0.19712079 0 0.21519405
		 0 0.22184786 0 0.22184786 0 0.21519405 0 -0.21519405 0 -0.22184789 0 -0.21519405
		 0 -0.22184777 0 -0.27002954 0 -0.28125 0 -0.25049323 0 -0.21995133 0 0.22018361 0
		 0.25113189 0 0.26925892 0 0.28125 0 0.28125 0 0.28125 0 0.28125 0 0.28125 0 0.28125
		 0 0.27003175 0 0.27003175 0 0.28125 0 0.28125 0 0.26024252 0 0.26024252 0 0.28125
		 0 0.28125 0 0.26461172 0 0.25396201 0 0.22112504 2.9802322e-08 -0.22113049 2.9802322e-08
		 -0.25396973 0 -0.26468658 0 -0.28125 0 -0.28125 0 -0.26024252 0 -0.26024252 0 -0.28125
		 0 -0.28125 0 -0.27003181 0 -0.27003181 0 -0.28125 0 -0.28125 0 -0.28125 0 -0.28125
		 0 -0.28125 0;
createNode polyTweakUV -n "polyTweakUV22";
	rename -uid "6540BC5A-47D7-3993-ECC9-52B1A92D0CCC";
	setAttr ".uopa" yes;
	setAttr -s 1008 ".nuv";
	setAttr ".nuv[0:124]"  255 209 0.01493864 0.11123147 255 249
		 0.01493864 0.11123147 255 235 0 0.11898082 255 85 0 0.11898082 254 
		248 0.01493864 0.10224121 254 234 0 0.094491772 254 79 0 0.094491772 
		254 202 0.01493864 0.10224121 253 199 0.38506135 0.10224121 253 247
		 0.38506135 0.10224121 253 225 0.40000001 0.094491772 253 47 0.40000001
		 0.094491772 252 246 0.38506135 0.11123147 252 224 0.40000001 0.11898088 
		252 39 0.40000001 0.11898086 252 196 0.38506135 0.11123147 251 184
		 0.0079774139 0.36271864 251 245 0.0079774139 0.36271864 251 237 0 0.37027454 
		251 132 0 0.37027454 250 244 0.0079774139 0.35334143 250 236 0 0.34578544 
		250 128 0 0.34578544 250 180 0.0079774139 0.35334143 249 171 0.39202258
		 0.35334143 249 243 0.39202258 0.35334143 249 223 0.40000001 0.34578547 
		249 90 0.40000001 0.34578544 248 242 0.39202258 0.36271864 248 222
		 0.40000001 0.3702746 248 96 0.40000001 0.37027454 248 176 0.39202258
		 0.36271864 247 0 0 0.9467057 247 211 0 0.9467057 247 241 0 0.90815157 
		247 4 0 0.90815157 246 241 0 0.90815157 246 240 0 0.88366258 
		246 5 0 0.88366258 246 4 0 0.90815157 245 240 0 0.88366258 
		245 239 0 0.75065923 245 103 0 0.75065923 245 5 0 0.88366258 
		244 239 0 0.75065923 244 238 0 0.72617024 244 104 0 0.72617024 
		244 103 0 0.75065923 243 238 0 0.72617024 243 237 0 0.37027454 
		243 127 0 0.37027454 243 104 0 0.72617024 242 245 0.0079774139 0.36271864 
		242 244 0.0079774139 0.35334143 242 180 0.0079774139 0.35334143 242 
		178 0.0079774139 0.36271864 241 236 0 0.34578544 241 235 0 0.11898082 
		241 78 0 0.11898082 241 128 0 0.34578544 240 249 0.01493864 0.11123147 
		240 248 0.01493864 0.10224121 240 202 0.01493864 0.10224121 240 203
		 0.01493864 0.11123147 239 234 0 0.094491772 239 233 0 0.034051847 239 
		58 0 0.034051847 239 79 0 0.094491772 238 233 0 0.034051847 238 
		232 0.011778402 0.012145805 238 59 0.011831678 0.012110233 238 58
		 0 0.034051847 237 232 0.011778402 0.012145805 237 231 0.01939931 0.0070651057 
		237 55 0.019386137 0.0070738792 237 59 0.011831678 0.012110233 236 
		231 0.01939931 0.0070651057 236 230 0.042751648 0 236 56 0.04274217
		 0 236 55 0.019386137 0.0070738792 235 230 0.042751648 0 235 229
		 0.35724446 0 235 42 0.35723367 0 235 56 0.04274217 0 234 229
		 0.35724446 0 234 228 0.38059521 0.0070614815 234 43 0.38057992 0.0070512774 
		234 42 0.35723367 0 233 228 0.38059521 0.0070614815 233 227 0.38816833
		 0.012110233 233 36 0.38816833 0.012110233 233 43 0.38057992 0.0070512774 
		232 227 0.38816833 0.012110233 232 226 0.40000001 0.034217883 232 
		34 0.40000001 0.034217883 232 36 0.38816833 0.012110233 231 226 0.40000001
		 0.034217883 231 225 0.40000001 0.094491772 231 38 0.40000001 0.094491772 
		231 34 0.40000001 0.034217883 230 247 0.38506135 0.10224121 230 246
		 0.38506135 0.11123147 230 196 0.38506135 0.11123147 230 194 0.38506135
		 0.10224121 229 224 0.40000001 0.11898088 229 223 0.40000001 0.34578547 
		229 95 0.40000001 0.34578544 229 39 0.40000001 0.11898086 228 243
		 0.39202258 0.35334143 228 242 0.39202258 0.36271864 228 176 0.39202258
		 0.36271864 228 174 0.39202258 0.35334143 227 222 0.40000001 0.3702746 
		227 221 0.40000001 0.72617024 227 140 0.40000001 0.72617024 227 96
		 0.40000001 0.37027454 226 221 0.40000001 0.72617024 226 220 0.40000001
		 0.75065923 226 141 0.40000001 0.75065923 226 140 0.40000001 0.72617024 
		225 220 0.40000001 0.75065923 225 219 0.40000001 0.88366246 225 118
		 0.40000001 0.88366258 225 141 0.40000001 0.75065923 224 219 0.40000001
		 0.88366246;
	setAttr ".nuv[125:249]" 224 218 0.40000001 0.90815157 224 119 0.40000001
		 0.90815157 224 118 0.40000001 0.88366258 223 218 0.40000001 0.90815157 
		223 217 0.40000001 0.95078826 223 24 0.40000001 0.95078826 223 119
		 0.40000001 0.90815157 222 217 0.40000001 0.95078826 222 216 0.39147303
		 0.97423571 222 25 0.3914167 0.97430331 222 24 0.40000001 0.95078826 
		221 216 0.39147303 0.97423571 221 215 0.37858269 0.98970431 221 21
		 0.37860653 0.9896757 221 25 0.3914167 0.97430331 220 215 0.37858269
		 0.98970431 220 214 0.35657501 1.000000119209 220 22 0.35660222 1.000000119209 
		220 21 0.37860653 0.9896757 219 214 0.35657501 1.000000119209 219 
		213 0.043590188 0.99999994 219 8 0.043617666 1.000000119209 219 22
		 0.35660222 1.000000119209 218 213 0.043590188 0.99999994 218 212 0.021871448
		 0.98916596 218 9 0.021893119 0.98919481 218 8 0.043617666 1.000000119209 
		217 212 0.021871448 0.98916596 217 210 0.007979 0.97064275 217 2
		 0.007979 0.97064275 217 9 0.021893119 0.98919481 216 211 0 0.9467057 
		216 210 0.007979 0.97064275 216 10 0.007979 0.97064275 216 12
		 0 0.9467057 215 249 0.01493864 0.11123147 215 203 0.01493864 0.11123147 
		215 78 0 0.11898082 215 235 0 0.11898082 214 247 0.38506135 0.10224121 
		214 194 0.38506135 0.10224121 214 38 0.40000001 0.094491772 214 225
		 0.40000001 0.094491772 213 208 0.01493864 0.10224121 213 84 0 0.094491772 
		213 234 0 0.094491772 213 248 0.01493864 0.10224121 212 201 0.38506135
		 0.11123147 212 50 0.40000001 0.11898086 212 224 0.40000001 0.11898088 
		212 246 0.38506135 0.11123147 211 101 0.04224154 0.11898096 211 81
		 0.017752469 0.11898091 211 205 0.031208564 0.1112315 211 192 0.053652491
		 0.11123152 210 80 0.017752469 0.094491862 210 100 0.04224154 0.094491862 
		210 193 0.053652491 0.10224123 210 204 0.031208564 0.10224123 209 
		40 0.38224754 0.11898091 209 98 0.35775849 0.11898096 209 191 0.34634754
		 0.11123152 209 197 0.36879146 0.1112315 208 99 0.35775849 0.094491862 
		208 37 0.38224754 0.094491862 208 195 0.36879146 0.10224123 208 190
		 0.34634754 0.10224123 207 89 0.35775849 0.11898096 207 49 0.38224754
		 0.11898091 207 200 0.36879146 0.1112315 207 188 0.34634754 0.11123152 
		206 48 0.38224754 0.094491862 206 88 0.35775849 0.094491862 206 
		189 0.34634754 0.10224123 206 198 0.36879146 0.10224123 205 82 0.017752469
		 0.11898091 205 86 0.04224154 0.11898096 205 187 0.053652491 0.11123152 
		205 207 0.031208564 0.1112315 204 87 0.04224154 0.094491862 204 83
		 0.017752469 0.094491862 204 206 0.031208564 0.10224123 204 186 0.053652491
		 0.10224123 203 85 0 0.11898082 203 82 0.017752469 0.11898091 203 
		207 0.031208564 0.1112315 203 209 0.01493864 0.11123147 202 83 0.017752469
		 0.094491862 202 84 0 0.094491772 202 208 0.01493864 0.10224121 202 
		206 0.031208564 0.10224123 201 81 0.017752469 0.11898091 201 78 0
		 0.11898082 201 203 0.01493864 0.11123147 201 205 0.031208564 0.1112315 
		200 79 0 0.094491772 200 80 0.017752469 0.094491862 200 204 0.031208564
		 0.10224123 200 202 0.01493864 0.10224121 199 49 0.38224754 0.11898091 
		199 50 0.40000001 0.11898086 199 201 0.38506135 0.11123147 199 200
		 0.36879146 0.1112315 198 47 0.40000001 0.094491772 198 48 0.38224754
		 0.094491862 198 198 0.36879146 0.10224123 198 199 0.38506135 0.10224121 
		197 39 0.40000001 0.11898086 197 40 0.38224754 0.11898091 197 197
		 0.36879146 0.1112315 197 196 0.38506135 0.11123147 196 37 0.38224754
		 0.094491862 196 38 0.40000001 0.094491772 196 194 0.38506135 0.10224121 
		196 195 0.36879146 0.10224123 195 100 0.04224154 0.094491862 195 99
		 0.35775849 0.094491862 195 190 0.34634754 0.10224123 195 193 0.053652491
		 0.10224123 194 98 0.35775849 0.11898096 194 101 0.04224154 0.11898096 
		194 192 0.053652491 0.11123152 194 191 0.34634754 0.11123152 193 88
		 0.35775849 0.094491862 193 87 0.04224154 0.094491862;
	setAttr ".nuv[250:374]" 193 186 0.053652491 0.10224123 193 189
		 0.34634754 0.10224123 192 86 0.04224154 0.11898096 192 89 0.35775849
		 0.11898096 192 188 0.34634754 0.11123152 192 187 0.053652491 0.11123152 
		191 245 0.0079774139 0.36271864 191 178 0.0079774139 0.36271864 191 
		127 0 0.37027454 191 237 0 0.37027454 190 243 0.39202258 0.35334143 
		190 174 0.39202258 0.35334143 190 95 0.40000001 0.34578544 190 223
		 0.40000001 0.34578547 189 182 0.0079774139 0.35334143 189 131 0 0.34578544 
		189 236 0 0.34578544 189 244 0.0079774139 0.35334143 188 173 0.39202258
		 0.36271864 188 93 0.40000001 0.37027454 188 222 0.40000001 0.3702746 
		188 242 0.39202258 0.36271864 187 145 0.042241551 0.37027463 187 126
		 0.017752482 0.3702746 187 179 0.024938202 0.36271864 187 168 0.048335135
		 0.36271864 186 129 0.017752482 0.34578553 186 144 0.042241551 0.34578553 
		186 169 0.048335135 0.35334143 186 181 0.024938202 0.35334143 185 
		97 0.38224754 0.3702746 185 143 0.35775849 0.37027463 185 167 0.3516649
		 0.36271864 185 177 0.37506184 0.36271864 184 142 0.35775849 0.34578553 
		184 94 0.38224754 0.34578553 184 175 0.37506184 0.35334143 184 166
		 0.3516649 0.35334143 183 137 0.35775849 0.37027463 183 92 0.38224754
		 0.3702746 183 172 0.37506184 0.36271864 183 164 0.3516649 0.36271864 
		182 91 0.38224754 0.34578553 182 136 0.35775849 0.34578553 182 165
		 0.3516649 0.35334143 182 170 0.37506184 0.35334143 181 133 0.017752482
		 0.3702746 181 135 0.042241551 0.37027463 181 163 0.048335135 0.36271864 
		181 185 0.024938202 0.36271864 180 134 0.042241551 0.34578553 180 
		130 0.017752482 0.34578553 180 183 0.024938202 0.35334143 180 162 0.048335135
		 0.35334143 179 132 0 0.37027454 179 133 0.017752482 0.3702746 179 
		185 0.024938202 0.36271864 179 184 0.0079774139 0.36271864 178 130
		 0.017752482 0.34578553 178 131 0 0.34578544 178 182 0.0079774139 0.35334143 
		178 183 0.024938202 0.35334143 177 128 0 0.34578544 177 129 0.017752482
		 0.34578553 177 181 0.024938202 0.35334143 177 180 0.0079774139 0.35334143 
		176 126 0.017752482 0.3702746 176 127 0 0.37027454 176 178 0.0079774139
		 0.36271864 176 179 0.024938202 0.36271864 175 96 0.40000001 0.37027454 
		175 97 0.38224754 0.3702746 175 177 0.37506184 0.36271864 175 176
		 0.39202258 0.36271864 174 94 0.38224754 0.34578553 174 95 0.40000001
		 0.34578544 174 174 0.39202258 0.35334143 174 175 0.37506184 0.35334143 
		173 92 0.38224754 0.3702746 173 93 0.40000001 0.37027454 173 173
		 0.39202258 0.36271864 173 172 0.37506184 0.36271864 172 90 0.40000001
		 0.34578544 172 91 0.38224754 0.34578553 172 170 0.37506184 0.35334143 
		172 171 0.39202258 0.35334143 171 144 0.042241551 0.34578553 171 142
		 0.35775849 0.34578553 171 166 0.3516649 0.35334143 171 169 0.048335135
		 0.35334143 170 143 0.35775849 0.37027463 170 145 0.042241551 0.37027463 
		170 168 0.048335135 0.36271864 170 167 0.3516649 0.36271864 169 136
		 0.35775849 0.34578553 169 134 0.042241551 0.34578553 169 162 0.048335135
		 0.35334143 169 165 0.3516649 0.35334143 168 135 0.042241551 0.37027463 
		168 137 0.35775849 0.37027463 168 164 0.3516649 0.36271864 168 163
		 0.048335135 0.36271864 167 15 0 0.90815157 167 241 0 0.90815157 167 
		211 0 0.9467057 167 12 0 0.9467057 166 14 0 0.88366258 166 240
		 0 0.88366258 166 241 0 0.90815157 166 15 0 0.90815157 165 108
		 0 0.75065923 165 239 0 0.75065923 165 240 0 0.88366258 165 14
		 0 0.88366258 164 107 0 0.72617024 164 238 0 0.72617024 164 239
		 0 0.75065923 164 108 0 0.75065923 163 132 0 0.37027454 163 237
		 0 0.37027454 163 238 0 0.72617024 163 107 0 0.72617024 162 182
		 0.0079774139 0.35334143 162 244 0.0079774139 0.35334143 162 245 0.0079774139
		 0.36271864;
	setAttr ".nuv[375:499]" 162 184 0.0079774139 0.36271864 161 85
		 0 0.11898082 161 235 0 0.11898082 161 236 0 0.34578544 161 131
		 0 0.34578544 160 208 0.01493864 0.10224121 160 248 0.01493864 0.10224121 
		160 249 0.01493864 0.11123147 160 209 0.01493864 0.11123147 159 65
		 0 0.034051847 159 233 0 0.034051847 159 234 0 0.094491772 159 84
		 0 0.094491772 158 64 0.011693525 0.01220231 158 232 0.011778402 0.012145805 
		158 233 0 0.034051847 158 65 0 0.034051847 157 62 0.019420087
		 0.0070512774 157 231 0.01939931 0.0070651057 157 232 0.011778402 0.012145805 
		157 64 0.011693525 0.01220231 156 61 0.042766321 0 156 230 0.042751648
		 0 156 231 0.01939931 0.0070651057 156 62 0.019420087 0.0070512774 155 
		52 0.35725784 0 155 229 0.35724446 0 155 230 0.042751648 0 155 
		61 0.042766321 0 154 51 0.38061386 0.0070738792 154 228 0.38059521
		 0.0070614815 154 229 0.35724446 0 154 52 0.35725784 0 153 44
		 0.38816833 0.012110233 153 227 0.38816833 0.012110233 153 228 0.38059521
		 0.0070614815 153 51 0.38061386 0.0070738792 152 46 0.40000001 0.034217883 
		152 226 0.40000001 0.034217883 152 227 0.38816833 0.012110233 152 
		44 0.38816833 0.012110233 151 47 0.40000001 0.094491772 151 225 0.40000001
		 0.094491772 151 226 0.40000001 0.034217883 151 46 0.40000001 0.034217883 
		150 201 0.38506135 0.11123147 150 246 0.38506135 0.11123147 150 247
		 0.38506135 0.10224121 150 199 0.38506135 0.10224121 149 90 0.40000001
		 0.34578544 149 223 0.40000001 0.34578547 149 224 0.40000001 0.11898088 
		149 50 0.40000001 0.11898086 148 173 0.39202258 0.36271864 148 242
		 0.39202258 0.36271864 148 243 0.39202258 0.35334143 148 171 0.39202258
		 0.35334143 147 139 0.40000001 0.72617024 147 221 0.40000001 0.72617024 
		147 222 0.40000001 0.3702746 147 93 0.40000001 0.37027454 146 138
		 0.40000001 0.75065923 146 220 0.40000001 0.75065923 146 221 0.40000001
		 0.72617024 146 139 0.40000001 0.72617024 145 117 0.40000001 0.88366258 
		145 219 0.40000001 0.88366246 145 220 0.40000001 0.75065923 145 138
		 0.40000001 0.75065923 144 116 0.40000001 0.90815157 144 218 0.40000001
		 0.90815157 144 219 0.40000001 0.88366246 144 117 0.40000001 0.88366258 
		143 33 0.40000001 0.95078826 143 217 0.40000001 0.95078826 143 218
		 0.40000001 0.90815157 143 116 0.40000001 0.90815157 142 32 0.39154005
		 0.97415531 142 216 0.39147303 0.97423571 142 217 0.40000001 0.95078826 
		142 33 0.40000001 0.95078826 141 29 0.37855417 0.98973852 141 215
		 0.37858269 0.98970431 141 216 0.39147303 0.97423571 141 32 0.39154005
		 0.97415531 140 28 0.35654208 1.000000119209 140 214 0.35657501 1.000000119209 
		140 215 0.37858269 0.98970431 140 29 0.37855417 0.98973852 139 18
		 0.043548513 1.000000119209 139 213 0.043590188 0.99999994 139 214 0.35657501
		 1.000000119209 139 28 0.35654208 1.000000119209 138 17 0.021838117
		 0.9891215 138 212 0.021871448 0.98916596 138 213 0.043590188 0.99999994 
		138 18 0.043548513 1.000000119209 137 10 0.007979 0.97064275 137 
		210 0.007979 0.97064275 137 212 0.021871448 0.98916596 137 17 0.021838117
		 0.9891215 136 210 0.007979 0.97064275 136 211 0 0.9467057 136 0
		 0 0.9467057 136 2 0.007979 0.97064275 135 111 0.042241551 0.75065941 
		135 72 0.04224154 0.88366276 135 156 0.04224154 0.88366276 135 161
		 0.042241551 0.75065941 134 114 0.35775849 0.75065941 134 111 0.042241551
		 0.75065941 134 161 0.042241551 0.75065941 134 159 0.35775849 0.75065941 
		133 75 0.35775849 0.88366276 133 114 0.35775849 0.75065941 133 159
		 0.35775849 0.75065941 133 155 0.35775849 0.88366276 132 72 0.04224154
		 0.88366276 132 75 0.35775849 0.88366276 132 155 0.35775849 0.88366276 
		132 156 0.04224154 0.88366276 131 160 0.046973135 0.755391 131 157
		 0.04697312 0.87893122 131 151 0.059825242 0.87108302 131 153 0.059825253
		 0.76323915;
	setAttr ".nuv[500:624]" 130 158 0.3530269 0.755391 130 160 0.046973135
		 0.755391 130 153 0.059825253 0.76323915 130 152 0.34017476 0.76323915 
		129 154 0.3530269 0.87893122 129 158 0.3530269 0.755391 129 152
		 0.34017476 0.76323915 129 150 0.34017476 0.87108302 128 157 0.04697312
		 0.87893122 128 154 0.3530269 0.87893122 128 150 0.34017476 0.87108302 
		128 151 0.059825242 0.87108302 127 158 0.3530269 0.755391 127 159
		 0.35775849 0.75065941 127 161 0.042241551 0.75065941 127 160 0.046973135
		 0.755391 126 156 0.04224154 0.88366276 126 157 0.04697312 0.87893122 
		126 160 0.046973135 0.755391 126 161 0.042241551 0.75065941 125 155
		 0.35775849 0.88366276 125 154 0.3530269 0.87893122 125 157 0.04697312
		 0.87893122 125 156 0.04224154 0.88366276 124 154 0.3530269 0.87893122 
		124 155 0.35775849 0.88366276 124 159 0.35775849 0.75065941 124 158
		 0.3530269 0.755391 123 147 0.059825242 0.87108302 123 149 0.059825253
		 0.76323915 123 153 0.059825253 0.76323915 123 151 0.059825242 0.87108302 
		122 149 0.059825253 0.76323915 122 148 0.34017476 0.76323915 122 152
		 0.34017476 0.76323915 122 153 0.059825253 0.76323915 121 148 0.34017476
		 0.76323915 121 146 0.34017476 0.87108302 121 150 0.34017476 0.87108302 
		121 152 0.34017476 0.76323915 120 146 0.34017476 0.87108302 120 147
		 0.059825242 0.87108302 120 151 0.059825242 0.87108302 120 150 0.34017476
		 0.87108302 119 181 0.024938202 0.35334143 119 169 0.048335135 0.35334143 
		119 168 0.048335135 0.36271864 119 179 0.024938202 0.36271864 118 
		166 0.3516649 0.35334143 118 175 0.37506184 0.35334143 118 177 0.37506184
		 0.36271864 118 167 0.3516649 0.36271864 117 140 0.40000001 0.72617024 
		117 141 0.40000001 0.75065923 117 122 0.38224754 0.75065935 117 121
		 0.38224754 0.7261703 116 112 0.38224754 0.7261703 116 115 0.38224754
		 0.75065935 116 138 0.40000001 0.75065923 116 139 0.40000001 0.72617024 
		115 170 0.37506184 0.35334143 115 165 0.3516649 0.35334143 115 164
		 0.3516649 0.36271864 115 172 0.37506184 0.36271864 114 162 0.048335135
		 0.35334143 114 183 0.024938202 0.35334143 114 185 0.024938202 0.36271864 
		114 163 0.048335135 0.36271864 113 183 0.024938202 0.35334143 113 
		182 0.0079774139 0.35334143 113 184 0.0079774139 0.36271864 113 185
		 0.024938202 0.36271864 112 179 0.024938202 0.36271864 112 178 0.0079774139
		 0.36271864 112 180 0.0079774139 0.35334143 112 181 0.024938202 0.35334143 
		111 105 0.017752482 0.7261703 111 124 0.042241551 0.72617042 111 125
		 0.042241551 0.75065941 111 102 0.017752482 0.75065935 110 120 0.35775849
		 0.72617042 110 121 0.38224754 0.7261703 110 122 0.38224754 0.75065935 
		110 123 0.35775849 0.75065941 109 118 0.40000001 0.88366258 109 119
		 0.40000001 0.90815157 109 70 0.38224754 0.90815169 109 69 0.38224754
		 0.88366264 108 74 0.38224754 0.88366264 108 77 0.3826836 0.90815169 
		108 116 0.40000001 0.90815157 108 117 0.40000001 0.88366258 107 112
		 0.38224754 0.7261703 107 113 0.35775849 0.72617042 107 114 0.35775849
		 0.75065941 107 115 0.38224754 0.75065935 106 110 0.042241551 0.72617042 
		106 106 0.017752482 0.7261703 106 109 0.017752482 0.75065935 106 111
		 0.042241551 0.75065941 105 106 0.017752482 0.7261703 105 107 0 0.72617024 
		105 108 0 0.75065923 105 109 0.017752482 0.75065935 104 102 0.017752482
		 0.75065935 104 103 0 0.75065923 104 104 0 0.72617024 104 105 0.017752482
		 0.7261703 103 205 0.031208564 0.1112315 103 204 0.031208564 0.10224123 
		103 193 0.053652491 0.10224123 103 192 0.053652491 0.11123152 102 
		191 0.34634754 0.11123152 102 190 0.34634754 0.10224123 102 195 0.36879146
		 0.10224123 102 197 0.36879146 0.1112315 101 175 0.37506184 0.35334143 
		101 174 0.39202258 0.35334143 101 176 0.39202258 0.36271864 101 177
		 0.37506184 0.36271864 100 171 0.39202258 0.35334143 100 170 0.37506184
		 0.35334143 100 172 0.37506184 0.36271864 100 173 0.39202258 0.36271864 
		99 200 0.36879146 0.1112315;
	setAttr ".nuv[625:749]" 99 198 0.36879146 0.10224123 99 189 0.34634754
		 0.10224123 99 188 0.34634754 0.11123152 98 187 0.053652491 0.11123152 
		98 186 0.053652491 0.10224123 98 206 0.031208564 0.10224123 98 
		207 0.031208564 0.1112315 97 207 0.031208564 0.1112315 97 206 0.031208564
		 0.10224123 97 208 0.01493864 0.10224121 97 209 0.01493864 0.11123147 
		96 203 0.01493864 0.11123147 96 202 0.01493864 0.10224121 96 204
		 0.031208564 0.10224123 96 205 0.031208564 0.1112315 95 74 0.38224754
		 0.88366264 95 75 0.35775849 0.88366276 95 76 0.35775849 0.90815181 
		95 77 0.3826836 0.90815169 94 72 0.04224154 0.88366276 94 13
		 0.017752469 0.88366264 94 16 0.01731639 0.90815169 94 73 0.04224154
		 0.90815181 93 68 0.35775849 0.88366276 93 69 0.38224754 0.88366264 
		93 70 0.38224754 0.90815169 93 71 0.35775849 0.90815181 92 6
		 0.017752469 0.88366264 92 66 0.04224154 0.88366276 92 67 0.04224154
		 0.90815181 92 3 0.017752469 0.90815169 91 63 0.017659569 0.029194547 
		91 64 0.011693525 0.01220231 91 65 0 0.034051847 90 60 0.042271651
		 0.017358972 90 61 0.042766321 0 90 62 0.019420087 0.0070512774 90 
		63 0.017659569 0.029194547 89 58 0 0.034051847 89 59 0.011831678
		 0.012110233 89 54 0.017659569 0.029194547 88 54 0.017659569 0.029194547 
		88 55 0.019386137 0.0070738792 88 56 0.04274217 0 88 57 0.042271651
		 0.017358972 87 45 0.38234043 0.029194547 87 51 0.38061386 0.0070738792 
		87 52 0.35725784 0 87 53 0.35772836 0.017358972 86 199 0.38506135
		 0.10224121 86 198 0.36879146 0.10224123 86 200 0.36879146 0.1112315 
		86 201 0.38506135 0.11123147 85 44 0.38816833 0.012110233 85 45
		 0.38234043 0.029194547 85 46 0.40000001 0.034217883 84 41 0.35772836
		 0.017358972 84 42 0.35723367 0 84 43 0.38057992 0.0070512774 84 
		35 0.38234043 0.029194547 83 195 0.36879146 0.10224123 83 194 0.38506135
		 0.10224121 83 196 0.38506135 0.11123147 83 197 0.36879146 0.1112315 
		82 34 0.40000001 0.034217883 82 35 0.38234043 0.029194547 82 
		36 0.38816833 0.012110233 81 31 0.38350055 0.95802969 81 32 0.39154005
		 0.97415531 81 33 0.40000001 0.95078826 80 27 0.35767069 0.98255956 
		80 28 0.35654208 1.000000119209 80 29 0.37855417 0.98973852 80 
		30 0.38241151 0.95769823 79 24 0.40000001 0.95078826 79 25 0.3914167
		 0.97430331 79 26 0.38350055 0.95802969 78 20 0.38241151 0.95769823 
		78 21 0.37860653 0.9896757 78 22 0.35660222 1.000000119209 78 
		23 0.35767069 0.98255956 77 11 0.017573083 0.95415133 77 17 0.021838117
		 0.9891215 77 18 0.043548513 1.000000119209 77 19 0.04234308 0.98254007 
		76 13 0.017752469 0.88366264 76 14 0 0.88366258 76 15 0 0.90815157 
		76 16 0.01731639 0.90815169 75 10 0.007979 0.97064275 75 11
		 0.017573083 0.95415133 75 12 0 0.9467057 74 7 0.04234308 0.98254007 
		74 8 0.043617666 1.000000119209 74 9 0.021893119 0.98919481 74 
		1 0.017573083 0.95415133 73 3 0.017752469 0.90815169 73 4 0
		 0.90815157 73 5 0 0.88366258 73 6 0.017752469 0.88366264 72 
		0 0 0.9467057 72 1 0.017573083 0.95415133 72 2 0.007979 0.97064275 
		71 120 0.35775849 0.72617042 71 124 0.042241551 0.72617042 71 145
		 0.042241551 0.37027463 71 143 0.35775849 0.37027463 70 110 0.042241551
		 0.72617042 70 113 0.35775849 0.72617042 70 137 0.35775849 0.37027463 
		70 135 0.042241551 0.37027463 69 68 0.35775849 0.88366276 69 66
		 0.04224154 0.88366276 69 125 0.042241551 0.75065941 69 123 0.35775849
		 0.75065941 68 147 0.059825242 0.87108302 68 146 0.34017476 0.87108302 
		68 148 0.34017476 0.76323915 68 149 0.059825253 0.76323915 67 7
		 0.04234308 0.98254007 67 67 0.04224154 0.90815181 67 71 0.35775849
		 0.90815181 67 23 0.35767069 0.98255956 66 20 0.38241151 0.95769823 
		66 70 0.38224754 0.90815169;
	setAttr ".nuv[750:874]" 66 26 0.38350055 0.95802969 65 77 0.3826836
		 0.90815169 65 30 0.38241151 0.95769823 65 31 0.38350055 0.95802969 
		64 27 0.35767069 0.98255956 64 76 0.35775849 0.90815181 64 73
		 0.04224154 0.90815181 64 19 0.04234308 0.98254007 63 142 0.35775849
		 0.34578553 63 144 0.042241551 0.34578553 63 101 0.04224154 0.11898096 
		63 98 0.35775849 0.11898096 62 134 0.042241551 0.34578553 62 136
		 0.35775849 0.34578553 62 89 0.35775849 0.11898096 62 86 0.04224154
		 0.11898096 61 87 0.04224154 0.094491862 61 88 0.35775849 0.094491862 
		61 53 0.35772836 0.017358972 61 60 0.042271651 0.017358972 60 
		99 0.35775849 0.094491862 60 100 0.04224154 0.094491862 60 57 0.042271651
		 0.017358972 60 41 0.35772836 0.017358972 59 166 0.3516649 0.35334143 
		59 167 0.3516649 0.36271864 59 168 0.048335135 0.36271864 59 169
		 0.048335135 0.35334143 58 162 0.048335135 0.35334143 58 163 0.048335135
		 0.36271864 58 164 0.3516649 0.36271864 58 165 0.3516649 0.35334143 
		57 124 0.042241551 0.72617042 57 105 0.017752482 0.7261703 57 126
		 0.017752482 0.3702746 57 145 0.042241551 0.37027463 56 121 0.38224754
		 0.7261703 56 120 0.35775849 0.72617042 56 143 0.35775849 0.37027463 
		56 97 0.38224754 0.3702746 55 120 0.35775849 0.72617042 55 123
		 0.35775849 0.75065941 55 125 0.042241551 0.75065941 55 124 0.042241551
		 0.72617042 54 118 0.40000001 0.88366258 54 69 0.38224754 0.88366264 
		54 122 0.38224754 0.75065935 54 141 0.40000001 0.75065923 53 74
		 0.38224754 0.88366264 53 117 0.40000001 0.88366258 53 138 0.40000001
		 0.75065923 53 115 0.38224754 0.75065935 52 113 0.35775849 0.72617042 
		52 112 0.38224754 0.7261703 52 92 0.38224754 0.3702746 52 137
		 0.35775849 0.37027463 51 106 0.017752482 0.7261703 51 110 0.042241551
		 0.72617042 51 135 0.042241551 0.37027463 51 133 0.017752482 0.3702746 
		50 110 0.042241551 0.72617042 50 111 0.042241551 0.75065941 50 
		114 0.35775849 0.75065941 50 113 0.35775849 0.72617042 49 107 0 0.72617024 
		49 106 0.017752482 0.7261703 49 133 0.017752482 0.3702746 49 132
		 0 0.37027454 48 105 0.017752482 0.7261703 48 104 0 0.72617024 48 
		127 0 0.37027454 48 126 0.017752482 0.3702746 47 81 0.017752469
		 0.11898091 47 101 0.04224154 0.11898096 47 144 0.042241551 0.34578553 
		47 129 0.017752482 0.34578553 46 190 0.34634754 0.10224123 46 191
		 0.34634754 0.11123152 46 192 0.053652491 0.11123152 46 193 0.053652491
		 0.10224123 45 98 0.35775849 0.11898096 45 40 0.38224754 0.11898091 
		45 94 0.38224754 0.34578553 45 142 0.35775849 0.34578553 44 97
		 0.38224754 0.3702746 44 96 0.40000001 0.37027454 44 140 0.40000001
		 0.72617024 44 121 0.38224754 0.7261703 43 93 0.40000001 0.37027454 
		43 92 0.38224754 0.3702746 43 112 0.38224754 0.7261703 43 139
		 0.40000001 0.72617024 42 49 0.38224754 0.11898091 42 89 0.35775849
		 0.11898096 42 136 0.35775849 0.34578553 42 91 0.38224754 0.34578553 
		41 186 0.053652491 0.10224123 41 187 0.053652491 0.11123152 41 
		188 0.34634754 0.11123152 41 189 0.34634754 0.10224123 40 86 0.04224154
		 0.11898096 40 82 0.017752469 0.11898091 40 130 0.017752482 0.34578553 
		40 134 0.042241551 0.34578553 39 82 0.017752469 0.11898091 39 
		85 0 0.11898082 39 131 0 0.34578544 39 130 0.017752482 0.34578553 
		38 78 0 0.11898082 38 81 0.017752469 0.11898091 38 129 0.017752482
		 0.34578553 38 128 0 0.34578544 37 75 0.35775849 0.88366276 37 
		74 0.38224754 0.88366264 37 115 0.38224754 0.75065935 37 114 0.35775849
		 0.75065941 36 13 0.017752469 0.88366264 36 72 0.04224154 0.88366276 
		36 111 0.042241551 0.75065941 36 109 0.017752482 0.75065935 35 
		72 0.04224154 0.88366276 35 73 0.04224154 0.90815181 35 76 0.35775849
		 0.90815181 35 75 0.35775849 0.88366276 34 69 0.38224754 0.88366264;
	setAttr ".nuv[875:999]" 34 68 0.35775849 0.88366276 34 123 0.35775849
		 0.75065941 34 122 0.38224754 0.75065935 33 67 0.04224154 0.90815181 
		33 66 0.04224154 0.88366276 33 68 0.35775849 0.88366276 33 71
		 0.35775849 0.90815181 32 66 0.04224154 0.88366276 32 6 0.017752469
		 0.88366264 32 102 0.017752482 0.75065935 32 125 0.042241551 0.75065941 
		31 63 0.017659569 0.029194547 31 65 0 0.034051847 31 84 0
		 0.094491772 31 83 0.017752469 0.094491862 30 63 0.017659569 0.029194547 
		30 62 0.019420087 0.0070512774 30 64 0.011693525 0.01220231 29 
		60 0.042271651 0.017358972 29 63 0.017659569 0.029194547 29 83
		 0.017752469 0.094491862 29 87 0.04224154 0.094491862 28 58 0 0.034051847 
		28 54 0.017659569 0.029194547 28 80 0.017752469 0.094491862 28 
		79 0 0.094491772 27 55 0.019386137 0.0070738792 27 54 0.017659569
		 0.029194547 27 59 0.011831678 0.012110233 26 54 0.017659569 0.029194547 
		26 57 0.042271651 0.017358972 26 100 0.04224154 0.094491862 26 
		80 0.017752469 0.094491862 25 53 0.35772836 0.017358972 25 52
		 0.35725784 0 25 61 0.042766321 0 25 60 0.042271651 0.017358972 24 
		45 0.38234043 0.029194547 24 53 0.35772836 0.017358972 24 88 0.35775849
		 0.094491862 24 48 0.38224754 0.094491862 23 50 0.40000001 0.11898086 
		23 49 0.38224754 0.11898091 23 91 0.38224754 0.34578553 23 90
		 0.40000001 0.34578544 22 46 0.40000001 0.034217883 22 45 0.38234043
		 0.029194547 22 48 0.38224754 0.094491862 22 47 0.40000001 0.094491772 
		21 45 0.38234043 0.029194547 21 44 0.38816833 0.012110233 21 
		51 0.38061386 0.0070738792 20 42 0.35723367 0 20 41 0.35772836
		 0.017358972 20 57 0.042271651 0.017358972 20 56 0.04274217 0 19 
		41 0.35772836 0.017358972 19 35 0.38234043 0.029194547 19 37 0.38224754
		 0.094491862 19 99 0.35775849 0.094491862 18 40 0.38224754 0.11898091 
		18 39 0.40000001 0.11898086 18 95 0.40000001 0.34578544 18 94
		 0.38224754 0.34578553 17 36 0.38816833 0.012110233 17 35 0.38234043
		 0.029194547 17 43 0.38057992 0.0070512774 16 35 0.38234043 0.029194547 
		16 34 0.40000001 0.034217883 16 38 0.40000001 0.094491772 16 
		37 0.38224754 0.094491862 15 31 0.38350055 0.95802969 15 33 0.40000001
		 0.95078826 15 116 0.40000001 0.90815157 15 77 0.3826836 0.90815169 
		14 30 0.38241151 0.95769823 14 29 0.37855417 0.98973852 14 32
		 0.39154005 0.97415531 14 31 0.38350055 0.95802969 13 27 0.35767069
		 0.98255956 13 30 0.38241151 0.95769823 13 77 0.3826836 0.90815169 
		13 76 0.35775849 0.90815181 12 24 0.40000001 0.95078826 12 26
		 0.38350055 0.95802969 12 70 0.38224754 0.90815169 12 119 0.40000001
		 0.90815157 11 21 0.37860653 0.9896757 11 20 0.38241151 0.95769823 
		11 26 0.38350055 0.95802969 11 25 0.3914167 0.97430331 10 20
		 0.38241151 0.95769823 10 23 0.35767069 0.98255956 10 71 0.35775849
		 0.90815181 10 70 0.38224754 0.90815169 9 19 0.04234308 0.98254007 
		9 18 0.043548513 1.000000119209 9 28 0.35654208 1.000000119209 
		9 27 0.35767069 0.98255956 8 11 0.017573083 0.95415133 8 19
		 0.04234308 0.98254007 8 73 0.04224154 0.90815181 8 16 0.01731639
		 0.90815169 7 14 0 0.88366258 7 13 0.017752469 0.88366264 7 
		109 0.017752482 0.75065935 7 108 0 0.75065923 6 12 0 0.9467057 
		6 11 0.017573083 0.95415133 6 16 0.01731639 0.90815169 6 15
		 0 0.90815157 5 11 0.017573083 0.95415133 5 10 0.007979 0.97064275 
		5 17 0.021838117 0.9891215 4 8 0.043617666 1.000000119209 4 
		7 0.04234308 0.98254007 4 23 0.35767069 0.98255956 4 22 0.35660222
		 1.000000119209 3 7 0.04234308 0.98254007 3 1 0.017573083 0.95415133 
		3 3 0.017752469 0.90815169 3 67 0.04224154 0.90815181 2 6
		 0.017752469 0.88366264 2 5 0 0.88366258 2 103 0 0.75065923;
	setAttr ".nuv[1000:1007]" 2 102 0.017752482 0.75065935 1 2
		 0.007979 0.97064275 1 1 0.017573083 0.95415133 1 9 0.021893119
		 0.98919481 0 1 0.017573083 0.95415133 0 0 0 0.9467057 0 
		4 0 0.90815157 0 3 0.017752469 0.90815169;
createNode polyMapSew -n "polyMapSew1";
	rename -uid "302FA5BF-44F4-DFFB-9BBB-1DAD3E78FB8B";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:503]";
createNode polyMapCut -n "polyMapCut1";
	rename -uid "C47DE588-4ADD-14D2-6BD7-8DAE2E378B38";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 4 "e[464:470]" "e[479:495]" "e[498:499]" "e[501:503]";
createNode polyTweakUV -n "polyTweakUV23";
	rename -uid "F05D2587-4F01-13CC-FFE5-5EBEB028CE11";
	setAttr ".uopa" yes;
	setAttr -s 278 ".uvtk";
	setAttr ".uvtk[0:249]" -type "float2" 0.094531991 -0.026297979 0.10077447
		 -0.016415393 0.091695264 0.0032454426 0.085242316 -0.0027779588 0.10143761 -0.030337237
		 0.097095005 -0.042784713 0.08078818 0.0093975943 0.086288795 0.01516214 0.067776561
		 0.073849268 0.063278213 0.070591889 0.084619358 -0.044519752 0.072348632 -0.0076968321
		 0.086215049 -0.049456477 -0.078540541 -0.065817311 -0.074544631 -0.070622757 0.54964608
		 -0.026223086 0.56230175 -0.030944251 0.53924656 -0.042814411 0.57886922 -0.017086601
		 0.55811536 -0.0025528506 0.58686346 0.0018442419 0.59163934 0.012972917 0.56118691
		 0.0091867074 0.57514787 0.060432687 0.60623008 0.063807383 0.51043504 -0.044104464
		 0.52096933 -0.0057753758 0.50682932 -0.049117684 0.038143232 -0.06709905 0.039443672
		 -0.062202536 -0.094221964 -0.053378046 -0.083630793 -0.029001251 -0.096108302 -0.028604582
		 -0.088233873 -0.067618385 -0.094819054 -0.053569734 -0.095574871 -0.059903465 -0.10070156
		 -0.048071697 -0.10176193 -0.027363315 0.0053463997 -0.050564542 0.006408629 -0.026186012
		 0.043419249 -0.025734387 0.0078508109 -0.065055326 -0.010761337 -0.057470925 0.0037701316
		 -0.050775006 -0.023555459 -0.045744538 -0.022603631 -0.02561596 -0.11417527 0.38404426
		 -0.12033057 0.3775129 -0.11516147 0.34543282 -0.10908245 0.3489984 -0.11570916 0.39057499
		 -0.11169521 0.39350247 -0.10831468 0.34445959 -0.11286097 0.34331903 -0.11394814
		 0.23454241 -0.10994295 0.23536806 -0.10028574 0.39131156 -0.097006783 0.35280219
		 -0.098481327 0.39588368 0.058830105 0.38483936 0.058920495 0.38895944 0.012331545
		 0.38086113 0.0022143852 0.38739941 0.013329517 0.3901554 -0.01685714 0.37470564 0.0074057626
		 0.34686199 -0.022048168 0.34347954 -0.024434011 0.34169254 0.0064945268 0.34243864
		 0.010744039 0.23396043 -0.020827837 0.23346306 0.047696389 0.38747361 0.044348978
		 0.35059243 0.046899416 0.39220679 0.52030879 0.3845323 0.5215373 0.3805638 0.072196223
		 0.37736726 0.049330629 0.34881845 0.062254369 0.34385893 0.071830027 0.38606691 0.075586967
		 0.38314542 0.078998655 0.37017253 0.069206208 0.33920383 0.55746162 0.37258083 0.56747472
		 0.33784074 0.53139001 0.34266841 0.55404973 0.3818858 0.5655666 0.37879673 0.5861029
		 0.36497119 0.59602451 0.33317846 0.068584062 0.0043346579 0.052060805 0.067624062
		 -0.084968321 -0.016931208 -0.097004123 -0.016655238 -0.09114977 0.046229802 -0.10228962
		 0.045878492 0.5239054 0.0067425515 0.044478096 -0.013340319 0.53756279 0.056915596
		 0.0079432614 -0.014371539 0.012758661 0.041721009 0.050579332 0.040158056 0.063573509
		 0.33848488 0.058626711 0.34041867 0.048708871 0.2411636 0.052643448 0.24032889 0.57137704
		 0.33403432 0.60193366 0.33193809 0.61509943 0.23028345 0.58350956 0.23128186 0.53399938
		 0.33472568 0.54520899 0.23251398 0.51486421 0.34111887 0.51550561 0.33681247 0.061786212
		 0.34370646 0.061774828 0.34825924 0.044210546 0.34186617 0.048968039 0.23474948 -0.020641051
		 0.22532947 0.010954563 0.22491725 0.013154406 0.053236037 -0.01819567 0.054061085
		 -0.1100835 0.22642781 -0.11394248 0.22652633 -0.1075056 0.057222813 -0.10330082 0.057662994
		 -0.0969695 0.34433934 -0.099219635 0.23651163 -0.09151087 0.35067692 -0.09159226
		 0.34621891 0.042600669 0.34280929 0.043147661 0.34714654 0.047186218 0.34085292 0.037809394
		 0.24222814 0.061048403 0.081271589 0.065266699 0.083974242 0.053001463 0.23482843
		 0.048821554 0.23401619 0.60816997 0.073414288 0.5768106 0.070986293 0.58391166 0.22384749
		 0.61522657 0.22448371 0.53886873 0.068684295 0.051118068 0.052472383 0.54591566 0.2228138
		 0.049239866 0.22415869 -0.022121578 -0.014433587 -0.018472232 0.042844672 -0.10228246
		 -0.015721465 -0.10656162 0.045634888 -0.092203401 0.05827155 0.049890779 0.078739353
		 -0.099446788 0.22601573 0.037911527 0.23280482 0.53592783 0.22981377 0.53619009 0.22557829
		 0.058678873 0.22715195 0.058570869 0.23169155 -0.096560255 0.23363541 -0.096632734
		 0.22913076 0.035149276 0.23532926 0.035094678 0.23946963 0.49109536 0.00090767408
		 0.080943733 -0.014913464 0.085386835 0.044540904 0.49926507 0.058233693 -0.099239245
		 0.34931806 -0.098564088 0.346093 -0.098167151 0.34185174 -0.099113479 0.34522891
		 -0.0087911692 0.34435976 0.024420906 0.34719402 0.024339188 0.34304315 -0.0092142429
		 0.34020004 0.050160956 0.3364594 0.051296782 0.34035051 0.051087633 0.34485081 0.050350651
		 0.34100264 0.55272192 0.33478475 0.55178899 0.33870628 0.58413786 0.33409691 0.58536327
		 0.33009741 -0.013180455 0.23165341 0.020443719 0.23160894 0.020476561 0.22727884
		 -0.01313754 0.22714229 -0.1052073 0.23310511 -0.10557234 0.23275863 -0.10556253 0.22828259
		 -0.10530994 0.22880991 0.043852083 0.23570929 0.044455986 0.23573063 0.044359129
		 0.2394089 0.043851905 0.23943739 0.5741697 0.22948833 0.60759526 0.22924532 0.60762584
		 0.22547369 0.57429296 0.22566412 0.49536031 0.0069530155 0.075886667 -0.0096764844
		 0.08061707 0.038991354 0.50467765 0.053116404 0.056182168 -0.014579857 0.046441473
		 -0.015208328 0.052364431 0.042219721 0.061286427 0.042574611 0.51405209 0.0036868672
		 0.52243024 0.0044141631 0.52513748 0.057977572 0.53538287 0.058662966 0.08112558
		 0.0034396923 0.60588068 0.010620855 0.081581235 -0.0034284317 0.076920316 -0.0046043717
		 -0.048633058 -0.038450442 -0.057902325 -0.042708896 -0.062236715 -0.040021025 -0.061644573
		 -0.032549731 -0.061933476 -0.018819898 -0.062022541 -0.010309545 -0.0627084 0.045294963
		 -0.063000165 0.056059152 -0.067328855 0.22533597 -0.059419978 0.22721131 -0.059474666
		 0.2317308 -0.067515433 0.23357318 -0.068708286 0.33508101 -0.053763732 0.33208731
		 -0.053749159 0.33517283 -0.066669032 0.33117992 -0.089290008 0.35301477 -0.089907184
		 0.36051071 -0.08715602 0.36024642 -0.078346916 0.35502717 0.046908431 0.34950176
		 0.054239638 0.35261518 0.0563059 0.35185546 0.053861648 0.34227535 0.029564558 0.31945023
		 0.62430012 0.31644002 0.0090148561 0.32037672 0.64547384 0.3166818 0.0078249853 0.23963375
		 0.65232241 0.22825493 -0.00043239119 0.23597221 0.66101295 0.22430943 0.020957617
		 0.093357109 0.023353724 0.085745089 0.049265087 0.037850283 0.057738155 0.029319488;
	setAttr ".uvtk[250:277]" 0.01995918 0.32396966 0.62638295 0.31338391 0.63546902
		 0.31290862 0.011014353 0.32327658 -0.070689 0.33187732 0.007245569 0.23556943 0.65260553
		 0.22485779 0.66007322 0.22878177 -0.00025733234 0.23924606 0.62240785 0.024700247
		 0.075048506 0.013948698 0.63025725 0.032269027 0.65146673 0.073786572 0.6530357 0.081103221
		 0.61063403 0.33685353 0.58520645 0.34605801 0.57196814 0.34691775 0.53242767 0.34496918
		 0.026553098 0.35154673 -0.011347977 0.35723212 -0.023734611 0.35768494 -0.048033144
		 0.35071024 -0.044616133 -0.038011037 -0.022764582 -0.039617084 0.013087347 -0.035283051
		 0.51853478 -0.004793922 0.55708021 -0.0044786804 0.5849793 0.0016322952;
createNode polyTweakUV -n "polyTweakUV24";
	rename -uid "8EE2624F-4ECD-9D0B-F717-259D236AEC5A";
	setAttr ".uopa" yes;
	setAttr -s 214 ".uvtk[0:213]" -type "float2" 0.26971689 0.37237805 0.26377964
		 0.39212918 0.26392788 0.41275275 0.27014819 0.4324159 0.28188872 0.44937223 0.298105
		 0.46211505 0.31735721 0.46951151 0.33793384 0.47090489 0.35800737 0.46617121 0.37579376
		 0.45573133 0.38971263 0.44051224 0.39852709 0.42186666 0.40145421 0.40145135 0.39823383
		 0.38108045 0.38915181 0.36256355 0.37501597 0.34754634 0.35708141 0.33736289 0.33694208
		 0.33291847 0.31638709 0.33460754 0.2972436 0.34228033 0.28121215 0.35525471 0.1380215
		 -0.080912232 0.12020991 -0.021659471 0.12065468 0.04021094 0.13931659 0.099201322
		 0.17453679 0.15007056 0.22318625 0.1882983 0.28094244 0.21048805 0.34267336 0.21466812
		 0.40289348 0.2004669 0.45625234 0.16914643 0.49800888 0.12348966 0.52445251 0.067553192
		 0.5332337 0.0063076466 0.52357268 -0.054805651 0.49632713 -0.11035582 0.45391887
		 -0.15540728 0.40011477 -0.18595734 0.33969694 -0.1992912 0.27803248 -0.19422385 0.2206012
		 -0.17120603 0.17250678 -0.1322827 0.20057234 -0.051341608 0.1886979 -0.011839594
		 0.18899444 0.029407419 0.2014356 0.068734393 0.2249158 0.10264695 0.25734898 0.12813199
		 0.29585332 0.1429251 0.33700675 0.14571185 0.37715358 0.13624437 0.41272634 0.11536413
		 0.44056386 0.084926531 0.458193 0.047635533 0.46404737 0.0068049282 0.45760661 -0.033937074
		 0.43944287 -0.070970714 0.41117048 -0.10100493 0.37530112 -0.12137158 0.33502263
		 -0.1302608 0.29391295 -0.12688258 0.25562549 -0.11153743 0.22356212 -0.085588425
		 0.26312292 -0.021770872 0.25718597 -0.0020198449 0.2573342 0.018603515 0.26355469
		 0.038267113 0.27529469 0.055223443 0.2915113 0.067966029 0.31076339 0.075362846 0.33134025
		 0.076756164 0.35141379 0.072022304 0.36920005 0.061582126 0.38311917 0.046363272
		 0.39193362 0.027717661 0.39486098 0.0073024482 0.39164013 -0.013068465 0.38255835
		 -0.031585373 0.36842227 -0.046602562 0.35048771 -0.056786016 0.33034837 -0.061230361
		 0.30979338 -0.059541412 0.29064989 -0.05186864 0.27461788 -0.038894273 0.32666424
		 0.40807539 0.32007053 0.013926715 0.26377964 0.39212918 0.26971689 0.37237805 0.26392788
		 0.41275275 0.27014819 0.4324159 0.28188872 0.44937223 0.298105 0.46211505 0.31735721
		 0.46951151 0.33793384 0.47090489 0.35800737 0.46617121 0.37579376 0.45573133 0.38971263
		 0.44051224 0.39852709 0.42186666 0.40145421 0.40145135 0.39823383 0.38108045 0.38915181
		 0.36256355 0.37501597 0.34754634 0.35708141 0.33736289 0.33694208 0.33291847 0.31638709
		 0.33460754 0.2972436 0.34228033 0.28121215 0.35525471 0.14461505 0.31323689 0.12680337
		 0.37248948 0.12724838 0.43435979 0.14591014 0.49335051 0.18113074 0.54421967 0.22977993
		 0.58244741 0.28753638 0.60463715 0.34926707 0.6088171 0.40948719 0.59461588 0.46284628
		 0.56329548 0.50460255 0.51763868 0.53104621 0.46170223 0.53982741 0.40045643 0.53016621
		 0.33934349 0.50292057 0.28379315 0.4605124 0.23874173 0.40670872 0.20819157 0.34629041
		 0.19485769 0.28462642 0.19992504 0.22719491 0.22294292 0.17910025 0.26186621 0.19529137
		 0.38230932 0.17572442 0.32792258 0.19558814 0.42355633 0.16087171 0.37734276 0.2080293
		 0.46288347 0.16124997 0.42894089 0.2315093 0.49679595 0.17682186 0.47813207 0.2639426
		 0.52228129 0.20620069 0.52054405 0.30244678 0.53707457 0.24677348 0.55240929 0.34360045
		 0.53986084 0.29493272 0.57089871 0.38374704 0.53039372 0.34639859 0.57437265 0.41931981
		 0.50951326 0.39659953 0.56252545 0.44715732 0.47907513 0.44107771 0.53641129 0.46478671
		 0.44178456 0.47588634 0.49835122 0.4706412 0.40095425 0.49793562 0.45172399 0.46419978
		 0.36021215 0.50526446 0.40066713 0.4460361 0.32317841 0.4972209 0.34971529 0.41776419
		 0.29314387 0.47451609 0.30339432 0.38189507 0.2727772 0.43916398 0.26582092 0.34161609
		 0.26388815 0.39430356 0.24033579 0.30050665 0.26726639 0.34392112 0.22920689 0.26221907
		 0.28261167 0.29249448 0.23342606 0.23015597 0.30856055 0.24459529 0.25261909 0.20716593
		 0.34280747 0.20448396 0.2850816 0.16988826 -0.13526535 0.14529011 -0.13503546 0.16880774
		 -0.43918091 0.12069181 -0.13480568 0.14420959 -0.43895143 0.096094221 -0.13457587
		 0.11961129 -0.43872154 0.071496256 -0.13434601 0.095013708 -0.43849176 0.046897843
		 -0.13411623 0.070415743 -0.43826193 0.022299796 -0.13388634 0.045817569 -0.43803233
		 -0.0022980273 -0.1336565 0.021219268 -0.43780226 -0.026896216 -0.13342702 -0.0033783019
		 -0.43757266 -0.051493928 -0.13319719 -0.027976491 -0.43734282 -0.076092117 -0.13296688
		 -0.052574441 -0.43711293 -0.10068987 -0.1327374 -0.077172868 -0.43688309 -0.12528823
		 -0.13250771 -0.10177039 -0.43665326 -0.14988606 -0.13227773 -0.12636875 -0.43642342
		 -0.17448436 -0.13204801 -0.15096657 -0.43619359 -0.19908212 -0.13181785 -0.17556487
		 -0.43596405 -0.22368006 -0.13158828 -0.20016275 -0.43573421 -0.24827825 -0.13135859
		 -0.22476058 -0.43550408 -0.27287644 -0.13112861 -0.24935864 -0.43527436 -0.29747432
		 -0.13089892 -0.27395695 -0.43504471 -0.32207227 -0.13066936 -0.29855472 -0.43481493
		 -0.34667033 -0.13043922 -0.34775096 -0.4343552 -0.32315278 -0.43458492;
createNode polyTweakUV -n "polyTweakUV25";
	rename -uid "EED7B3D7-4222-580D-E7B9-07A4E632308F";
	setAttr ".uopa" yes;
	setAttr -s 40 ".uvtk";
	setAttr ".uvtk[2]" -type "float2" -0.13336802 -0.15651348 ;
	setAttr ".uvtk[12]" -type "float2" -0.3833679 -0.15651351 ;
	setAttr ".uvtk[13]" -type "float2" 0.46380642 -0.22656296 ;
	setAttr ".uvtk[19]" -type "float2" 0.21380642 -0.22656296 ;
	setAttr ".uvtk[22]" -type "float2" 0.5082643 -0.28905872 ;
	setAttr ".uvtk[28]" -type "float2" 0.2582643 -0.28905872 ;
	setAttr ".uvtk[35]" -type "float2" 0.6207152 -0.35025173 ;
	setAttr ".uvtk[39]" -type "float2" 0.37071535 -0.35025173 ;
	setAttr ".uvtk[40]" -type "float2" 0.62072921 -0.74796343 ;
	setAttr ".uvtk[44]" -type "float2" 0.37072933 -0.74796343 ;
	setAttr ".uvtk[46]" -type "float2" 0.50827682 -0.80020595 ;
	setAttr ".uvtk[50]" -type "float2" 0.25827685 -0.80020595 ;
	setAttr ".uvtk[51]" -type "float2" 0.46381894 -0.86271 ;
	setAttr ".uvtk[55]" -type "float2" 0.21381895 -0.86271 ;
	setAttr ".uvtk[62]" -type "float2" -0.13939391 -0.93400222 ;
	setAttr ".uvtk[65]" -type "float2" -0.38939378 -0.93400222 ;
	setAttr ".uvtk[105]" -type "float2" -0.37175104 -0.072784625 ;
	setAttr ".uvtk[106]" -type "float2" -0.33133495 -0.0882494 ;
	setAttr ".uvtk[110]" -type "float2" -0.62091017 -0.073407754 ;
	setAttr ".uvtk[111]" -type "float2" -0.59102321 -0.094629452 ;
	setAttr ".uvtk[130]" -type "float2" 0.12305141 -0.0022903779 ;
	setAttr ".uvtk[131]" -type "float2" 0.12303741 -0.086953722 ;
	setAttr ".uvtk[134]" -type "float2" 0.86840701 -0.002290376 ;
	setAttr ".uvtk[135]" -type "float2" 0.868393 -0.086953707 ;
	setAttr ".uvtk[160]" -type "float2" -0.13336802 -0.15617213 ;
	setAttr ".uvtk[162]" -type "float2" -0.3833679 -0.15617213 ;
	setAttr ".uvtk[163]" -type "float2" 0.45378432 -0.22656296 ;
	setAttr ".uvtk[165]" -type "float2" 0.22302797 -0.22656296 ;
	setAttr ".uvtk[167]" -type "float2" 0.49915412 -0.28905872 ;
	setAttr ".uvtk[168]" -type "float2" 0.2711798 -0.28905872 ;
	setAttr ".uvtk[171]" -type "float2" 0.49536142 -0.80020595 ;
	setAttr ".uvtk[172]" -type "float2" 0.26738706 -0.80020601 ;
	setAttr ".uvtk[174]" -type "float2" 0.45459756 -0.86271 ;
	setAttr ".uvtk[175]" -type "float2" 0.22384112 -0.86271 ;
	setAttr ".uvtk[176]" -type "float2" -0.13939391 -0.93321121 ;
	setAttr ".uvtk[177]" -type "float2" -0.38939378 -0.93321115 ;
	setAttr ".uvtk[179]" -type "float2" -0.34101006 -0.98194766 ;
	setAttr ".uvtk[180]" -type "float2" -0.59100986 -0.98194766 ;
	setAttr ".uvtk[191]" -type "float2" -0.3410233 -0.1074734 ;
	setAttr ".uvtk[193]" -type "float2" -0.59102321 -0.10747343 ;
	setAttr -s 440 ".nuv";
	setAttr ".nuv[0:124]"  121 116 0.040058844 0.15629125 121 117
		 0.040240005 0.16058013 121 118 0.034611668 0.15848586 120 113 0.0346012
		 0.15847676 120 114 0.040230788 0.16058013 120 115 0.040058844 0.15629125 
		119 109 0 0.12505513 119 110 0.0040896963 0.12659718 119 111 0.0025744841
		 0.13069694 118 106 0.0025837643 0.029876225 118 107 0.0040982217 0.033976179 
		118 108 8.2415736e-06 0.035517551 117 103 0.0025744841 0.13069694 117 
		104 0.0040896963 0.12659718 117 105 0 0.12505513 116 100 8.2415736e-06
		 0.035517551 116 101 0.0040982217 0.033976179 116 102 0.0025837643 0.029876225 
		115 96 0.84389877 0.015604043 115 97 0.84403235 0.011359676 115 
		98 0.83934778 0.0077827503 115 99 0.83873898 0.012338066 114 92
		 0.83873898 0.012338066 114 93 0.83931518 0.007673596 114 94 0.84408587
		 0.01135968 114 95 0.84389877 0.015604043 113 88 0.87819648 0.015607201 
		113 89 0.87806356 0.011362808 113 90 0.8827489 0.0077867452 113 
		91 0.88335687 0.012342173 112 84 0.88335687 0.012342173 112 85 0.88278157
		 0.007677597 112 86 0.87801015 0.011362803 112 87 0.87819648 0.015607201 
		111 80 0.87818456 0.14512715 111 81 0.87805086 0.14937152 111 82
		 0.88273555 0.15294841 111 83 0.88334435 0.14839312 110 76 0.88334435
		 0.14839312 110 77 0.88276815 0.15305759 110 78 0.87799746 0.1493715 
		110 79 0.87818456 0.14512715 109 72 0.84388685 0.14512399 109 73
		 0.84401965 0.14936839 109 74 0.83933437 0.15294449 109 75 0.83872646
		 0.14838901 108 68 0.83872646 0.14838901 108 69 0.83930176 0.1530536 
		108 70 0.84407318 0.14936839 108 71 0.84388685 0.14512399 107 65
		 0.034615595 0.0021022614 107 66 0.040245567 0 107 67 0.040072832 0.0042887372 
		106 60 0.040072832 0.0042887372 106 61 0.040254783 8.4831558e-10 106 
		62 0.034626063 0.0020931887 105 57 0.23560649 1.7982185e-05 105 58
		 0.24164636 1.8538132e-05 105 59 0.24164598 0.0042893351 104 52 0.24164598
		 0.0042893351 104 53 0.24164636 1.8538132e-05 104 54 0.23560649 1.7982185e-05 
		103 49 0.83358371 0.0042893407 103 50 0.83343667 7.3010044e-05 103 
		51 0.8381561 0.0037956138 102 44 0.8381561 0.0037956138 102 45 0.83337885
		 7.3004725e-05 102 46 0.83366781 0.0041868971 101 40 0.88394135 0.0037998282 
		101 41 0.88871926 7.8098587e-05 101 42 0.88842958 0.0041919379 100 
		37 0.88851368 0.0042943968 100 38 0.88866144 7.8093261e-05 100 39
		 0.88394135 0.0037998282 99 33 0.99572963 8.7948458e-05 99 34 1.000000119209
		 0.0043591387 99 35 0.99572921 0.0043587456 98 30 0.99572921 0.0043587456 
		98 31 1.000000119209 0.0043591387 98 32 0.99572963 8.7948458e-05 
		97 27 0.99998605 0.15639767 97 28 0.99571484 0.16066808 97 29
		 0.9957152 0.15639728 96 24 0.9957152 0.15639728 96 25 0.99571484
		 0.16066808 96 26 0.99998605 0.15639767 95 21 0.88849968 0.15644185 
		95 22 0.88864666 0.16065823 95 23 0.88392723 0.15693554 94 16
		 0.88392723 0.15693554 94 17 0.88870448 0.16065823 94 18 0.88841552
		 0.15654437 93 12 0.83814198 0.15693133 93 13 0.83336407 0.16065313 
		93 14 0.83365375 0.15653934 92 9 0.83356971 0.1564368 92 10
		 0.83342189 0.16065313 92 11 0.83814198 0.15693133 91 4 0.2355921
		 0.15632731 91 6 0.2416316 0.16059867 91 7 0.23559171 0.16059811 
		90 0 0.23559171 0.16059811 90 1 0.2416316 0.16059867 90 3
		 0.2355921 0.15632731 89 55 0.23560609 0.0042887791 89 60 0.040072832
		 0.0042887372 89 115 0.040058844 0.15629125 89 3 0.2355921 0.15632731 
		88 107 0.0040982217 0.033976179 88 64 0.033989947 0.0083534205 88 
		119 0.033976704 0.15222555 88 110 0.0040896963 0.12659718 87 113
		 0.0346012 0.15847676 87 103 0.0025744841 0.13069694 87 111 0.0025744841
		 0.13069694 87 118 0.034611668 0.15848586 86 102 0.0025837643 0.029876225 
		86 62 0.034626063 0.0020931887 86 65 0.034615595 0.0021022614 86 
		106 0.0025837643 0.029876225 85 116 0.040058844 0.15629125 85 67
		 0.040072832 0.0042887372 85 56 0.23560609 0.0042887791 85 4 0.2355921
		 0.15632731 84 19 0.8832643 0.14844128;
	setAttr ".nuv[125:249]" 84 36 0.88327682 0.012294079 84 84
		 0.88335687 0.012342173 84 83 0.88334435 0.14839312 83 47 0.83881897
		 0.012289987 83 8 0.83880639 0.14843704 83 68 0.83872646 0.14838901 
		83 99 0.83873898 0.012338066 82 15 0.83880639 0.14843704 82 48
		 0.83881897 0.012289987 82 92 0.83873898 0.012338066 82 75 0.83872646
		 0.14838901 81 43 0.88327682 0.012294079 81 20 0.8832643 0.14844128 
		81 76 0.88334435 0.14839312 81 91 0.88335687 0.012342173 80 51
		 0.8381561 0.0037956138 80 44 0.8381561 0.0037956138 80 98 0.83934778
		 0.0077827503 80 93 0.83931518 0.007673596 79 39 0.88394135 0.0037998282 
		79 40 0.88394135 0.0037998282 79 90 0.8827489 0.0077867452 79 
		85 0.88278157 0.007677597 78 23 0.88392723 0.15693554 78 16 0.88392723
		 0.15693554 78 82 0.88273555 0.15294841 78 77 0.88276815 0.15305759 
		77 11 0.83814198 0.15693133 77 12 0.83814198 0.15693133 77 74
		 0.83933437 0.15294449 77 69 0.83930176 0.1530536 76 112 0.033976704
		 0.15222555 76 63 0.033989947 0.0083534205 76 101 0.0040982217 0.033976179 
		76 104 0.0040896963 0.12659718 75 46 0.83366781 0.0041868971 75 
		52 0.24164598 0.0042893351 75 2 0.24163198 0.15632787 75 9 0.83356971
		 0.1564368 74 87 0.87819648 0.015607201 74 96 0.84389877 0.015604043 
		74 71 0.84388685 0.14512399 74 80 0.87818456 0.14512715 73 37
		 0.88851368 0.0042943968 73 18 0.88841552 0.15654437 72 59 0.24164598
		 0.0042893351 72 49 0.83358371 0.0042893407 72 14 0.83365375 0.15653934 
		72 5 0.24163198 0.15632787 71 95 0.84389877 0.015604043 71 88
		 0.87819648 0.015607201 71 79 0.87818456 0.14512715 71 72 0.84388685
		 0.14512399 70 42 0.88842958 0.0041919379 70 21 0.88849968 0.15644185 
		69 54 0.23560649 1.7982185e-05 69 57 0.23560649 1.7982185e-05 69 
		66 0.040245567 0 69 61 0.040254783 8.4831558e-10 68 45 0.83337885
		 7.3004725e-05 68 50 0.83343667 7.3010044e-05 68 58 0.24164636 1.8538132e-05 
		68 53 0.24164636 1.8538132e-05 67 86 0.87801015 0.011362803 67 
		89 0.87806356 0.011362808 67 94 0.84408587 0.01135968 67 97 0.84403235
		 0.011359676 66 32 0.99572963 8.7948458e-05 66 33 0.99572963 8.7948458e-05 
		66 41 0.88871926 7.8098587e-05 66 38 0.88866144 7.8093261e-05 65 
		26 0.99998605 0.15639767 65 27 0.99998605 0.15639767 65 34 1.000000119209
		 0.0043591387 65 31 1.000000119209 0.0043591387 64 17 0.88870448 0.16065823 
		64 22 0.88864666 0.16065823 64 28 0.99571484 0.16066808 64 25
		 0.99571484 0.16066808 63 70 0.84407318 0.14936839 63 73 0.84401965
		 0.14936839 63 78 0.87799746 0.1493715 63 81 0.87805086 0.14937152 
		62 1 0.2416316 0.16059867 62 6 0.2416316 0.16059867 62 13
		 0.83336407 0.16065313 62 10 0.83342189 0.16065313 61 114 0.040230788
		 0.16058013 61 117 0.040240005 0.16058013 61 7 0.23559171 0.16059811 
		61 0 0.23559171 0.16059811 60 100 8.2415736e-06 0.035517551 60 
		108 8.2415736e-06 0.035517551 60 109 0 0.12505513 60 105 0 0.12505513 
		59 114 0.040230788 0.16058013 59 113 0.0346012 0.15847676 59 118
		 0.034611668 0.15848586 59 117 0.040240005 0.16058013 58 111 0.0025744841
		 0.13069694 58 118 0.034611668 0.15848586 57 108 8.2415736e-06 0.035517551 
		57 107 0.0040982217 0.033976179 57 110 0.0040896963 0.12659718 57 
		109 0 0.12505513 56 104 0.0040896963 0.12659718 56 112 0.033976704
		 0.15222555 55 103 0.0025744841 0.13069694 55 105 0 0.12505513 55 
		109 0 0.12505513 55 111 0.0025744841 0.13069694 54 101 0.0040982217
		 0.033976179 54 100 8.2415736e-06 0.035517551 54 105 0 0.12505513 54 
		104 0.0040896963 0.12659718 53 100 8.2415736e-06 0.035517551 53 102
		 0.0025837643 0.029876225 53 106 0.0025837643 0.029876225 53 108 8.2415736e-06
		 0.035517551 52 94 0.84408587 0.01135968 52 93 0.83931518 0.007673596 
		52 98 0.83934778 0.0077827503 52 97 0.84403235 0.011359676 51 
		89 0.87806356 0.011362808 51 88 0.87819648 0.015607201;
	setAttr ".nuv[250:374]" 51 95 0.84389877 0.015604043 51 94
		 0.84408587 0.01135968 50 87 0.87819648 0.015607201 50 86 0.87801015
		 0.011362803 50 97 0.84403235 0.011359676 50 96 0.84389877 0.015604043 
		49 86 0.87801015 0.011362803 49 85 0.88278157 0.007677597 49 
		90 0.8827489 0.0077867452 49 89 0.87806356 0.011362808 48 80 0.87818456
		 0.14512715 48 83 0.88334435 0.14839312 48 84 0.88335687 0.012342173 
		48 87 0.87819648 0.015607201 47 78 0.87799746 0.1493715 47 77
		 0.88276815 0.15305759 47 82 0.88273555 0.15294841 47 81 0.87805086
		 0.14937152 46 76 0.88334435 0.14839312 46 79 0.87818456 0.14512715 
		46 88 0.87819648 0.015607201 46 91 0.88335687 0.012342173 45 
		73 0.84401965 0.14936839 45 72 0.84388685 0.14512399 45 79 0.87818456
		 0.14512715 45 78 0.87799746 0.1493715 44 72 0.84388685 0.14512399 
		44 75 0.83872646 0.14838901 44 92 0.83873898 0.012338066 44 95
		 0.84389877 0.015604043 43 71 0.84388685 0.14512399 43 70 0.84407318
		 0.14936839 43 81 0.87805086 0.14937152 43 80 0.87818456 0.14512715 
		42 70 0.84407318 0.14936839 42 69 0.83930176 0.1530536 42 74
		 0.83933437 0.15294449 42 73 0.84401965 0.14936839 41 68 0.83872646
		 0.14838901 41 71 0.84388685 0.14512399 41 96 0.84389877 0.015604043 
		41 99 0.83873898 0.012338066 40 65 0.034615595 0.0021022614 40 
		64 0.033989947 0.0083534205 40 107 0.0040982217 0.033976179 40 106
		 0.0025837643 0.029876225 39 64 0.033989947 0.0083534205 39 67 0.040072832
		 0.0042887372 39 116 0.040058844 0.15629125 39 119 0.033976704 0.15222555 
		38 63 0.033989947 0.0083534205 38 62 0.034626063 0.0020931887 38 
		102 0.0025837643 0.029876225 38 101 0.0040982217 0.033976179 37 62
		 0.034626063 0.0020931887 37 61 0.040254783 8.4831558e-10 37 66 0.040245567
		 0 37 65 0.034615595 0.0021022614 36 60 0.040072832 0.0042887372 
		36 63 0.033989947 0.0083534205 36 112 0.033976704 0.15222555 36 
		115 0.040058844 0.15629125 35 57 0.23560649 1.7982185e-05 35 67
		 0.040072832 0.0042887372 35 66 0.040245567 0 34 54 0.23560649 1.7982185e-05 
		34 61 0.040254783 8.4831558e-10 34 60 0.040072832 0.0042887372 33 
		54 0.23560649 1.7982185e-05 33 53 0.24164636 1.8538132e-05 33 58
		 0.24164636 1.8538132e-05 33 57 0.23560649 1.7982185e-05 32 50 0.83343667
		 7.3010044e-05 32 49 0.83358371 0.0042893407 32 59 0.24164598 0.0042893351 
		32 58 0.24164636 1.8538132e-05 31 51 0.8381561 0.0037956138 31 
		93 0.83931518 0.007673596 31 92 0.83873898 0.012338066 30 46 0.83366781
		 0.0041868971 30 45 0.83337885 7.3004725e-05 30 53 0.24164636 1.8538132e-05 
		30 52 0.24164598 0.0042893351 29 45 0.83337885 7.3004725e-05 29 
		44 0.8381561 0.0037956138 29 51 0.8381561 0.0037956138 29 50 0.83343667
		 7.3010044e-05 28 44 0.8381561 0.0037956138 28 99 0.83873898 0.012338066 
		28 98 0.83934778 0.0077827503 27 40 0.88394135 0.0037998282 27 
		91 0.88335687 0.012342173 27 90 0.8827489 0.0077867452 26 39 0.88394135
		 0.0037998282 26 38 0.88866144 7.8093261e-05 26 41 0.88871926 7.8098587e-05 
		26 40 0.88394135 0.0037998282 25 39 0.88394135 0.0037998282 25 
		85 0.88278157 0.007677597 25 84 0.88335687 0.012342173 24 33 0.99572963
		 8.7948458e-05 24 42 0.88842958 0.0041919379 24 41 0.88871926 7.8098587e-05 
		23 32 0.99572963 8.7948458e-05 23 31 1.000000119209 0.0043591387 
		23 34 1.000000119209 0.0043591387 23 33 0.99572963 8.7948458e-05 
		22 32 0.99572963 8.7948458e-05 22 38 0.88866144 7.8093261e-05 22 
		37 0.88851368 0.0042943968 21 27 0.99998605 0.15639767 21 35 0.99572921
		 0.0043587456 21 34 1.000000119209 0.0043591387 20 26 0.99998605 0.15639767 
		20 25 0.99571484 0.16066808 20 28 0.99571484 0.16066808 20 27
		 0.99998605 0.15639767 19 26 0.99998605 0.15639767 19 31 1.000000119209
		 0.0043591387 19 30 0.99572921 0.0043587456 18 22 0.88864666 0.16065823 
		18 21 0.88849968 0.15644185 18 29 0.9957152 0.15639728 18 28
		 0.99571484 0.16066808 17 21 0.88849968 0.15644185;
	setAttr ".nuv[375:439]" 17 20 0.8832643 0.14844128 17 43 0.88327682
		 0.012294079 17 42 0.88842958 0.0041919379 16 23 0.88392723 0.15693554 
		16 77 0.88276815 0.15305759 16 76 0.88334435 0.14839312 15 19
		 0.8832643 0.14844128 15 18 0.88841552 0.15654437 15 37 0.88851368
		 0.0042943968 15 36 0.88327682 0.012294079 14 18 0.88841552 0.15654437 
		14 17 0.88870448 0.16065823 14 25 0.99571484 0.16066808 14 24
		 0.9957152 0.15639728 13 17 0.88870448 0.16065823 13 16 0.88392723
		 0.15693554 13 23 0.88392723 0.15693554 13 22 0.88864666 0.16065823 
		12 16 0.88392723 0.15693554 12 83 0.88334435 0.14839312 12 82
		 0.88273555 0.15294841 11 15 0.83880639 0.14843704 11 14 0.83365375
		 0.15653934 11 49 0.83358371 0.0042893407 11 48 0.83881897 0.012289987 
		10 12 0.83814198 0.15693133 10 75 0.83872646 0.14838901 10 74
		 0.83933437 0.15294449 9 11 0.83814198 0.15693133 9 10 0.83342189
		 0.16065313 9 13 0.83336407 0.16065313 9 12 0.83814198 0.15693133 
		8 9 0.83356971 0.1564368 8 8 0.83880639 0.14843704 8 47
		 0.83881897 0.012289987 8 46 0.83366781 0.0041868971 7 11 0.83814198
		 0.15693133 7 69 0.83930176 0.1530536 7 68 0.83872646 0.14838901 
		6 6 0.2416316 0.16059867 6 14 0.83365375 0.15653934 6 13
		 0.83336407 0.16065313 5 5 0.24163198 0.15632787 5 4 0.2355921
		 0.15632731 5 56 0.23560609 0.0042887791 5 59 0.24164598 0.0042893351 
		4 4 0.2355921 0.15632731 4 7 0.23559171 0.16059811 4 117
		 0.040240005 0.16058013 4 116 0.040058844 0.15629125 3 3 0.2355921
		 0.15632731 3 2 0.24163198 0.15632787 3 52 0.24164598 0.0042893351 
		3 55 0.23560609 0.0042887791 2 1 0.2416316 0.16059867 2 10
		 0.83342189 0.16065313 2 9 0.83356971 0.1564368 1 1 0.2416316
		 0.16059867 1 0 0.23559171 0.16059811 1 7 0.23559171 0.16059811 
		1 6 0.2416316 0.16059867 0 0 0.23559171 0.16059811 0 3
		 0.2355921 0.15632731 0 115 0.040058844 0.15629125 0 114 0.040230788
		 0.16058013;
createNode polyMapSew -n "polyMapSew2";
	rename -uid "B40859E3-413E-D2C2-6BBF-B183279F116D";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:239]";
createNode polyTweak -n "polyTweak33";
	rename -uid "E246C710-49C8-4B06-5C58-6DBE1E18338F";
	setAttr ".uopa" yes;
	setAttr -s 76 ".tk";
	setAttr ".tk[8]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[9]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[10]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[11]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[12]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[13]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[14]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[15]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[16]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[17]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[18]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[19]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[20]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[21]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[22]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[23]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[24]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[25]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[26]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[27]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[28]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[29]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[30]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[31]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[32]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[33]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[34]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[35]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[36]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[37]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[38]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[39]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[40]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[41]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[42]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[43]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[44]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[45]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[46]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[47]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[48]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[49]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[50]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[51]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[68]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[69]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[70]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[71]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[72]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[73]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[74]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[75]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[76]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[77]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[78]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[79]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[80]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[81]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[82]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[83]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[84]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[85]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[86]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[87]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[88]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[89]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[90]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[91]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[92]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[93]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[94]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[95]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[96]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[97]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[98]" -type "float3" 0 0 -0.14310506 ;
	setAttr ".tk[99]" -type "float3" 0 0 -0.14310506 ;
createNode polySplit -n "polySplit12";
	rename -uid "FD76AAA0-4D03-2942-1F99-B89F41BD6D57";
	setAttr -s 33 ".e[0:32]"  0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5 0.5
		 0.5;
	setAttr -s 33 ".d[0:32]"  -2147483643 -2147483409 -2147483411 -2147483425 -2147483427 -2147483433 
		-2147483435 -2147483497 -2147483499 -2147483513 -2147483515 -2147483529 -2147483531 -2147483439 -2147483437 -2147483449 -2147483451 -2147483541 
		-2147483543 -2147483553 -2147483555 -2147483565 -2147483567 -2147483593 -2147483595 -2147483459 -2147483457 -2147483477 -2147483479 -2147483609 
		-2147483611 -2147483641 -2147483643;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweakUV -n "polyTweakUV26";
	rename -uid "6A3DAA64-4036-D385-F6EF-B298304B12AC";
	setAttr ".uopa" yes;
	setAttr -s 608 ".nuv";
	setAttr ".nuv[0:124]"  153 1 0.2416316 0.16059867 153 0 0.23559171
		 0.16059811 153 120 0.23559171 0.16059811 153 151 0.2416316 0.16059867 
		152 1 0.2416316 0.16059867 152 151 0.2416316 0.16059867 152 150
		 0.83339298 0.16065313 152 10 0.83342189 0.16065313 151 11 0.83814198
		 0.15693133 151 10 0.83342189 0.16065313 151 150 0.83339298 0.16065313 
		151 149 0.83814198 0.15693133 150 11 0.83814198 0.15693133 150 149
		 0.83814198 0.15693133 150 148 0.8393181 0.15299904 150 69 0.83930176
		 0.1530536 149 70 0.84407318 0.14936839 149 69 0.83930176 0.1530536 
		149 148 0.8393181 0.15299904 149 147 0.84404641 0.14936839 148 70
		 0.84407318 0.14936839 148 147 0.84404641 0.14936839 148 146 0.87802416
		 0.14937152 148 81 0.87805086 0.14937152 147 146 0.87802416 0.14937152 
		147 145 0.88275188 0.15300299 147 82 0.88273555 0.15294841 147 81
		 0.87805086 0.14937152 146 145 0.88275188 0.15300299 146 144 0.88392723
		 0.15693554 146 16 0.88392723 0.15693554 146 82 0.88273555 0.15294841 
		145 17 0.88870448 0.16065823 145 16 0.88392723 0.15693554 145 144
		 0.88392723 0.15693554 145 143 0.88867557 0.16065823 144 17 0.88870448
		 0.16065823 144 143 0.88867557 0.16065823 144 142 0.99571484 0.16066808 
		144 25 0.99571484 0.16066808 143 26 0.99998605 0.15639767 143 25
		 0.99571484 0.16066808 143 142 0.99571484 0.16066808 143 141 0.99998605
		 0.15639767 142 26 0.99998605 0.15639767 142 141 0.99998605 0.15639767 
		142 140 1.000000119209 0.0043591387 142 31 1.000000119209 0.0043591387 
		141 32 0.99572963 8.7948458e-05 141 31 1.000000119209 0.0043591387 
		141 140 1.000000119209 0.0043591387 141 139 0.99572963 8.7948458e-05 
		140 32 0.99572963 8.7948458e-05 140 139 0.99572963 8.7948458e-05 140 
		138 0.88869035 7.8095924e-05 140 38 0.88866144 7.8093261e-05 139 39
		 0.88394135 0.0037998282 139 38 0.88866144 7.8093261e-05 139 138 0.88869035
		 7.8095924e-05 139 137 0.88394135 0.0037998282 138 39 0.88394135 0.0037998282 
		138 137 0.88394135 0.0037998282 138 136 0.88276523 0.0077321711 138 
		85 0.88278157 0.007677597 137 86 0.87801015 0.011362803 137 85 0.88278157
		 0.007677597 137 136 0.88276523 0.0077321711 137 135 0.87803686 0.011362806 
		136 86 0.87801015 0.011362803 136 135 0.87803686 0.011362806 136 
		134 0.84405911 0.011359678 136 97 0.84403235 0.011359676 135 134 0.84405911
		 0.011359678 135 133 0.83933145 0.0077281734 135 98 0.83934778 0.0077827503 
		135 97 0.84403235 0.011359676 134 133 0.83933145 0.0077281734 134 
		132 0.8381561 0.0037956138 134 44 0.8381561 0.0037956138 134 98 0.83934778
		 0.0077827503 133 45 0.83337885 7.3004725e-05 133 44 0.8381561 0.0037956138 
		133 132 0.8381561 0.0037956138 133 131 0.83340776 7.3007381e-05 132 
		45 0.83337885 7.3004725e-05 132 131 0.83340776 7.3007381e-05 132 130
		 0.24164636 1.8538132e-05 132 53 0.24164636 1.8538132e-05 131 54 0.23560649
		 1.7982185e-05 131 53 0.24164636 1.8538132e-05 131 130 0.24164636 1.8538132e-05 
		131 129 0.23560649 1.7982185e-05 130 54 0.23560649 1.7982185e-05 130 
		129 0.23560649 1.7982185e-05 130 128 0.040250156 4.2241227e-10 130 61
		 0.040254783 8.4831558e-10 129 62 0.034626063 0.0020931887 129 61 0.040254783
		 8.4831558e-10 129 128 0.040250156 4.2241227e-10 129 127 0.034620829 0.0020977249 
		128 102 0.0025837643 0.029876225 128 62 0.034626063 0.0020931887 128 
		127 0.034620829 0.0020977249 128 126 0.0025837643 0.029876225 127 100
		 8.2415736e-06 0.035517551 127 102 0.0025837643 0.029876225 127 126 0.0025837643
		 0.029876225 127 125 8.2415736e-06 0.035517551 126 100 8.2415736e-06 0.035517551 
		126 125 8.2415736e-06 0.035517551 126 124 0 0.12505513 126 105 0
		 0.12505513 125 103 0.0025744841 0.13069694 125 105 0 0.12505513 125 
		124 0 0.12505513 125 123 0.0025744841 0.13069694 124 113 0.0346012
		 0.15847676 124 103 0.0025744841 0.13069694 124 123 0.0025744841 0.13069694 
		124 122 0.034606434 0.15848131 123 114 0.040230788 0.16058013 123 
		113 0.0346012 0.15847676 123 122 0.034606434 0.15848131 123 121 0.040235378
		 0.16058013 122 114 0.040230788 0.16058013;
	setAttr ".nuv[125:249]" 122 121 0.040235378 0.16058013 122 120
		 0.23559171 0.16059811 122 0 0.23559171 0.16059811 121 116 0.040058844
		 0.15629125 121 117 0.040240005 0.16058013 121 118 0.034611668 0.15848586 
		121 119 0.033976704 0.15222555 120 112 0.033976704 0.15222555 120 
		113 0.0346012 0.15847676 120 114 0.040230788 0.16058013 120 115 0.040058844
		 0.15629125 119 109 0 0.12505513 119 110 0.0040896963 0.12659718 119 
		111 0.0025744841 0.13069694 118 106 0.0025837643 0.029876225 118 107
		 0.0040982217 0.033976179 118 108 8.2415736e-06 0.035517551 117 103 0.0025744841
		 0.13069694 117 104 0.0040896963 0.12659718 117 105 0 0.12505513 116 
		100 8.2415736e-06 0.035517551 116 101 0.0040982217 0.033976179 116 102
		 0.0025837643 0.029876225 115 96 0.84389877 0.015604043 115 97 0.84403235
		 0.011359676 115 98 0.83934778 0.0077827503 115 99 0.83873898 0.012338066 
		114 92 0.83873898 0.012338066 114 93 0.83931518 0.007673596 114 
		94 0.84408587 0.01135968 114 95 0.84389877 0.015604043 113 88 0.87819648
		 0.015607201 113 89 0.87806356 0.011362808 113 90 0.8827489 0.0077867452 
		113 91 0.88335687 0.012342173 112 84 0.88335687 0.012342173 112 
		85 0.88278157 0.007677597 112 86 0.87801015 0.011362803 112 87 0.87819648
		 0.015607201 111 80 0.87818456 0.14512715 111 81 0.87805086 0.14937152 
		111 82 0.88273555 0.15294841 111 83 0.88334435 0.14839312 110 76
		 0.88334435 0.14839312 110 77 0.88276815 0.15305759 110 78 0.87799746
		 0.1493715 110 79 0.87818456 0.14512715 109 72 0.84388685 0.14512399 
		109 73 0.84401965 0.14936839 109 74 0.83933437 0.15294449 109 75
		 0.83872646 0.14838901 108 68 0.83872646 0.14838901 108 69 0.83930176
		 0.1530536 108 70 0.84407318 0.14936839 108 71 0.84388685 0.14512399 
		107 64 0.033989947 0.0083534205 107 65 0.034615595 0.0021022614 107 
		66 0.040245567 0 107 67 0.040072832 0.0042887372 106 60 0.040072832
		 0.0042887372 106 61 0.040254783 8.4831558e-10 106 62 0.034626063 0.0020931887 
		106 63 0.033989947 0.0083534205 105 56 0.23560609 0.0042887791 105 
		57 0.23560649 1.7982185e-05 105 58 0.24164636 1.8538132e-05 105 59
		 0.24164598 0.0042893351 104 52 0.24164598 0.0042893351 104 53 0.24164636
		 1.8538132e-05 104 54 0.23560649 1.7982185e-05 104 55 0.23560609 0.0042887791 
		103 48 0.83881897 0.012289987 103 49 0.83358371 0.0042893407 103 
		50 0.83343667 7.3010044e-05 103 51 0.8381561 0.0037956138 102 44
		 0.8381561 0.0037956138 102 45 0.83337885 7.3004725e-05 102 46 0.83366781
		 0.0041868971 102 47 0.83881897 0.012289987 101 40 0.88394135 0.0037998282 
		101 41 0.88871926 7.8098587e-05 101 42 0.88842958 0.0041919379 101 
		43 0.88327682 0.012294079 100 36 0.88327682 0.012294079 100 37 0.88851368
		 0.0042943968 100 38 0.88866144 7.8093261e-05 100 39 0.88394135 0.0037998282 
		99 33 0.99572963 8.7948458e-05 99 34 1.000000119209 0.0043591387 
		99 35 0.99572921 0.0043587456 98 30 0.99572921 0.0043587456 98 
		31 1.000000119209 0.0043591387 98 32 0.99572963 8.7948458e-05 97 
		27 0.99998605 0.15639767 97 28 0.99571484 0.16066808 97 29 0.9957152
		 0.15639728 96 24 0.9957152 0.15639728 96 25 0.99571484 0.16066808 
		96 26 0.99998605 0.15639767 95 20 0.8832643 0.14844128 95 21
		 0.88849968 0.15644185 95 22 0.88864666 0.16065823 95 23 0.88392723
		 0.15693554 94 16 0.88392723 0.15693554 94 17 0.88870448 0.16065823 
		94 18 0.88841552 0.15654437 94 19 0.8832643 0.14844128 93 12
		 0.83814198 0.15693133 93 13 0.83336407 0.16065313 93 14 0.83365375
		 0.15653934 93 15 0.83880639 0.14843704 92 8 0.83880639 0.14843704 
		92 9 0.83356971 0.1564368 92 10 0.83342189 0.16065313 92 11
		 0.83814198 0.15693133 91 4 0.2355921 0.15632731 91 5 0.24163198
		 0.15632787 91 6 0.2416316 0.16059867 91 7 0.23559171 0.16059811 
		90 0 0.23559171 0.16059811 90 1 0.2416316 0.16059867 90 2
		 0.24163198 0.15632787 90 3 0.2355921 0.15632731 89 55 0.23560609
		 0.0042887791 89 60 0.040072832 0.0042887372;
	setAttr ".nuv[250:374]" 89 115 0.040058844 0.15629125 89 3
		 0.2355921 0.15632731 88 107 0.0040982217 0.033976179 88 64 0.033989947
		 0.0083534205 88 119 0.033976704 0.15222555 88 110 0.0040896963 0.12659718 
		87 122 0.034606434 0.15848131 87 123 0.0025744841 0.13069694 87 
		111 0.0025744841 0.13069694 87 118 0.034611668 0.15848586 86 126
		 0.0025837643 0.029876225 86 127 0.034620829 0.0020977249 86 65 0.034615595
		 0.0021022614 86 106 0.0025837643 0.029876225 85 116 0.040058844 0.15629125 
		85 67 0.040072832 0.0042887372 85 56 0.23560609 0.0042887791 85 
		4 0.2355921 0.15632731 84 19 0.8832643 0.14844128 84 36 0.88327682
		 0.012294079 84 84 0.88335687 0.012342173 84 83 0.88334435 0.14839312 
		83 47 0.83881897 0.012289987 83 8 0.83880639 0.14843704 83 68
		 0.83872646 0.14838901 83 99 0.83873898 0.012338066 82 15 0.83880639
		 0.14843704 82 48 0.83881897 0.012289987 82 92 0.83873898 0.012338066 
		82 75 0.83872646 0.14838901 81 43 0.88327682 0.012294079 81 20
		 0.8832643 0.14844128 81 76 0.88334435 0.14839312 81 91 0.88335687
		 0.012342173 80 51 0.8381561 0.0037956138 80 132 0.8381561 0.0037956138 
		80 133 0.83933145 0.0077281734 80 93 0.83931518 0.007673596 79 
		136 0.88276523 0.0077321711 79 137 0.88394135 0.0037998282 79 40
		 0.88394135 0.0037998282 79 90 0.8827489 0.0077867452 78 23 0.88392723
		 0.15693554 78 144 0.88392723 0.15693554 78 145 0.88275188 0.15300299 
		78 77 0.88276815 0.15305759 77 148 0.8393181 0.15299904 77 149
		 0.83814198 0.15693133 77 12 0.83814198 0.15693133 77 74 0.83933437
		 0.15294449 76 112 0.033976704 0.15222555 76 63 0.033989947 0.0083534205 
		76 101 0.0040982217 0.033976179 76 104 0.0040896963 0.12659718 75 
		46 0.83366781 0.0041868971 75 52 0.24164598 0.0042893351 75 2
		 0.24163198 0.15632787 75 9 0.83356971 0.1564368 74 87 0.87819648
		 0.015607201 74 96 0.84389877 0.015604043 74 71 0.84388685 0.14512399 
		74 80 0.87818456 0.14512715 73 30 0.99572921 0.0043587456 73 
		37 0.88851368 0.0042943968 73 18 0.88841552 0.15654437 73 24 0.9957152
		 0.15639728 72 59 0.24164598 0.0042893351 72 49 0.83358371 0.0042893407 
		72 14 0.83365375 0.15653934 72 5 0.24163198 0.15632787 71 95
		 0.84389877 0.015604043 71 88 0.87819648 0.015607201 71 79 0.87818456
		 0.14512715 71 72 0.84388685 0.14512399 70 42 0.88842958 0.0041919379 
		70 35 0.99572921 0.0043587456 70 29 0.9957152 0.15639728 70 21
		 0.88849968 0.15644185 69 128 0.040250156 4.2241227e-10 69 129 0.23560649
		 1.7982185e-05 69 57 0.23560649 1.7982185e-05 69 66 0.040245567 0 
		68 130 0.24164636 1.8538132e-05 68 131 0.83340776 7.3007381e-05 68 
		50 0.83343667 7.3010044e-05 68 58 0.24164636 1.8538132e-05 67 134
		 0.84405911 0.011359678 67 135 0.87803686 0.011362806 67 89 0.87806356
		 0.011362808 67 94 0.84408587 0.01135968 66 138 0.88869035 7.8095924e-05 
		66 139 0.99572963 8.7948458e-05 66 33 0.99572963 8.7948458e-05 66 
		41 0.88871926 7.8098587e-05 65 140 1.000000119209 0.0043591387 65 
		141 0.99998605 0.15639767 65 27 0.99998605 0.15639767 65 34 1.000000119209
		 0.0043591387 64 142 0.99571484 0.16066808 64 143 0.88867557 0.16065823 
		64 22 0.88864666 0.16065823 64 28 0.99571484 0.16066808 63 146
		 0.87802416 0.14937152 63 147 0.84404641 0.14936839 63 73 0.84401965
		 0.14936839 63 78 0.87799746 0.1493715 62 150 0.83339298 0.16065313 
		62 151 0.2416316 0.16059867 62 6 0.2416316 0.16059867 62 13
		 0.83336407 0.16065313 61 120 0.23559171 0.16059811 61 121 0.040235378
		 0.16058013 61 117 0.040240005 0.16058013 61 7 0.23559171 0.16059811 
		60 124 0 0.12505513 60 125 8.2415736e-06 0.035517551 60 108 8.2415736e-06
		 0.035517551 60 109 0 0.12505513 59 121 0.040235378 0.16058013 59 
		122 0.034606434 0.15848131 59 118 0.034611668 0.15848586 59 117 0.040240005
		 0.16058013 58 111 0.0025744841 0.13069694 58 110 0.0040896963 0.12659718 
		58 119 0.033976704 0.15222555;
	setAttr ".nuv[375:499]" 58 118 0.034611668 0.15848586 57 108
		 8.2415736e-06 0.035517551 57 107 0.0040982217 0.033976179 57 110 0.0040896963
		 0.12659718 57 109 0 0.12505513 56 104 0.0040896963 0.12659718 56 
		103 0.0025744841 0.13069694 56 113 0.0346012 0.15847676 56 112 0.033976704
		 0.15222555 55 123 0.0025744841 0.13069694 55 124 0 0.12505513 55 
		109 0 0.12505513 55 111 0.0025744841 0.13069694 54 101 0.0040982217
		 0.033976179 54 100 8.2415736e-06 0.035517551 54 105 0 0.12505513 54 
		104 0.0040896963 0.12659718 53 125 8.2415736e-06 0.035517551 53 126
		 0.0025837643 0.029876225 53 106 0.0025837643 0.029876225 53 108 8.2415736e-06
		 0.035517551 52 94 0.84408587 0.01135968 52 93 0.83931518 0.007673596 
		52 133 0.83933145 0.0077281734 52 134 0.84405911 0.011359678 51 
		89 0.87806356 0.011362808 51 88 0.87819648 0.015607201 51 95 0.84389877
		 0.015604043 51 94 0.84408587 0.01135968 50 87 0.87819648 0.015607201 
		50 86 0.87801015 0.011362803 50 97 0.84403235 0.011359676 50 
		96 0.84389877 0.015604043 49 135 0.87803686 0.011362806 49 136 0.88276523
		 0.0077321711 49 90 0.8827489 0.0077867452 49 89 0.87806356 0.011362808 
		48 80 0.87818456 0.14512715 48 83 0.88334435 0.14839312 48 84
		 0.88335687 0.012342173 48 87 0.87819648 0.015607201 47 78 0.87799746
		 0.1493715 47 77 0.88276815 0.15305759 47 145 0.88275188 0.15300299 
		47 146 0.87802416 0.14937152 46 76 0.88334435 0.14839312 46 79
		 0.87818456 0.14512715 46 88 0.87819648 0.015607201 46 91 0.88335687
		 0.012342173 45 73 0.84401965 0.14936839 45 72 0.84388685 0.14512399 
		45 79 0.87818456 0.14512715 45 78 0.87799746 0.1493715 44 72
		 0.84388685 0.14512399 44 75 0.83872646 0.14838901 44 92 0.83873898
		 0.012338066 44 95 0.84389877 0.015604043 43 71 0.84388685 0.14512399 
		43 70 0.84407318 0.14936839 43 81 0.87805086 0.14937152 43 80
		 0.87818456 0.14512715 42 147 0.84404641 0.14936839 42 148 0.8393181
		 0.15299904 42 74 0.83933437 0.15294449 42 73 0.84401965 0.14936839 
		41 68 0.83872646 0.14838901 41 71 0.84388685 0.14512399 41 96
		 0.84389877 0.015604043 41 99 0.83873898 0.012338066 40 65 0.034615595
		 0.0021022614 40 64 0.033989947 0.0083534205 40 107 0.0040982217 0.033976179 
		40 106 0.0025837643 0.029876225 39 64 0.033989947 0.0083534205 39 
		67 0.040072832 0.0042887372 39 116 0.040058844 0.15629125 39 119
		 0.033976704 0.15222555 38 63 0.033989947 0.0083534205 38 62 0.034626063
		 0.0020931887 38 102 0.0025837643 0.029876225 38 101 0.0040982217 0.033976179 
		37 127 0.034620829 0.0020977249 37 128 0.040250156 4.2241227e-10 37 
		66 0.040245567 0 37 65 0.034615595 0.0021022614 36 60 0.040072832
		 0.0042887372 36 63 0.033989947 0.0083534205 36 112 0.033976704 0.15222555 
		36 115 0.040058844 0.15629125 35 57 0.23560649 1.7982185e-05 35 
		56 0.23560609 0.0042887791 35 67 0.040072832 0.0042887372 35 66
		 0.040245567 0 34 55 0.23560609 0.0042887791 34 54 0.23560649 1.7982185e-05 
		34 61 0.040254783 8.4831558e-10 34 60 0.040072832 0.0042887372 33 
		129 0.23560649 1.7982185e-05 33 130 0.24164636 1.8538132e-05 33 58
		 0.24164636 1.8538132e-05 33 57 0.23560649 1.7982185e-05 32 50 0.83343667
		 7.3010044e-05 32 49 0.83358371 0.0042893407 32 59 0.24164598 0.0042893351 
		32 58 0.24164636 1.8538132e-05 31 48 0.83881897 0.012289987 31 
		51 0.8381561 0.0037956138 31 93 0.83931518 0.007673596 31 92 0.83873898
		 0.012338066 30 46 0.83366781 0.0041868971 30 45 0.83337885 7.3004725e-05 
		30 53 0.24164636 1.8538132e-05 30 52 0.24164598 0.0042893351 29 
		131 0.83340776 7.3007381e-05 29 132 0.8381561 0.0037956138 29 51
		 0.8381561 0.0037956138 29 50 0.83343667 7.3010044e-05 28 44 0.8381561
		 0.0037956138 28 47 0.83881897 0.012289987 28 99 0.83873898 0.012338066 
		28 98 0.83934778 0.0077827503 27 40 0.88394135 0.0037998282 27 
		43 0.88327682 0.012294079 27 91 0.88335687 0.012342173 27 90 0.8827489
		 0.0077867452;
	setAttr ".nuv[500:607]" 26 137 0.88394135 0.0037998282 26 138
		 0.88869035 7.8095924e-05 26 41 0.88871926 7.8098587e-05 26 40 0.88394135
		 0.0037998282 25 36 0.88327682 0.012294079 25 39 0.88394135 0.0037998282 
		25 85 0.88278157 0.007677597 25 84 0.88335687 0.012342173 24 
		33 0.99572963 8.7948458e-05 24 35 0.99572921 0.0043587456 24 42
		 0.88842958 0.0041919379 24 41 0.88871926 7.8098587e-05 23 139 0.99572963
		 8.7948458e-05 23 140 1.000000119209 0.0043591387 23 34 1.000000119209
		 0.0043591387 23 33 0.99572963 8.7948458e-05 22 30 0.99572921 0.0043587456 
		22 32 0.99572963 8.7948458e-05 22 38 0.88866144 7.8093261e-05 22 
		37 0.88851368 0.0042943968 21 27 0.99998605 0.15639767 21 29 0.9957152
		 0.15639728 21 35 0.99572921 0.0043587456 21 34 1.000000119209 0.0043591387 
		20 141 0.99998605 0.15639767 20 142 0.99571484 0.16066808 20 28
		 0.99571484 0.16066808 20 27 0.99998605 0.15639767 19 24 0.9957152
		 0.15639728 19 26 0.99998605 0.15639767 19 31 1.000000119209 0.0043591387 
		19 30 0.99572921 0.0043587456 18 22 0.88864666 0.16065823 18 
		21 0.88849968 0.15644185 18 29 0.9957152 0.15639728 18 28 0.99571484
		 0.16066808 17 21 0.88849968 0.15644185 17 20 0.8832643 0.14844128 
		17 43 0.88327682 0.012294079 17 42 0.88842958 0.0041919379 16 
		20 0.8832643 0.14844128 16 23 0.88392723 0.15693554 16 77 0.88276815
		 0.15305759 16 76 0.88334435 0.14839312 15 19 0.8832643 0.14844128 
		15 18 0.88841552 0.15654437 15 37 0.88851368 0.0042943968 15 
		36 0.88327682 0.012294079 14 18 0.88841552 0.15654437 14 17 0.88870448
		 0.16065823 14 25 0.99571484 0.16066808 14 24 0.9957152 0.15639728 
		13 143 0.88867557 0.16065823 13 144 0.88392723 0.15693554 13 23
		 0.88392723 0.15693554 13 22 0.88864666 0.16065823 12 16 0.88392723
		 0.15693554 12 19 0.8832643 0.14844128 12 83 0.88334435 0.14839312 
		12 82 0.88273555 0.15294841 11 15 0.83880639 0.14843704 11 14
		 0.83365375 0.15653934 11 49 0.83358371 0.0042893407 11 48 0.83881897
		 0.012289987 10 12 0.83814198 0.15693133 10 15 0.83880639 0.14843704 
		10 75 0.83872646 0.14838901 10 74 0.83933437 0.15294449 9 149
		 0.83814198 0.15693133 9 150 0.83339298 0.16065313 9 13 0.83336407
		 0.16065313 9 12 0.83814198 0.15693133 8 9 0.83356971 0.1564368 
		8 8 0.83880639 0.14843704 8 47 0.83881897 0.012289987 8 46
		 0.83366781 0.0041868971 7 8 0.83880639 0.14843704 7 11 0.83814198
		 0.15693133 7 69 0.83930176 0.1530536 7 68 0.83872646 0.14838901 
		6 6 0.2416316 0.16059867 6 5 0.24163198 0.15632787 6 14
		 0.83365375 0.15653934 6 13 0.83336407 0.16065313 5 5 0.24163198
		 0.15632787 5 4 0.2355921 0.15632731 5 56 0.23560609 0.0042887791 
		5 59 0.24164598 0.0042893351 4 4 0.2355921 0.15632731 4 7
		 0.23559171 0.16059811 4 117 0.040240005 0.16058013 4 116 0.040058844
		 0.15629125 3 3 0.2355921 0.15632731 3 2 0.24163198 0.15632787 
		3 52 0.24164598 0.0042893351 3 55 0.23560609 0.0042887791 2 
		2 0.24163198 0.15632787 2 1 0.2416316 0.16059867 2 10 0.83342189
		 0.16065313 2 9 0.83356971 0.1564368 1 151 0.2416316 0.16059867 
		1 120 0.23559171 0.16059811 1 7 0.23559171 0.16059811 1 6
		 0.2416316 0.16059867 0 0 0.23559171 0.16059811 0 3 0.2355921
		 0.15632731 0 115 0.040058844 0.15629125 0 114 0.040230788 0.16058013;
createNode polyMapSew -n "polyMapSew3";
	rename -uid "533BE2E5-4BF8-FF46-B676-2D8B7F851658";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[0:303]";
createNode polyTweak -n "polyTweak34";
	rename -uid "BC6A71EF-45F8-6B5A-0E37-A2B54E2DFC0D";
	setAttr ".uopa" yes;
	setAttr -s 32 ".tk[120:151]" -type "float3"  -1.192081e-07 0 0 7.0332775e-05
		 0 0 -0.00010585679 0 0 2.3841619e-07 0 0 2.3841619e-07 0 0 2.3841619e-07 0 0 2.3841619e-07
		 0 0 0.00010609521 0 0 -7.0094364e-05 0 0 -1.192081e-07 0 0 -1.192081e-07 0 0 -0.00037920097
		 0 0 -2.789602e-15 0 0 0.00028085429 0 0 0.0003502334 0 0 -0.00035011419 0 0 -0.00028025825
		 0 0 -2.789602e-15 0 0 0.00037920097 0 0 -1.192081e-07 0 0 -1.192081e-07 0 0 -1.192081e-07
		 0 0 -1.192081e-07 0 0 -0.00037920097 0 0 -2.789602e-15 0 0 0.00028085429 0 0 0.0003502334
		 0 0 -0.00035011419 0 0 -0.00028013904 0 0 -2.789602e-15 0 0 0.00037920097 0 0 -1.192081e-07
		 0 0;
createNode polyMapCut -n "polyMapCut2";
	rename -uid "DC0E2959-476B-3EFC-F571-FAAA51BC239D";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[273:293]";
createNode polyTweakUV -n "polyTweakUV27";
	rename -uid "4034E52C-4714-FB0C-BDA7-BC9A63EEDC25";
	setAttr ".uopa" yes;
	setAttr -s 172 ".uvtk[0:171]" -type "float2" 0.47092855 0.094430372 0.47022575
		 0.084359422 0.46648127 0.094611719 0.46607554 0.084733471 0.056788653 0.095651463
		 0.45357883 0.34370318 0.4702093 0.00099866278 0.609456 0.0031778831 0.46656102 -0.00070024841
		 0.47098184 -0.0005679857 0.45784116 0.057054028 0.055340499 0.10632016 0.055537313
		 0.10647129 0.05868867 0.32918623 0.057615489 0.086574286 0.056539446 0.0012101699
		 0.053894967 0.0056310464 0.055173725 0.00055039115 0.058155805 0.05644609 0.027225532
		 0.10445748 0.029195882 0.089238524 0.02666644 0.085646808 -0.054152168 0.090777069
		 0.025325447 0.093095928 0.031422354 0.33446988 0.02586171 0.0062167067 0.027781226
		 0.0044466276 0.02567187 0.0063413847 0.023630835 0.0015137065 0.030706979 0.0568607
		 -0.043799974 0.32378125 -0.051018037 0.082908392 -0.051118232 0.0020941962 -0.054207839
		 0.0029968191 -0.04330603 0.32322145 -0.046997942 0.07316862 -0.047628202 0.072765462
		 0.029480197 0.062988199 0.03286913 0.32438707 0.032649487 0.32442972 0.033306748
		 0.34164858 0.031224348 0.064106464 0.058567196 0.34564069 0.060314506 0.35004881
		 0.056869477 0.052325346 0.056670338 0.052769102 0.057096452 0.052388802 0.45356011
		 0.056780569 0.45238024 0.35374433 0.45231485 0.055195272 0.4578281 0.34341034 0.45648909
		 0.35328442 0.6001572 0.32279509 0.6093235 0.090974316 0.59697932 0.33078071 0.59733188
		 0.076948643 0.60176694 0.076465361 0.6014483 0.3270072 0.60042214 0.076397561 0.60503417
		 0.074782811 0.057690054 0.32466933 0.058927506 0.32905254 0.056677192 0.093471706
		 0.055516094 0.0092300083 0.054786175 0.095300525 0.02916608 0.10835105 0.052431494
		 0.0086041521 0.054094225 0.0055776555 0.027757742 0.0090936851 0.032245964 0.052857794
		 0.030505873 0.056693949 0.027150549 0.0092816856 0.028430082 0.092398509 0.031046547
		 0.094194055 0.027040102 0.10442036 0.034724742 0.33660257 0.032619983 0.053782895
		 0.037264794 0.33552846 0.055876523 0.050317511 0.058414429 0.048751794 0.060383528
		 0.34175435 0.059262365 0.33919603 0.62541533 0.28160819 0.62572205 0.065986373 0.62756848
		 0.27252203 0.63243592 0.1331434 0.63159579 0.12466127 0.61262119 0.085173845 0.61347824
		 0.096620128 0.62818569 0.064312831 0.63253582 0.023451852 0.63334322 0.020517351
		 0.61360085 0.0056309719 0.61271876 0.0045501161 0.60879952 0.0032165069 0.62785596
		 0.063745387 0.60869771 0.082335904 0.46601415 0.00067512877 0.053682894 0.01458578
		 0.029905893 0.014758455 0.025212318 0.00058993883 -0.054209985 0.089584976 -0.054383136
		 0.0038054157 -0.040383138 0.33035392 -0.044109143 0.074669316 0.035157651 0.047517307
		 0.057210535 0.044184424 0.058418244 0.055787019 0.45645571 0.055652291 0.034270793
		 0.32176888 0.053945452 0.10971235 0.059753686 0.34095651 0.60476798 0.31620389 0.62795168
		 0.27509546 0.63319826 0.13302089 0.055432886 0.090434536 0.054257303 0.0046068747
		 0.035569936 0.3388564 0.03353104 0.059381984 0.63168144 0.020637261 0.46757883 0.042819954
		 0.5855028 0.042615585 0.58857083 0.047163703 0.60175282 0.10015774 0.60133898 0.11063237
		 0.585976 0.27694964 0.58523643 0.28805992 0.56639212 0.34439293 0.56263471 0.34948847
		 0.44030488 0.39617863 0.43707955 0.39715675 0.070220023 0.39590052 0.069166869 0.39030945
		 0.071284503 0.38472882 0.070160955 0.37935305 0.050643355 0.37398392 0.049726099
		 0.37633556 0.052073807 0.37918895 0.05129692 0.3817378 -0.012691522 0.34754032 -0.013556922
		 0.33914986 -0.023605967 0.050031535 -0.023878062 0.041967429 0.037135333 0.043182544
		 0.038467556 0.046983026 0.036632389 0.050988503 0.038113683 0.054712154 0.060022205
		 0.054575972 0.061746866 0.051035039 0.060182005 0.047173165 0.061863869 0.043522783
		 0.4638381 0.042821787 -0.023586417 0.042252727 -0.017346168 0.05632551 -0.016440356
		 0.056539953 0.048491389 0.024128733 0.049372524 0.019344371 0.047121495 0.014422799
		 0.048144132 0.0096128266 0.068245679 0.0037314417 0.069467098 0.0056500277 0.06744203
		 0.0079233581 0.068592101 0.0097507006 0.43719703 0.01148392 0.44039762 0.012380766
		 0.56308317 0.057835892 0.56682539 0.058703989 0.58561289 0.059064545 0.58636928 0.05881492
		 0.60126299 0.045515396 0.60170883 0.044702441 0.58856785 0.042244457;
createNode polyUnite -n "polyUnite1";
	rename -uid "A0AA676D-4779-06B5-447A-719E7817BBC4";
	setAttr -s 3 ".ip";
	setAttr -s 3 ".im";
createNode groupId -n "groupId1";
	rename -uid "2AA891B3-42D2-1D52-CB9F-869E223C3F1A";
	setAttr ".ihi" 0;
createNode groupParts -n "groupParts1";
	rename -uid "5632EAD4-4083-FD09-7C63-E5BE17375C5D";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "f[0:255]";
createNode groupId -n "groupId2";
	rename -uid "1A2275A2-424D-4055-C363-7D8B0CE3B24C";
	setAttr ".ihi" 0;
createNode groupId -n "groupId3";
	rename -uid "86FC67EA-41C8-F75F-8A45-7BB4BE0D96DE";
	setAttr ".ihi" 0;
createNode groupParts -n "groupParts2";
	rename -uid "03638B8F-4523-FBF5-C879-BE8E6C68649C";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "f[0:188]";
createNode groupId -n "groupId4";
	rename -uid "A8D5F19F-43FB-A675-0959-4B8F4EFDA377";
	setAttr ".ihi" 0;
createNode groupId -n "groupId5";
	rename -uid "069D60D1-4040-9EA3-EC9D-E788086CC189";
	setAttr ".ihi" 0;
createNode groupParts -n "groupParts3";
	rename -uid "5631C99F-4C40-367E-9C77-B98B0810B1A3";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "f[0:153]";
createNode groupId -n "groupId6";
	rename -uid "3D660E55-4B8D-C84F-E8A2-649751FD01AE";
	setAttr ".ihi" 0;
createNode groupId -n "groupId7";
	rename -uid "710D18A4-45E5-3E21-746D-4DAFB2772878";
	setAttr ".ihi" 0;
createNode groupParts -n "groupParts4";
	rename -uid "475DEB8B-412B-9460-696A-DBB78637FB8E";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "f[0:598]";
createNode polyMapCut -n "polyMapCut3";
	rename -uid "31A23484-45D8-3D81-0ED0-3C9248F06A7D";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 3 "e[470:478]" "e[496:497]" "e[500:501]";
createNode polyTweakUV -n "polyTweakUV28";
	rename -uid "55340313-4C96-8908-84B6-3CA84A09ADBD";
	setAttr ".uopa" yes;
	setAttr -s 506 ".uvtk";
	setAttr ".uvtk[0]" -type "float2" -0.042007625 -0.00022601709 ;
	setAttr ".uvtk[1]" -type "float2" -0.045441657 -0.002662953 ;
	setAttr ".uvtk[2]" -type "float2" -0.036362454 0.0039101876 ;
	setAttr ".uvtk[3]" -type "float2" -0.032897338 0.0099334158 ;
	setAttr ".uvtk[4]" -type "float2" -0.051689558 -0.00086027011 ;
	setAttr ".uvtk[5]" -type "float2" -0.04889068 0.00075060502 ;
	setAttr ".uvtk[6]" -type "float2" -0.028443204 0.0073087253 ;
	setAttr ".uvtk[7]" -type "float2" -0.030955987 0.0015442409 ;
	setAttr ".uvtk[8]" -type "float2" -0.012443752 -0.0032070242 ;
	setAttr ".uvtk[9]" -type "float2" -0.010933253 5.0250441e-05 ;
	setAttr ".uvtk[10]" -type "float2" -0.04608573 0.0028320588 ;
	setAttr ".uvtk[11]" -type "float2" -0.03371346 0.01485217 ;
	setAttr ".uvtk[12]" -type "float2" -0.048956007 0.0037212409 ;
	setAttr ".uvtk[13]" -type "float2" -0.022408208 0.024110138 ;
	setAttr ".uvtk[14]" -type "float2" -0.02533563 0.024887502 ;
	setAttr ".uvtk[15]" -type "float2" 0.024408855 -0.0022822875 ;
	setAttr ".uvtk[16]" -type "float2" 0.027617726 -0.0026116627 ;
	setAttr ".uvtk[17]" -type "float2" 0.030543298 -0.0012191194 ;
	setAttr ".uvtk[18]" -type "float2" 0.02239684 -0.0039730924 ;
	setAttr ".uvtk[19]" -type "float2" 0.016196225 0.0076125618 ;
	setAttr ".uvtk[20]" -type "float2" 0.014402602 0.0032155863 ;
	setAttr ".uvtk[21]" -type "float2" 0.0096267173 0.0014873487 ;
	setAttr ".uvtk[22]" -type "float2" 0.012688611 0.0052734958 ;
	setAttr ".uvtk[23]" -type "float2" -0.0012723058 -0.0013767141 ;
	setAttr ".uvtk[24]" -type "float2" -0.0049639796 -0.0047512907 ;
	setAttr ".uvtk[25]" -type "float2" 0.031987704 0.0016646129 ;
	setAttr ".uvtk[26]" -type "float2" 0.02155498 0.010834966 ;
	setAttr ".uvtk[27]" -type "float2" 0.034387976 0.0024410835 ;
	setAttr ".uvtk[28]" -type "float2" 0.008230947 0.020422433 ;
	setAttr ".uvtk[29]" -type "float2" 0.0058019161 0.019743178 ;
	setAttr ".uvtk[30]" -type "float2" -0.020165747 0.027010262 ;
	setAttr ".uvtk[31]" -type "float2" -0.017405724 0.036156595 ;
	setAttr ".uvtk[32]" -type "float2" -0.018115466 0.035759985 ;
	setAttr ".uvtk[33]" -type "float2" -0.022348886 0.027460635 ;
	setAttr ".uvtk[34]" -type "float2" -0.020657724 0.026870489 ;
	setAttr ".uvtk[35]" -type "float2" -0.015447622 0.028507829 ;
	setAttr ".uvtk[36]" -type "float2" -0.017097509 0.028613865 ;
	setAttr ".uvtk[37]" -type "float2" -0.016037142 0.034518898 ;
	setAttr ".uvtk[38]" -type "float2" 0.0032154024 0.023058858 ;
	setAttr ".uvtk[39]" -type "float2" 0.0018810648 0.031245612 ;
	setAttr ".uvtk[40]" -type "float2" 0.0017385501 0.030793935 ;
	setAttr ".uvtk[41]" -type "float2" 0.0045683682 0.023805764 ;
	setAttr ".uvtk[42]" -type "float2" 0.0039241323 0.024739292 ;
	setAttr ".uvtk[43]" -type "float2" 0.0037026107 0.02293786 ;
	setAttr ".uvtk[44]" -type "float2" -0.00031757355 0.025148835 ;
	setAttr ".uvtk[45]" -type "float2" -0.0012694001 0.030675791 ;
	setAttr ".uvtk[46]" -type "float2" 0.0025964016 -0.012686756 ;
	setAttr ".uvtk[47]" -type "float2" 0.0025314922 -0.011178758 ;
	setAttr ".uvtk[48]" -type "float2" -0.0026376019 -0.014220294 ;
	setAttr ".uvtk[49]" -type "float2" -0.0024035047 -0.017785963 ;
	setAttr ".uvtk[50]" -type "float2" 0.0086112246 -0.014785375 ;
	setAttr ".uvtk[51]" -type "float2" 0.0018768543 -0.012537804 ;
	setAttr ".uvtk[52]" -type "float2" -0.0059090927 -0.014558431 ;
	setAttr ".uvtk[53]" -type "float2" -0.0049381028 -0.013417806 ;
	setAttr ".uvtk[54]" -type "float2" -0.0038509429 0.0024353899 ;
	setAttr ".uvtk[55]" -type "float2" -0.0042808116 0.0016096868 ;
	setAttr ".uvtk[56]" -type "float2" 0.00016809301 -0.0081184767 ;
	setAttr ".uvtk[57]" -type "float2" -0.003140993 -0.021589752 ;
	setAttr ".uvtk[58]" -type "float2" -0.0011416296 -0.00786772 ;
	setAttr ".uvtk[59]" -type "float2" -0.020768436 -0.0016462766 ;
	setAttr ".uvtk[60]" -type "float2" -0.021329345 -0.0009434782 ;
	setAttr ".uvtk[61]" -type "float2" -0.0086278133 -0.018815059 ;
	setAttr ".uvtk[62]" -type "float2" -0.018646538 -0.020802218 ;
	setAttr ".uvtk[63]" -type "float2" -0.0078991931 -0.018521864 ;
	setAttr ".uvtk[64]" -type "float2" -0.0070159137 -0.017682929 ;
	setAttr ".uvtk[65]" -type "float2" -0.0036091325 -0.025284875 ;
	setAttr ".uvtk[66]" -type "float2" -0.0018248968 -0.021902341 ;
	setAttr ".uvtk[67]" -type "float2" 0.00056093 -0.022016216 ;
	setAttr ".uvtk[68]" -type "float2" 0.0022312589 -0.022762377 ;
	setAttr ".uvtk[69]" -type "float2" -0.002018258 -0.0079867486 ;
	setAttr ".uvtk[70]" -type "float2" -0.0030452386 -0.0074892864 ;
	setAttr ".uvtk[71]" -type "float2" -0.006224215 -0.013591968 ;
	setAttr ".uvtk[72]" -type "float2" -0.0029070191 -0.029015321 ;
	setAttr ".uvtk[73]" -type "float2" -0.0049567823 -0.013499372 ;
	setAttr ".uvtk[74]" -type "float2" 0.012114782 -0.0058248858 ;
	setAttr ".uvtk[75]" -type "float2" 0.011380929 -0.0066821501 ;
	setAttr ".uvtk[76]" -type "float2" -0.017024161 -0.0060097538 ;
	setAttr ".uvtk[77]" -type "float2" -0.011238846 -0.017606016 ;
	setAttr ".uvtk[78]" -type "float2" -0.0071752109 -0.012646493 ;
	setAttr ".uvtk[79]" -type "float2" -0.018384533 -0.0051248334 ;
	setAttr ".uvtk[80]" -type "float2" -0.02489586 -0.0048940443 ;
	setAttr ".uvtk[81]" -type "float2" -0.023665847 -0.0036723278 ;
	setAttr ".uvtk[82]" -type "float2" -0.0138734 -0.0079913102 ;
	setAttr ".uvtk[83]" -type "float2" 0.0071467906 -0.010534698 ;
	setAttr ".uvtk[84]" -type "float2" -0.0029592365 -0.016263623 ;
	setAttr ".uvtk[85]" -type "float2" 0.0015583802 -0.021091301 ;
	setAttr ".uvtk[86]" -type "float2" 0.0087981373 -0.010229671 ;
	setAttr ".uvtk[87]" -type "float2" 0.019315794 -0.008437179 ;
	setAttr ".uvtk[88]" -type "float2" 0.015163202 -0.0077823624 ;
	setAttr ".uvtk[89]" -type "float2" 0.0052415878 -0.011601264 ;
	setAttr ".uvtk[90]" -type "float2" -0.029948892 0.012371544 ;
	setAttr ".uvtk[91]" -type "float2" -0.013425646 0.0030180253 ;
	setAttr ".uvtk[92]" -type "float2" -0.016068196 0.033637404 ;
	setAttr ".uvtk[93]" -type "float2" -0.017219638 0.033361554 ;
	setAttr ".uvtk[94]" -type "float2" -0.0098867482 0.024412278 ;
	setAttr ".uvtk[95]" -type "float2" -0.011934138 0.024763647 ;
	setAttr ".uvtk[96]" -type "float2" 0.01516882 0.0091849919 ;
	setAttr ".uvtk[97]" -type "float2" 0.0015909541 0.029133473 ;
	setAttr ".uvtk[98]" -type "float2" 0.0015918165 0.0010561724 ;
	setAttr ".uvtk[99]" -type "float2" 0.00078248419 0.028831687 ;
	setAttr ".uvtk[100]" -type "float2" -0.0040328917 0.017334972 ;
	setAttr ".uvtk[101]" -type "float2" -0.0044065532 0.017924223 ;
	setAttr ".uvtk[102]" -type "float2" -0.0082407026 -0.0085836314 ;
	setAttr ".uvtk[103]" -type "float2" -0.0062817372 -0.010517504 ;
	setAttr ".uvtk[104]" -type "float2" 0.0036360892 -0.0041858517 ;
	setAttr ".uvtk[105]" -type "float2" 0.0026893588 -0.0033510886 ;
	setAttr ".uvtk[106]" -type "float2" 0.0024985224 -0.014358066 ;
	setAttr ".uvtk[107]" -type "float2" -0.00066755712 -0.012261743 ;
	setAttr ".uvtk[108]" -type "float2" -0.013833329 -0.0043096771 ;
	setAttr ".uvtk[109]" -type "float2" -0.009634003 -0.0053081741 ;
	setAttr ".uvtk[110]" -type "float2" 0.0026559383 -0.015049446 ;
	setAttr ".uvtk[111]" -type "float2" -0.0085538477 -0.0065403213 ;
	setAttr ".uvtk[112]" -type "float2" 0.00040151365 -0.018597592 ;
	setAttr ".uvtk[113]" -type "float2" -0.00023989193 -0.017943371 ;
	setAttr ".uvtk[114]" -type "float2" -0.0026986413 -0.024837364 ;
	setAttr ".uvtk[115]" -type "float2" -0.0026872568 -0.02573799 ;
	setAttr ".uvtk[116]" -type "float2" -0.005334836 -0.022189964 ;
	setAttr ".uvtk[117]" -type "float2" -0.010092331 -0.0087757949 ;
	setAttr ".uvtk[118]" -type "float2" -0.0032320172 -0.0062579741 ;
	setAttr ".uvtk[119]" -type "float2" -0.0022287816 -0.005845808 ;
	setAttr ".uvtk[120]" -type "float2" -0.0044286367 0.015614718 ;
	setAttr ".uvtk[121]" -type "float2" -0.0056774132 0.014789671 ;
	setAttr ".uvtk[122]" -type "float2" -0.0041402639 0.0035277642 ;
	setAttr ".uvtk[123]" -type "float2" -0.0038566054 0.0034292974 ;
	setAttr ".uvtk[124]" -type "float2" -0.01029349 0.022943079 ;
	setAttr ".uvtk[125]" -type "float2" -0.010922945 0.022502843 ;
	setAttr ".uvtk[126]" -type "float2" -0.00022790534 -0.014438238 ;
	setAttr ".uvtk[127]" -type "float2" 0.0020222301 0.00046611205 ;
	setAttr ".uvtk[128]" -type "float2" -0.0037311683 -0.01830643 ;
	setAttr ".uvtk[129]" -type "float2" -0.0036497782 -0.017352875 ;
	setAttr ".uvtk[130]" -type "float2" -0.009881082 -0.013943251 ;
	setAttr ".uvtk[131]" -type "float2" -0.010428074 -0.014776047 ;
	setAttr ".uvtk[132]" -type "float2" -0.012438525 -0.010951784 ;
	setAttr ".uvtk[133]" -type "float2" -0.003061715 -0.0052503906 ;
	setAttr ".uvtk[134]" -type "float2" -0.0087034432 -0.0011057816 ;
	setAttr ".uvtk[135]" -type "float2" -0.0099338917 -0.0038083754 ;
	setAttr ".uvtk[136]" -type "float2" 0.0023313435 -0.0048727952 ;
	setAttr ".uvtk[137]" -type "float2" 0.0035234066 -0.0040606223 ;
	setAttr ".uvtk[138]" -type "float2" -0.0069038719 -0.0045634764 ;
	setAttr ".uvtk[139]" -type "float2" -0.002935037 -0.0021355408 ;
	setAttr ".uvtk[140]" -type "float2" -0.010036096 -0.0047760834 ;
	setAttr ".uvtk[141]" -type "float2" -0.013960458 -0.0054122438 ;
	setAttr ".uvtk[142]" -type "float2" 0.0036555678 0.00016633468 ;
	setAttr ".uvtk[143]" -type "float2" -0.0059602968 0.016378257 ;
	setAttr ".uvtk[144]" -type "float2" -0.0033913702 -0.0037424196 ;
	setAttr ".uvtk[145]" -type "float2" -0.0040820991 -0.0050872792 ;
	setAttr ".uvtk[146]" -type "float2" -0.0017514899 0.028893795 ;
	setAttr ".uvtk[147]" -type "float2" -0.0054008481 0.01621142 ;
	setAttr ".uvtk[148]" -type "float2" -0.015516615 0.032427788 ;
	setAttr ".uvtk[149]" -type "float2" -0.011237449 0.025007367 ;
	setAttr ".uvtk[150]" -type "float2" -0.0088331169 0.021894161 ;
	setAttr ".uvtk[151]" -type "float2" -0.011255625 0.0014263429 ;
	setAttr ".uvtk[152]" -type "float2" -0.0015897225 0.0039398111 ;
	setAttr ".uvtk[153]" -type "float2" 0.00072362693 -0.0028492771 ;
	setAttr ".uvtk[154]" -type "float2" -0.0056549087 -0.0056609144 ;
	setAttr ".uvtk[155]" -type "float2" -0.0059171692 -0.0053242673 ;
	setAttr ".uvtk[156]" -type "float2" -0.012040092 -0.0068978891 ;
	setAttr ".uvtk[157]" -type "float2" -0.011932088 -0.0075386986 ;
	setAttr ".uvtk[158]" -type "float2" 0.0045015747 0.0016259588 ;
	setAttr ".uvtk[159]" -type "float2" 0.0045740539 0.0022615232 ;
	setAttr ".uvtk[160]" -type "float2" -0.0054526064 -0.0039370023 ;
	setAttr ".uvtk[161]" -type "float2" -0.0053980085 -0.004208263 ;
	setAttr ".uvtk[162]" -type "float2" 0.011834417 0.0098044053 ;
	setAttr ".uvtk[163]" -type "float2" 0.0012294594 0.025228474 ;
	setAttr ".uvtk[164]" -type "float2" -0.0030106124 0.018664096 ;
	setAttr ".uvtk[165]" -type "float2" 0.0038488731 0.0053077717 ;
	setAttr ".uvtk[166]" -type "float2" 0.0012093419 -0.016947564 ;
	setAttr ".uvtk[167]" -type "float2" -0.0042963396 -0.013722476 ;
	setAttr ".uvtk[168]" -type "float2" -0.0046932767 -0.012985643 ;
	setAttr ".uvtk[169]" -type "float2" 0.0010835761 -0.016362842 ;
	setAttr ".uvtk[170]" -type "float2" -0.00014323927 -0.021838475 ;
	setAttr ".uvtk[171]" -type "float2" -0.0071682148 -0.024672735 ;
	setAttr ".uvtk[172]" -type "float2" -0.0070864968 -0.024174023 ;
	setAttr ".uvtk[173]" -type "float2" 0.00027983449 -0.021330882 ;
	setAttr ".uvtk[174]" -type "float2" -0.0097667901 -0.0075933002 ;
	setAttr ".uvtk[175]" -type "float2" -0.010902616 -0.0079799853 ;
	setAttr ".uvtk[176]" -type "float2" -0.0094645647 -0.012480315 ;
	setAttr ".uvtk[177]" -type "float2" -0.0087275831 -0.012136575 ;
	setAttr ".uvtk[178]" -type "float2" -0.0016625375 -0.015915621 ;
	setAttr ".uvtk[179]" -type "float2" -0.00072960556 -0.016185034 ;
	setAttr ".uvtk[180]" -type "float2" 0.0021895915 -0.011575634 ;
	setAttr ".uvtk[181]" -type "float2" 0.0009641815 -0.011228258 ;
	setAttr ".uvtk[182]" -type "float2" -0.0027151853 -0.0075005516 ;
	setAttr ".uvtk[183]" -type "float2" -0.0045322333 -0.0074560866 ;
	setAttr ".uvtk[184]" -type "float2" -0.0045650755 -0.0070247874 ;
	setAttr ".uvtk[185]" -type "float2" -0.0027581006 -0.0068882331 ;
	setAttr ".uvtk[186]" -type "float2" -0.0018307636 0.0021562614 ;
	setAttr ".uvtk[187]" -type "float2" -0.0042493106 0.0025027432 ;
	setAttr ".uvtk[188]" -type "float2" -0.0042591156 0.0031096973 ;
	setAttr ".uvtk[189]" -type "float2" -0.0017281245 0.002582375 ;
	setAttr ".uvtk[190]" -type "float2" 0.0013071569 -0.0043170415 ;
	setAttr ".uvtk[191]" -type "float2" 0.0028994055 -0.0043383799 ;
	setAttr ".uvtk[192]" -type "float2" 0.0029962631 -0.0041475259 ;
	setAttr ".uvtk[193]" -type "float2" 0.0013073357 -0.0041760169 ;
	setAttr ".uvtk[194]" -type "float2" -0.0074798837 -0.005335473 ;
	setAttr ".uvtk[195]" -type "float2" -0.014306583 -0.0050924649 ;
	setAttr ".uvtk[196]" -type "float2" -0.01433716 -0.0052196612 ;
	setAttr ".uvtk[197]" -type "float2" -0.0076031461 -0.005410098 ;
	setAttr ".uvtk[198]" -type "float2" 0.012709055 0.0096459165 ;
	setAttr ".uvtk[199]" -type "float2" 0.0016940478 0.026343439 ;
	setAttr ".uvtk[200]" -type "float2" -0.0034042713 0.018357728 ;
	setAttr ".uvtk[201]" -type "float2" 0.0030054599 0.0040458818 ;
	setAttr ".uvtk[202]" -type "float2" 0.0013471786 0.027594537 ;
	setAttr ".uvtk[203]" -type "float2" 0.0014680494 0.028688166 ;
	setAttr ".uvtk[204]" -type "float2" -0.0043434016 0.018155843 ;
	setAttr ".uvtk[205]" -type "float2" -0.0038970825 0.01843271 ;
	setAttr ".uvtk[206]" -type "float2" 0.01384059 0.009272553 ;
	setAttr ".uvtk[207]" -type "float2" 0.014814649 0.0092006065 ;
	setAttr ".uvtk[208]" -type "float2" 0.0025931746 0.0028172513 ;
	setAttr ".uvtk[209]" -type "float2" 0.0019483715 0.0016403575 ;
	setAttr ".uvtk[210]" -type "float2" -0.044835016 -0.0034415685 ;
	setAttr ".uvtk[211]" -type "float2" 0.040776938 -0.0074726008 ;
	setAttr ".uvtk[212]" -type "float2" -0.047005683 -0.0011591278 ;
	setAttr ".uvtk[213]" -type "float2" -0.039633796 0.00063789263 ;
	setAttr ".uvtk[214]" -type "float2" -0.05121997 0.034483731 ;
	setAttr ".uvtk[215]" -type "float2" -0.040191382 0.03644979 ;
	setAttr ".uvtk[216]" -type "float2" -0.037598372 0.038361549 ;
	setAttr ".uvtk[217]" -type "float2" -0.018079141 0.040052235 ;
	setAttr ".uvtk[218]" -type "float2" -0.017790204 0.025975466 ;
	setAttr ".uvtk[219]" -type "float2" -0.017701155 0.027015984 ;
	setAttr ".uvtk[220]" -type "float2" -0.017015288 0.025347292 ;
	setAttr ".uvtk[221]" -type "float2" -0.016723523 0.024106681 ;
	setAttr ".uvtk[222]" -type "float2" -0.012394854 0.0046196021 ;
	setAttr ".uvtk[223]" -type "float2" 0.0047060177 -0.0069572553 ;
	setAttr ".uvtk[224]" -type "float2" -0.01227159 0.0035305656 ;
	setAttr ".uvtk[225]" -type "float2" 0.0048240349 -0.0075994357 ;
	setAttr ".uvtk[226]" -type "float2" -0.011015424 -0.0051798187 ;
	setAttr ".uvtk[227]" -type "float2" 0.0060109645 -0.013218161 ;
	setAttr ".uvtk[228]" -type "float2" -0.011035868 -0.0028023086 ;
	setAttr ".uvtk[229]" -type "float2" 0.003977634 -0.0096027236 ;
	setAttr ".uvtk[230]" -type "float2" 0.0095663005 -0.01479733 ;
	setAttr ".uvtk[231]" -type "float2" -0.011551715 -0.014188528 ;
	setAttr ".uvtk[232]" -type "float2" -0.022677606 -0.013854325 ;
	setAttr ".uvtk[233]" -type "float2" -0.021286821 -0.012592942 ;
	setAttr ".uvtk[234]" -type "float2" -0.0093267588 -0.0070675276 ;
	setAttr ".uvtk[235]" -type "float2" -0.016812207 -0.0057136677 ;
	setAttr ".uvtk[236]" -type "float2" -0.016695054 -0.0053770207 ;
	setAttr ".uvtk[237]" -type "float2" -0.016325714 -0.0045215748 ;
	setAttr ".uvtk[238]" -type "float2" -0.014148802 0.011762295 ;
	setAttr ".uvtk[239]" -type "float2" 0.0074188858 0.0060812626 ;
	setAttr ".uvtk[240]" -type "float2" -0.0085377414 0.0084893741 ;
	setAttr ".uvtk[241]" -type "float2" 0.0011838246 0.0029945462 ;
	setAttr ".uvtk[242]" -type "float2" 0.0075907707 -0.0026559196 ;
	setAttr ".uvtk[243]" -type "float2" -0.01364217 -0.0041020741 ;
	setAttr ".uvtk[244]" -type "float2" 0.0078707328 -0.0045799576 ;
	setAttr ".uvtk[245]" -type "float2" -0.014355287 -0.0052379598 ;
	setAttr ".uvtk[246]" -type "float2" -0.0055418606 -0.013191219 ;
	setAttr ".uvtk[247]" -type "float2" -0.0079379678 -0.015102863 ;
	setAttr ".uvtk[248]" -type "float2" -0.033849329 -0.021143913 ;
	setAttr ".uvtk[249]" -type "float2" -0.042322397 -0.022163868 ;
	setAttr ".uvtk[250]" -type "float2" -0.0045434232 0.0059315898 ;
	setAttr ".uvtk[251]" -type "float2" 0.0053360611 0.005485245 ;
	setAttr ".uvtk[252]" -type "float2" 0.011188645 0.0086685792 ;
	setAttr ".uvtk[253]" -type "float2" -0.010537237 0.009093944 ;
	setAttr ".uvtk[254]" -type "float2" -0.0090347007 -0.00066479668 ;
	setAttr ".uvtk[255]" -type "float2" 0.0081701865 -0.0056138001 ;
	setAttr ".uvtk[256]" -type "float2" -0.013925292 -0.0046037664 ;
	setAttr ".uvtk[257]" -type "float2" -0.01341556 -0.0028079976 ;
	setAttr ".uvtk[258]" -type "float2" 0.007695674 -0.003984686 ;
	setAttr ".uvtk[259]" -type "float2" 0.02424977 -0.019640416 ;
	setAttr ".uvtk[260]" -type "float2" -0.059632748 -0.0056221485 ;
	setAttr ".uvtk[261]" -type "float2" 0.016400371 -0.017808765 ;
	setAttr ".uvtk[262]" -type "float2" -0.0048090597 -0.014730476 ;
	setAttr ".uvtk[263]" -type "float2" -0.0063780397 -0.012252418 ;
	setAttr ".uvtk[264]" -type "float2" 0.0065833479 -0.0076694712 ;
	setAttr ".uvtk[265]" -type "float2" 0.0072708875 -0.0085633919 ;
	setAttr ".uvtk[266]" -type "float2" 0.007487312 -0.0089312121 ;
	setAttr ".uvtk[267]" -type "float2" 1.0462478e-05 -0.011769498 ;
	setAttr ".uvtk[268]" -type "float2" 0.01540288 -0.018347044 ;
	setAttr ".uvtk[269]" -type "float2" 0.016796913 -0.021365423 ;
	setAttr ".uvtk[270]" -type "float2" 0.0057507679 -0.021826465 ;
	setAttr ".uvtk[271]" -type "float2" -0.014658235 -0.022796709 ;
	setAttr ".uvtk[272]" -type "float2" 0.020011958 0.034612916 ;
	setAttr ".uvtk[273]" -type "float2" 0.022450626 0.032376133 ;
	setAttr ".uvtk[274]" -type "float2" 0.033253945 0.029503789 ;
	setAttr ".uvtk[275]" -type "float2" 0.022640854 -0.00098511158 ;
	setAttr ".uvtk[276]" -type "float2" 0.031056851 -0.0032671946 ;
	setAttr ".uvtk[277]" -type "float2" 0.029343575 -0.0054363864 ;
	setAttr ".uvtk[448]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[449]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[450]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[451]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[452]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[453]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[454]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[455]" -type "float2" -0.2482492 -0.0022364787 ;
	setAttr ".uvtk[456]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[457]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[458]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[459]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[460]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[461]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[462]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[463]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[464]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[465]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[466]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[467]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[468]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[469]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[470]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[471]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[472]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[473]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[474]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[475]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[476]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[477]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[478]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[479]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[480]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[481]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[482]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[483]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[484]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[485]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[486]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[487]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[488]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[489]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[490]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[491]" -type "float2" -0.24824919 -0.0022364787 ;
	setAttr ".uvtk[492]" -type "float2" -0.22553772 -0.056769703 ;
	setAttr ".uvtk[493]" -type "float2" -0.22615927 -0.058574393 ;
	setAttr ".uvtk[494]" -type "float2" -0.29043251 -0.058922395 ;
	setAttr ".uvtk[495]" -type "float2" -0.29012468 -0.0580124 ;
	setAttr ".uvtk[496]" -type "float2" -0.22143298 -0.040059917 ;
	setAttr ".uvtk[497]" -type "float2" -0.22295681 -0.040087096 ;
	setAttr ".uvtk[498]" -type "float2" -0.22516781 -0.023127586 ;
	setAttr ".uvtk[499]" -type "float2" -0.22338325 -0.023011401 ;
	setAttr ".uvtk[500]" -type "float2" -0.2242412 -0.058588713 ;
	setAttr ".uvtk[501]" -type "float2" -0.22381756 -0.056889106 ;
	setAttr ".uvtk[502]" -type "float2" -0.037927292 -0.056584079 ;
	setAttr ".uvtk[503]" -type "float2" -0.037000023 -0.05785552 ;
	setAttr ".uvtk[504]" -type "float2" -0.21757999 -0.056630224 ;
	setAttr ".uvtk[505]" -type "float2" -0.21966243 -0.056593627 ;
	setAttr ".uvtk[506]" -type "float2" -0.22578478 -0.021277644 ;
	setAttr ".uvtk[507]" -type "float2" -0.29006302 -0.023336358 ;
	setAttr ".uvtk[508]" -type "float2" -0.29036847 -0.022451237 ;
	setAttr ".uvtk[509]" -type "float2" -0.2238518 -0.021279775 ;
	setAttr ".uvtk[510]" -type "float2" -0.21868294 -0.024697036 ;
	setAttr ".uvtk[511]" -type "float2" -0.2166127 -0.024591446 ;
	setAttr ".uvtk[512]" -type "float2" -0.035438143 -0.018088497 ;
	setAttr ".uvtk[513]" -type "float2" -0.036784731 -0.019306608 ;
	setAttr ".uvtk[514]" -type "float2" -0.036790513 -0.057115097 ;
	setAttr ".uvtk[515]" -type "float2" -0.037338637 -0.055539548 ;
	setAttr ".uvtk[516]" -type "float2" -0.037655495 -0.054199696 ;
	setAttr ".uvtk[517]" -type "float2" -0.036799632 -0.057210524 ;
	setAttr ".uvtk[518]" -type "float2" -0.03701248 -0.055819079 ;
	setAttr ".uvtk[519]" -type "float2" -0.037000023 -0.055449963 ;
	setAttr ".uvtk[520]" -type "float2" -0.039501213 -0.037664883 ;
	setAttr ".uvtk[521]" -type "float2" -0.039739273 -0.03763295 ;
	setAttr ".uvtk[522]" -type "float2" -0.036117099 -0.020154513 ;
	setAttr ".uvtk[523]" -type "float2" -0.035224758 -0.018537246 ;
	setAttr ".uvtk[524]" -type "float2" -0.035237335 -0.018443771 ;
	setAttr ".uvtk[525]" -type "float2" -0.036418222 -0.021345221 ;
	setAttr ".uvtk[526]" -type "float2" -0.032890525 -0.018456157 ;
	setAttr ".uvtk[527]" -type "float2" -0.032948162 -0.01807683 ;
	setAttr ".uvtk[528]" -type "float2" -0.025178455 -0.05620192 ;
	setAttr ".uvtk[529]" -type "float2" -0.023744546 -0.057276685 ;
	setAttr ".uvtk[530]" -type "float2" -0.023738585 -0.05720355 ;
	setAttr ".uvtk[531]" -type "float2" -0.025303625 -0.054617018 ;
	setAttr ".uvtk[532]" -type "float2" -0.035319649 -0.037209891 ;
	setAttr ".uvtk[533]" -type "float2" -0.035590492 -0.037196614 ;
	setAttr ".uvtk[534]" -type "float2" -0.024261855 -0.018465124 ;
	setAttr ".uvtk[535]" -type "float2" -0.023385726 -0.016981401 ;
	setAttr ".uvtk[536]" -type "float2" -0.023388945 -0.057944138 ;
	setAttr ".uvtk[537]" -type "float2" -0.024266265 -0.057633448 ;
	setAttr ".uvtk[538]" -type "float2" 0.0087774806 -0.058689851 ;
	setAttr ".uvtk[539]" -type "float2" 0.010672312 -0.059122682 ;
	setAttr ".uvtk[540]" -type "float2" -0.023425721 -0.052286908 ;
	setAttr ".uvtk[541]" -type "float2" -0.023802184 -0.053650901 ;
	setAttr ".uvtk[542]" -type "float2" -0.022758864 -0.017412037 ;
	setAttr ".uvtk[543]" -type "float2" -0.024405085 -0.020133384 ;
	setAttr ".uvtk[544]" -type "float2" -0.022745155 -0.017480403 ;
	setAttr ".uvtk[545]" -type "float2" -0.022485934 -0.016756855 ;
	setAttr ".uvtk[546]" -type "float2" -0.01958915 -0.019637831 ;
	setAttr ".uvtk[547]" -type "float2" -0.019133354 -0.020997457 ;
	setAttr ".uvtk[548]" -type "float2" 0.012078268 -0.013688721 ;
	setAttr ".uvtk[549]" -type "float2" 0.010021251 -0.013935111 ;
	setAttr ".uvtk[550]" -type "float2" 0.0097093992 -0.058692429 ;
	setAttr ".uvtk[551]" -type "float2" 0.0097157173 -0.055364132 ;
	setAttr ".uvtk[552]" -type "float2" 0.01104806 -0.055866569 ;
	setAttr ".uvtk[553]" -type "float2" -0.0018047839 -0.036581717 ;
	setAttr ".uvtk[554]" -type "float2" -0.0034158379 -0.035796784 ;
	setAttr ".uvtk[555]" -type "float2" 0.011086922 -0.013833366 ;
	setAttr ".uvtk[556]" -type "float2" 0.012244863 -0.016186014 ;
	setAttr ".uvtk[557]" -type "float2" 0.010923665 -0.016583234 ;
	setAttr ".uvtk[558]" -type "float2" 0.0092173629 -0.055427819 ;
	setAttr ".uvtk[559]" -type "float2" -0.023853801 -0.052234143 ;
	setAttr ".uvtk[560]" -type "float2" 0.00060294569 -0.012051128 ;
	setAttr ".uvtk[561]" -type "float2" 0.00090418756 -0.01000962 ;
	setAttr ".uvtk[562]" -type "float2" 0.010238569 -0.016318358 ;
	setAttr ".uvtk[563]" -type "float2" -0.01945051 -0.021184303 ;
	setAttr ".uvtk[564]" -type "float2" -0.024841331 -0.054031223 ;
	setAttr ".uvtk[565]" -type "float2" -0.025109313 -0.056214929 ;
	setAttr ".uvtk[566]" -type "float2" -0.023767315 -0.053725585 ;
	setAttr ".uvtk[567]" -type "float2" -0.035103343 -0.00064277463 ;
	setAttr ".uvtk[568]" -type "float2" -0.034633122 -0.0029677413 ;
	setAttr ".uvtk[569]" -type "float2" -0.020526076 -0.01920408 ;
	setAttr ".uvtk[570]" -type "float2" -0.019567693 -0.019550651 ;
	setAttr ".uvtk[571]" -type "float2" -0.020833695 -0.016942039 ;
	setAttr ".uvtk[572]" -type "float2" -0.037310623 -0.057800472 ;
	setAttr ".uvtk[573]" -type "float2" -0.037057661 -0.055743411 ;
	setAttr ".uvtk[574]" -type "float2" -0.038009249 -0.058924109 ;
	setAttr ".uvtk[575]" -type "float2" -0.037872337 0.0047245789 ;
	setAttr ".uvtk[576]" -type "float2" -0.037743531 0.0052387584 ;
	setAttr ".uvtk[577]" -type "float2" -0.032993879 -0.016085472 ;
	setAttr ".uvtk[578]" -type "float2" -0.03320422 -0.017188653 ;
	setAttr ".uvtk[579]" -type "float2" -0.037582241 -0.056841105 ;
	setAttr ".uvtk[580]" -type "float2" -0.21669072 -0.058499813 ;
	setAttr ".uvtk[581]" -type "float2" -0.033710204 -0.014856461 ;
	setAttr ".uvtk[582]" -type "float2" -0.032982912 -0.018160522 ;
	setAttr ".uvtk[583]" -type "float2" -0.21563202 -0.022647038 ;
	setAttr ".uvtk[584]" -type "float2" -0.20470613 -0.0047043245 ;
	setAttr ".uvtk[585]" -type "float2" -0.20258781 -0.0037443172 ;
	setAttr ".uvtk[586]" -type "float2" -0.21773374 -0.022909548 ;
	setAttr ".uvtk[587]" -type "float2" -0.21880531 -0.058318108 ;
	setAttr ".uvtk[588]" -type "float2" -0.28483057 -0.051129475 ;
	setAttr ".uvtk[589]" -type "float2" -0.28682995 -0.050856888 ;
	setAttr ".uvtk[590]" -type "float2" -0.28591609 -0.031395219 ;
	setAttr ".uvtk[591]" -type "float2" -0.28394309 -0.031085566 ;
	setAttr ".uvtk[592]" -type "float2" -0.28868893 -0.051089883 ;
	setAttr ".uvtk[593]" -type "float2" -0.29207948 -0.058480371 ;
	setAttr ".uvtk[594]" -type "float2" -0.26507238 -0.031773821 ;
	setAttr ".uvtk[595]" -type "float2" -0.26197943 -0.032071635 ;
	setAttr ".uvtk[596]" -type "float2" -0.28566095 -0.030940175 ;
	setAttr ".uvtk[597]" -type "float2" -0.28654763 -0.051307499 ;
	setAttr ".uvtk[598]" -type "float2" -0.29642239 -0.052239895 ;
	setAttr ".uvtk[599]" -type "float2" -0.29815832 -0.05236131 ;
	setAttr ".uvtk[600]" -type "float2" -0.28781027 -0.031153567 ;
	setAttr ".uvtk[601]" -type "float2" -0.29197961 -0.022909902 ;
	setAttr ".uvtk[602]" -type "float2" -0.29742724 -0.029827349 ;
	setAttr ".uvtk[603]" -type "float2" -0.29569635 -0.029968046 ;
	setAttr ".uvtk[604]" -type "float2" -0.036476396 -0.056424472 ;
	setAttr ".uvtk[605]" -type "float2" -0.036906384 -0.056028977 ;
	setAttr ".uvtk[606]" -type "float2" -0.040122535 -0.037752338 ;
	setAttr ".uvtk[607]" -type "float2" -0.040089037 -0.037681378 ;
	setAttr ".uvtk[608]" -type "float2" -0.035861753 -0.023468129 ;
	setAttr ".uvtk[609]" -type "float2" -0.037082516 -0.051853225 ;
	setAttr ".uvtk[610]" -type "float2" -0.026574634 -0.052115396 ;
	setAttr ".uvtk[611]" -type "float2" -0.024385057 -0.056558941 ;
	setAttr ".uvtk[612]" -type "float2" -0.034917377 -0.018980257 ;
	setAttr ".uvtk[613]" -type "float2" -0.032873597 -0.017759621 ;
	setAttr ".uvtk[614]" -type "float2" -0.023229741 -0.0182871 ;
	setAttr ".uvtk[615]" -type "float2" -0.02563896 -0.022814579 ;
	setAttr ".uvtk[616]" -type "float2" -0.020231033 -0.018225223 ;
	setAttr ".uvtk[617]" -type "float2" -0.03495159 -0.037187554 ;
	setAttr ".uvtk[618]" -type "float2" -0.034936868 -0.037128337 ;
	setAttr ".uvtk[619]" -type "float2" -0.024293922 -0.055180565 ;
	setAttr ".uvtk[620]" -type "float2" -0.03435602 0.0035502482 ;
	setAttr ".uvtk[621]" -type "float2" -0.034387074 0.0013000537 ;
	setAttr ".uvtk[622]" -type "float2" -0.02252885 -0.013704948 ;
	setAttr ".uvtk[623]" -type "float2" -0.026695333 -0.059567004 ;
	setAttr ".uvtk[624]" -type "float2" -0.037800632 -0.061089188 ;
	setAttr ".uvtk[625]" -type "float2" -0.033583067 -0.012446593 ;
	setAttr ".uvtk[626]" -type "float2" -0.038591288 0.0051193405 ;
	setAttr ".uvtk[627]" -type "float2" -0.038830839 0.0052117277 ;
	setAttr ".uvtk[628]" -type "float2" -0.27734202 -0.030980654 ;
	setAttr ".uvtk[629]" -type "float2" -0.27635166 -0.030904017 ;
	setAttr ".uvtk[630]" -type "float2" -0.29629055 -0.029919468 ;
	setAttr ".uvtk[631]" -type "float2" -0.29695308 -0.052264869 ;
	setAttr ".uvtk[632]" -type "float2" -0.29859546 -0.054552335 ;
	setAttr ".uvtk[633]" -type "float2" -0.29993376 -0.05616558 ;
	setAttr ".uvtk[634]" -type "float2" -0.28581873 -0.040018152 ;
	setAttr ".uvtk[635]" -type "float2" -0.28592891 -0.03999659 ;
	setAttr ".uvtk[636]" -type "float2" -0.2983335 -0.027080014 ;
	setAttr ".uvtk[637]" -type "float2" -0.29834059 -0.02674894 ;
	setAttr ".uvtk[638]" -type "float2" -0.29854703 -0.054846559 ;
	setAttr ".uvtk[639]" -type "float2" -0.2915239 -0.05764145 ;
	setAttr ".uvtk[640]" -type "float2" -0.2997216 -0.025447518 ;
	setAttr ".uvtk[641]" -type "float2" -0.29145172 -0.023765154 ;
	setAttr ".uvtk[642]" -type "float2" -0.27526376 -0.040585268 ;
	setAttr ".uvtk[643]" -type "float2" -0.2779198 -0.040438987 ;
	setAttr ".uvtk[644]" -type "float2" -0.27793175 -0.040679488 ;
	setAttr ".uvtk[645]" -type "float2" -0.2861214 -0.041322857 ;
	setAttr ".uvtk[646]" -type "float2" -0.28622931 -0.041361734 ;
	setAttr ".uvtk[647]" -type "float2" -0.27802202 -0.05091244 ;
	setAttr ".uvtk[648]" -type "float2" -0.27701813 -0.051033482 ;
	setAttr ".uvtk[649]" -type "float2" -0.26607856 -0.050191313 ;
	setAttr ".uvtk[650]" -type "float2" -0.2629995 -0.049920708 ;
	setAttr ".uvtk[651]" -type "float2" -0.20599312 -0.076193035 ;
	setAttr ".uvtk[652]" -type "float2" -0.20382822 -0.077148587 ;
	setAttr ".uvtk[653]" -type "float2" -0.042671926 -0.078567147 ;
	setAttr ".uvtk[654]" -type "float2" -0.042670019 -0.079226732 ;
	setAttr ".uvtk[655]" -type "float2" -0.043637834 -0.079235047 ;
	setAttr ".uvtk[656]" -type "float2" -0.044037364 -0.079542875 ;
	setAttr ".uvtk[657]" -type "float2" -0.039373897 -0.07433486 ;
	setAttr ".uvtk[658]" -type "float2" -0.039314412 -0.072003394 ;
	setAttr ".uvtk[659]" -type "float2" -0.039979242 -0.069932193 ;
	setAttr ".uvtk[660]" -type "float2" -0.039405771 -0.06726405 ;
	setAttr ".uvtk[661]" -type "float2" -0.0021217614 -0.060580641 ;
	setAttr ".uvtk[662]" -type "float2" -0.001320377 -0.062177226 ;
	setAttr ".uvtk[663]" -type "float2" -0.0022158772 -0.034885429 ;
	setAttr ".uvtk[664]" -type "float2" 0.0059964359 -0.012651559 ;
	setAttr ".uvtk[665]" -type "float2" 0.0060168691 -0.015404694 ;
	setAttr ".uvtk[666]" -type "float2" -0.011021324 -0.0032212101 ;
	setAttr ".uvtk[667]" -type "float2" -0.01220826 0.003404621 ;
	setAttr ".uvtk[668]" -type "float2" 0.0047607049 -0.0075779185 ;
	setAttr ".uvtk[669]" -type "float2" 0.0046374425 -0.0062645306 ;
	setAttr ".uvtk[670]" -type "float2" -0.012326277 0.0041809715 ;
	setAttr ".uvtk[671]" -type "float2" 0.00030876882 0.012791596 ;
	setAttr ".uvtk[672]" -type "float2" 1.7007813e-05 0.013761126 ;
	setAttr ".uvtk[673]" -type "float2" -0.0006688647 0.024769869 ;
	setAttr ".uvtk[674]" -type "float2" -0.00075791031 0.023879673 ;
	setAttr ".uvtk[675]" -type "float2" -0.001046814 0.036833428 ;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 7 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 7 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	addAttr -ci true -h true -sn "dss" -ln "defaultSurfaceShader" -dt "string";
	setAttr ".ren" -type "string" "arnold";
	setAttr ".dss" -type "string" "lambert1";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "groupId1.id" "pCubeShape1.iog.og[1].gid";
connectAttr ":initialShadingGroup.mwc" "pCubeShape1.iog.og[1].gco";
connectAttr "groupParts1.og" "pCubeShape1.i";
connectAttr "polyTweakUV23.uvtk[0]" "pCubeShape1.uvst[0].uvtw";
connectAttr "groupId2.id" "pCubeShape1.ciog.cog[0].cgid";
connectAttr "groupId3.id" "pCylinderShape1.iog.og[1].gid";
connectAttr ":initialShadingGroup.mwc" "pCylinderShape1.iog.og[1].gco";
connectAttr "groupParts2.og" "pCylinderShape1.i";
connectAttr "polyTweakUV24.uvtk[0]" "pCylinderShape1.uvst[0].uvtw";
connectAttr "groupId4.id" "pCylinderShape1.ciog.cog[0].cgid";
connectAttr "groupId5.id" "pCubeShape2.iog.og[1].gid";
connectAttr ":initialShadingGroup.mwc" "pCubeShape2.iog.og[1].gco";
connectAttr "groupParts3.og" "pCubeShape2.i";
connectAttr "polyTweakUV27.uvtk[0]" "pCubeShape2.uvst[0].uvtw";
connectAttr "groupId6.id" "pCubeShape2.ciog.cog[0].cgid";
connectAttr "polyTweakUV28.out" "LockShape.i";
connectAttr "groupId7.id" "LockShape.iog.og[0].gid";
connectAttr ":initialShadingGroup.mwc" "LockShape.iog.og[0].gco";
connectAttr "polyTweakUV28.uvtk[0]" "LockShape.uvst[0].uvtw";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "polyCube1.out" "polyBevel1.ip";
connectAttr "pCubeShape1.wm" "polyBevel1.mp";
connectAttr "polyBevel1.out" "polyBevel2.ip";
connectAttr "pCubeShape1.wm" "polyBevel2.mp";
connectAttr "polyBevel2.out" "polyBevel3.ip";
connectAttr "pCubeShape1.wm" "polyBevel3.mp";
connectAttr "polyBevel3.out" "polyTweak1.ip";
connectAttr "polyTweak1.out" "polySplit1.ip";
connectAttr "polySplit1.out" "polySplit2.ip";
connectAttr "polySplit2.out" "polySplit3.ip";
connectAttr "polySplit3.out" "polySplit4.ip";
connectAttr "polySplit4.out" "polySplit5.ip";
connectAttr "polyTweak2.out" "polySplit6.ip";
connectAttr "polySplit5.out" "polyTweak2.ip";
connectAttr "polySplit6.out" "polySplit7.ip";
connectAttr "polySplit7.out" "polySplit8.ip";
connectAttr "polyTweak3.out" "polyBevel4.ip";
connectAttr "pCubeShape1.wm" "polyBevel4.mp";
connectAttr "polySplit8.out" "polyTweak3.ip";
connectAttr "polyBevel4.out" "polyTweakUV1.ip";
connectAttr "polyTweak4.out" "polyMergeVert1.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert1.mp";
connectAttr "polyTweakUV1.out" "polyTweak4.ip";
connectAttr "polyMergeVert1.out" "polyTweakUV2.ip";
connectAttr "polyTweak5.out" "polyMergeVert2.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert2.mp";
connectAttr "polyTweakUV2.out" "polyTweak5.ip";
connectAttr "polyMergeVert2.out" "polyTweakUV3.ip";
connectAttr "polyTweak6.out" "polyMergeVert3.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert3.mp";
connectAttr "polyTweakUV3.out" "polyTweak6.ip";
connectAttr "polyMergeVert3.out" "polyTweakUV4.ip";
connectAttr "polyTweak7.out" "polyMergeVert4.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert4.mp";
connectAttr "polyTweakUV4.out" "polyTweak7.ip";
connectAttr "polyMergeVert4.out" "polyTweakUV5.ip";
connectAttr "polyTweak8.out" "polyMergeVert5.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert5.mp";
connectAttr "polyTweakUV5.out" "polyTweak8.ip";
connectAttr "polyMergeVert5.out" "polyTweakUV6.ip";
connectAttr "polyTweak9.out" "polyMergeVert6.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert6.mp";
connectAttr "polyTweakUV6.out" "polyTweak9.ip";
connectAttr "polyMergeVert6.out" "polyTweakUV7.ip";
connectAttr "polyTweak10.out" "polyMergeVert7.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert7.mp";
connectAttr "polyTweakUV7.out" "polyTweak10.ip";
connectAttr "polyMergeVert7.out" "polyTweakUV8.ip";
connectAttr "polyTweak11.out" "polyMergeVert8.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert8.mp";
connectAttr "polyTweakUV8.out" "polyTweak11.ip";
connectAttr "polyMergeVert8.out" "polyTweakUV9.ip";
connectAttr "polyTweak12.out" "polyMergeVert9.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert9.mp";
connectAttr "polyTweakUV9.out" "polyTweak12.ip";
connectAttr "polyMergeVert9.out" "polyTweakUV10.ip";
connectAttr "polyTweak13.out" "polyMergeVert10.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert10.mp";
connectAttr "polyTweakUV10.out" "polyTweak13.ip";
connectAttr "polyMergeVert10.out" "polyTweakUV11.ip";
connectAttr "polyTweak14.out" "polyMergeVert11.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert11.mp";
connectAttr "polyTweakUV11.out" "polyTweak14.ip";
connectAttr "polyMergeVert11.out" "polyTweakUV12.ip";
connectAttr "polyTweak15.out" "polyMergeVert12.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert12.mp";
connectAttr "polyTweakUV12.out" "polyTweak15.ip";
connectAttr "polyMergeVert12.out" "polyTweakUV13.ip";
connectAttr "polyTweak16.out" "polyMergeVert13.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert13.mp";
connectAttr "polyTweakUV13.out" "polyTweak16.ip";
connectAttr "polyMergeVert13.out" "polyTweakUV14.ip";
connectAttr "polyTweak17.out" "polyMergeVert14.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert14.mp";
connectAttr "polyTweakUV14.out" "polyTweak17.ip";
connectAttr "polyMergeVert14.out" "polyTweakUV15.ip";
connectAttr "polyTweak18.out" "polyMergeVert15.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert15.mp";
connectAttr "polyTweakUV15.out" "polyTweak18.ip";
connectAttr "polyMergeVert15.out" "polyTweakUV16.ip";
connectAttr "polyTweak19.out" "polyMergeVert16.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert16.mp";
connectAttr "polyTweakUV16.out" "polyTweak19.ip";
connectAttr "polyMergeVert16.out" "polyTweakUV17.ip";
connectAttr "polyTweak20.out" "polyMergeVert17.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert17.mp";
connectAttr "polyTweakUV17.out" "polyTweak20.ip";
connectAttr "polyMergeVert17.out" "polyTweakUV18.ip";
connectAttr "polyTweak21.out" "polyMergeVert18.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert18.mp";
connectAttr "polyTweakUV18.out" "polyTweak21.ip";
connectAttr "polyMergeVert18.out" "polyTweakUV19.ip";
connectAttr "polyTweak22.out" "polyMergeVert19.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert19.mp";
connectAttr "polyTweakUV19.out" "polyTweak22.ip";
connectAttr "polyMergeVert19.out" "polyTweakUV20.ip";
connectAttr "polyTweak23.out" "polyMergeVert20.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert20.mp";
connectAttr "polyTweakUV20.out" "polyTweak23.ip";
connectAttr "polyMergeVert20.out" "polyExtrudeFace1.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace1.mp";
connectAttr "polyTweak24.out" "polyExtrudeFace2.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace2.mp";
connectAttr "polyExtrudeFace1.out" "polyTweak24.ip";
connectAttr "polyExtrudeFace2.out" "polyBevel5.ip";
connectAttr "pCubeShape1.wm" "polyBevel5.mp";
connectAttr "polyTweak25.out" "polySplit9.ip";
connectAttr "polyBevel5.out" "polyTweak25.ip";
connectAttr "polySplit9.out" "polyBevel6.ip";
connectAttr "pCubeShape1.wm" "polyBevel6.mp";
connectAttr "polyBevel6.out" "polyExtrudeFace3.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace3.mp";
connectAttr "polyTweak26.out" "polyExtrudeFace4.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace4.mp";
connectAttr "polyExtrudeFace3.out" "polyTweak26.ip";
connectAttr "polyTweak27.out" "polyExtrudeFace5.ip";
connectAttr "pCylinderShape1.wm" "polyExtrudeFace5.mp";
connectAttr "polyCylinder1.out" "polyTweak27.ip";
connectAttr "polyTweak28.out" "polyBevel7.ip";
connectAttr "pCylinderShape1.wm" "polyBevel7.mp";
connectAttr "polyExtrudeFace5.out" "polyTweak28.ip";
connectAttr "polyTweak29.out" "polyExtrudeFace6.ip";
connectAttr "pCubeShape2.wm" "polyExtrudeFace6.mp";
connectAttr "polyCube2.out" "polyTweak29.ip";
connectAttr "polyTweak30.out" "polyBevel8.ip";
connectAttr "pCubeShape2.wm" "polyBevel8.mp";
connectAttr "polyExtrudeFace6.out" "polyTweak30.ip";
connectAttr "polyBevel8.out" "polySplit10.ip";
connectAttr "polySplit10.out" "polySplit11.ip";
connectAttr "polySplit11.out" "polyBevel9.ip";
connectAttr "pCubeShape2.wm" "polyBevel9.mp";
connectAttr "polyTweak31.out" "polyCut1.ip";
connectAttr "pCubeShape1.wm" "polyCut1.mp";
connectAttr "polyExtrudeFace4.out" "polyTweak31.ip";
connectAttr "polyCut1.out" "polyTweak32.ip";
connectAttr "polyTweak32.out" "deleteComponent1.ig";
connectAttr "deleteComponent1.og" "deleteComponent2.ig";
connectAttr "deleteComponent2.og" "polyPlanarProj1.ip";
connectAttr "pCubeShape1.wm" "polyPlanarProj1.mp";
connectAttr "polyPlanarProj1.out" "polyTweakUV21.ip";
connectAttr "polyTweakUV21.out" "polyTweakUV22.ip";
connectAttr "polyTweakUV22.out" "polyMapSew1.ip";
connectAttr "polyMapSew1.out" "polyMapCut1.ip";
connectAttr "polyMapCut1.out" "polyTweakUV23.ip";
connectAttr "polyBevel7.out" "polyTweakUV24.ip";
connectAttr "polyBevel9.out" "polyTweakUV25.ip";
connectAttr "polyTweak33.out" "polyMapSew2.ip";
connectAttr "polyTweakUV25.out" "polyTweak33.ip";
connectAttr "polyMapSew2.out" "polySplit12.ip";
connectAttr "polySplit12.out" "polyTweakUV26.ip";
connectAttr "polyTweak34.out" "polyMapSew3.ip";
connectAttr "polyTweakUV26.out" "polyTweak34.ip";
connectAttr "polyMapSew3.out" "polyMapCut2.ip";
connectAttr "polyMapCut2.out" "polyTweakUV27.ip";
connectAttr "pCubeShape1.o" "polyUnite1.ip[0]";
connectAttr "pCylinderShape1.o" "polyUnite1.ip[1]";
connectAttr "pCubeShape2.o" "polyUnite1.ip[2]";
connectAttr "pCubeShape1.wm" "polyUnite1.im[0]";
connectAttr "pCylinderShape1.wm" "polyUnite1.im[1]";
connectAttr "pCubeShape2.wm" "polyUnite1.im[2]";
connectAttr "polyTweakUV23.out" "groupParts1.ig";
connectAttr "groupId1.id" "groupParts1.gi";
connectAttr "polyTweakUV24.out" "groupParts2.ig";
connectAttr "groupId3.id" "groupParts2.gi";
connectAttr "polyTweakUV27.out" "groupParts3.ig";
connectAttr "groupId5.id" "groupParts3.gi";
connectAttr "polyUnite1.out" "groupParts4.ig";
connectAttr "groupId7.id" "groupParts4.gi";
connectAttr "groupParts4.og" "polyMapCut3.ip";
connectAttr "polyMapCut3.out" "polyTweakUV28.ip";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pCubeShape1.iog.og[1]" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape1.ciog.cog[0]" ":initialShadingGroup.dsm" -na;
connectAttr "pCylinderShape1.iog.og[1]" ":initialShadingGroup.dsm" -na;
connectAttr "pCylinderShape1.ciog.cog[0]" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape2.iog.og[1]" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape2.ciog.cog[0]" ":initialShadingGroup.dsm" -na;
connectAttr "LockShape.iog.og[0]" ":initialShadingGroup.dsm" -na;
connectAttr "groupId1.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId2.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId3.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId4.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId5.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId6.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId7.msg" ":initialShadingGroup.gn" -na;
// End of Door_Lock.ma
