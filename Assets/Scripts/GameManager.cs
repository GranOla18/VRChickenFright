using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas winCanvas;

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
        SFXController.instance.ReproduceSFX(1);
    }

    public void GameOver()
    {
        //SceneManager.LoadScene(0);
        gameOverCanvas.enabled = true;
    }

    public void Win()
    {
        //SceneManager.LoadScene(0);
        winCanvas.enabled = true;
    }
}
