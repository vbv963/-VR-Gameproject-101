using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilemove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {
        //���� �浹�� �ı�
        if(collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if(collision.gameObject.name == "Monster")
        {
            //���Ϳ��� �������� �ְ� �������.
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
