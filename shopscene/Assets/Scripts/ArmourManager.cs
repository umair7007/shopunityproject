using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourManager : MonoBehaviour
{
   
    [SerializeField]
    Animator playeranimator; 
    [SerializeField]
    RuntimeAnimatorController[] playerarmour;
    int coins;
    public GameObject errorMessage;
    [SerializeField]
    GameObject goldEquip;
    [SerializeField]
    GameObject redEquip;
    //goldequi and red equip for enabling equip buttons
    private void Start()
    {     
        playeranimator = gameObject.GetComponent<Animator>();
        coins = PlayerPrefs.GetInt("Amount");
    }

    #region public functions
    public void Goldarmour()
    {
      if (coins >= 20)
        {
          coins =coins-20;
          PlayerPrefs.SetInt("Amount", coins);// updating amount value
           goldEquip.SetActive(true);// activating equip button for armour 
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void Redarmour()
    {
        if (coins >= 40)
        {
            coins = coins - 40;
            PlayerPrefs.SetInt("Amount", coins);// updating amount value
            redEquip.SetActive(true);
        }
        else
        {
            errorMessage.SetActive(true);//ui text
        }
    }

    public void GoldEquip()
    {
        playeranimator.runtimeAnimatorController = playerarmour[0];// chnaging the animator controller for gold animations
    }
    public void RedEquip()
    {
        playeranimator.runtimeAnimatorController = playerarmour[1];
    }
    #endregion
}
