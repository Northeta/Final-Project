using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRenderTexture : MonoBehaviour
{
    public Material Mat;

    void Start()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
    }
 
    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, Mat);
    }
}
