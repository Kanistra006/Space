using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Image healthBarImage;  // ������ �� ��������� Image
    public Sprite[] healthBarSprites;  // ������ �������� ��� ������� ������ ��������

    private int maxHealth = 5;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void SetHealth(int health)
    {
        currentHealth = Mathf.Clamp(health, 0, maxHealth);  // ������������ �������� �������� �� 0 �� maxHealth
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        if (currentHealth >= 0 && currentHealth < healthBarSprites.Length)
        {
            healthBarImage.sprite = healthBarSprites[currentHealth];
        }
    }
}

