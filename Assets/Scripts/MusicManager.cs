using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] GameObject initialAudioClipG;
    [SerializeField] GameObject finalAudioClipG;
    AudioSource initialAudioClip;
    AudioSource finalAudioClip;
    float timer = 0;
    bool timerReached = false;

    private void Start()
    {
        initialAudioClip=initialAudioClipG.GetComponent<AudioSource>();
        finalAudioClip = finalAudioClipG.GetComponent<AudioSource>();
        
    }


    void playAudio()
    {
        finalAudioClip.Play();
    }


    void Update()
    {
        if (!timerReached)
            timer += Time.deltaTime;

        if (!timerReached && timer > 5)
        {
            Debug.Log("Playing audio");
            playAudio();

            //Set to false so that We don't run this again
            timerReached = true;
        }
    }
}
