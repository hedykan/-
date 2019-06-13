using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UniArt.PixelScifiLandscape.Sample
{
    [AddComponentMenu("UniArt/PixelScifiLandscape/Sample/Enemy/EnemyAttack")]

    public class EnemyAttack : MonoBehaviour
    {
        public float timeBetweenAttacks = 0.5f; //每一次进攻的间隔时间
        //public int attackDamage = 10;   //每一次攻击造成的伤害


        Animator anim;
        GameObject player;
        //PlayerHealth playerHealth;
        //EnemyHealth enemyHealth;    //EnemyHealth的脚本引用
        bool playerInRange;
        float timer;

        void Awake ()
        {
           // player = GameObject.FindGameObjectWithTag ("Player");
            //playerHealth = player.GetComponent <PlayerHealth> ();
            //enemyHealth = GetComponent<EnemyHealth>();
            anim = GetComponent <Animator> ();
        }


        void OnTriggerEnter (Collider other)
        {
            /* if(other.gameObject == player)
            {
                playerInRange = true;
            }*/
            if(other.gameObject)
            {
                playerInRange = true;
            }
        }


        void OnTriggerExit (Collider other)
        {
            /* if(other.gameObject == player)
            {
                playerInRange = false;
            }*/
            if(other.gameObject)
            {
                playerInRange = false;
            }
        }


        void Update ()
        {
            timer += Time.deltaTime;

            if(timer >= timeBetweenAttacks && playerInRange /* && enemyHealth.currentHealth > 0*/)
            {
                Attack ();
            }

            /* if(playerHealth.currentHealth <= 0)
            {
                anim.SetTrigger ("PlayerDead");  //玩家从move -> idle
            }*/
        }


        void Attack ()
        {
            timer = 0f;

            /* if(playerHealth.currentHealth > 0)
            {
                playerHealth.TakeDamage (attackDamage);
            }*/
        }
    }
}


