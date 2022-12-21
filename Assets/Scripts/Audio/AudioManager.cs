using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public float fadeInTime = 3f; // Time to fade in the audio
    public float maxVolume = 1f; // Maximum volume of the audio

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0f; // Set the initial volume to 0
        audioSource.Play(); // Start playing the audio
        StartCoroutine(FadeIn()); // Start the fade-in coroutine
    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeInTime)
        {
            // Increase the volume over time
            audioSource.volume = Mathf.Lerp(0f, maxVolume, elapsedTime / fadeInTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        audioSource.volume = maxVolume; // Make sure the volume is at the maximum value
    }
}
