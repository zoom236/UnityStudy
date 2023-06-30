using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //탄알 이동 속도
    private Rigidbody bulletRigidbody; //이동에 사용할 리지드바디 컴포넌트

    private void OnTriggerEnter(Collider other)
    {
        //충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            //상대방 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            
            if (playerController != null)
            {
                //상대방 PlayerController 컴포넌트의 Die() 메서드 실행

                playerController.Die();
            }
        }
    }
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>(); //게임 오브젝트 Rigidbody 컴포넌트 찾아 bulletRigidbody에 할당
        bulletRigidbody.velocity = transform.forward* speed; //리지드 바디의 속도 = 앞방향 * 이동 속력

        Destroy(gameObject, 3f); //3초 뒤에 자신의 게임 오브젝트 파괴
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
