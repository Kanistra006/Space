using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_attack_boss : MonoBehaviour
{
    public GameObject bombPrefab; // ������ �����
    public Transform[] firePoints; // ������ firepoints
    public float fireInterval = 2.5f; // �������� ��������

    private float timeSinceLastFire;

    void Start()
    {
        timeSinceLastFire = fireInterval; // ������������� ��������� �������� ��� �������
    }

    void Update()
    {
        timeSinceLastFire += Time.time;

        if (timeSinceLastFire >= fireInterval)
        {
            FireBombs();
            timeSinceLastFire = 0f;
        }
    }

    void FireBombs()
    {
        // �������� �� ���� firepoints � ������� ����� �� ������ �� ���
        foreach (Transform firePoint in firePoints)
        {
            Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
