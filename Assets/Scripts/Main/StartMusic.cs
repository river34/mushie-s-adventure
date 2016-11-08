using UnityEngine;
using System.Collections;

public class StartMusic : MonoBehaviour {

    AudioSource audio;

    bool isStarted = false;
    
    void Start () {
        audio = GetComponent<AudioSource>();
    }

    void Update ()
    {
        if (!isStarted)
        {
            if (audio.enabled)
            {
                StartCoroutine(AudioFadeIn.FadeIn(audio, 10f));
                isStarted = true;
            }
        }
    }

    public void FadeOut()
    {
        StartCoroutine(AudioFadeOut.FadeOut(audio, 5f));
        isStarted = false;
    }

    public static class AudioFadeIn
    {
        public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
        {
            float endVolume = audioSource.volume;

            audioSource.volume = 0;

            audioSource.Play();

            while (audioSource.volume < endVolume)
            {
                audioSource.volume += endVolume * Time.deltaTime / FadeTime;

                yield return null;
            }
            
            audioSource.volume = endVolume;
        }
    }

    public static class AudioFadeOut 
    {
        public static IEnumerator FadeOut (AudioSource audioSource, float FadeTime)
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
