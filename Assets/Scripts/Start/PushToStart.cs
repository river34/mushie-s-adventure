using UnityEngine;
using System.Collections;

public class PushToStart : MonoBehaviour {

    GameObject root;

    void Start ()
    {
        root = GameObject.Find("Root");
    }

	void OnTriggerEnter (Collider other)
    {
        if (root && other.name == "bone3")
        {
            root.GetComponent<SceneController>().goToNextScene();
        }
    }
}
