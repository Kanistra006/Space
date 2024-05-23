using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_attack_boss : MonoBehaviour
{
    public GameObject laserPrefab; // ������ ������
    public float laserDuration = 5f; // ������������ ������ (� ��������)
     // ������������ �������� � ����� �������� (� ��������)
     // �������� �������� �����
    public Transform firePoint;
    private float laserTimer;
    
    
    private bool isMoving = false;
    private GameObject laserInstance;

    void Start()
    {
        CreateLaser();
        StartLaser();
        
    }

    void Update()
    {
        HandleLaser();
        
    }

    void CreateLaser()
    {
        // ������� ��������� ������ � ������ ��� �������� �������� �����
        laserInstance = Instantiate(laserPrefab, firePoint.position, Quaternion.identity);
        laserInstance.transform.parent = firePoint.transform;
    }

    void StartLaser()
    {
        laserInstance.SetActive(true); // ���������� �����
        laserTimer = laserDuration;
    }

    void StopLaser()
    {
        laserInstance.SetActive(false); // ������������ �����
        laserTimer = laserDuration;
    }



    void HandleLaser()
    {
        laserTimer -= Time.deltaTime;
        if (laserTimer <= 0)
        {
            if (laserInstance.activeSelf)
            {
                StopLaser();
            }
            else
            {
                StartLaser();
            }
        }
    }
}
