using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDownTimer : MonoBehaviour
{
    public GameObject myobject;
    float currentTime = 0f;
    float startingTime =30f;
    [SerializeField] Text countdownText;
  void Start()
    {
    currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        countdownText.color = Color.green;
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
        }
        if (currentTime <= 0)
        {
            countdownText.text = "Well done!";
        }
     
    }
}
