using UnityEngine;

public class DisappearOnContact : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        
        // ���������, ������������� �� ������, � ������� ��������� ������������, ������������� �������
        if (other.gameObject.tag == "Player") // ���������, ��� � ������� ������ ���� ��� "Player"
        {
            Destroy(gameObject); // ���������� ���� ������
            GameManager.score += 1;
            Debug.Log("score = " + GameManager.score);
        }
    }
}

