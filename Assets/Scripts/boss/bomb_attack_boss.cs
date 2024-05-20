using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_attack_boss : MonoBehaviour
{
    public GameObject bombPrefab; // Префаб бомбы
    public Transform[] firePoints; // Массив firepoints
    public float fireInterval = 2.5f; // Интервал стрельбы

    private float timeSinceLastFire;

    void Start()
    {
        timeSinceLastFire = fireInterval; // Устанавливаем начальное значение для таймера
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
        // Проходим по всем firepoints и создаем бомбу на каждом из них
        foreach (Transform firePoint in firePoints)
        {
            Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
