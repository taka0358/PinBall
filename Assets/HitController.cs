using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HitController : MonoBehaviour
{

    //�ϐ��̐錾
    private int score = 0;


    // �����������ɌĂ΂��֐�
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HitText");

        //�V�[������Text�I�u�W�F�N�g���擾
        this.HitText = GameObject.Find("HitText");

        // �^�O�ɂ���ē��_��ς���
        if (tag == "SmallStarTag")
        {
            //Text�ɓ��_10�����Z�\�� 
            this.HitText.GetComponent<Score>().score += 10;



        }
        else if (tag == "LargeStarTag")
        {
            //Text�ɓ��_20�����Z�\��
            this.HitText.GetComponent<Score>().score += 20;




        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            //Text�ɓ��_30�����Z
            this.HitText.GetComponent<Score>().score += 30;



        }

    }

    //���_��\������e�L�X�g

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










