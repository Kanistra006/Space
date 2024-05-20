using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5; // Максимальное здоровье игрока
    public int currentHealth; // Текущее здоровье игрока


    void Start()
    {
        currentHealth = maxHealth; // Начальное здоровье при создании игрока
    }
   
        
    void OnTriggerEnter2D(Collider2D other)
    {

        // Проверяем, соответствует ли объект, с которым произошло столкновение, определенному условию
        if (other.gameObject.tag == "Enemy") // Убедитесь, что у объекта игрока есть тег "Enemy"
        {
            TakeDamage(1);

        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Уменьшаем здоровье на величину полученного урона
        if (currentHealth <= 0)
        {
            Die(); // Функция смерти, если здоровье опустится до 0 или ниже
        }
    }
    public void Heal(int healPower)
    {
        currentHealth = Mathf.Min(maxHealth, currentHealth + healPower);
    }

    private void Die()
    {
        Destroy(gameObject); // Уничтожаем объект врага
        SceneManager.LoadScene("StartScene");
        // Здесь можно добавить логику для анимации смерти, очков и т.д.
    }
}
