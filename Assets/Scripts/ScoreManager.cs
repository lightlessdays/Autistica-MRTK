using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshPro _points;
    private int points;
    private bool seeTarget = false;

    private void Start()
    {
        points = 0;
    }

    private void Update()
    {
        if (seeTarget) {
            StopCoroutine(timerDecreaser());
            StartCoroutine(timerIncreaser());
        } else {
            StopCoroutine(timerIncreaser());
            StartCoroutine(timerDecreaser());
        }
    }
    public void decreasePoints()
    {
        seeTarget = false;
    }

    public void increasePoints()
    {
        seeTarget = true;
    }

    private IEnumerator timerIncreaser()
    {
        
            points++;
            _points.text = "" + (int)points/1000;
            yield return new WaitForSeconds(4);
        
    }

    private IEnumerator timerDecreaser()
    {
        
            points--;
            _points.text = "" + (int)points/1000;
            yield return new WaitForSeconds(4);
        
    }

    public void Reset()
    {
        points = 0;
        _points.text = ""+points;
    }

}
