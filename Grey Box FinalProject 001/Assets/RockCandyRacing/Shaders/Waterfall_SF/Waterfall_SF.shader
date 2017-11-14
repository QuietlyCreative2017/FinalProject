// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:14,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:32719,y:32712,varname:node_4013,prsc:2|diff-9760-OUT,alpha-3439-OUT,refract-4939-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:31961,y:32546,ptovrint:False,ptlb:WaterStreak_Color1,ptin:_WaterStreak_Color1,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:6916,x:32158,y:32444,varname:node_6916,prsc:2|A-2866-A,B-1304-RGB;n:type:ShaderForge.SFN_Tex2d,id:2866,x:31961,y:32354,varname:node_2866,prsc:2,tex:680f914764403184b86e8a49604a0a7e,ntxv:0,isnm:False|UVIN-2144-UVOUT,TEX-2027-TEX;n:type:ShaderForge.SFN_TexCoord,id:79,x:31582,y:32353,varname:node_79,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:2144,x:31753,y:32354,varname:node_2144,prsc:2,spu:0,spv:1|UVIN-79-UVOUT,DIST-7209-OUT;n:type:ShaderForge.SFN_Tex2d,id:6638,x:31961,y:32717,varname:node_6638,prsc:2,tex:976537ccc033cc04aa64790592980fbe,ntxv:0,isnm:False|UVIN-5613-UVOUT,TEX-9820-TEX;n:type:ShaderForge.SFN_TexCoord,id:9102,x:31578,y:32717,varname:node_9102,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:5613,x:31754,y:32717,varname:node_5613,prsc:2,spu:0,spv:1|UVIN-9102-UVOUT,DIST-9176-OUT;n:type:ShaderForge.SFN_Multiply,id:6764,x:32151,y:32830,varname:node_6764,prsc:2|A-6638-A,B-2538-RGB;n:type:ShaderForge.SFN_Color,id:2538,x:31961,y:32925,ptovrint:False,ptlb:WaterStreak_Color2,ptin:_WaterStreak_Color2,varname:node_2538,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Tex2dAsset,id:2027,x:31754,y:32546,ptovrint:False,ptlb:StreakTexture1,ptin:_StreakTexture1,varname:node_2027,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:680f914764403184b86e8a49604a0a7e,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:9820,x:31754,y:32900,ptovrint:False,ptlb:StreakTexture2,ptin:_StreakTexture2,varname:node_9820,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:976537ccc033cc04aa64790592980fbe,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7007,x:32358,y:32490,varname:node_7007,prsc:2|A-6916-OUT,B-6764-OUT,T-6638-A;n:type:ShaderForge.SFN_Time,id:5620,x:31335,y:32801,varname:node_5620,prsc:2;n:type:ShaderForge.SFN_Slider,id:5777,x:31212,y:32936,ptovrint:False,ptlb:StreakSpeed2,ptin:_StreakSpeed2,varname:node_5777,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:9176,x:31560,y:32917,varname:node_9176,prsc:2|A-5620-T,B-5777-OUT;n:type:ShaderForge.SFN_Time,id:9937,x:31357,y:32422,varname:node_9937,prsc:2;n:type:ShaderForge.SFN_Slider,id:1244,x:31234,y:32558,ptovrint:False,ptlb:StreakSpeed1,ptin:_StreakSpeed1,varname:_node_5777_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:7209,x:31582,y:32539,varname:node_7209,prsc:2|A-9937-T,B-1244-OUT;n:type:ShaderForge.SFN_Add,id:9760,x:32531,y:32544,varname:node_9760,prsc:2|A-7007-OUT,B-7132-RGB;n:type:ShaderForge.SFN_Color,id:7132,x:32358,y:32655,ptovrint:False,ptlb:WaterBaseColor,ptin:_WaterBaseColor,varname:node_7132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:3439,x:32326,y:32830,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_3439,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Tex2d,id:4260,x:32132,y:33081,varname:node_4260,prsc:2,tex:ea89a2f026950f44a9515274ae49c092,ntxv:0,isnm:False|UVIN-2911-UVOUT,TEX-2066-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:2066,x:31742,y:33249,ptovrint:False,ptlb:RefractionMap,ptin:_RefractionMap,varname:node_2066,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ea89a2f026950f44a9515274ae49c092,ntxv:2,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:5943,x:31376,y:33079,varname:node_5943,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:2911,x:31754,y:33079,varname:node_2911,prsc:2,spu:0,spv:2|UVIN-1913-OUT;n:type:ShaderForge.SFN_Multiply,id:1913,x:31573,y:33079,varname:node_1913,prsc:2|A-5943-UVOUT,B-1209-OUT;n:type:ShaderForge.SFN_Vector1,id:1209,x:31376,y:33244,varname:node_1209,prsc:2,v1:4;n:type:ShaderForge.SFN_Multiply,id:2757,x:32328,y:33258,varname:node_2757,prsc:2|A-6378-OUT,B-7529-OUT;n:type:ShaderForge.SFN_Slider,id:6378,x:32002,y:33258,ptovrint:False,ptlb:RefractionDistortion,ptin:_RefractionDistortion,varname:node_6378,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Vector1,id:7529,x:32159,y:33332,varname:node_7529,prsc:2,v1:0.2;n:type:ShaderForge.SFN_ComponentMask,id:7951,x:32328,y:33081,varname:node_7951,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-4260-RGB;n:type:ShaderForge.SFN_Multiply,id:4939,x:32536,y:33177,varname:node_4939,prsc:2|A-7951-OUT,B-2757-OUT;proporder:1304-2538-7132-2027-9820-3439-1244-5777-2066-6378;pass:END;sub:END;*/

