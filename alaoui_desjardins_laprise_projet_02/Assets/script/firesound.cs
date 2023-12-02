using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FireSound : MonoBehaviour
{
    public float basePitch = 1f;
    public float pitchRange = 0.1f;
    public float volume = 0.5f;
    public float noiseIntensity = 0.1f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;

        // Start the fire sound coroutine
        StartCoroutine(PlayFireSound());
    }

    IEnumerator PlayFireSound()
    {
        while (true)
        {
            // Generate a random pitch within the specified range
            float randomPitch = Random.Range(basePitch - pitchRange, basePitch + pitchRange);

            // Apply the pitch and volume to the audio source
            audioSource.pitch = randomPitch;
            audioSource.volume = volume + Random.Range(-noiseIntensity, noiseIntensity);

            // Play the audio
            audioSource.Play();

            // Wait for a random duration to simulate the irregularity of fire sounds
            yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
        }
    }
}
