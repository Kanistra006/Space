using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public Image healthBarImage;
    public Sprite[] healthBarSprites;
    // Update is called once per frame
    void Update()
    {
        healthBarImage.sprite = healthBarSprites[PlayerHealth.currentHealth];
    }
}
