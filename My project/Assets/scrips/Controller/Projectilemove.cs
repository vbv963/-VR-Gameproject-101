using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilemove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {
        //벽에 충돌시 파괴
        if(collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }
        //몬스터에 충돌시
        if(collision.gameObject.name == "Monster")
        {
            //몬스터에게 데미지를 주고 사라진다.
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
        
    }
   private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }
       
}
