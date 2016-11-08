using UnityEngine;
using System.Collections;
using Leap.Unity;

public class HoldInHands : MonoBehaviour {

    GameObject camera;

    Vector3 offset;

    void Start ()
    {
        camera = GameObject.Find("LMHeadMountedRig");
        offset = this.transform.position - camera.transform.position;
    }

	void Update ()
    {
        this.transform.position = camera.transform.position + offset;
        // wait for a ssecond
    }
}
