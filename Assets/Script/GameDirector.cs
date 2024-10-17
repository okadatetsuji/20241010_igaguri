using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    float time = 30.0f;
    private int point = 0;

    public int GetPoint()
    {
        return point;
    }

    public void GetTargetCollision()
    {
        this.point += 100;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.time-=Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text =
            this.time.ToString("F1");
        if(this.time <= 0)
        {
            SceneManager.LoadScene("ResultScene");
        }

        this.pointText.GetComponent<TextMeshProUGUI>().text =
            this.point.ToString() + "point";
    }
}
