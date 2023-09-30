using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour, IDamage
{
    [SerializeField] private int health;
    [SerializeField] private int damageReceived;
    // Start is called before the first frame update
    void Start()
    {
        
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
            this.gameObject.SetActive(false);
        }
    }
}
