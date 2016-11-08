using UnityEngine;
using System.Collections;

namespace Leap.Unity
{
    public class LeapCreateCube : MonoBehaviour
    {

        [SerializeField]
        private ProximityDetector _thumbA;
        public ProximityDetector ThumbA
        {
            get
            {
                return _thumbA;
            }
            set
            {
                _thumbA = value;
            }
        }

        [SerializeField]
        private ProximityDetector _thumbB;
        public ProximityDetector ThumbB
        {
            get
            {
                return _thumbB;
            }
            set
            {
                _thumbB = value;
            }
        }

        [SerializeField]
        private ProximityDetector _indexA;
        public ProximityDetector IndexA
        {
            get
            {
                return _indexA;
            }
            set
            {
                _indexA = value;
            }
        }

        [SerializeField]
        private ProximityDetector _indexB;
        public ProximityDetector IndexB
        {
            get
            {
                return _indexB;
            }
            set
            {
                _indexB = value;
            }
        }

        [SerializeField]
        private ProximityDetector _middleA;
        public ProximityDetector MiddleA
        {
            get
            {
                return _middleA;
            }
            set
            {
                _middleA = value;
            }
        }

        [SerializeField]
        private ProximityDetector _middleB;
        public ProximityDetector MiddleB
        {
            get
            {
                return _middleB;
            }
            set
            {
                _middleB = value;
            }
        }

        [SerializeField]
        private ProximityDetector _ringA;
        public ProximityDetector RingA
        {
            get
            {
                return _ringA;
            }
            set
            {
                _ringA = value;
            }
        }

        [SerializeField]
        private ProximityDetector _ringB;
        public ProximityDetector RingB
        {
            get
            {
                return _ringB;
            }
            set
            {
                _ringB = value;
            }
        }

        [SerializeField]
        private ExtendedFingerDetector _handA;
        public ExtendedFingerDetector HandA
        {
            get
            {
                return _handA;
            }
            set
            {
                _handA = value;
            }
        }

        [SerializeField]
        private ExtendedFingerDetector _handB;
        public ExtendedFingerDetector HandB
        {
            get
            {
                return _handB;
            }
            set
            {
                _handB = value;
            }
        }

        public GameObject shape;

        public Transform target;

        GameObject newShape = null;

        bool isBlocked = false;

        void Update()
        {
            if (!newShape &&
                _thumbA != null && _thumbA.IsActive &&
                _indexA != null && _indexA.IsActive &&
                _thumbB != null && _thumbB.IsActive &&
                _indexB != null && _indexB.IsActive /*&&
                _handA != null && _handA.IsActive &&
                _handB != null && _handB.IsActive*/)    // Do not have a shape in hold. When fingers cross, create a new shape.
            {
                CreateShape();
            }
            else if (newShape &&
                _thumbA != null && !_thumbA.IsActive &&
                _indexA != null && !_indexA.IsActive)   // Have a shape in hold. When fingers seperate, release shape.
            {
                newShape.GetComponent<LeapAim>().SetHold(false);
                newShape.GetComponent<LeapAim>().SetReleased(true);
                UnsetShape();
            }
            else
            {
                //
            }
        }

        void CreateShape()
        {
            if (!isBlocked && !gameObject.GetComponent<CreateShapeController>().GetBlocked())
            {
                Vector3 position = (_thumbA.transform.position + _thumbB.transform.position + _indexA.transform.position + _indexB.transform.position) / 4.0f;

                position += new Vector3(0f, 0f, 1f);

                Quaternion rotation = new Quaternion(0, 0, 0, 0);

                newShape = (GameObject)Instantiate(shape, position, rotation);

                newShape.GetComponent<LeapAim>().SetHold(true);

                isBlocked = true;

                gameObject.GetComponent<CreateShapeController>().SetBlocked(isBlocked);

                StartCoroutine(BlockAction(2));
            }
        }

        IEnumerator BlockAction(int seconds)
        {
            yield return new WaitForSeconds(seconds);

            isBlocked = false;

            gameObject.GetComponent<CreateShapeController>().SetBlocked(isBlocked);
        }

        public void SetShape(GameObject shape)
        {
            newShape = shape;
        }

        public void UnsetShape()
        {
            newShape = null;
        }
    }
}