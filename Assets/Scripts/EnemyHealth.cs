using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3; // ������������ �������� �����
    private int currentHealth; // ������� �������� �����

   
    void Start()
    {
        currentHealth = maxHealth; // ��������� �������� ��� �������� �����
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        // ���������, ������������� �� ������, � ������� ��������� ������������, ������������� �������
        if (other.gameObject.tag == "PlayerBullet") // ���������, ��� � ������� ������ ���� ��� "Player"
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
        // ����� ����� �������� ������ ��� �������� ������, ����� � �.�.
    }
}
