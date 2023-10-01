using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour, IDamage
{
    [SerializeField] private int health;
    [SerializeField] private int damageReceived;
    [SerializeField] private Animator enemyAnimator;
    [SerializeField] private EnemyAI enemyAI;

    // Start is called before the first frame update
    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        enemyAI = GetComponent<EnemyAI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage()
    {
        if (health > 1)
        {
            health -= damageReceived;
            Debug.Log("Enemy Damaged");
        }
        else if(health <= 1)
        {
            //Win
            health = 0;
            Debug.Log("Enemy Morido");
            enemyAI.enabled = false;
            //this.gameObject.SetActive(false);
            enemyAnimator.SetBool("Walk", false);
            enemyAnimator.SetBool("Run", false);
            enemyAnimator.SetBool("Turn Head", true);
        }
    }
}
