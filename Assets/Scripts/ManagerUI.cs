﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerUI : MonoBehaviour
{

    public TextMeshProUGUI txtPrecio; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void UpdateMoneyUI(string moneyAmount)
    {
        txtPrecio.text = moneyAmount;
    }
}
