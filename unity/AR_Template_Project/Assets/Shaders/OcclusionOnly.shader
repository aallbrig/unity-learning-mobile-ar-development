Shader "Unlit/OcclusionOnly"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue"="Geometry" }
        LOD 100
        
        Pass
        {
            ZWrite On
            ColorMask 0
        }
    }
}
