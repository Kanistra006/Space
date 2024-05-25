using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5; // ������������ �������� �����
    public int currentHealth; // ������� �������� �����
    int healthWasBefore;
    bool isUltimateActive = false;

    private Coroutine damageCoroutine;

    void Start()
    {
        currentHealth = maxHealth; // ��������� �������� ��� �������� �����
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        // ���������, ������������� �� ������, � ������� ��������� ������������, ������������� �������
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet") // ���������, ��� � ������� ������ ���� ��� "Player"
        {
            TakeDamage(1);

        }
        else if (other.gameObject.tag == "BossLaser")
        {
            if (damageCoroutine == null) // ���������, �������� �� ��� ��������
            {
                damageCoroutine = StartCoroutine(DamageOverTime(1, other));
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "BossLaser")
        {
            if (damageCoroutine != null) // ���������, �������� �� ��������
            {
                StopCoroutine(damageCoroutine);
                damageCoroutine = null; // ���������� ������ �� ��������
            }
        }
    }


    IEnumerator DamageOverTime(int damage, Collider2D other)
    {
        while (true)
        {
            TakeDamage(damage);
            yield return new WaitForSeconds(1f);
        }
    }
    public void TakeDamage(int damage)
    {
        if (isUltimateActive)
        {
            damage = 0;
        }
        else currentHealth -= damage; // ��������� �������� �� �������� ����������� �����

        if (currentHealth <= 0)
        {
            Die(); // ������� ������, ���� �������� ��������� �� 0 ��� ����
        }
    }



    public void Heal(int healPower)
    {
        currentHealth = Mathf.Min(maxHealth, currentHealth + healPower);
    }

    private void Die()
    {
        Destroy(gameObject); // ���������� ������ �����
        SceneManager.LoadScene("StartScene");
        // ����� ����� �������� ������ ��� �������� ������, ����� � �.�.
    }
    public void Ultimate()
    {
        isUltimateActive = true;
    }
    public void UltimateOver()
    {
        isUltimateActive = false;
    }
}
