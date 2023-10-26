using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private int maxAmmo;
    [SerializeField] private int currentAmmo;
    [SerializeField] private Text ammoText;

    void Start()
    {
        //currentAmmo = maxAmmo; //sets current to max
        UpdateUI();
    }

    private void UpdateUI()
    {
        ammoText.text = "The ammo: " + currentAmmo + "/" + maxAmmo;
    }

    public void AddAmmo(int addAmmo)
    {
        // adds the addAmmo int to the current ammo count and displays it
        currentAmmo += addAmmo;

        if(currentAmmo > maxAmmo) //if the current is more than the max, it sets it to max
        {
            currentAmmo = maxAmmo;
            UpdateUI();
        }

        UpdateUI();
    }


}
