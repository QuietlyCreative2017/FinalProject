// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:32795,y:32363,varname:node_4013,prsc:2|emission-8861-OUT,alpha-4315-OUT;n:type:ShaderForge.SFN_Tex2d,id:9231,x:32037,y:32490,varname:node_9231,prsc:2,ntxv:0,isnm:False|UVIN-2083-UVOUT,TEX-9897-TEX;n:type:ShaderForge.SFN_TexCoord,id:6406,x:31688,y:32605,varname:node_6406,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:2416,x:31483,y:32605,varname:node_2416,prsc:2;n:type:ShaderForge.SFN_Panner,id:2083,x:31867,y:32680,varname:node_2083,prsc:2,spu:-1,spv:0|UVIN-6406-UVOUT,DIST-4111-OUT;n:type:ShaderForge.SFN_Slider,id:3702,x:31326,y:32778,ptovrint:False,ptlb:ArrowSpeed_Large,ptin:_ArrowSpeed_Large,varname:node_3702,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1.6;n:type:ShaderForge.SFN_Multiply,id:4111,x:31688,y:32760,varname:node_4111,prsc:2|A-2416-T,B-3702-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:9897,x:31854,y:32473,ptovrint:False,ptlb:Arrow_Texture,ptin:_Arrow_Texture,varname:_ArrowTexture_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Time,id:6029,x:31651,y:31991,varname:node_6029,prsc:2;n:type:ShaderForge.SFN_Panner,id:3933,x:32000,y:32017,varname:node_3933,prsc:2,spu:-1,spv:0|UVIN-611-OUT,DIST-1502-OUT;n:type:ShaderForge.SFN_Slider,id:5906,x:31494,y:32139,ptovrint:False,ptlb:ArrowSpeed_Small,ptin:_ArrowSpeed_Small,varname:_ArrowSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2,max:1.6;n:type:ShaderForge.SFN_Multiply,id:1502,x:31829,y:32027,varname:node_1502,prsc:2|A-6029-T,B-5906-OUT;n:type:ShaderForge.SFN_Lerp,id:8861,x:32531,y:32385,varname:node_8861,prsc:2|A-1604-OUT,B-819-OUT,T-9231-A;n:type:ShaderForge.SFN_TexCoord,id:6585,x:31651,y:31731,varname:node_6585,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:611,x:31829,y:31894,varname:node_611,prsc:2|A-6585-UVOUT,B-2134-OUT;n:type:ShaderForge.SFN_Vector1,id:2134,x:31651,y:31915,varname:node_2134,prsc:2,v1:2;n:type:ShaderForge.SFN_Tex2d,id:1379,x:32221,y:32017,varname:node_1379,prsc:2,ntxv:0,isnm:False|UVIN-3933-UVOUT,TEX-9897-TEX;n:type:ShaderForge.SFN_Lerp,id:4315,x:32564,y:32821,varname:node_4315,prsc:2|A-7446-OUT,B-9231-A,T-9231-A;n:type:ShaderForge.SFN_Multiply,id:1604,x:32442,y:32017,varname:node_1604,prsc:2|A-1379-RGB,B-9866-RGB;n:type:ShaderForge.SFN_Color,id:9866,x:32145,y:32225,ptovrint:False,ptlb:ArrowSmall_Color,ptin:_ArrowSmall_Color,varname:node_9866,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1490196,c2:0.7490196,c3:0.8745098,c4:0.2509804;n:type:ShaderForge.SFN_Multiply,id:819,x:32208,y:32402,varname:node_819,prsc:2|A-9231-RGB,B-9866-RGB;n:type:ShaderForge.SFN_Multiply,id:7446,x:32472,y:32551,varname:node_7446,prsc:2|A-1379-A,B-8305-OUT;n:type:ShaderForge.SFN_Slider,id:8305,x:32087,y:32765,ptovrint:False,ptlb:ArrowsSmall_Opacity,ptin:_ArrowsSmall_Opacity,varname:node_8305,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.25,max:1;proporder:3702-5906-8305-9866-9897;pass:END;sub:END;*/

Shader "Shader Forge/TestShader" {
    Properties {
        _ArrowSpeed_Large ("ArrowSpeed_Large", Range(0, 1.6)) = 0.8
        _ArrowSpeed_Small ("ArrowSpeed_Small", Range(0, 1.6)) = 0.2
        _ArrowsSmall_Opacity ("ArrowsSmall_Opacity", Range(0, 1)) = 0.25
        _ArrowSmall_Color ("ArrowSmall_Color", Color) = (0.1490196,0.7490196,0.8745098,0.2509804)
        _Arrow_Texture ("Arrow_Texture", 2D) = "white" {}
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
            uniform float _ArrowSpeed_Large;
            uniform sampler2D _Arrow_Texture; uniform float4 _Arrow_Texture_ST;
            uniform float _ArrowSpeed_Small;
            uniform float4 _ArrowSmall_Color;
            uniform float _ArrowsSmall_Opacity;
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
                float4 node_6029 = _Time;
                float2 node_3933 = ((i.uv0*2.0)+(node_6029.g*_ArrowSpeed_Small)*float2(-1,0));
                float4 node_1379 = tex2D(_Arrow_Texture,TRANSFORM_TEX(node_3933, _Arrow_Texture));
                float4 node_2416 = _Time;
                float2 node_2083 = (i.uv0+(node_2416.g*_ArrowSpeed_Large)*float2(-1,0));
                float4 node_9231 = tex2D(_Arrow_Texture,TRANSFORM_TEX(node_2083, _Arrow_Texture));
                float3 emissive = lerp((node_1379.rgb*_ArrowSmall_Color.rgb),(node_9231.rgb*_ArrowSmall_Color.rgb),node_9231.a);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,lerp((node_1379.a*_ArrowsSmall_Opacity),node_9231.a,node_9231.a));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
