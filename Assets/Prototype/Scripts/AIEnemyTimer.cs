using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AIEnemyTimer : MonoBehaviour
{
    [SerializeField]
    private float startTime = 0.0f;
    [SerializeField]
    private float minusEachFrame = 0.0f;
    private float countDown = 0.0f;

    [SerializeField]
    private float delay = 0.0f;
    private float futureTime = 0.0f;

    private void Start()
    {
        futureTime = Time.time + delay;
        countDown = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown <= 0.0f)
        {
            countDown = startTime;
        }

        if(countDown >= 5.0f)
        {
            GetComponent<TextMeshPro>().color = Color.green;
        }
        else
        {
            GetComponent<TextMeshPro>().color = Color.red;
        }

        if (Time.time > (futureTime))
        {
            countDown = (countDown - minusEachFrame);

            GetComponent<TextMeshPro>().text = string.Format("{0:F1}", countDown);

            futureTime = Time.time + delay;
        }
    }
}
