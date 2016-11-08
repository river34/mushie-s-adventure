using UnityEngine;
using System.Collections;

public class ShapeRotate : MonoBehaviour {

    public float speed = 3.0f;

	void Update () {
        transform.Rotate (new Vector3(0, 30, 0) * speed * Time.deltaTime);
    }
}
