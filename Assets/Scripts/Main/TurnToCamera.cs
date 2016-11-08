using UnityEngine;
using System.Collections;

public class TurnToCamera : MonoBehaviour {

    GameObject camera;

    void Start ()
    {
        camera = GameObject.Find("CenterEyeAnchor");
    }

	void Update () {
        if (camera)
        {
            Vector3 relativePos = camera.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(relativePos);
        }
    }
}
