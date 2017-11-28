// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33721,y:32534,varname:node_4013,prsc:2|emission-3660-OUT,alpha-8726-OUT;n:type:ShaderForge.SFN_TexCoord,id:6406,x:30829,y:32195,varname:node_6406,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:2416,x:30908,y:32512,varname:node_2416,prsc:2;n:type:ShaderForge.SFN_Panner,id:2083,x:31253,y:32553,cmnt:Pan large wind texture,varname:node_2083,prsc:2,spu:-1,spv:0|UVIN-5558-OUT,DIST-4111-OUT;n:type:ShaderForge.SFN_Slider,id:3702,x:30751,y:32655,ptovrint:False,ptlb:Large_WindSpeed,ptin:_Large_WindSpeed,varname:node_3702,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4,max:3.2;n:type:ShaderForge.SFN_Multiply,id:4111,x:31096,y:32618,varname:node_4111,prsc:2|A-2416-T,B-3702-OUT;n:type:ShaderForge.SFN_Time,id:6029,x:31052,y:31672,varname:node_6029,prsc:2;n:type:ShaderForge.SFN_Panner,id:3933,x:31401,y:31698,varname:node_3933,prsc:2,spu:-1,spv:0|UVIN-611-OUT,DIST-1502-OUT;n:type:ShaderForge.SFN_Slider,id:5906,x:30719,y:31856,ptovrint:False,ptlb:Small_WindSpeed,ptin:_Small_WindSpeed,varname:_ArrowSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4,max:3.2;n:type:ShaderForge.SFN_Multiply,id:1502,x:31230,y:31708,varname:node_1502,prsc:2|A-6029-TDB,B-9831-OUT;n:type:ShaderForge.SFN_TexCoord,id:6585,x:31052,y:31396,varname:node_6585,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:611,x:31230,y:31575,cmnt: Smaller cloud tile,varname:node_611,prsc:2|A-6585-UVOUT,B-6600-OUT;n:type:ShaderForge.SFN_Tex2d,id:8893,x:31666,y:32412,varname:node_8893,prsc:2,tex:cfa7be8613943c14cbc9b72af5a5a563,ntxv:0,isnm:False|UVIN-2083-UVOUT,TEX-9067-TEX;n:type:ShaderForge.SFN_Tex2d,id:2844,x:31666,y:32549,varname:node_2844,prsc:2,tex:3dfaa696d1cffae4191e00e891600f31,ntxv:0,isnm:False|UVIN-2083-UVOUT,TEX-7805-TEX;n:type:ShaderForge.SFN_Multiply,id:2149,x:31849,y:32714,varname:node_2149,prsc:2|A-2844-RGB,B-2805-RGB;n:type:ShaderForge.SFN_Multiply,id:8538,x:31852,y:32412,varname:node_8538,prsc:2|A-8893-R,B-4646-RGB;n:type:ShaderForge.SFN_Color,id:2805,x:31666,y:32704,ptovrint:False,ptlb:Large_FillColor,ptin:_Large_FillColor,varname:node_2805,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.5,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:4646,x:31666,y:32262,ptovrint:False,ptlb:Large_OutlineColor,ptin:_Large_OutlineColor,varname:node_4646,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:1102,x:32052,y:32661,cmnt:Front wind alpha layer,varname:node_1102,prsc:2|A-8893-A,B-2844-A,T-2844-A;n:type:ShaderForge.SFN_Lerp,id:3229,x:32052,y:32531,cmnt:Front wind diffuse layer,varname:node_3229,prsc:2|A-8538-OUT,B-2149-OUT,T-2844-A;n:type:ShaderForge.SFN_Tex2dAsset,id:7805,x:31371,y:32244,ptovrint:False,ptlb:texSpeedBoost_Fill,ptin:_texSpeedBoost_Fill,varname:node_7805,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3dfaa696d1cffae4191e00e891600f31,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:9067,x:31371,y:32047,ptovrint:False,ptlb:texSpeedBoost_Outline,ptin:_texSpeedBoost_Outline,varname:node_9067,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:cfa7be8613943c14cbc9b72af5a5a563,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:9745,x:31845,y:32027,varname:node_9745,prsc:2|A-4885-RGB,B-1269-RGB;n:type:ShaderForge.SFN_Multiply,id:1413,x:31843,y:31696,varname:node_1413,prsc:2|A-7932-RGB,B-1099-RGB;n:type:ShaderForge.SFN_Color,id:1269,x:31666,y:32048,ptovrint:False,ptlb:Small_FillColor,ptin:_Small_FillColor,varname:_FillColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.5,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:1099,x:31666,y:31619,ptovrint:False,ptlb:Small_OutlineColor,ptin:_Small_OutlineColor,varname:_OutlineColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:9179,x:32025,y:31902,cmnt:Back wind alpha layer,varname:node_9179,prsc:2|A-7932-A,B-4885-A,T-4885-A;n:type:ShaderForge.SFN_Lerp,id:2519,x:32025,y:31743,cmnt:Back wind diffuse layer,varname:node_2519,prsc:2|A-1413-OUT,B-9745-OUT,T-4885-A;n:type:ShaderForge.SFN_Lerp,id:2037,x:32367,y:32184,cmnt:DIffuse lerp 1,varname:node_2037,prsc:2|A-2519-OUT,B-3229-OUT,T-1102-OUT;n:type:ShaderForge.SFN_Lerp,id:7269,x:32367,y:32656,cmnt:Alpha lerp 1,varname:node_7269,prsc:2|A-2163-OUT,B-1102-OUT,T-1102-OUT;n:type:ShaderForge.SFN_Tex2d,id:7932,x:31666,y:31767,varname:node_7932,prsc:2,tex:cfa7be8613943c14cbc9b72af5a5a563,ntxv:0,isnm:False|UVIN-3933-UVOUT,TEX-9067-TEX;n:type:ShaderForge.SFN_Tex2d,id:4885,x:31666,y:31895,varname:node_4885,prsc:2,tex:3dfaa696d1cffae4191e00e891600f31,ntxv:0,isnm:False|UVIN-3933-UVOUT,TEX-7805-TEX;n:type:ShaderForge.SFN_Slider,id:4069,x:31868,y:32176,ptovrint:False,ptlb:windSmall_Opacity,ptin:_windSmall_Opacity,varname:node_4069,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:2163,x:32367,y:32513,varname:node_2163,prsc:2|A-9179-OUT,B-4069-OUT;n:type:ShaderForge.SFN_Color,id:7095,x:32367,y:32347,ptovrint:False,ptlb:Background_Colour,ptin:_Background_Colour,varname:node_7095,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:2893,x:32611,y:32186,cmnt:Diffuse 1 Color,varname:node_2893,prsc:2|A-2037-OUT,B-7095-RGB,T-9567-OUT;n:type:ShaderForge.SFN_Slider,id:5380,x:32397,y:33058,ptovrint:False,ptlb:BG_Opacity,ptin:_BG_Opacity,varname:node_5380,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_OneMinus,id:9567,x:32611,y:32347,varname:node_9567,prsc:2|IN-7269-OUT;n:type:ShaderForge.SFN_Vector1,id:6353,x:30876,y:31494,varname:node_6353,prsc:2,v1:2.5;n:type:ShaderForge.SFN_Multiply,id:6600,x:31052,y:31537,varname:node_6600,prsc:2|A-6353-OUT,B-3838-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3838,x:30876,y:31597,ptovrint:False,ptlb:Small_WindTile,ptin:_Small_WindTile,varname:node_3838,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Multiply,id:5558,x:31096,y:32430,varname:node_5558,prsc:2|A-6406-UVOUT,B-8003-OUT;n:type:ShaderForge.SFN_Vector1,id:2939,x:30660,y:32403,varname:node_2939,prsc:2,v1:2.5;n:type:ShaderForge.SFN_Multiply,id:8003,x:30829,y:32403,varname:node_8003,prsc:2|A-2939-OUT,B-4143-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4143,x:30660,y:32481,ptovrint:False,ptlb:Large_WindTile,ptin:_Large_WindTile,varname:node_4143,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Divide,id:9831,x:31052,y:31803,varname:node_9831,prsc:2|A-5906-OUT,B-3838-OUT;n:type:ShaderForge.SFN_Lerp,id:8726,x:33025,y:32936,varname:node_8726,prsc:2|A-9212-OUT,B-7269-OUT,T-7269-OUT;n:type:ShaderForge.SFN_Tex2d,id:1451,x:32367,y:32827,ptovrint:False,ptlb:Streak_Texture,ptin:_Streak_Texture,varname:node_1451,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6f0340337b09f274fb5329a76e05efe1,ntxv:0,isnm:False|UVIN-6265-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:6952,x:31739,y:32932,varname:node_6952,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:4946,x:31739,y:33092,varname:node_4946,prsc:2|A-867-OUT,B-2813-OUT;n:type:ShaderForge.SFN_Panner,id:6265,x:32125,y:33071,varname:node_6265,prsc:2,spu:-1,spv:0|UVIN-2990-OUT,DIST-182-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2813,x:31547,y:33186,ptovrint:False,ptlb:StreakTile,ptin:_StreakTile,varname:node_2813,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Vector1,id:867,x:31547,y:33092,varname:node_867,prsc:2,v1:5;n:type:ShaderForge.SFN_Multiply,id:2990,x:31942,y:33071,varname:node_2990,prsc:2|A-6952-UVOUT,B-4946-OUT;n:type:ShaderForge.SFN_Time,id:755,x:31759,y:33240,varname:node_755,prsc:2;n:type:ShaderForge.SFN_Slider,id:7704,x:31602,y:33388,ptovrint:False,ptlb:StreakSpeed,ptin:_StreakSpeed,varname:node_7704,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:5;n:type:ShaderForge.SFN_Multiply,id:182,x:31942,y:33240,varname:node_182,prsc:2|A-755-T,B-7704-OUT;n:type:ShaderForge.SFN_Multiply,id:9212,x:32835,y:33009,varname:node_9212,prsc:2|A-1451-A,B-5380-OUT;n:type:ShaderForge.SFN_Multiply,id:7880,x:32797,y:32422,varname:node_7880,prsc:2|A-1451-RGB,B-9734-RGB;n:type:ShaderForge.SFN_Color,id:9734,x:32611,y:32503,ptovrint:False,ptlb:StreakColor,ptin:_StreakColor,varname:node_9734,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:3660,x:32994,y:32473,varname:node_3660,prsc:2|A-7880-OUT,B-2893-OUT,T-527-OUT;n:type:ShaderForge.SFN_Lerp,id:6426,x:33332,y:32943,varname:node_6426,prsc:2|A-8092-OUT,B-8726-OUT,T-8726-OUT;n:type:ShaderForge.SFN_Slider,id:8092,x:32868,y:32858,ptovrint:False,ptlb:UnusedOpacity,ptin:_UnusedOpacity,varname:node_8092,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:527,x:32722,y:32658,varname:node_527,prsc:2|A-1451-A,B-7269-OUT,T-7269-OUT;proporder:7805-9067-3838-4143-2805-4646-1269-1099-7095-5906-3702-4069-5380-1451-2813-7704-9734-8092;pass:END;sub:END;*/

