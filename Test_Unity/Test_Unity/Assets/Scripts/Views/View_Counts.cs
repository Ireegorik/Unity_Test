using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View_Counts : MonoBehaviour
{
    public Score score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score.CountPress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.CountPress.ToString();
    }
}
