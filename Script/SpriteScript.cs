using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteScript : MonoBehaviour
{
    private ClickerScript levelCheck;
    [SerializeField] private GameObject Brigand;
    [SerializeField] private GameObject lynSprite, eliwoodSprite, hectorSprite, sueSprite, roySprite, lilinaSprite, eirikaSprite, ephraimSpite; 

    void Start()
    {
        // levelCheck is used to the check the levels made in ClickerScript.
        levelCheck = Brigand.GetComponent<ClickerScript>();
    }

    void Update()
    {
        // If Lyn's level is 0 or less...
        if (levelCheck.lynUpgradeLevel <= 0)
        {
            // Hide her sprite.
            lynSprite.SetActive(false);
        }
        else
        {
            // Show her sprite.
            lynSprite.SetActive(true);
        }

        if (levelCheck.eliwoodUpgradeLevel <= 0)
        {
            eliwoodSprite.SetActive(false);
        }
        else
        {
            eliwoodSprite.SetActive(true);
        }

        if (levelCheck.hectorUpgradeLevel <= 0)
        {
            hectorSprite.SetActive(false);
        }
        else
        {
            hectorSprite.SetActive(true);
        }

        if (levelCheck.sueUpgradeLevel <= 0)
        {
            sueSprite.SetActive(false);
        }
        else
        {
            sueSprite.SetActive(true);
        }

        if (levelCheck.royUpgradeLevel <= 0)
        {
            roySprite.SetActive(false);
        }
        else
        {
            roySprite.SetActive(true);
        }

        if (levelCheck.lilinaUpgradeLevel <= 0)
        {
            lilinaSprite.SetActive(false);
        }
        else
        {
            lilinaSprite.SetActive(true);
        }

        if (levelCheck.eirikaUpgradeLevel <= 0)
        {
            eirikaSprite.SetActive(false);
        }
        else
        {
            eirikaSprite.SetActive(true);
        }

        if (levelCheck.ephraimUpgradeLevel <= 0)
        {
            ephraimSpite.SetActive(false);
        }
        else
        {
            ephraimSpite.SetActive(true);
        }
    }
}
