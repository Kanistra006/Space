using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MommySpaceship : MonoBehaviour
{
    public int maxHealth = 5; // ������������ �������� �����
    private int currentHealth; // ������� �������� �����


    void Start()
    {
        currentHealth = maxHealth; // ��������� �������� ��� �������� �����
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        // ���������, ������������� �� ������, � ������� ��������� ������������, ������������� �������
        if (other.gameObject.tag == "Enemy") // ���������, ��� � ������� ������ ���� ��� "Player"
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

    private void Die()
    {
        Destroy(gameObject); // ���������� ������ �����
        SceneManager.LoadScene("StartScene");
        // ����� ����� �������� ������ ��� �������� ������, ����� � �.�.
    }
}
