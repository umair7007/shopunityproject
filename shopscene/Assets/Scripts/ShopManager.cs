using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text cointext;
    int amount=50;
   
    private void Start()
    {
       PlayerPrefs.SetInt("Amount", amount); // seting amount 
    }
    private void Update()
    {
     cointext.text = PlayerPrefs.GetInt("Amount").ToString();// sending to text ui
        
    }
}
