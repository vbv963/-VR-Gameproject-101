using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6;
    public GameObject PlayerPivot;
    Camera viewCamera;
    Vector3 Velocity;
    public ProjectileController projectileController;

    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
        //��ǻ�� ȭ�� 2D�� ���콺 ��ǥ���� ī�޶� ����� �� 3D ���������� ���콺 ��ġ ���� �������� ���ؼ�
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        //�÷��̾ ������ Ÿ�� ����Ʈ
        Vector3 targetposition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        //�÷��̾� �Ǻ��� ������� �ϴ� ��ǥ�� ����
        PlayerPivot.transform.LookAt(targetposition, Vector3.up);

        //Input�� ���� ĳ���� �̵� ���͸� �����Ѵ�.
        Velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;
    }
    private void FixedUpdate()
    {
        //����� ���͸� �÷��̾� ��Ʈ�ѷ��� �ִ� Rigidbody�� �����ؼ� �̵� ���͸� �����ð� Time ��ŭ �̵������ִ� ����
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Velocity * Time.fixedDeltaTime);
    }
}
