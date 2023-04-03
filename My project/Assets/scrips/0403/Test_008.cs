using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                          //ul�� �����ϱ� ���ؼ� ���

public class Player
{ 
    private int hp = 100;                                      //hp �� ������ �� 100�� ���� �Է�
    private int power = 50;                                    //power�� ������ �� 50�� ���� �Է�

    public void Attack()
    {
        Debug.Log(this.power + "�������� ������.");             //this�� player�� Ŭ������ �̾߱��Ѵ�.
    } 
    public void Damage(int damage)                              //Damage �Լ��� int ���·� ���� ���̹� �μ��� �޴´�.
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }
    public int GetHp()                                          //Private�� ����Ǿ��ִ� Hp ���� ���� �Լ��� ���ؼ� ����
    {
        return this.hp; 
    }
}
public class Test_008 : MonoBehaviour
{
    Player player_01 = new Player();
    Player player_02 = new Player();                           //���� ���� �÷��̾� Ŭ������ �����Ѵ�. (������ ����ϱ� ���ؼ�)
    public Text player01HP;
    public Text player02HP;                                    //�÷��̾� Hp�� �����ִ� UI ����

    // Start is called before the first frame update
    void Start()
    {
        player_01.Attack();                                     //������ player_01 �� Attack �Լ��� �����Ų��.
        player_01.Damage(30);                                   //������ player_01 �� Damage �Լ��� �����Ų��. (�μ� 30�� �־��ش�.)
    }

    // Update is called once per frame
    void Update()
    {   //UI�� ������Ʈ�� ���
        player01HP.text = "player 01 Hp : " + player_01.GetHp().ToString();        //GetHp() �Լ��� ȣ���ϰ� ToString���� ���ڿ��� ��ȯ
        player02HP.text = "player 02 Hp : " + player_02.GetHp().ToString();        //GetHp() �Լ��� ȣ���ϰ� ToString���� ���ڿ��� ��ȯ

        if(Input.GetMouseButtonDown(0))            //���� ���콺�� ��������
        {
            player_01.Damage(1);                   //Player_01�� ��ü�� �Լ� Damage�� ���� (�Ƕ���ͷδ� 1�� ����)
        }

        if (Input.GetMouseButtonDown(1))            //������ ���콺�� ��������
        {
            player_02.Damage(1);                    //Player_02�� ��ü�� �Լ� Damage�� ���� (�Ƕ���ͷδ� 1�� ����)
        }
    }
}
