using UnityEngine;
using System.Collections;

public class MushieSayHello : MonoBehaviour {

    public AudioSource audio1;

    public AudioSource audio2;

    void Start()
    {
        StartCoroutine(playSoundAfterTenSeconds());
    }

    IEnumerator playSoundAfterTenSeconds()
    {
        yield return new WaitForSeconds(4);
        if (Random.value < 0.3)
        {
            audio1.Play();
        }
        else
        {
            audio2.Play();
        }
        
        StartCoroutine(playSoundAfterTenSeconds());
    }
}
