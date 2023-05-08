using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenController : MonoBehaviour
{
    public GameObject MonsterTemp; // ���� �������� �־��ش�.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(1)) //���콺 ��ư �������� ������ �� 
        {
            Ray Cast = Camera.main.ScreenPointToRay(Input.mousePosition);
               
            RaycastHit hit;                        //Hit �������� ���� ���� 
            
            if(Physics.Raycast(Cast, out hit))   //out �μ��� hit�� Ray�� ����� ���� �־��ش�. 
            {
                if(hit.collider.tag == "Ground")  //hit�Ѱ��� Tag�� Ground �� �� 
                {
                    GameObject temp = (GameObject)Instantiate(MonsterTemp);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);

                }
                Debug.DrawLine(Cast.origin, hit.point, Color.red, 2.0f); //����� ���� ������ 2�� ���� �׷��ش�.

                Debug.Log("Hit => " + hit.collider.name); //hit �� ��ü�� name�� ������.
            }
        }
    }
}
