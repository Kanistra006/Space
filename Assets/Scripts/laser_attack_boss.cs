using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_attack_boss : MonoBehaviour
{
    public GameObject laserPrefab; // Префаб лазера
    public float laserDuration = 5f; // Длительность лазера (в секундах)
     // Длительность движения в одной половине (в секундах)
     // Скорость движения босса
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
        // Создаем экземпляр лазера и делаем его дочерним объектом босса
        laserInstance = Instantiate(laserPrefab, firePoint.position, Quaternion.identity);
        laserInstance.transform.parent = firePoint.transform;
    }

    void StartLaser()
    {
        laserInstance.SetActive(true); // Активируем лазер
        laserTimer = laserDuration;
    }

    void StopLaser()
    {
        laserInstance.SetActive(false); // Деактивируем лазер
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
