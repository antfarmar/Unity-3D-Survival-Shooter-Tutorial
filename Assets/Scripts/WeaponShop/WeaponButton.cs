using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WeaponButton : MonoBehaviour
{

    public PlayerShooting playerShooting;
    public int weaponNumber;

    public Text weaponName;
    public Text cost;
    public Text description;

    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        SetButton();
    }

    void SetButton()
    {
        string costString = playerShooting.weapons[weaponNumber].cost.ToString();
        weaponName.text = playerShooting.weapons[weaponNumber].weaponName;
        cost.text = "$" + playerShooting.weapons[weaponNumber].cost;
        description.text = playerShooting.weapons[weaponNumber].description;
    }

    public void OnClick()
    {
        if (ScoreManager.score >= playerShooting.weapons[weaponNumber].cost)
        {

            ScoreManager.score -= playerShooting.weapons[weaponNumber].cost;
            playerShooting.currentWeapon = weaponNumber;

        }
        else
        {
            source.Play();
        }
    }

}

