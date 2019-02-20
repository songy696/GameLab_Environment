using UnityEngine;
using System.Collections;

public class underwaterCam : MonoBehaviour
{
    // ! VARIABLES !
    private int underwaterLevel = 999;
    private readonly bool defaultFog = RenderSettings.fog;
    private Color defaultFogColor = RenderSettings.fogColor;
    public float fogDensity = RenderSettings.fogDensity; // This variable controls fog density.
    private Material defaultSkybox = RenderSettings.skybox;
    private Material noSkybox;

    void Start()
    {
        // ! BACKGROUND COLOR !
        GetComponent<Camera>().backgroundColor = new Color(0, 0.4f, 0.7f, 1);
    }

    void Update()
    {
        if (transform.position.y < underwaterLevel)
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
            RenderSettings.fogDensity = 0.1f;
            RenderSettings.skybox = noSkybox;
        }
        else
        {
            RenderSettings.fog = defaultFog;
            RenderSettings.fogColor = defaultFogColor;
            RenderSettings.fogDensity = fogDensity;
            RenderSettings.skybox = defaultSkybox;
        }
    }
}