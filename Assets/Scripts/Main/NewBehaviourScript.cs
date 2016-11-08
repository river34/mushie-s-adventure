using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{ 
    void Start()
    {
        RenderSettings.skybox.SetFloat("_Blend", 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            StartCoroutine("Fade");
        }
    }

    IEnumerator Fade()
    {
        for (float f = 0f; f<= 1; f +=0.005f)
        {
            RenderSettings.skybox.SetFloat("_Blend", f);
            yield return null;
        }
    }
}

