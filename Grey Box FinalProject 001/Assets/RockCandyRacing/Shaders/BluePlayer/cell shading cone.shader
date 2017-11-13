// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|emission-9845-OUT,custl-9358-OUT,olwid-578-OUT;n:type:ShaderForge.SFN_Multiply,id:9845,x:32930,y:32494,varname:node_9845,prsc:2|A-4356-OUT,B-7993-RGB;n:type:ShaderForge.SFN_AmbientLight,id:7993,x:32744,y:32543,varname:node_7993,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4356,x:32617,y:32443,varname:node_4356,prsc:2|A-3634-RGB,B-6656-RGB;n:type:ShaderForge.SFN_Tex2d,id:3634,x:32357,y:32342,ptovrint:False,ptlb:Diffuse_copy,ptin:_Diffuse_copy,varname:_Diffuse_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c84bb6c9bb441f340bcf94cb02c30f5f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:6656,x:32357,y:32534,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_1568,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:1280,x:32654,y:32679,varname:node_1280,prsc:2|A-4356-OUT,B-6511-OUT;n:type:ShaderForge.SFN_Multiply,id:9358,x:32946,y:32959,varname:node_9358,prsc:2|A-8981-OUT,B-5930-RGB,C-3640-OUT;n:type:ShaderForge.SFN_Add,id:8981,x:32747,y:32866,varname:node_8981,prsc:2|A-1280-OUT,B-3191-OUT;n:type:ShaderForge.SFN_LightColor,id:5930,x:32747,y:33002,varname:node_5930,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:3640,x:32747,y:33141,varname:node_3640,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3191,x:32561,y:33087,varname:node_3191,prsc:2|A-6511-OUT,B-4514-OUT;n:type:ShaderForge.SFN_Posterize,id:8190,x:32157,y:33086,varname:node_8190,prsc:2|IN-1860-OUT,STPS-4987-OUT;n:type:ShaderForge.SFN_Power,id:4514,x:32352,y:33100,varname:node_4514,prsc:2|VAL-8190-OUT,EXP-3331-OUT;n:type:ShaderForge.SFN_Posterize,id:6511,x:32181,y:32775,varname:node_6511,prsc:2|IN-6395-OUT,STPS-237-OUT;n:type:ShaderForge.SFN_Dot,id:1860,x:31969,y:33076,varname:node_1860,prsc:2,dt:1|A-8529-OUT,B-8598-OUT;n:type:ShaderForge.SFN_Vector1,id:4987,x:31969,y:33214,varname:node_4987,prsc:2,v1:50;n:type:ShaderForge.SFN_NormalVector,id:8529,x:31717,y:32884,prsc:2,pt:False;n:type:ShaderForge.SFN_HalfVector,id:8598,x:31717,y:33100,varname:node_8598,prsc:2;n:type:ShaderForge.SFN_LightVector,id:3291,x:31717,y:32669,varname:node_3291,prsc:2;n:type:ShaderForge.SFN_Exp,id:3331,x:32157,y:33293,varname:node_3331,prsc:2,et:1|IN-6072-OUT;n:type:ShaderForge.SFN_Slider,id:6540,x:31657,y:33367,ptovrint:False,ptlb:Gloss_copy,ptin:_Gloss_copy,varname:_Gloss_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_ConstantLerp,id:6072,x:31969,y:33293,varname:node_6072,prsc:2,a:1,b:11|IN-6540-OUT;n:type:ShaderForge.SFN_Vector1,id:237,x:31996,y:32887,varname:node_237,prsc:2,v1:4;n:type:ShaderForge.SFN_Dot,id:6395,x:31996,y:32733,varname:node_6395,prsc:2,dt:1|A-3291-OUT,B-8529-OUT;n:type:ShaderForge.SFN_Vector1,id:1371,x:32922,y:33226,varname:node_1371,prsc:2,v1:0.025;n:type:ShaderForge.SFN_Divide,id:578,x:33060,y:33305,varname:node_578,prsc:2|A-1371-OUT,B-3575-OUT;n:type:ShaderForge.SFN_Vector1,id:3575,x:32783,y:33431,varname:node_3575,prsc:2,v1:75;proporder:3634-6656-6540;pass:END;sub:END;*/

Shader "Shader Forge/cell shading cone" {
    Properties {
        _Diffuse_copy ("Diffuse_copy", 2D) = "white" {}
        _Colour ("Colour", Color) = (1,1,1,1)
        _Gloss_copy ("Gloss_copy", Range(0, 1)) = 0.5
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_FOG_COORDS(0)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*(0.025/75.0),1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(float3(0,0,0),0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Diffuse_copy; uniform float4 _Diffuse_copy_ST;
            uniform float4 _Colour;
            uniform float _Gloss_copy;
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float4 _Diffuse_copy_var = tex2D(_Diffuse_copy,TRANSFORM_TEX(i.uv0, _Diffuse_copy));
                float3 node_4356 = (_Diffuse_copy_var.rgb*_Colour.rgb);
                float3 emissive = (node_4356*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float node_237 = 4.0;
                float node_6511 = floor(max(0,dot(lightDirection,i.normalDir)) * node_237) / (node_237 - 1);
                float node_4987 = 50.0;
                float3 finalColor = emissive + (((node_4356*node_6511)+(node_6511*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_4987) / (node_4987 - 1),exp2(lerp(1,11,_Gloss_copy)))))*_LightColor0.rgb*attenuation);
                fixed4 finalRGBA = fixed4(finalColor,1);
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
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Diffuse_copy; uniform float4 _Diffuse_copy_ST;
            uniform float4 _Colour;
            uniform float _Gloss_copy;
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _Diffuse_copy_var = tex2D(_Diffuse_copy,TRANSFORM_TEX(i.uv0, _Diffuse_copy));
                float3 node_4356 = (_Diffuse_copy_var.rgb*_Colour.rgb);
                float node_237 = 4.0;
                float node_6511 = floor(max(0,dot(lightDirection,i.normalDir)) * node_237) / (node_237 - 1);
                float node_4987 = 50.0;
                float3 finalColor = (((node_4356*node_6511)+(node_6511*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_4987) / (node_4987 - 1),exp2(lerp(1,11,_Gloss_copy)))))*_LightColor0.rgb*attenuation);
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
