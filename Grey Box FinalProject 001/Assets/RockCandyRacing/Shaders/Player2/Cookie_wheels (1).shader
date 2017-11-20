// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|emission-218-OUT,custl-3288-OUT,olwid-4986-OUT;n:type:ShaderForge.SFN_Multiply,id:218,x:32893,y:32466,varname:node_218,prsc:2|A-5212-OUT,B-3479-RGB;n:type:ShaderForge.SFN_AmbientLight,id:3479,x:32707,y:32515,varname:node_3479,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5212,x:32580,y:32415,varname:node_5212,prsc:2|A-3574-RGB,B-8732-RGB;n:type:ShaderForge.SFN_Tex2d,id:3574,x:32320,y:32314,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_4080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8732,x:32320,y:32506,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_1568,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:2183,x:32617,y:32651,varname:node_2183,prsc:2|A-5212-OUT,B-4205-OUT;n:type:ShaderForge.SFN_Multiply,id:3288,x:32909,y:32931,varname:node_3288,prsc:2|A-5245-OUT,B-6198-RGB,C-8307-OUT;n:type:ShaderForge.SFN_Add,id:5245,x:32710,y:32838,varname:node_5245,prsc:2|A-2183-OUT,B-641-OUT;n:type:ShaderForge.SFN_LightColor,id:6198,x:32710,y:32974,varname:node_6198,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:8307,x:32710,y:33113,varname:node_8307,prsc:2;n:type:ShaderForge.SFN_Multiply,id:641,x:32524,y:33059,varname:node_641,prsc:2|A-4205-OUT,B-1242-OUT;n:type:ShaderForge.SFN_Posterize,id:2490,x:32120,y:33058,varname:node_2490,prsc:2|IN-4219-OUT,STPS-75-OUT;n:type:ShaderForge.SFN_Power,id:1242,x:32315,y:33072,varname:node_1242,prsc:2|VAL-2490-OUT,EXP-5682-OUT;n:type:ShaderForge.SFN_Posterize,id:4205,x:32144,y:32747,varname:node_4205,prsc:2|IN-1331-OUT,STPS-596-OUT;n:type:ShaderForge.SFN_Dot,id:4219,x:31932,y:33048,varname:node_4219,prsc:2,dt:1|A-4478-OUT,B-5780-OUT;n:type:ShaderForge.SFN_Vector1,id:75,x:31932,y:33186,varname:node_75,prsc:2,v1:50;n:type:ShaderForge.SFN_NormalVector,id:4478,x:31680,y:32856,prsc:2,pt:False;n:type:ShaderForge.SFN_HalfVector,id:5780,x:31680,y:33072,varname:node_5780,prsc:2;n:type:ShaderForge.SFN_LightVector,id:7752,x:31680,y:32641,varname:node_7752,prsc:2;n:type:ShaderForge.SFN_Exp,id:5682,x:32120,y:33265,varname:node_5682,prsc:2,et:1|IN-15-OUT;n:type:ShaderForge.SFN_Slider,id:1769,x:31620,y:33339,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_5,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_ConstantLerp,id:15,x:31932,y:33265,varname:node_15,prsc:2,a:1,b:11|IN-1769-OUT;n:type:ShaderForge.SFN_Vector1,id:596,x:31959,y:32859,varname:node_596,prsc:2,v1:4;n:type:ShaderForge.SFN_Dot,id:1331,x:31959,y:32705,varname:node_1331,prsc:2,dt:1|A-7752-OUT,B-4478-OUT;n:type:ShaderForge.SFN_Vector1,id:4986,x:32885,y:33198,varname:node_4986,prsc:2,v1:0.05;proporder:3574-8732-1769;pass:END;sub:END;*/

Shader "Shader Forge/Cookie_wheels" {
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
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*0.05,1) );
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
                float3 node_5212 = (_Diffuse_var.rgb*_Colour.rgb);
                float3 emissive = (node_5212*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float node_596 = 4.0;
                float node_4205 = floor(max(0,dot(lightDirection,i.normalDir)) * node_596) / (node_596 - 1);
                float node_75 = 50.0;
                float3 finalColor = emissive + (((node_5212*node_4205)+(node_4205*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_75) / (node_75 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
                float3 node_5212 = (_Diffuse_var.rgb*_Colour.rgb);
                float node_596 = 4.0;
                float node_4205 = floor(max(0,dot(lightDirection,i.normalDir)) * node_596) / (node_596 - 1);
                float node_75 = 50.0;
                float3 finalColor = (((node_5212*node_4205)+(node_4205*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_75) / (node_75 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
