using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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

    public int bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = 10;
    }

    public void Shoot()
    {
        bullets--;
    }

}
