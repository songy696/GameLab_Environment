﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class fog : MonoBehaviour
{
    public Material _mat;
    public Color _fogColor;

    void Start() {

        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
    }

    void Update()
    {
        _mat.SetColor("_FogColor", _fogColor);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _mat);
    }
}
