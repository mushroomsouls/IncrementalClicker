using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    private ClickerScript levelCheck;
    [SerializeField] private GameObject Brigand;
    [SerializeField] private GameObject lynSprite, eliwoodSprite, hectorSprite, sueSprite, roySprite, lilinaSprite, eirikaSprite, ephraimSpite; 
    [SerializeField] private GameObject lynMapSprite, eliwoodMapSprite, hectorMapSprite, sueMapSprite, royMapSprite, lilinaMapSprite, eirikaMapSprite, ephraimMapSpite; 

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
            // And turn her map sprite into black, otherwise...
            lynMapSprite.GetComponent<Renderer>().material.color = Color.black; 
        }
        else
        {
            // Show her sprite.
            lynSprite.SetActive(true);
            // And turn her map sprite back into white.
            lynMapSprite.GetComponent<Renderer>().material.color = Color.white;
        }

        if (levelCheck.eliwoodUpgradeLevel <= 0)
        {
            eliwoodSprite.SetActive(false);
            eliwoodMapSprite.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            eliwoodSprite.SetActive(true);
            eliwoodMapSprite.GetComponent<Renderer>().material.color = Color.white;
        }

        if (levelCheck.hectorUpgradeLevel <= 0)
        {
            hectorSprite.SetActive(false);
            hectorMapSprite.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            hectorSprite.SetActive(true);
            hectorMapSprite.GetComponent<Renderer>().material.color = Color.white;
        }

        if (levelCheck.sueUpgradeLevel <= 0)
        {
            sueSprite.SetActive(false);
            sueMapSprite.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            sueSprite.SetActive(true);
            sueMapSprite.GetComponent<Renderer>().material.color = Color.white;
        }

        if (levelCheck.royUpgradeLevel <= 0)
        {
            roySprite.SetActive(false);
            royMapSprite.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            roySprite.SetActive(true);
            royMapSprite.GetComponent<Renderer>().material.color = Color.white;
        }

        if (levelCheck.lilinaUpgradeLevel <= 0)
        {
            lilinaSprite.SetActive(false);
            lilinaMapSprite.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            lilinaSprite.SetActive(true);
            lilinaMapSprite.GetComponent<Renderer>().material.color = Color.white;
        }

        if (levelCheck.eirikaUpgradeLevel <= 0)
        {
            eirikaSprite.SetActive(false);
            eirikaMapSprite.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            eirikaSprite.SetActive(true);
            eirikaMapSprite.GetComponent<Renderer>().material.color = Color.white;
        }

        if (levelCheck.ephraimUpgradeLevel <= 0)
        {
            ephraimSpite.SetActive(false);
            ephraimMapSpite.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            ephraimSpite.SetActive(true);
            ephraimMapSpite.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
