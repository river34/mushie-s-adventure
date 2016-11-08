using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    GameObject camera;

    // level 1
    GameObject Triangle_witch_1;
    GameObject Cube_witch_1;
    GameObject Circle_witch_1;
    GameObject Destination_1;
    GameObject Level_1;

    // level 2
    GameObject Triangle_witch_2;
    GameObject Cube_witch_2;
    GameObject Circle_witch_2;
    GameObject Triangle_witch_3;
    GameObject Cube_witch_3;
    GameObject Circle_witch_3;
    GameObject Destination_2;
    GameObject Level_2;

    // level 3
    GameObject Destination_3;

    // level 3-1
    GameObject Level_3_cube;
    GameObject Cube_witch_4;
    GameObject Cube_witch_5;
    GameObject Cube_witch_6;

    // level 3-2
    GameObject Level_3_circle;
    GameObject Circle_witch_4;
    GameObject Circle_witch_5;
    GameObject Circle_witch_6;

    // level 3-3
    GameObject Level_3_triangle;
    GameObject Triangle_witch_4;
    GameObject Triangle_witch_5;
    GameObject Triangle_witch_6;

    // end point
    GameObject Destination_4;

    // bool
    bool level_1_ready = false;
    bool level_2_ready = false;
    bool level_3_cube_ready = false;
    bool level_3_circle_ready = false;
    bool level_3_triangle_ready = false;

    // fight music
    GameObject Fight_Music_1;
    GameObject Fight_Music_2;

    // Use this for initialization
    void Start () {
        camera = GameObject.Find("LMHeadMountedRig");

        // level 1
        Destination_1 = GameObject.Find("Destination1");
        Level_1 = GameObject.Find("Level1");
        Triangle_witch_1 = GameObject.Find("Triangle Witch 1");
        Cube_witch_1 = GameObject.Find("Cube Witch 1");
        Circle_witch_1 = GameObject.Find("Circle Witch 1");
        Fight_Music_1 = GameObject.Find("Fight_Music_1");

        // level 2
        Destination_2 = GameObject.Find("Destination2");
        Level_2 = GameObject.Find("Level2");
        Triangle_witch_2 = GameObject.Find("Triangle Witch 2");
        Cube_witch_2 = GameObject.Find("Cube Witch 2");
        Circle_witch_2 = GameObject.Find("Circle Witch 2");
        Triangle_witch_3 = GameObject.Find("Triangle Witch 3");
        Cube_witch_3 = GameObject.Find("Cube Witch 3");
        Circle_witch_3 = GameObject.Find("Circle Witch 3");

        // level 3
        Destination_3 = GameObject.Find("Destination3");
        Fight_Music_2 = GameObject.Find("Fight_Music_2");

        // level 3-1
        Level_3_cube = GameObject.Find("Level3_cube");
        Cube_witch_4 = GameObject.Find("Cube Witch 5");
        Cube_witch_5 = GameObject.Find("Cube Witch 5 (1)");
        Cube_witch_6 = GameObject.Find("Cube Witch 5 (2)");

        // level 3-2
        Level_3_circle = GameObject.Find("Level3_circle");
        Circle_witch_4 = GameObject.Find("Circle Witch 4");
        Circle_witch_5 = GameObject.Find("Circle Witch 5");
        Circle_witch_6 = GameObject.Find("Circle Witch 6");

        // level 3-3
        Level_3_triangle = GameObject.Find("Level3_triangle");
        Triangle_witch_4 = GameObject.Find("Triangle Witch 4");
        Triangle_witch_5 = GameObject.Find("Triangle Witch 5");
        Triangle_witch_6 = GameObject.Find("Triangle Witch 6");

        // end point 
        Destination_4 = GameObject.Find("Destination4");

        // start game with level 1
        if (!level_1_ready)
        {
            Level_1.SetActive(true);
            Triangle_witch_1.SetActive(true);
            
            iTween.MoveTo(Triangle_witch_1, iTween.Hash(
                   "path", iTweenPath.GetPath("New Path 1"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));

            Cube_witch_1.SetActive(false);
           Circle_witch_1.SetActive(false);
            
            StartCoroutine (StartMusic_1());

            level_1_ready = true;
        }

        // disable level 2 and 3
        Level_2.SetActive(false);
        Level_3_cube.SetActive(false);
        Level_3_circle.SetActive(false);
        Level_3_triangle.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Level_1 && Level_1.activeSelf)
        {
            if (Triangle_witch_1 == null && Cube_witch_1 != null && Cube_witch_1.activeSelf == false)
            {
                Cube_witch_1.SetActive(true);
                iTween.MoveTo(Cube_witch_1, iTween.Hash(
                   "path", iTweenPath.GetPath("Cube Path"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
            }

            if (Triangle_witch_1 == null && Cube_witch_1 == null && Circle_witch_1 != null && Circle_witch_1.activeSelf == false)
            {
                Circle_witch_1.SetActive(true);
                iTween.MoveTo(Circle_witch_1, iTween.Hash(
                   "path", iTweenPath.GetPath("Circle Path"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
            }

            if (Triangle_witch_1 == null && Cube_witch_1 == null && Circle_witch_1 == null)
            {
                camera.GetComponent<MoveForward>().target = Destination_2.transform;
                Destroy (Level_1);
                Level_2.SetActive (true);
            }
        }
        else if (Level_2 && Level_2.activeSelf)
        {
            if (!level_2_ready)
            {
                // change speed
                camera.GetComponent<MoveForward>().speed = 3.0f;

                // start routing here
                iTween.MoveTo(Triangle_witch_2, iTween.Hash(
                   "path", iTweenPath.GetPath("Triangle Path 2"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Cube_witch_2, iTween.Hash(
                   "path", iTweenPath.GetPath("Cube Path 2"),
                   "time", 20.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Circle_witch_2, iTween.Hash(
                   "path", iTweenPath.GetPath("Circle Path 2"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Triangle_witch_3, iTween.Hash(
                   "path", iTweenPath.GetPath("Triangle Path 3"),
                   "time", 22.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Cube_witch_3, iTween.Hash(
                   "path", iTweenPath.GetPath("Cube Path 3"),
                   "time", 25.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Circle_witch_3, iTween.Hash(
                   "path", iTweenPath.GetPath("Circle Path 3"),
                   "time", 30.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                level_2_ready = true;
            }

            if (Triangle_witch_2 == null && Cube_witch_2 == null && Circle_witch_2 == null
                && Triangle_witch_3 == null && Cube_witch_3 == null && Circle_witch_3 == null)
            {
                camera.GetComponent<MoveForward>().target = Destination_3.transform;
                Destroy(Level_2);
                Level_3_circle.SetActive(true);
            }
        }
        else if (Level_3_circle && Level_3_circle.activeSelf)
        {
            if (!level_3_circle_ready)
            {
                // start routing here
                iTween.MoveTo(Circle_witch_4, iTween.Hash(
                   "path", iTweenPath.GetPath("Circle1"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Circle_witch_5, iTween.Hash(
                   "path", iTweenPath.GetPath("Circle44"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Circle_witch_6, iTween.Hash(
                   "path", iTweenPath.GetPath("Circle56"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));

                // StartMusic_2();

                level_3_circle_ready = true;
            }
            if (Circle_witch_4 == null && Circle_witch_5 == null && Circle_witch_6 == null)
            {
                Destroy(Level_3_circle);
                Level_3_cube.SetActive(true);
            }
        }
        else if (Level_3_cube && Level_3_cube.activeSelf)
        {
            if (!level_3_cube_ready)
            {
                // start routing here
                iTween.MoveTo(Cube_witch_4, iTween.Hash(
                   "path", iTweenPath.GetPath("final"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Cube_witch_5, iTween.Hash(
                   "path", iTweenPath.GetPath("final2"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Cube_witch_6, iTween.Hash(
                   "path", iTweenPath.GetPath("final3"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                level_3_cube_ready = true;
            }
            if (Cube_witch_4 == null && Cube_witch_5 == null && Cube_witch_6 == null)
            {
                Destroy(Level_3_cube);
                Level_3_triangle.SetActive(true);
            }
        }
        else if (Level_3_triangle && Level_3_triangle.activeSelf)
        {
            if (!level_3_triangle_ready)
            {
                // start routing here
                iTween.MoveTo(Triangle_witch_4, iTween.Hash(
                   "path", iTweenPath.GetPath("finaltri"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Triangle_witch_5, iTween.Hash(
                   "path", iTweenPath.GetPath("finaltri2"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                iTween.MoveTo(Triangle_witch_6, iTween.Hash(
                   "path", iTweenPath.GetPath("finaltri3"),
                   "time", 15.0f,
                   "looptype", iTween.LoopType.pingPong,
                   "easetype", iTween.EaseType.linear
                ));
                level_3_triangle_ready = true;
            }
            if (Triangle_witch_4 == null && Triangle_witch_5 == null && Triangle_witch_6 == null)
            {
                camera.GetComponent<MoveForward>().target = Destination_4.transform;
                Destroy(Level_3_triangle);
            }
        }
    }

    IEnumerator StartMusic_1()
    {
        yield return new WaitForSeconds(22);
        Fight_Music_1.GetComponent<AudioSource>().enabled = true;
    }

    void StartMusic_2()
    {
        Fight_Music_1.GetComponent<StartMusic>().FadeOut();
        Fight_Music_2.GetComponent<AudioSource>().enabled = true;
    }
}
