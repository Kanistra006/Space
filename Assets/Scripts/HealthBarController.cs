using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Image healthBarImage;  // Ссылка на компонент Image
    public Sprite[] healthBarSprites;  // Массив спрайтов для каждого уровня здоровья

    private int maxHealth = 5;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void SetHealth(int health)
    {
        currentHealth = Mathf.Clamp(health, 0, maxHealth);  // Ограничиваем значение здоровья от 0 до maxHealth
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

