using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public TMP_Text text;

    void Update()
    {
        text.text = GameManager.instance.bullets.ToString();
    }
}
