using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealBag : MonoBehaviour
{
    public float speed;
    public int healPower = 1;
    public PlayerHealth player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }
    private void Update()
    {
        transform.position += new Vector3(0, -1f) * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (player != null)
            {
                player.Heal(healPower);
            }
            Destroy(gameObject);
        }


    }
}