Shader "Shader Forge/SpeedBoostShader" {
    Properties {
        _texSpeedBoost_Fill ("texSpeedBoost_Fill", 2D) = "white" {}
        _texSpeedBoost_Outline ("texSpeedBoost_Outline", 2D) = "white" {}
        _Small_WindTile ("Small_WindTile", Float ) = 2
        _Large_WindTile ("Large_WindTile", Float ) = 1
        _Large_FillColor ("Large_FillColor", Color) = (0,0.5,1,1)
        _Large_OutlineColor ("Large_OutlineColor", Color) = (1,0,0,1)
        _Small_FillColor ("Small_FillColor", Color) = (0,0.5,1,1)
        _Small_OutlineColor ("Small_OutlineColor", Color) = (1,0,0,1)
        _Background_Colour ("Background_Colour", Color) = (0,1,0,1)
        _Small_WindSpeed ("Small_WindSpeed", Range(0, 3.2)) = 0.4
        _Large_WindSpeed ("Large_WindSpeed", Range(0, 3.2)) = 0.4
        _windSmall_Opacity ("windSmall_Opacity", Range(0, 1)) = 1
        _BG_Opacity ("BG_Opacity", Range(0, 1)) = 1
        _Streak_Texture ("Streak_Texture", 2D) = "white" {}
        _StreakTile ("StreakTile", Float ) = 1
        _StreakSpeed ("StreakSpeed", Range(0, 5)) = 0
        _StreakColor ("StreakColor", Color) = (1,0,1,1)
        _UnusedOpacity ("UnusedOpacity", Range(0, 1)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _Large_WindSpeed;
            uniform float _Small_WindSpeed;
            uniform float4 _Large_FillColor;
            uniform float4 _Large_OutlineColor;
            uniform sampler2D _texSpeedBoost_Fill; uniform float4 _texSpeedBoost_Fill_ST;
            uniform sampler2D _texSpeedBoost_Outline; uniform float4 _texSpeedBoost_Outline_ST;
            uniform float4 _Small_FillColor;
            uniform float4 _Small_OutlineColor;
            uniform float _windSmall_Opacity;
            uniform float4 _Background_Colour;
            uniform float _BG_Opacity;
            uniform float _Small_WindTile;
            uniform float _Large_WindTile;
            uniform sampler2D _Streak_Texture; uniform float4 _Streak_Texture_ST;
            uniform float _StreakTile;
            uniform float _StreakSpeed;
            uniform float4 _StreakColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_755 = _Time;
                float2 node_6265 = ((i.uv0*(5.0*_StreakTile))+(node_755.g*_StreakSpeed)*float2(-1,0));
                float4 _Streak_Texture_var = tex2D(_Streak_Texture,TRANSFORM_TEX(node_6265, _Streak_Texture));
                float3 node_7880 = (_Streak_Texture_var.rgb*_StreakColor.rgb);
                float4 node_6029 = _Time;
                float2 node_3933 = ((i.uv0*(2.5*_Small_WindTile))+(node_6029.b*(_Small_WindSpeed/_Small_WindTile))*float2(-1,0));
                float4 node_7932 = tex2D(_texSpeedBoost_Outline,TRANSFORM_TEX(node_3933, _texSpeedBoost_Outline));
                float4 node_4885 = tex2D(_texSpeedBoost_Fill,TRANSFORM_TEX(node_3933, _texSpeedBoost_Fill));
                float4 node_2416 = _Time;
                float2 node_2083 = ((i.uv0*(2.5*_Large_WindTile))+(node_2416.g*_Large_WindSpeed)*float2(-1,0)); // Pan large wind texture
                float4 node_8893 = tex2D(_texSpeedBoost_Outline,TRANSFORM_TEX(node_2083, _texSpeedBoost_Outline));
                float4 node_2844 = tex2D(_texSpeedBoost_Fill,TRANSFORM_TEX(node_2083, _texSpeedBoost_Fill));
                float node_1102 = lerp(node_8893.a,node_2844.a,node_2844.a); // Front wind alpha layer
                float node_7269 = lerp((lerp(node_7932.a,node_4885.a,node_4885.a)*_windSmall_Opacity),node_1102,node_1102); // Alpha lerp 1
                float node_527 = lerp(_Streak_Texture_var.a,node_7269,node_7269);
                float3 node_3660 = lerp(node_7880,lerp(lerp(lerp((node_7932.rgb*_Small_OutlineColor.rgb),(node_4885.rgb*_Small_FillColor.rgb),node_4885.a),lerp((node_8893.r*_Large_OutlineColor.rgb),(node_2844.rgb*_Large_FillColor.rgb),node_2844.a),node_1102),_Background_Colour.rgb,(1.0 - node_7269)),node_527);
                float3 emissive = node_3660;
                float3 finalColor = emissive;
                float node_8726 = lerp((_Streak_Texture_var.a*_BG_Opacity),node_7269,node_7269);
                fixed4 finalRGBA = fixed4(finalColor,node_8726);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
