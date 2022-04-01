using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickeableItems : MonoBehaviour
{
    public Weapons weapon;
    public Armors armor;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player" && this.gameObject.tag == "Weapon")
        {
            Inventory.Instance.AddWeapon(weapon);
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag == "Player" && this.gameObject.tag == "Armor")
        {
            Inventory.Instance.AddArmors(armor);
            Destroy(gameObject);

        }
    }
}
