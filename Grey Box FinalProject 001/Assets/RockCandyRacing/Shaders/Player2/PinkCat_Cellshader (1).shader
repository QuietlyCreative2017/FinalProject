// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33372,y:32700,varname:node_9361,prsc:2|emission-8780-OUT,custl-6190-OUT,olwid-3337-OUT,olcol-4732-RGB;n:type:ShaderForge.SFN_Multiply,id:8780,x:33015,y:32485,varname:node_8780,prsc:2|A-1726-OUT,B-5598-RGB;n:type:ShaderForge.SFN_AmbientLight,id:5598,x:32829,y:32534,varname:node_5598,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1726,x:32702,y:32434,varname:node_1726,prsc:2|A-6953-RGB,B-7900-RGB;n:type:ShaderForge.SFN_Tex2d,id:6953,x:32442,y:32333,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_4080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f08ce3521e02e7347a7d9d01ed0f6523,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:7900,x:32442,y:32525,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_1568,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:4485,x:32739,y:32670,varname:node_4485,prsc:2|A-1726-OUT,B-6071-OUT;n:type:ShaderForge.SFN_Multiply,id:6190,x:33031,y:32950,varname:node_6190,prsc:2|A-3259-OUT,B-5208-RGB,C-1755-OUT;n:type:ShaderForge.SFN_Add,id:3259,x:32832,y:32857,varname:node_3259,prsc:2|A-4485-OUT,B-2998-OUT;n:type:ShaderForge.SFN_LightColor,id:5208,x:32832,y:32993,varname:node_5208,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:1755,x:32832,y:33132,varname:node_1755,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2998,x:32646,y:33078,varname:node_2998,prsc:2|A-6071-OUT,B-7494-OUT;n:type:ShaderForge.SFN_Posterize,id:7785,x:32242,y:33112,varname:node_7785,prsc:2|IN-6572-OUT,STPS-9638-OUT;n:type:ShaderForge.SFN_Power,id:7494,x:32437,y:33091,varname:node_7494,prsc:2|VAL-7785-OUT,EXP-6475-OUT;n:type:ShaderForge.SFN_Posterize,id:6071,x:32266,y:32766,varname:node_6071,prsc:2|IN-4993-OUT,STPS-2735-OUT;n:type:ShaderForge.SFN_Dot,id:6572,x:32054,y:33067,varname:node_6572,prsc:2,dt:1|A-4164-OUT,B-85-OUT;n:type:ShaderForge.SFN_Vector1,id:9638,x:32054,y:33205,varname:node_9638,prsc:2,v1:50;n:type:ShaderForge.SFN_NormalVector,id:4164,x:31802,y:32875,prsc:2,pt:False;n:type:ShaderForge.SFN_HalfVector,id:85,x:31802,y:33091,varname:node_85,prsc:2;n:type:ShaderForge.SFN_LightVector,id:1083,x:31802,y:32660,varname:node_1083,prsc:2;n:type:ShaderForge.SFN_Exp,id:6475,x:32242,y:33284,varname:node_6475,prsc:2,et:1|IN-6094-OUT;n:type:ShaderForge.SFN_Slider,id:2916,x:31742,y:33358,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_5,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_ConstantLerp,id:6094,x:32054,y:33284,varname:node_6094,prsc:2,a:1,b:11|IN-2916-OUT;n:type:ShaderForge.SFN_Vector1,id:2735,x:32081,y:32878,varname:node_2735,prsc:2,v1:4;n:type:ShaderForge.SFN_Dot,id:4993,x:32081,y:32724,varname:node_4993,prsc:2,dt:1|A-1083-OUT,B-4164-OUT;n:type:ShaderForge.SFN_Vector1,id:3337,x:33007,y:33192,varname:node_3337,prsc:2,v1:0.025;n:type:ShaderForge.SFN_Color,id:4732,x:33007,y:33327,ptovrint:False,ptlb:node_4732,ptin:_node_4732,varname:node_4732,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0.4344826,c4:1;proporder:6953-7900-2916-4732;pass:END;sub:END;*/

Shader "Shader Forge/PinkCat_Cellshader" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Colour ("Colour", Color) = (1,1,1,1)
        _Gloss ("Gloss", Range(0, 1)) = 0.5
        _node_4732 ("node_4732", Color) = (1,0,0.4344826,1)
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
            uniform float4 _node_4732;
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
                return fixed4(_node_4732.rgb,0);
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
                float3 node_1726 = (_Diffuse_var.rgb*_Colour.rgb);
                float3 emissive = (node_1726*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float node_2735 = 4.0;
                float node_6071 = floor(max(0,dot(lightDirection,i.normalDir)) * node_2735) / (node_2735 - 1);
                float node_9638 = 50.0;
                float3 finalColor = emissive + (((node_1726*node_6071)+(node_6071*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_9638) / (node_9638 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
                float3 node_1726 = (_Diffuse_var.rgb*_Colour.rgb);
                float node_2735 = 4.0;
                float node_6071 = floor(max(0,dot(lightDirection,i.normalDir)) * node_2735) / (node_2735 - 1);
                float node_9638 = 50.0;
                float3 finalColor = (((node_1726*node_6071)+(node_6071*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_9638) / (node_9638 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
