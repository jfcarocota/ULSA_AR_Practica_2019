using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class CinematicCtroller : MonoBehaviour
{
    PlayableDirector director;

    [SerializeField]
    Button playButton;
    [SerializeField]
    Button pauseButton;
    [SerializeField]
    Button stopButton;
    [SerializeField]
    Button skipRight;
    [SerializeField]
    Button skipLeft;

    void Awake()
    {
        director = GetComponent<PlayableDirector>();

        playButton.onClick.AddListener(PlayCinematic);
        pauseButton.onClick.AddListener(PauseCinematic);
        stopButton.onClick.AddListener(StopButton);
    }

    void PlayCinematic()
    {
        director.Play();
    }

    void PauseCinematic()
    {
        director.Pause();
    }

    void StopButton()
    {
        director.Stop();
    }

    void SkipRightButton()
    {
        director.time += 20f;
    }

    void SkipLeftButton()
    {

    }
}
