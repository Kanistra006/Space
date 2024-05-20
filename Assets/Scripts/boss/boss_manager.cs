using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class boss_manager : MonoBehaviour
{
    public rocket_attack_boss Rocket_Attack_Boss;
    public bomb_attack_boss Bomb_Attack_Boss;
    public laser_attack_boss laser_Attack_Boss;
    public float delayTime;
    public float attack_cd;
    private bool isAttack = false;
    private int randomizer;
    private float timer;
    
    
    private void Start()
    {
        Rocket_Attack_Boss.enabled = false;
        Bomb_Attack_Boss.enabled =  false;
        laser_Attack_Boss.enabled = false;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delayTime && isAttack != true)
        {
            randomizer = Random.Range(1, 4);
            switch (randomizer)
            {
                case 1:
                    strt_attack1();
                    
                    break;
                case 2:
                    strt_attack2();
                    
                    break;
                case 3:
                    strt_attack3();
                    
                    break;
                default:
                    break;

            }
            timer = 0f;
        }

    }


    private void strt_attack1()
    {
        isAttack = true;
        Rocket_Attack_Boss.enabled = true;
        Invoke("endAttack1", 7.0f);
    }
    private void strt_attack2()
    {
        isAttack = true;
        Bomb_Attack_Boss.enabled = true;
        Invoke("endAttack2", 5.0f);
    }
    private void strt_attack3()
    {
        isAttack = true;
        laser_Attack_Boss.enabled = true;
        Invoke("endAttack3", 15.0f);
    }


    private void endAttack1()
    {
        Rocket_Attack_Boss.enabled = false;
        isAttack = false;
    }
    private void endAttack2()
    {
        Bomb_Attack_Boss.enabled = false;
        isAttack = false;
    }
    private void endAttack3()
    {
        laser_Attack_Boss.enabled = false;
        isAttack = false;
    }
}
