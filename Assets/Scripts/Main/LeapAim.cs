using UnityEngine;
using System.Collections;
using Leap;

namespace Leap.Unity
{
    public class LeapAim : MonoBehaviour
    {
        GameObject camera;

        Vector3 left_position;

        Vector3 right_position;

        Vector3 cross_position;

        Vector3 camera_position;

        Vector3 direction;

        Vector3 offset;

        float speed = 10f;

        bool isHold = false;

        bool isReleased = false;

        int lifetime = 5;

        public AudioClip releaseSound;

        void Start ()
        {
            camera = GameObject.Find("CenterEyeAnchor");

            isHold = true;

            offset = transform.position - camera.transform.position;

            //direction = Aim();
        }

        void Update ()
        {
            if (isHold)
            {
                // transform.position = camera.transform.position + offset;

                transform.position = UpdatePosition ();

                // StartCoroutine(checkHoldStatus());
                // transform.position = (_handA.transform.position + _handB.transform.position) / 2.0f + offset;
                // StartCoroutine (HoldInHands (1));
            }
            else if (isReleased)
            {
                isReleased = false;
                direction = Aim ();
                StartCoroutine (EndLife(lifetime));
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = releaseSound;
                audio.Play();
                StartCoroutine(MusicFadeOut(audio));
            }

            if (direction != null && direction != Vector3.zero)
            {
                transform.position += (direction) * speed * Time.deltaTime;
            }
        }

        Vector3 UpdatePosition ()
        {
            LeapProvider provider = FindObjectOfType<LeapProvider>() as LeapProvider;

            camera_position = camera.transform.position;

            left_position = camera_position;

            right_position = camera_position;

            foreach (Hand hand in provider.CurrentFrame.Hands)
            {
                if (hand.IsLeft)
                {
                    left_position = hand.PalmPosition.ToVector3();
                }

                if (hand.IsRight)
                {
                    right_position = hand.PalmPosition.ToVector3();
                }
            }

            cross_position = (left_position + right_position) / 2f;

            return cross_position;
        }

        Vector3 Aim ()
        {
            LeapProvider provider = FindObjectOfType <LeapProvider> () as LeapProvider;

            camera_position = camera.transform.position;

            left_position = camera_position;

            right_position = camera_position;

            foreach (Hand hand in provider.CurrentFrame.Hands)
            {
                if (hand.IsLeft)
                {
                    left_position = hand.PalmPosition.ToVector3();
                }

                if (hand.IsRight)
                {
                    right_position = hand.PalmPosition.ToVector3();
                }
            }

            cross_position = (left_position + right_position) / 2f;

            direction = Vector3.Normalize (cross_position - camera_position);

            print (left_position + ", " + right_position + ", " + cross_position + ", " + camera_position + ", " + direction + ", " + offset);

            return direction;
        }

        IEnumerator HoldInHands (int seconds)
        {
            yield return new WaitForSeconds (seconds);

            isHold = false;
            
            direction = Aim();
        }

        IEnumerator checkHoldStatus ()
        {
            transform.position = camera.transform.position + offset;
            yield return null;
        }

        IEnumerator EndLife(int seconds)
        {
            yield return new WaitForSeconds(seconds);
            Destroy(gameObject);
        }

        IEnumerator MusicFadeOut (AudioSource audio)
        {
            yield return new WaitForSeconds(3);
            StartCoroutine(AudioFadeOut.FadeOut(audio, 10f));
        }

        public void SetHold (bool holdStatus)
        {
            isHold = holdStatus;
        }

        public bool GetHold()
        {
            return isHold;
        }

        public void SetReleased (bool releasedStatus)
        {
            isReleased = releasedStatus;
        }

        public static class AudioFadeOut
        {
            public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
            {
                float startVolume = audioSource.volume;

                while (audioSource.volume > 0)
                {
                    audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

                    yield return null;
                }

                audioSource.Stop();
                audioSource.volume = startVolume;
            }
        }
    }
}