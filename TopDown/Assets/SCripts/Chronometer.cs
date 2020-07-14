using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{
    float timer;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = Mathf.Floor(timer).ToString();
    }
}
