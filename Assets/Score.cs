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
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        
    }
    void Update()
    {


        {
            //HitText�ɓ��_��\��
            GetComponent<Text>().text = (GetComponent<Score>().score) + "point";

        }
    }

}

// Update is called once per frame







