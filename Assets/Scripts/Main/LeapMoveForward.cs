using UnityEngine;
using System.Collections;

namespace Leap.Unity
{
    public class LeapMoveForward : MonoBehaviour
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

        [SerializeField]
        private PalmDirectionDetector _palmA;
        public PalmDirectionDetector PalmA
        {
            get
            {
                return _palmA;
            }
            set
            {
                _palmA = value;
            }
        }

        [SerializeField]
        private PalmDirectionDetector _palmB;
        public PalmDirectionDetector PalmB
        {
            get
            {
                return _palmB;
            }
            set
            {
                _palmB = value;
            }
        }

        public GameObject mainView;

		bool isBlocked = false;

        void Update()
        {
            if (_thumbA != null && !_thumbA.IsActive &&
                _thumbB != null && !_thumbB.IsActive && 
                _handA != null && _handA.IsActive &&
                _handB != null && _handB.IsActive &&
                _palmA != null && _palmA.IsActive &&
                _palmB != null && _palmB.IsActive)
            {
                MoveForward();
            }
            else
            {
                //
            }
        }

        void MoveForward ()
        {
			if (mainView && !isBlocked)
            {
				if (mainView.GetComponent<MoveForward> ().enabled == false)
				{
					mainView.GetComponent<MoveForward>().enabled = true;

					isBlocked = true;

					StartCoroutine(BlockAction(2));
				}
            }
        }

        IEnumerator BlockAction(int seconds)
        {
            yield return new WaitForSeconds(seconds);
			isBlocked = false;
        }
    }
}
