using UnityEngine;

public class MusicZone : MonoBehaviour
{
    public AudioSource backgroundMusic;   // Main game music
    public AudioSource zoneMusic;         // Music for this area

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (backgroundMusic.isPlaying)
            backgroundMusic.Pause();

        if (!zoneMusic.isPlaying)
            zoneMusic.Play();
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (zoneMusic.isPlaying)
            zoneMusic.Stop();

        if (!backgroundMusic.isPlaying)
            backgroundMusic.Play();
    }
}