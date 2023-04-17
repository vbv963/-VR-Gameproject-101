using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileController : MonoBehaviour
{
    public GameObject Projectilie;

    //발사체를 생성 후 이동 백터를 넣어줘서 발사이동 후 10초 후 소멸
    public void FireProjectile()
    {
        //Instantiate 함수는 오브젝트 및 프리팹 생성하는 함수
        GameObject temp = (GameObject)Instantiate(Projectilie);
        //생성된  Projectile을 temp에 입력

        //해당 게임오브젝트 위치에서 생성
        temp.transform.position = this.gameObject.transform.position;

        //발사체에 발사 방향을 내 오브젝트의 앞쪽으로 설정한다.
        temp.GetComponent<Projectilemove>().launchDirection = transform.forward;
    }

}


