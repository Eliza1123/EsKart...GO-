using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using System;


[Serializable]
public class Score// : MonoBehaviour
{
    public string name;
    public float score;

    public Score(string name, float score)
    {
        this.name = name;
        this.score = score;

    }
}
