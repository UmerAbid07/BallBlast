using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIEditor : MonoBehaviour
{
    static float score=2;
    TextMeshProUGUI scoreEditor;
    Bullet isCollidedFlag;

    // Start is called before the first frame update
    void Start()
    {
        scoreEditor = GameObject.Find("UIScore").GetComponent<TextMeshProUGUI>();
        isCollidedFlag = GetComponent<Bullet>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isCollidedFlag.scoreFlag)
        {
            score = score + 1;
            print(score);
            
        }
        scoreEditor.text = score.ToString();
    }
}
