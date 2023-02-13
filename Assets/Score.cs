using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public int score = 0;
    
    

    


    
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        
    }
    void Update()
    {


        {
            //HitTextに得点を表示
            GetComponent<Text>().text = (GetComponent<Score>().score) + "point";

        }
    }

}

// Update is called once per frame







