using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HitController : MonoBehaviour
{

    //変数の宣言
    private int score = 0;


    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HitText");

        //シーン中のTextオブジェクトを取得
        this.HitText = GameObject.Find("HitText");

        // タグによって得点を変える
        if (tag == "SmallStarTag")
        {
            //Textに得点10を加算表示 
            this.HitText.GetComponent<Score>().score += 10;



        }
        else if (tag == "LargeStarTag")
        {
            //Textに得点20を加算表示
            this.HitText.GetComponent<Score>().score += 20;




        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            //Textに得点30を加算
            this.HitText.GetComponent<Score>().score += 30;



        }

    }

    //得点を表示するテキスト

    private GameObject HitText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {

    }


}










