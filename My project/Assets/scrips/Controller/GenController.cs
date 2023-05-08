using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenController : MonoBehaviour
{
    public GameObject MonsterTemp; // 몬스터 프리팹을 넣어준다.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(1)) //마우스 버튼 오른쪽을 눌렀을 때 
        {
            Ray Cast = Camera.main.ScreenPointToRay(Input.mousePosition);
               
            RaycastHit hit;                        //Hit 물리레이 변수 선언 
            
            if(Physics.Raycast(Cast, out hit))   //out 인수로 hit에 Ray값 검출된 값을 넣어준다. 
            {
                if(hit.collider.tag == "Ground")  //hit한곳의 Tag가 Ground 일 때 
                {
                    GameObject temp = (GameObject)Instantiate(MonsterTemp);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);

                }
                Debug.DrawLine(Cast.origin, hit.point, Color.red, 2.0f); //디버그 빨강 라인을 2초 동안 그려준다.

                Debug.Log("Hit => " + hit.collider.name); //hit 된 물체의 name을 보여줌.
            }
        }
    }
}
