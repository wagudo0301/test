using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //�����肽������
    //�ϐ��쐬�@(�ړ��X�s�[�h�A�A�j���[�V�����A����)
    [SerializeField,Tooltip("�ړ��X�s�[�h")]
    private int moveSpeed;

    [SerializeField]
    private Animator playerAnim;

    public Rigidbody2D rb;


    //�L�[���͂��󂯎��ړ�������R�[�h�L�q
    //�����ƃA�j���[�V������A��
    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
