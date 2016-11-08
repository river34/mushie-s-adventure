using UnityEngine;
using System.Collections;

public class TutorialWitchMove : MonoBehaviour
{

    float speedRight = 1f;

    float speedUp = 0.5f;

    Vector3 movement;

    float min_x = -1f;

    float max_x = 1f;

    float min_y = -0.5f;

    float max_y = 0.5f;

    int goRight = 1;

    int goUp = 1;

    void Start()
    {
        min_x = transform.position.x + min_x;
        max_x = transform.position.x + max_x;
        min_y = transform.position.y + min_y;
        max_y = transform.position.y + max_y;
    }

    void Update()
    {

        transform.position += new Vector3(goRight * speedRight * Time.deltaTime, goUp * speedUp * Time.deltaTime, 0);

        if (transform.position.x > max_x)
        {
            if (goRight == 1)
            {
                goRight = -1;
            }
        }

        if (transform.position.x < min_x)
        {
            if (goRight == -1)
            {
                goRight = 1;
            }
        }

        if (transform.position.y > max_y)
        {
            if (goUp == 1)
            {
                goUp = -1;
            }
        }

        if (transform.position.y < min_y)
        {
            if (goUp == -1)
            {
                goUp = 1;
            }
        }
    }
}
