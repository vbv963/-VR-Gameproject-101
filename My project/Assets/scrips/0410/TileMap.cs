using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
    public GameObject tile_001;                                       //������ �������� ����Ƽ �ν����� â���� �Է� �޴´�.
                                          //������ �������� ����Ƽ �ν����� â���� �Է� �޴´�.

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_001);
                temp.transform.position = new Vector3(i, 0, j);
            }

           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
