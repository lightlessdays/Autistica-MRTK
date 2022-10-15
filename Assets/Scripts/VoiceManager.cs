using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VoiceManager : MonoBehaviour, IMixedRealitySpeechHandler
{
    [SerializeField] TextMeshPro _tmPro;
    [SerializeField] AudioSource _congaratsAudio;
    List<string> words = new List<string> { "avocado", "strawberry", "jackfruit", "raspberry", "banana", "pizza", "burger", "sandwhich", "taco", "mocktail" };
    int level = 0;
    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        string eventString = eventData.Command.Keyword.ToLower();
        if (level < 9 && eventString == words[level])
        {
            level++;
            _tmPro.SetText(words[level]);
        }
        else if (eventString == words[level])
        {
            _congaratsAudio.Play();
        }
    }
    void Start()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealitySpeechHandler>(this);
        _tmPro.SetText(words[0]);
    }
}
