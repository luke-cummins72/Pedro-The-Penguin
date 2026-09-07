using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    void Start()
    {
        GameManager.Instance.onPlay.AddListener(PlayMusic);
        GameManager.Instance.onGameOver.AddListener(StopMusic);
    }

    private void PlayMusic()
    {
        music.Play();
    }

    private void StopMusic()
    {
        music.Stop();
    }
}
