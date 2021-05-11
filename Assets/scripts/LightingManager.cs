using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using scripts;
using UnityEngine.SceneManagement;

// BASED ON https://github.com/Glynn-Taylor/Tutorials/releases/tag/1.0

[ExecuteAlways]
public class LightingManager : MonoBehaviour
{
    //Scene References
    [SerializeField] private Light DirectionalLight;
    [SerializeField] private LightingPreset Preset;
    //Variables
    // [SerializeField, Range(0, 24)] private float TimeOfDay = 6f;
    [SerializeField, Range(0, 720)] private float TimeOfDay = 180f;
    [SerializeField] private float minutes;
    private bool getTime = false;

    private GameManager gm;


    private void Start()
    {
        gm = GameManager.GetInstance();
    }

    private void Update()
    {
        if (Preset == null)
            return;
        
        gm = GameManager.GetInstance();
		if (gm.gameState != GameManager.GameState.GAME &
			 gm.gameState != GameManager.GameState.RESUME)
		{
			return;
		}

        if (Application.isPlaying) // && getTime == false)
        {
            //(Replace with a reference to the game time)
            // StartCoroutine(increaseTime());
            TimeOfDay += Time.deltaTime;
            TimeOfDay %= 720; //Modulus to ensure always between 0-720
            UpdateLighting(TimeOfDay / 720f);
        }
        else
        {
            UpdateLighting(TimeOfDay / 720f);
            // UpdateLighting(TimeOfDay / 24f);
        }

        if (TimeOfDay > 580)
        {
            SceneManager.LoadScene(3);
            gm.ChangeState(GameManager.GameState.MENU);
            TimeOfDay = 180f;
        }
    }


    private void UpdateLighting(float timePercent)
    {
        //Set ambient and fog
        RenderSettings.ambientLight = Preset.AmbientColor.Evaluate(timePercent);
        RenderSettings.fogColor = Preset.FogColor.Evaluate(timePercent);

        //If the directional light is set then rotate and set it's color, I actually rarely use the rotation because it casts tall shadows unless you clamp the value
        if (DirectionalLight != null)
        {
            DirectionalLight.color = Preset.DirectionalColor.Evaluate(timePercent);

            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170f, 0));
        }

    }

    //Try to find a directional light to use if we haven't set one
    private void OnValidate()
    {
        if (DirectionalLight != null)
            return;

        //Search for lighting tab sun
        if (RenderSettings.sun != null)
        {
            DirectionalLight = RenderSettings.sun;
        }
        //Search scene for light that fits criteria (directional)
        else
        {
            Light[] lights = GameObject.FindObjectsOfType<Light>();
            foreach (Light light in lights)
            {
                if (light.type == LightType.Directional)
                {
                    DirectionalLight = light;
                    return;
                }
            }
        }
    }

    private IEnumerator increaseTime()
    {
        getTime = true;
        yield return new WaitForSeconds(1);
        TimeOfDay += 13/(minutes*60);
        TimeOfDay %= 24; //Modulus to ensure always between 0-24
        UpdateLighting(TimeOfDay / 24f);
        getTime = false;
    }
}