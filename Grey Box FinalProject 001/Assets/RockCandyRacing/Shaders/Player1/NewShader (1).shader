// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33282,y:32720,varname:node_9361,prsc:2|emission-9464-OUT,custl-3618-OUT,olwid-7078-OUT;n:type:ShaderForge.SFN_Multiply,id:9464,x:32978,y:32651,varname:node_9464,prsc:2|A-3976-OUT,B-32-RGB;n:type:ShaderForge.SFN_AmbientLight,id:32,x:32792,y:32700,varname:node_32,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3976,x:32665,y:32600,varname:node_3976,prsc:2|A-4080-RGB,B-1568-RGB;n:type:ShaderForge.SFN_Tex2d,id:4080,x:32405,y:32499,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_4080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1fcf6da367903214d87370d3b3cf7095,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:1568,x:32405,y:32691,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_1568,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:3635,x:32702,y:32836,varname:node_3635,prsc:2|A-3976-OUT,B-3644-OUT;n:type:ShaderForge.SFN_Multiply,id:3618,x:32994,y:33116,varname:node_3618,prsc:2|A-6928-OUT,B-3753-RGB,C-1380-OUT;n:type:ShaderForge.SFN_Add,id:6928,x:32795,y:33023,varname:node_6928,prsc:2|A-3635-OUT,B-4191-OUT;n:type:ShaderForge.SFN_LightColor,id:3753,x:32795,y:33159,varname:node_3753,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:1380,x:32795,y:33298,varname:node_1380,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4191,x:32609,y:33244,varname:node_4191,prsc:2|A-3644-OUT,B-7235-OUT;n:type:ShaderForge.SFN_Posterize,id:54,x:32205,y:33243,varname:node_54,prsc:2|IN-147-OUT,STPS-4414-OUT;n:type:ShaderForge.SFN_Power,id:7235,x:32400,y:33257,varname:node_7235,prsc:2|VAL-54-OUT,EXP-2441-OUT;n:type:ShaderForge.SFN_Posterize,id:3644,x:32229,y:32932,varname:node_3644,prsc:2|IN-3731-OUT,STPS-2746-OUT;n:type:ShaderForge.SFN_Dot,id:147,x:32017,y:33233,varname:node_147,prsc:2,dt:1|A-1197-OUT,B-4917-OUT;n:type:ShaderForge.SFN_Vector1,id:4414,x:32017,y:33371,varname:node_4414,prsc:2,v1:50;n:type:ShaderForge.SFN_NormalVector,id:1197,x:31765,y:33041,prsc:2,pt:False;n:type:ShaderForge.SFN_HalfVector,id:4917,x:31765,y:33257,varname:node_4917,prsc:2;n:type:ShaderForge.SFN_LightVector,id:4524,x:31765,y:32826,varname:node_4524,prsc:2;n:type:ShaderForge.SFN_Exp,id:2441,x:32205,y:33450,varname:node_2441,prsc:2,et:1|IN-4600-OUT;n:type:ShaderForge.SFN_Slider,id:5,x:31705,y:33524,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_5,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_ConstantLerp,id:4600,x:32017,y:33450,varname:node_4600,prsc:2,a:1,b:11|IN-5-OUT;n:type:ShaderForge.SFN_Vector1,id:2746,x:32044,y:33044,varname:node_2746,prsc:2,v1:4;n:type:ShaderForge.SFN_Dot,id:3731,x:32044,y:32890,varname:node_3731,prsc:2,dt:1|A-4524-OUT,B-1197-OUT;n:type:ShaderForge.SFN_Vector1,id:7078,x:32970,y:33383,varname:node_7078,prsc:2,v1:0.025;proporder:4080-1568-5;pass:END;sub:END;*/

Shader "Shader Forge/NewShader" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Colour ("Colour", Color) = (1,1,1,1)
        _Gloss ("Gloss", Range(0, 1)) = 0.5
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
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*0.025,1) );
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
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Colour;
            uniform float _Gloss;
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
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float3 node_3976 = (_Diffuse_var.rgb*_Colour.rgb);
                float3 emissive = (node_3976*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float node_2746 = 4.0;
                float node_3644 = floor(max(0,dot(lightDirection,i.normalDir)) * node_2746) / (node_2746 - 1);
                float node_4414 = 50.0;
                float3 finalColor = emissive + (((node_3976*node_3644)+(node_3644*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_4414) / (node_4414 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Colour;
            uniform float _Gloss;
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
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float3 node_3976 = (_Diffuse_var.rgb*_Colour.rgb);
                float node_2746 = 4.0;
                float node_3644 = floor(max(0,dot(lightDirection,i.normalDir)) * node_2746) / (node_2746 - 1);
                float node_4414 = 50.0;
                float3 finalColor = (((node_3976*node_3644)+(node_3644*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_4414) / (node_4414 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
