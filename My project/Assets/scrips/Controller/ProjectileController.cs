using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileController : MonoBehaviour
{
    public GameObject Projectilie;

    //�߻�ü�� ���� �� �̵� ���͸� �־��༭ �߻��̵� �� 10�� �� �Ҹ�
    public void FireProjectile()
    {
        //Instantiate �Լ��� ������Ʈ �� ������ �����ϴ� �Լ�
        GameObject temp = (GameObject)Instantiate(Projectilie);
        //������  Projectile�� temp�� �Է�

        //�ش� ���ӿ�����Ʈ ��ġ���� ����
        temp.transform.position = this.gameObject.transform.position;

        //�߻�ü�� �߻� ������ �� ������Ʈ�� �������� �����Ѵ�.
        temp.GetComponent<Projectilemove>().launchDirection = transform.forward;
    }

}


