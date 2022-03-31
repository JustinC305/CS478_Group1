using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TMP_Text TextScore;
    public float Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0f;
        TextScore.text = Score.ToString() + "Unfair";
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = Score.ToString() + "Unfair";
    }
}
