using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    private Vector2 initialpos;
    public GameObject Character;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialpos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0))
        {
            Calculate(Input.mousePosition);
        }
    }

    // Update is called once per frame
    void Calculate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(initialpos.x - finalPos.x);
        float disY = Mathf.Abs(initialpos.y - finalPos.y);

        if (disX > 0 || disY > 0)
        {
            if (disX > disY)
            {
                if (initialpos.x > finalPos.x)
                {
                    Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);  //哭率
                }
                else
                {
                    Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);  //坷弗率
                }
            }
            else
            {
                if (initialpos.y > finalPos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);  //第率
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);  //菊率
                }
            }
            
           
        }
    }
}