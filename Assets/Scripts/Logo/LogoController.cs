using UnityEngine;
using System.Collections;

public class LogoController : MonoBehaviour {
    
	void Start () {
        StartCoroutine(WaitAndLoadScene());
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<SceneController>().goToNextScene();
    }
}
