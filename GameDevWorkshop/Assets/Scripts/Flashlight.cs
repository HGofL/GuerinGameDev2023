using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{

    public Light light;
    public AudioSource audio_source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started) ;

        {
            light.enabled = !light.enabled;
            audio_source.pitch = Random.Range(0.5f, 1.5f);
            audio_source.Play();
            //float r = Random.Range(0.0f, 1.0f);
            //float g = Random.Range(0.0f, 1.0f);
            //float b = Random.Range(0.0f, 1.0f);
           // light.color = new Color(r, g, b);
        }
    }
}
