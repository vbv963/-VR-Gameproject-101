using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterRotation : MonoBehaviour
{
    float rotSpeed = 0;                                     //�Ÿ� ���̳� ȸ�� ���� ������ ������ ����(float)

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10000;
        }

        transform.Rotate(0, this. rotSpeed * Time.deltaTime, 0);      //ĳ���͸� y���� ȸ���ϴ� ���·� ������.
                                                                      //Time detta ���� �������� ����Ǿ ������ ���� �����ؼ� ������ �Ѵ�.
       
        rotSpeed *= 0.99f;                                            //�����Ӹ��� �ӵ��� 1% �� �پ��� ����(rotSpeed = rotSpeed * 0.99.01)
    }
}
