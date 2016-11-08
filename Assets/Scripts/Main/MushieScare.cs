using UnityEngine;
using System.Collections;

public class MushieScare : MonoBehaviour {

    public GameObject mushie;

    public Animator ac;

    public AudioSource scaredSound;

    public AudioSource bossScaredSound;

    public GameObject sayHello;

    void OnTriggerEnter (Collider other)
    {
        /*
        if (other.CompareTag("Enemy Detector"))
        {
            sayHello.GetComponent<AudioSource>().enabled = false;
            ac.SetBool("Scared", true);
            scaredSound.Play();
        }
        else if (other.CompareTag("Boss Detector"))
        {
            sayHello.GetComponent<AudioSource>().enabled = false;
            ac.SetBool("Scared", true);
            bossScaredSound.Play();
        }
        else
        {
            sayHello.GetComponent<AudioSource>().enabled = true;
            ac.SetBool("Scared", false);
        }
        */
    }
}
