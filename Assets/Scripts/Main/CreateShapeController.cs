using UnityEngine;
using System.Collections;

namespace Leap.Unity
{
    public class CreateShapeController : MonoBehaviour
    {

        bool isBlocked = false;

        public void SetBlocked(bool blockedStatus)
        {
            isBlocked = blockedStatus;
        }

        public bool GetBlocked()
        {
            return isBlocked;
        }
    }

}