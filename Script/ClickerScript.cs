using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerScript : MonoBehaviour
{
    [SerializeField] private float goldAmount = 0f, goldUpgradeIncrease = 0f;
    private int clickIncrease = 1, lynUpgradeCost = 15, eliwoodUpgradeCost = 100, hectorUpgradeCost = 500, sueUpgradeCost = 3000, royUpgradeCost = 10000, lilinaUpgradeCost = 40000, eirikaUpgradeCost = 200000, ephraimUpgradeCost = 1666666;
    private int lynUpgradeCostIncrease, eliwoodUpgradeCostIncrease, hectorUpgradeCostIncrease, sueUpgradeCostIncrease, royUpgradeCostIncrease, lilinaUpgradeCostIncrease, eirikaUpgradeCostIncrease, ephraimUpgradeCostIncrease;
    public int lynUpgradeLevel = 0, eliwoodUpgradeLevel = 0, hectorUpgradeLevel = 0, sueUpgradeLevel = 0, royUpgradeLevel = 0, lilinaUpgradeLevel = 0, eirikaUpgradeLevel = 0, ephraimUpgradeLevel = 0;
    [SerializeField] private Text lynUpgradeLevelText, eliwoodUpgradeLevelText, hectorUpgradeLevelText, sueUpgradeLevelText, royUpgradeLevelText, lilinaUpgradeLevelText, eirikaUpgradeLevelText, ephraimUpgradeLevelText;
    [SerializeField] private Text goldText, goldPerSecond, lynUpgradeText, eliwoodUpgradeText, hectorUpgradeText, sueUpgradeText, royUpgradeText, lilinaUpgradeText, eirikaUpgradeText, ephraimUpgradeText;
    [SerializeField] private Button lynUpgradeButton, eliwoodUpgradeButton, hectorUpgradeButton, sueUpgradeButton, royUpgradeButton, lilinaUpgradeButton, eirikaUpgradeButton, ephraimUpgradeButton;

    private void Start()
    {
        StartCoroutine(goldIncreasePerSecond());
    }

    private IEnumerator goldIncreasePerSecond()
    {
        while (goldUpgradeIncrease >= 0)
        {
            // Increases the amount of gold using a variable that is increased from purchasing upgrades.
            // Also acts as a idle increase to the amount of gold every eliwood.
            yield return new WaitForSeconds(1f);
            goldAmount += goldUpgradeIncrease;
        }
    }

    void Update()
    {
        // Updates the gold text to show much gold the player has.
        goldText.text = "G: " + (int)goldAmount;

        // Rounds down the Gold Per Sec to one decimal point.
        goldUpgradeIncrease = Mathf.Round(goldUpgradeIncrease * 10.0f) * 0.1f;
        
        // Updates everytime a character is purchased, and shows how much gold the player is getting each second.
        goldPerSecond.text = "Gold Per Sec: " + goldUpgradeIncrease;

        // Updates the button's text whenever the cost is updated during the switch function...
        // So the player knows what gold they need to reach to purchase the upgrade.
        lynUpgradeText.text = "Lyn | Cost: " + (lynUpgradeCost);
        eliwoodUpgradeText.text = "Eliwood | Cost: " + (eliwoodUpgradeCost);
        hectorUpgradeText.text = "Hector | Cost: " + (hectorUpgradeCost);
        sueUpgradeText.text = "Sue | Cost: " + (sueUpgradeCost);
        royUpgradeText.text = "Roy | Cost: " + (royUpgradeCost);
        lilinaUpgradeText.text = "Lilina | Cost: " + (lilinaUpgradeCost);
        eirikaUpgradeText.text = "Eirika | Cost: " + (eirikaUpgradeCost);
        ephraimUpgradeText.text = "Ephraim | Cost: " + (ephraimUpgradeCost);

        // Checks whether the player has enough gold to buy Lyn or not...
        if (goldAmount >= lynUpgradeCost)
{
            // If true, the Lyn button becomes interactable.
            lynUpgradeButton.interactable = true;
        }
        else
        {
            // If false, the Lyn button becomes uninteractable until the player has enough gold to purchase the upgrade.
            lynUpgradeButton.interactable = false;
        }

        // too many if statements oh my goddddd
        if (goldAmount >= eliwoodUpgradeCost)
        {
            eliwoodUpgradeButton.interactable = true;
        }
        else
        {
            eliwoodUpgradeButton.interactable = false;
        }

        if (goldAmount >= hectorUpgradeCost)
        {
            hectorUpgradeButton.interactable = true;
        }
        else
        {
            hectorUpgradeButton.interactable = false;
        }

        if (goldAmount >= sueUpgradeCost)
        {
            sueUpgradeButton.interactable = true;
        }
        else
        {
            sueUpgradeButton.interactable = false;
        }

        if (goldAmount >= royUpgradeCost)
        {
            royUpgradeButton.interactable = true;
        }
        else
        {
            royUpgradeButton.interactable = false;
        }

        if (goldAmount >= lilinaUpgradeCost)
        {
            lilinaUpgradeButton.interactable = true;
        }
        else
        {
            lilinaUpgradeButton.interactable = false;
        }

        if (goldAmount >= eirikaUpgradeCost)
        {
            eirikaUpgradeButton.interactable = true;
        }
        else
        {
            eirikaUpgradeButton.interactable = false;
        }

        if (goldAmount >= ephraimUpgradeCost)
        {
            ephraimUpgradeButton.interactable = true;
        }
        else
        {
            ephraimUpgradeButton.interactable = false;
        }

        // If Lyn's level is 0 (or if it happens, less than 0) then...
        if (lynUpgradeLevel <= 0)
        {
            // Hide the Level text.
            lynUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            // Otherwise show the player the Level of Lyn.
            lynUpgradeLevelText.gameObject.SetActive(true);
        }

        if (eliwoodUpgradeLevel <= 0)
        {
            eliwoodUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            eliwoodUpgradeLevelText.gameObject.SetActive(true);
        }

        if (hectorUpgradeLevel <= 0)
        {
            hectorUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            hectorUpgradeLevelText.gameObject.SetActive(true);
        }

        if (sueUpgradeLevel <= 0)
        {
            sueUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            sueUpgradeLevelText.gameObject.SetActive(true);
        }

        if (royUpgradeLevel <= 0)
        {
            royUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            royUpgradeLevelText.gameObject.SetActive(true);
        }

        if (lilinaUpgradeLevel <= 0)
        {
            lilinaUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            lilinaUpgradeLevelText.gameObject.SetActive(true);
        }

        if (eirikaUpgradeLevel <= 0)
        {
            eirikaUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            eirikaUpgradeLevelText.gameObject.SetActive(true);
        }

        if (ephraimUpgradeLevel <= 0)
        {
            ephraimUpgradeLevelText.gameObject.SetActive(false);
        }
        else
        {
            ephraimUpgradeLevelText.gameObject.SetActive(true);
        }
    }

    // If the mouse pointer is on top of the Brigand...
    void OnMouseDown()
    {
        // Increase the amount of gold the player has gained by clicking.
        goldAmount = goldAmount + clickIncrease;
    }

    public void RaiseStat(int value)
    {
        switch (value)
        {
            case 1:
                // Whenever the button is pressed, if the gold is greater or equal to Lyn's cost...
                if (goldAmount >= lynUpgradeCost)
                {
                    // Subtract the gold via Lyn's cost...
                    goldAmount = goldAmount - lynUpgradeCost;
                    // And increase a variable that is related to GpS (Gold Per Second).
                    goldUpgradeIncrease = goldUpgradeIncrease + 0.1f;

                    // After the purchase is bought, increase the cost by multiplying itself by 15%...
                    lynUpgradeCostIncrease = (int)(lynUpgradeCost * 1.15);
                    // And then update the cost after that is done.
                    lynUpgradeCost = lynUpgradeCostIncrease;

                    // The level will increase by one when bought...
                    lynUpgradeLevel += 1;
                    // Then, its level will update.
                    lynUpgradeLevelText.text = "Level: " + lynUpgradeLevel;
                }
                break;

            case 2:
                if (goldAmount >= eliwoodUpgradeCost)
                {
                    goldAmount = goldAmount - eliwoodUpgradeCost;
                    goldUpgradeIncrease = goldUpgradeIncrease + 0.5f;

                    eliwoodUpgradeCostIncrease = (int)(eliwoodUpgradeCost * 1.15);
                    eliwoodUpgradeCost = eliwoodUpgradeCostIncrease;

                    eliwoodUpgradeLevel += 1;
                    eliwoodUpgradeLevelText.text = "Level: " + eliwoodUpgradeLevel;
                }
                break;

            case 3:
                if (goldAmount >= hectorUpgradeCost)
                {
                    goldAmount = goldAmount - hectorUpgradeCost;
                    goldUpgradeIncrease = goldUpgradeIncrease + 4;

                    hectorUpgradeCostIncrease = (int)(hectorUpgradeCost * 1.15);
                    hectorUpgradeCost = hectorUpgradeCostIncrease;

                    hectorUpgradeLevel += 1;
                    hectorUpgradeLevelText.text = "Level: " + hectorUpgradeLevel;
                }
                break;

            case 4:
                if (goldAmount >= sueUpgradeCost)
                {
                    goldAmount = goldAmount - sueUpgradeCost;
                    goldUpgradeIncrease = goldUpgradeIncrease + 10;

                    sueUpgradeCostIncrease = (int)(sueUpgradeCost * 1.15);
                    sueUpgradeCost = sueUpgradeCostIncrease;

                    sueUpgradeLevel += 1;
                    sueUpgradeLevelText.text = "Level: " + sueUpgradeLevel;
                }
                break;

            case 5:
                if (goldAmount >= royUpgradeCost)
                {
                    goldAmount = goldAmount - royUpgradeCost;
                    goldUpgradeIncrease = goldUpgradeIncrease + 40;

                    royUpgradeCostIncrease = (int)(royUpgradeCost * 1.15);
                    royUpgradeCost = royUpgradeCostIncrease;

                    royUpgradeLevel += 1;
                    royUpgradeLevelText.text = "Level: " + royUpgradeLevel;
                }
                break;

            case 6:
                if (goldAmount >= lilinaUpgradeCost)
                {
                    goldAmount = goldAmount - lilinaUpgradeCost;
                    goldUpgradeIncrease = goldUpgradeIncrease + 100;

                    lilinaUpgradeCostIncrease = (int)(lilinaUpgradeCost * 1.15);
                    lilinaUpgradeCost = lilinaUpgradeCostIncrease;

                    lilinaUpgradeLevel += 1;
                    lilinaUpgradeLevelText.text = "Level: " + lilinaUpgradeLevel;
                }
                break;

            case 7:
                if (goldAmount >= eirikaUpgradeCost)
                {
                    goldAmount = goldAmount - eirikaUpgradeCost;
                    goldUpgradeIncrease = goldUpgradeIncrease + 400;

                    eirikaUpgradeCostIncrease = (int)(eirikaUpgradeCost * 1.15);
                    eirikaUpgradeCost = eirikaUpgradeCostIncrease;

                    eirikaUpgradeLevel += 1;
                    eirikaUpgradeLevelText.text = "Level: " + eirikaUpgradeLevel;
                }
                break;

            case 8:
                if (goldAmount >= ephraimUpgradeCost)
                {
                    goldAmount = goldAmount - ephraimUpgradeCost;
                    goldUpgradeIncrease = goldUpgradeIncrease + 6666;

                    ephraimUpgradeCostIncrease = (int)(ephraimUpgradeCost * 1.15);
                    ephraimUpgradeCost = ephraimUpgradeCostIncrease;

                    ephraimUpgradeLevel += 1;
                    ephraimUpgradeLevelText.text = "Level: " + ephraimUpgradeLevel;
                }
                break;
        }
    }
}
