using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {
    
    GameObject camera_main;
    GameObject camera_1;
    GameObject camera_1_2;
    GameObject camera_2;
    //GameObject camera_tut;

    GameObject start_scene;
    GameObject start_scene_2;
    GameObject start_scene_3;
    GameObject death_scene;
    //GameObject tutorial_scene;
    GameObject main_scene;

    public AudioSource winSound;

    // Use this for initialization
    void Start ()
    {
        camera_main = GameObject.Find("LMHeadMountedRig");
        camera_1 = GameObject.Find("LMHeadMountedRig_1");
        camera_1_2 = GameObject.Find("LMHeadMountedRig_1_2");
        camera_2 = GameObject.Find("LMHeadMountedRig_2");
        //camera_tut = GameObject.Find("Tutorial_LMHeadMountedRig");

        start_scene = GameObject.Find("Start Scene");
        start_scene_2 = GameObject.Find("Start Scene_2");
        start_scene_3 = GameObject.Find("Start Scene_3");
        death_scene = GameObject.Find("End Scene");
        //tutorial_scene = GameObject.Find("Tutorial Scene");
        main_scene = GameObject.Find("Main Scene");

        ChangeToMainCamera();

        // ChangeToMainCamera();
        // GoToStartScene_2();
        // GoToTutorialScene();
    }

    IEnumerator WaitAndChangeToCamera_Main ()
    {
        yield return new WaitForSeconds(10);
        ChangeToMainCamera();
    }

    IEnumerator WaitAndGoToStartScene_2()
    {
        yield return new WaitForSeconds(5);
        GoToStartScene_2();
    }

    IEnumerator WaitAndGoToStartScene_3()
    {
        yield return new WaitForSeconds(5);
        GoToStartScene_3();
    }

    IEnumerator WaitAndGoToTutorialScene()
    {
        yield return new WaitForSeconds(5);
        GoToTutorialScene();
    }

    public void ChangeToMainCamera()
    {
        start_scene.SetActive(false);
        start_scene_2.SetActive(false);
        start_scene_3.SetActive(false);
        death_scene.SetActive(false);
        //tutorial_scene.SetActive(false);
        // Destroy(tutorial_scene);
        main_scene.SetActive(true);

        camera_main.SetActive(true);
        camera_1.SetActive(false);
        camera_1_2.SetActive(false);
        camera_2.SetActive(false);
        //camera_tut.SetActive(false);

        camera_main.transform.position = new Vector3(142f, 2.625f, -30.9f);
        camera_main.transform.Rotate(new Vector3(0f, 0f, 0f));
    }

    public void GoToDeathScene()
    {
        start_scene.SetActive(false);
        start_scene_2.SetActive(false);
        start_scene_3.SetActive(false);
        death_scene.SetActive(true);
        //tutorial_scene.SetActive(false);
        main_scene.SetActive(false);

        camera_main.SetActive(false);
        camera_1.SetActive(true);
        camera_1_2.SetActive(false);
        camera_2.SetActive(false);
        //camera_tut.SetActive(false);
    }

    public void GoToStartScene()
    {
        start_scene.SetActive(true);
        start_scene_2.SetActive(false);
        start_scene_3.SetActive(false);
        death_scene.SetActive(false);
        // tutorial_scene.SetActive(false);
        main_scene.SetActive(false);

        camera_main.SetActive(false);
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
        death_scene.SetActive(false);
        // tutorial_scene.SetActive(false);
        main_scene.SetActive(false);

        camera_main.SetActive(false);
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
        death_scene.SetActive(false);
        //tutorial_scene.SetActive(false);
        main_scene.SetActive(false);

        camera_main.SetActive(false);
        camera_1.SetActive(false);
        camera_1_2.SetActive(true);
        camera_2.SetActive(false);
        //camera_tut.SetActive(false);

        StartCoroutine(WaitAndGoToTutorialScene());
    }

    public void GoToSuccessScene()
    {
        start_scene.SetActive(false);
        start_scene_2.SetActive(false);
        start_scene_3.SetActive(false);
        death_scene.SetActive(false);
        //tutorial_scene.SetActive(false);
        main_scene.SetActive(false);

        camera_main.SetActive(false);
        camera_1.SetActive(false);
        camera_1_2.SetActive(false);
        camera_2.SetActive(true);
        //camera_tut.SetActive(false);

        winSound.Play();
    }

    public void GoToTutorialScene()
    {
        /*
        start_scene.SetActive(false);
        start_scene_2.SetActive(false);
        start_scene_3.SetActive(false);
        death_scene.SetActive(false);
        tutorial_scene.SetActive(true);
        main_scene.SetActive(false);

        camera_main.SetActive(true);
        camera_1.SetActive(false);
        camera_1_2.SetActive(false);
        camera_2.SetActive(false);
        //camera_tut.SetActive(true);

        camera_main.transform.position = new Vector3(338.6f, 32.6f, 264.3f);
        camera_main.transform.Rotate(new Vector3(0f, 29.116f, 0f));
        */

        GetComponent<SceneController>().GoToTutorial();
    }
}
