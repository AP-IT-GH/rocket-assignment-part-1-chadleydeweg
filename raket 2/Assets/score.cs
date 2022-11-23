using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
// using TextMeshPro;
using TMPro;

public class score : MonoBehaviour
{

    public TextMeshProUGUI  MyscoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
    
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider Block)    
    {
        Debug.Log("enter");
        if (Block.tag == "Plate")
        {
            ScoreNum += 1;
            MyscoreText.text = "Score" + ScoreNum;
        }

       
        
        
    }
}
