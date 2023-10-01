using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public Text text;
    public GameManager gameManager;

    void Update()
    {
        text.text = gameManager.bullets.ToString();
    }
}
