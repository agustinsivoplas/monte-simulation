using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Underwater : MonoBehaviour {

    public int underWaterLevel = 7;

    private bool defaultFog;
    private Color defaultFogColor;
    private float defaultFogDensity;

	void Start () {
        defaultFog = RenderSettings.fog;
        defaultFogColor = RenderSettings.fogColor;
        defaultFogDensity = RenderSettings.fogDensity;
        GetComponent<Camera>().backgroundColor = new Color(0f, 0.4f, 0.7f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.y < underWaterLevel)
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0f, 0.4f, 0.7f, 0.6f);
            RenderSettings.fogDensity = 0.04f;
        }

        else
        {
            RenderSettings.fog = defaultFog;
            RenderSettings.fogColor = defaultFogColor;
            RenderSettings.fogDensity = defaultFogDensity;
            //RenderSettings.skybox = defaultSkybox;
        }
		
	}
}
