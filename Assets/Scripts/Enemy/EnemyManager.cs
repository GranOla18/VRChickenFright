using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnemyManager : MonoBehaviour, IDamage
{
    [SerializeField] private int health;
    [SerializeField] private int damageReceived;
    [SerializeField] private Animator enemyAnimator;
    [SerializeField] private EnemyAI enemyAI;
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private AudioClip damagedSFX;
    [SerializeField] private AudioClip deathSFX;

    // Start is called before the first frame update
    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        enemyAI = GetComponent<EnemyAI>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage()
    {
        audiosource.loop = false;

        if (health > 1)
        {
            //SFXController.instance.ReproduceSFX(6);
            audiosource.PlayOneShot(damagedSFX);
            health -= damageReceived;
            Debug.Log("Enemy Damaged");
        }
        else if(health <= 1)
        {
            //Win
            health = 0;
            //SFXController.instance.ReproduceSFX(7);
            audiosource.PlayOneShot(deathSFX);

            Debug.Log("Enemy Morido");
            enemyAI.enabled = false;
            //this.gameObject.SetActive(false);
            enemyAnimator.SetBool("Walk", false);
            enemyAnimator.SetBool("Run", false);
            enemyAnimator.SetBool("Turn Head", true);
            GameManager.instance.Win();
        }
    }
}
