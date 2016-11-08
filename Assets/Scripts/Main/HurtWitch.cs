using UnityEngine;
using System.Collections;

public class HurtWitch : MonoBehaviour {

    public GameObject controller;

	void OnTriggerEnter (Collider other)
    {
        if (this.CompareTag("Triangle Enemy") && other.CompareTag("Triangle"))
        {
            controller.GetComponent<SceneController>().goToNextScene();
        }

        print(other.tag);
    }
}
