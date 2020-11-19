using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Button_Press : MonoBehaviour
{
    public Score score;
    public void Press()
    {
        score.CountPress++;
    }
}
