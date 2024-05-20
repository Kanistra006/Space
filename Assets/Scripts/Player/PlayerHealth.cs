using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5; // ������������ �������� ������
    public int currentHealth; // ������� �������� ������


    void Start()
    {
        currentHealth = maxHealth; // ��������� �������� ��� �������� ������
    }
   
        
    void OnTriggerEnter2D(Collider2D other)
    {

        // ���������, ������������� �� ������, � ������� ��������� ������������, ������������� �������
        if (other.gameObject.tag == "Enemy") // ���������, ��� � ������� ������ ���� ��� "Enemy"
        {
            TakeDamage(1);

        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // ��������� �������� �� �������� ����������� �����
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
}
