using UnityEngine;
using System.Collections;

public class DeathController : MonoBehaviour {

    void Start ()
    {
        StartCoroutine(WaitToLoadScene());
    }

	IEnumerator WaitToLoadScene ()
    {
        yield return new WaitForSeconds(5);
        GetComponent<SceneController>().goToNextScene();
    }
}
