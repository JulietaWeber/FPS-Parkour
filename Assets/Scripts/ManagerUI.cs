using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerUI : MonoBehaviour
{
    public DineroManager dineroManager;
    public MercanciaScript MercanciaScript;
    public TextMeshProUGUI txtPrecio;
    // Start is called before the first frame update
    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dineroManager && txtPrecio)
        {
            txtPrecio.text = "$" + dineroManager.playerMoney.ToString();
        }
        else
        {
            Debug.Log("Ocurrió algo extraño");
        }
    }
}
