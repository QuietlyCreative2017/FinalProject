// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|emission-3453-OUT,custl-9203-OUT,olwid-2091-OUT;n:type:ShaderForge.SFN_Multiply,id:3453,x:32957,y:32530,varname:node_3453,prsc:2|A-8145-OUT,B-8645-RGB;n:type:ShaderForge.SFN_AmbientLight,id:8645,x:32771,y:32579,varname:node_8645,prsc:2;n:type:ShaderForge.SFN_Multiply,id:8145,x:32644,y:32479,varname:node_8145,prsc:2|A-8500-RGB,B-7850-RGB;n:type:ShaderForge.SFN_Tex2d,id:8500,x:32384,y:32378,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_4080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7a13a6b9c04b26b49b3912efd1713f3a,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:7850,x:32384,y:32570,ptovrint:False,ptlb:Colour,ptin:_Colour,varname:node_1568,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:8272,x:32681,y:32715,varname:node_8272,prsc:2|A-8145-OUT,B-5712-OUT;n:type:ShaderForge.SFN_Multiply,id:9203,x:32973,y:32995,varname:node_9203,prsc:2|A-4106-OUT,B-5415-RGB,C-3881-OUT;n:type:ShaderForge.SFN_Add,id:4106,x:32774,y:32902,varname:node_4106,prsc:2|A-8272-OUT,B-3859-OUT;n:type:ShaderForge.SFN_LightColor,id:5415,x:32774,y:33038,varname:node_5415,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:3881,x:32774,y:33177,varname:node_3881,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3859,x:32588,y:33123,varname:node_3859,prsc:2|A-5712-OUT,B-8416-OUT;n:type:ShaderForge.SFN_Posterize,id:9003,x:32184,y:33122,varname:node_9003,prsc:2|IN-6152-OUT,STPS-2113-OUT;n:type:ShaderForge.SFN_Power,id:8416,x:32379,y:33136,varname:node_8416,prsc:2|VAL-9003-OUT,EXP-2439-OUT;n:type:ShaderForge.SFN_Posterize,id:5712,x:32208,y:32811,varname:node_5712,prsc:2|IN-2196-OUT,STPS-6965-OUT;n:type:ShaderForge.SFN_Dot,id:6152,x:31996,y:33112,varname:node_6152,prsc:2,dt:1|A-8990-OUT,B-8592-OUT;n:type:ShaderForge.SFN_Vector1,id:2113,x:31996,y:33250,varname:node_2113,prsc:2,v1:50;n:type:ShaderForge.SFN_NormalVector,id:8990,x:31744,y:32920,prsc:2,pt:False;n:type:ShaderForge.SFN_HalfVector,id:8592,x:31744,y:33136,varname:node_8592,prsc:2;n:type:ShaderForge.SFN_LightVector,id:9780,x:31744,y:32705,varname:node_9780,prsc:2;n:type:ShaderForge.SFN_Exp,id:2439,x:32184,y:33329,varname:node_2439,prsc:2,et:1|IN-2703-OUT;n:type:ShaderForge.SFN_Slider,id:795,x:31684,y:33403,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_5,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_ConstantLerp,id:2703,x:31996,y:33329,varname:node_2703,prsc:2,a:1,b:11|IN-795-OUT;n:type:ShaderForge.SFN_Vector1,id:6965,x:32023,y:32923,varname:node_6965,prsc:2,v1:4;n:type:ShaderForge.SFN_Dot,id:2196,x:32023,y:32769,varname:node_2196,prsc:2,dt:1|A-9780-OUT,B-8990-OUT;n:type:ShaderForge.SFN_Vector1,id:2091,x:32921,y:33433,varname:node_2091,prsc:2,v1:0.08;proporder:8500-7850-795;pass:END;sub:END;*/

Shader "Shader Forge/Chocolate_Cookiewheel" {
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
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*0.08,1) );
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
                float3 node_8145 = (_Diffuse_var.rgb*_Colour.rgb);
                float3 emissive = (node_8145*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float node_6965 = 4.0;
                float node_5712 = floor(max(0,dot(lightDirection,i.normalDir)) * node_6965) / (node_6965 - 1);
                float node_2113 = 50.0;
                float3 finalColor = emissive + (((node_8145*node_5712)+(node_5712*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_2113) / (node_2113 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
                float3 node_8145 = (_Diffuse_var.rgb*_Colour.rgb);
                float node_6965 = 4.0;
                float node_5712 = floor(max(0,dot(lightDirection,i.normalDir)) * node_6965) / (node_6965 - 1);
                float node_2113 = 50.0;
                float3 finalColor = (((node_8145*node_5712)+(node_5712*pow(floor(max(0,dot(i.normalDir,halfDirection)) * node_2113) / (node_2113 - 1),exp2(lerp(1,11,_Gloss)))))*_LightColor0.rgb*attenuation);
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
