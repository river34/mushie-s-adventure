using UnityEngine;
using System.Collections;

public class ThumbTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        /*
        print(other.gameObject.transform.parent.name + ", " 
            + this.gameObject.transform.parent.parent.parent.tag + ", " 
            + other.gameObject.transform.parent.parent.tag);
            */

        if (other.gameObject.transform.parent.name.Equals("thumb"))
        {
            if (this.gameObject.transform.parent.parent.parent.tag.Equals("Left") &&
            other.gameObject.transform.parent.parent.tag.Equals("Right"))
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = this.gameObject.transform.position;
                sphere.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            }

        }
    }
}
