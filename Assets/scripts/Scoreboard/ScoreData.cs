using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;


[Serializable]
public class ScoreData// : MonoBehaviour
{

    public List<Score> scores;

    public ScoreData() 
    {
        scores = new List<Score>();
    }

}
