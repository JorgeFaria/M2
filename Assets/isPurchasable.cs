using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class isPurchasable : MonoBehaviour
{
    private bool bought;
    private bool buyPossible;

    public Text PointsText;
    public int buyPoints;
    public GameObject[] Dependencies;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void BuyItem()
    {
        CheckDependencies();
        if (this.enabled != false && buyPossible == true)
        {
            if (int.Parse(PointsText.text) >= buyPoints)
            {
                this.enabled = true;
                bought = true;
                ColorBuy();
                var valor = int.Parse(PointsText.text);
                PointsText.text = (valor - buyPoints).ToString();
}
        }
    }

    public void CheckDependencies()
    {
        foreach (GameObject dependencie in Dependencies)
        {
            if(dependencie.activeInHierarchy == true)
            {
                buyPossible = true;
            }
        }
    }
    public void ColorBuy()
    {
        if (bought)
        {
            var colors = GetComponent<UnityEngine.UI.Button>().colors;
            colors.normalColor = Color.green;
            GetComponent<UnityEngine.UI.Button>().colors = colors;
        }
        
    }
}



