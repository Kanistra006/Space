using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    float bulletSpeed = 20.0f;
    float shootingRate = 0.2f;
    float shootingCooldown;


    // Update is called once per frame
    void Update()
    {
        shootingCooldown -= Time.deltaTime;

        if (shootingCooldown <= 0 && Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
            shootingCooldown = shootingRate;
        }
    }
    public void Ultimate()
    {
        shootingRate = 0.01f;
    }
    public void UltimateOver()
    {
        shootingRate = 0.02f;
    }

    void Shoot()
    {
        // ������ ����� ������� ������� � �������� ������� � � �������� �����������
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // ����������� ������� �������� � �����������, ��������� �� ���������� �������, � �������� ��������� ������
        bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }
}
