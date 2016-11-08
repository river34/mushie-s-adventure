using UnityEngine;
using System.Collections;

public class StopEmission : MonoBehaviour {

    GameObject effect_1;

    GameObject effect_2;

    void Start () {
        /*
         * ParticleSystem.EmissionModule effect_1 = transform.Find("DisappearEffect").transform.Find("Effect_1").gameObject.GetComponent<ParticleSystem>().emission;
        ParticleSystem.EmissionModule effect_2 = transform.Find("DisappearEffect").transform.Find("Effect_2").gameObject.GetComponent<ParticleSystem>().emission;
        effect_1.enabled = false;
        effect_2.enabled = false;
        */

        effect_1 = transform.Find("DisappearEffect").transform.Find("Effect_1").gameObject;
        effect_2 = transform.Find("DisappearEffect").transform.Find("Effect_2").gameObject;
        effect_1.SetActive(false);
        effect_2.SetActive(false);
    }

    public void StartEmission ()
    {
        effect_1.SetActive(true);
        effect_2.SetActive(true);
    }
}
