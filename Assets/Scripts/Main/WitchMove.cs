using UnityEngine;
using System.Collections;

public class WitchMove : MonoBehaviour {

    public GameObject Triangle_witch;
    public GameObject Square_witch;
    public GameObject Circle_witch;

    void Start()
    {

        iTween.MoveTo(Triangle_witch, iTween.Hash(
            "path", iTweenPath.GetPath("Triangle Path"),
            "time", 15.0f,
           "looptype", iTween.LoopType.pingPong,
           "easetype", iTween.EaseType.linear
            
            ));
        iTween.MoveTo(Square_witch, iTween.Hash(
            "path", iTweenPath.GetPath("Cube Path"),
            "time", 15.0f,
           "looptype", iTween.LoopType.pingPong,
           "easetype", iTween.EaseType.linear

            ));

        iTween.MoveTo(Circle_witch, iTween.Hash(
            "path", iTweenPath.GetPath("Circle Path"),
            "time", 15.0f,
           "looptype", iTween.LoopType.pingPong,
           "easetype", iTween.EaseType.linear

            ));


    }

    void Update () {

    }
}
