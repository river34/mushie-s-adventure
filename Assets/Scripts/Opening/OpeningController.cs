using UnityEngine;
using System.Collections;

public class OpeningController : MonoBehaviour {

    GameObject start_scene;
    GameObject start_scene_2;
    GameObject start_scene_3;
    GameObject camera_1;
    GameObject camera_1_2;
    GameObject camera_2;

    void Start()
    {
        camera_1 = GameObject.Find("LMHeadMountedRig_1");
        camera_1_2 = GameObject.Find("LMHeadMountedRig_1_2");
        camera_2 = GameObject.Find("LMHeadMountedRig_2");

        start_scene = GameObject.Find("Start Scene");
        start_scene_2 = GameObject.Find("Start Scene_2");
        start_scene_3 = GameObject.Find("Start Scene_3");

        // StartCoroutine(WaitToLoadScene());

        GoToStartScene();
    }

    IEnumerator WaitToLoadScene()
    {
        yield return new WaitForSeconds(7);
        GetComponent<SceneController>().goToNextScene();
    }

    IEnumerator WaitAndGoToStartScene_2()
    {
        yield return new WaitForSeconds(7);
        GoToStartScene_2();
    }

    IEnumerator WaitAndGoToStartScene_3()
    {
        yield return new WaitForSeconds(7);
        GoToStartScene_3();
    }

    public void GoToStartScene()
    {
        start_scene.SetActive(true);
        start_scene_2.SetActive(false);
        start_scene_3.SetActive(false);
        camera_1.SetActive(true);
        camera_1_2.SetActive(false);
        camera_2.SetActive(false);
        //camera_tut.SetActive(false);

        StartCoroutine(WaitAndGoToStartScene_2());
    }

    public void GoToStartScene_2()
    {
        start_scene.SetActive(false);
        start_scene_2.SetActive(true);
        start_scene_3.SetActive(false);
        camera_1.SetActive(false);
        camera_1_2.SetActive(true);
        camera_2.SetActive(false);
        //camera_tut.SetActive(false);

        StartCoroutine(WaitAndGoToStartScene_3());
    }

    public void GoToStartScene_3()
    {
        start_scene.SetActive(false);
        start_scene_2.SetActive(false);
        start_scene_3.SetActive(true);
        camera_1.SetActive(false);
        camera_1_2.SetActive(true);
        camera_2.SetActive(false);

        StartCoroutine(WaitToLoadScene());
    }
}
