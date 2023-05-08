using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilemove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {
        //벽에 충돌시 파괴
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        //몬스터에 충돌시
        if(collision.gameObject.tag == "Monster")
        {
            //몬스터에게 데미지를 주고 사라진다.
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
        
    }
   private void OnTriggerEnter(Collider other)          //Trigger함수
    {
        Debug.Log(other.gameObject.tag);
        
        //벽에 충돌시 파괴
        if (other.gameObject.tag == "Wall")         //name -> Tag
        {
            Destroy(this.gameObject);
        }
        //몬스터에 충돌시
        if (other.gameObject.tag == "Monster")
        {
            //몬스터에게 데미지를 주고 사라진다.
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }


}
