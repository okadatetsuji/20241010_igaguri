using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultDirector : MonoBehaviour
{
    public GameDirector gameDirector;
    GameObject ResultPoint;
    int Point = 0;

    // Start is called before the first frame update
    void Start()
    {
        Point = gameDirector.GetPoint();
        ResultPoint = GameObject.Find("ResultPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TitleScene");
        }

        this.ResultPoint.GetComponent<TextMeshProUGUI>().text =
            this.Point.ToString() + "point";
    }
}
