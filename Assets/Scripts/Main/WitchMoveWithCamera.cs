using UnityEngine;
using System.Collections;

public class WitchMoveWithCamera : MonoBehaviour {

    GameObject camera;

    float preset_z;

    void Start ()
    {
        preset_z = transform.position.z;
        camera = GameObject.Find ("CenterEyeAnchor");
        transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z + 20f);
    }

	void Update () {
	    if (transform.position.z < preset_z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z + 20f);
        }
	}
}
