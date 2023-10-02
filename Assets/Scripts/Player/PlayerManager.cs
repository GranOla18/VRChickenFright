using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour, IDamage
{
    public static PlayerManager instance;
    [SerializeField] private int health;
    [SerializeField] private int damageReceived;

    #region Singleton
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    public void Damage()
    {
        if(health > 1)
        {
            SFXController.instance.ReproduceSFX(7);
            health -= damageReceived;
            Debug.Log("Player Damaged");
        }
        else
        {
            //Game Over
            health = 0;
            Debug.Log("Player Morido");
            GameManager.instance.GameOver();
        }

    }
}


