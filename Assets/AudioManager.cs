using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private AudioSource audioSekarang;

    private void Awake()
    {
        instance = this;
    }

    public void PutarSuaraHewan(AudioSource audioBaru)
    {
        if (audioSekarang != null && audioSekarang.isPlaying)
        {
            audioSekarang.Stop();
        }
        audioSekarang = audioBaru;
        audioSekarang.Play();
    }
}