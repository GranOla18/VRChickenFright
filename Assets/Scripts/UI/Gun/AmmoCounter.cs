using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public TMP_Text text;
    public GameManager gameManager;

    void Update()
    {
        text.text = gameManager.bullets.ToString();
    }
}
