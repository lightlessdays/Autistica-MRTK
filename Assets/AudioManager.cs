using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioSource> audioSources;
    [SerializeField] private AudioSource tryAgain;
    [SerializeField] private TextMeshPro tmpro1;
    [SerializeField] private TextMeshPro tmpro2;
    [SerializeField] private TextMeshPro tmpro3;
    [SerializeField] private AudioSource completed;
    private int audioNumber;
    List<List<string>> optionwords = new List<List<string>>(){
                        new List<string>(){"SOPHISTICATED","SATURN","SPRING" },
                        new List<string>(){"CATNIP","CRAYON","CHOCOLATE"},
                        new List<string>(){"DRAGON","DINOSAUR","DYSENTERY"},
                        new List<string>(){"DYSENTERY","DEVELOPMENT","DELUSIONAL"},
                        new List<string>(){ "IRONIC", "ILLUSION","EROTIC"},
                        new List<string>(){"TASTELESS", "REGARDLESS", "WORTHLESS"},
                        new List<string>(){"BECKON","BACON","RECKON"},
                        new List<string>(){ "EDUCATED", "UNEDUCATED","AMPLIFY"},
                        new List<string>(){"LEJER","LEGGER","LEDGER"},
                        new List<string>(){ "PROTEIN", "PROFIT","PROGRESS"}
        };

    List<string> actualWords = new List<string>() {
        "SOPHISTICATED","CHOCOLATE","DYSENTERY","DEVELOPMENT","IRONIC","REGARDLESS","RECKON","EDUCATED","LEDGER","PROTEIN"
    };

    private void Start()
    {
        audioNumber = 0;
        GameFunction();
    }

    void GameFunction()
    {
        if (audioNumber == 10)
        {
            completed.Play();
        }
        audioSources[audioNumber].Play();
        tmpro1.SetText(optionwords[audioNumber][0]);
        tmpro2.SetText(optionwords[audioNumber][1]);
        tmpro3.SetText(optionwords[audioNumber][2]);
    }

    public void onFirstButtonPressed()
    {
        if (tmpro1.text == actualWords[audioNumber])
        {
            audioNumber++;
            GameFunction();
        }
        else
        {
            tryAgain.Play();
        }
    }

    public void onSecondButtonPressed()
    {
        if (tmpro2.text == actualWords[audioNumber])
        {
            audioNumber++;
            GameFunction();
        }
        else
        {
            tryAgain.Play();
        }
    }

    public void onThirdButtonPressed()
    {
        if (tmpro3.text == actualWords[audioNumber])
        {
            audioNumber++;
            GameFunction();
        }
        else
        {
            tryAgain.Play();
        }
    }
}