Shader "Shader Forge/Waterfall_SF" {
    Properties {
        _WaterStreak_Color1 ("WaterStreak_Color1", Color) = (1,0,0,1)
        _WaterStreak_Color2 ("WaterStreak_Color2", Color) = (0,1,0,1)
        _WaterBaseColor ("WaterBaseColor", Color) = (0,0,1,1)
        _StreakTexture1 ("StreakTexture1", 2D) = "white" {}
        _StreakTexture2 ("StreakTexture2", 2D) = "white" {}
        _Opacity ("Opacity", Range(0, 1)) = 1
        _StreakSpeed1 ("StreakSpeed1", Range(0, 1)) = 1
        _StreakSpeed2 ("StreakSpeed2", Range(0, 1)) = 1
        _RefractionMap ("RefractionMap", 2D) = "black" {}
        _RefractionDistortion ("RefractionDistortion", Range(0, 1)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            ColorMask RGB
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _WaterStreak_Color1;
            uniform float4 _WaterStreak_Color2;
            uniform sampler2D _StreakTexture1; uniform float4 _StreakTexture1_ST;
            uniform sampler2D _StreakTexture2; uniform float4 _StreakTexture2_ST;
            uniform float _StreakSpeed2;
            uniform float _StreakSpeed1;
            uniform float4 _WaterBaseColor;
            uniform float _Opacity;
            uniform sampler2D _RefractionMap; uniform float4 _RefractionMap_ST;
            uniform float _RefractionDistortion;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 node_9660 = _Time;
                float2 node_2911 = ((i.uv0*4.0)+node_9660.g*float2(0,2));
                float4 node_4260 = tex2D(_RefractionMap,TRANSFORM_TEX(node_2911, _RefractionMap));
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_4260.rgb.rg*(_RefractionDistortion*0.2));
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 node_9937 = _Time;
                float2 node_2144 = (i.uv0+(node_9937.g*_StreakSpeed1)*float2(0,1));
                float4 node_2866 = tex2D(_StreakTexture1,TRANSFORM_TEX(node_2144, _StreakTexture1));
                float4 node_5620 = _Time;
                float2 node_5613 = (i.uv0+(node_5620.g*_StreakSpeed2)*float2(0,1));
                float4 node_6638 = tex2D(_StreakTexture2,TRANSFORM_TEX(node_5613, _StreakTexture2));
                float3 diffuseColor = (lerp((node_2866.a*_WaterStreak_Color1.rgb),(node_6638.a*_WaterStreak_Color2.rgb),node_6638.a)+_WaterBaseColor.rgb);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,_Opacity),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            ColorMask RGB
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _WaterStreak_Color1;
            uniform float4 _WaterStreak_Color2;
            uniform sampler2D _StreakTexture1; uniform float4 _StreakTexture1_ST;
            uniform sampler2D _StreakTexture2; uniform float4 _StreakTexture2_ST;
            uniform float _StreakSpeed2;
            uniform float _StreakSpeed1;
            uniform float4 _WaterBaseColor;
            uniform float _Opacity;
            uniform sampler2D _RefractionMap; uniform float4 _RefractionMap_ST;
            uniform float _RefractionDistortion;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 node_16 = _Time;
                float2 node_2911 = ((i.uv0*4.0)+node_16.g*float2(0,2));
                float4 node_4260 = tex2D(_RefractionMap,TRANSFORM_TEX(node_2911, _RefractionMap));
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_4260.rgb.rg*(_RefractionDistortion*0.2));
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 node_9937 = _Time;
                float2 node_2144 = (i.uv0+(node_9937.g*_StreakSpeed1)*float2(0,1));
                float4 node_2866 = tex2D(_StreakTexture1,TRANSFORM_TEX(node_2144, _StreakTexture1));
                float4 node_5620 = _Time;
                float2 node_5613 = (i.uv0+(node_5620.g*_StreakSpeed2)*float2(0,1));
                float4 node_6638 = tex2D(_StreakTexture2,TRANSFORM_TEX(node_5613, _StreakTexture2));
                float3 diffuseColor = (lerp((node_2866.a*_WaterStreak_Color1.rgb),(node_6638.a*_WaterStreak_Color2.rgb),node_6638.a)+_WaterBaseColor.rgb);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * _Opacity,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
