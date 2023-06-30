using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //ź�� �̵� �ӵ�
    private Rigidbody bulletRigidbody; //�̵��� ����� ������ٵ� ������Ʈ

    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            
            if (playerController != null)
            {
                //���� PlayerController ������Ʈ�� Die() �޼��� ����

                playerController.Die();
            }
        }
    }
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>(); //���� ������Ʈ Rigidbody ������Ʈ ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody.velocity = transform.forward* speed; //������ �ٵ��� �ӵ� = �չ��� * �̵� �ӷ�

        Destroy(gameObject, 3f); //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
