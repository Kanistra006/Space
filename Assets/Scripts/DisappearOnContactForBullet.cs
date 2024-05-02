using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnContactForBullet : MonoBehaviour
{
    float lifeTimer = 0.83f; //��������� ��� ������ �������� �� �����
    void OnTriggerEnter2D(Collider2D other)
    {
        
        // ���������, ������������� �� ������, � ������� ��������� ������������, ������������� �������
        if (other.gameObject.tag == "Enemy") // ���������, ��� � ������� ������ ���� ��� "Player"
        {
            Destroy(gameObject); // ���������� ���� ������
        }
    }
    void Update()
    {
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0) { Destroy(gameObject); }
    
    }

}
