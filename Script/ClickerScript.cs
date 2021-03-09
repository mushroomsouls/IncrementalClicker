using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerScript : MonoBehaviour
{

    [SerializeField] public Text scoreText;
    [SerializeField] private float scoreAmount = 0f;
    private float scoreUpgradeIncrease;

    private int firstUpgradeCost = 15;
    private int firstUpgradeCostIncrease;
    [SerializeField] public Text firstUpgradeText;

    private int secondUpgradeCost = 100;
    private int secondUpgradeCostIncrease;
    [SerializeField] public Text secondUpgradeText;

    private int thirdUpgradeCost = 500;
    private int thirdUpgradeCostIncrease;
    [SerializeField] public Text thirdUpgradeText;

    private int fourthUpgradeCost = 3000;
    private int fourthUpgradeCostIncrease;
    [SerializeField] public Text fourthUpgradeText;

    private int fifthUpgradeCost = 10000;
    private int fifthUpgradeCostIncrease;
    [SerializeField] public Text fifthUpgradeText;

    private int sixthUpgradeCost = 40000;
    private int sixthUpgradeCostIncrease;
    [SerializeField] public Text sixthUpgradeText;

    private int seventhUpgradeCost = 200000;
    private int seventhUpgradeCostIncrease;
    [SerializeField] public Text seventhUpgradeText;

    private int eighthUpgradeCost = 1666666;
    private int eighthUpgradeCostIncrease;
    [SerializeField] public Text eighthUpgradeText;

    private void Start()
    {
        scoreUpgradeIncrease = 1f;
    }

    void Update()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        firstUpgradeText.text = "1st Upgrade | Cost: " + (firstUpgradeCost);
        secondUpgradeText.text = "2nd Upgrade | Cost: " + (secondUpgradeCost);
        thirdUpgradeText.text = "3rd Upgrade | Cost: " + (thirdUpgradeCost);
        fourthUpgradeText.text = "4th Upgrade | Cost: " + (fourthUpgradeCost);
        fifthUpgradeText.text = "5th Upgrade | Cost: " + (fifthUpgradeCost);
        sixthUpgradeText.text = "6th Upgrade | Cost: " + (sixthUpgradeCost);
        seventhUpgradeText.text = "7th Upgrade | Cost: " + (seventhUpgradeCost);
        eighthUpgradeText.text = "8th Upgrade | Cost: " + (eighthUpgradeCost);

        scoreAmount += scoreUpgradeIncrease * (Time.deltaTime * 1);
    }

    void OnMouseDown()
    {
        scoreAmount = scoreAmount + scoreUpgradeIncrease;
    }
    public void RaiseStat(int value)
    {
        switch (value)
        {
            case 1:
                if (scoreAmount >= firstUpgradeCost)
                {
                    scoreAmount = scoreAmount - firstUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 0.1f;

                    firstUpgradeCostIncrease = (int)(firstUpgradeCost * 1.15);
                    firstUpgradeCost = firstUpgradeCostIncrease;
                }
                break;

            case 2:
                if (scoreAmount >= secondUpgradeCost)
                {
                    scoreAmount = scoreAmount - secondUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 0.5f;

                    secondUpgradeCostIncrease = (int)(secondUpgradeCost * 1.15);
                    secondUpgradeCost = secondUpgradeCostIncrease;
                }
                break;

            case 3:
                if (scoreAmount >= thirdUpgradeCost)
                {
                    scoreAmount = scoreAmount - thirdUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 4;

                    thirdUpgradeCostIncrease = (int)(thirdUpgradeCost * 1.15);
                    thirdUpgradeCost = thirdUpgradeCostIncrease;
                }
                break;

            case 4:
                if (scoreAmount >= fourthUpgradeCost)
                {
                    scoreAmount = scoreAmount - fourthUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 10;

                    fourthUpgradeCostIncrease = (int)(fourthUpgradeCost * 1.15);
                    fourthUpgradeCost = fourthUpgradeCostIncrease;
                }
                break;

            case 5:
                if (scoreAmount >= fifthUpgradeCost)
                {
                    scoreAmount = scoreAmount - fifthUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 40;

                    fifthUpgradeCostIncrease = (int)(fifthUpgradeCost * 1.15);
                    fifthUpgradeCost = fifthUpgradeCostIncrease;
                }
                break;

            case 6:
                if (scoreAmount >= sixthUpgradeCost)
                {
                    scoreAmount = scoreAmount - sixthUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 100;

                    sixthUpgradeCostIncrease = (int)(sixthUpgradeCost * 1.15);
                    sixthUpgradeCost = sixthUpgradeCostIncrease;
                }
                break;

            case 7:
                if (scoreAmount >= seventhUpgradeCost)
                {
                    scoreAmount = scoreAmount - seventhUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 400;

                    seventhUpgradeCostIncrease = (int)(seventhUpgradeCost * 1.15);
                    seventhUpgradeCost = seventhUpgradeCostIncrease;
                }
                break;

            case 8:
                if (scoreAmount >= eighthUpgradeCost)
                {
                    scoreAmount = scoreAmount - eighthUpgradeCost;
                    scoreUpgradeIncrease = scoreUpgradeIncrease + 6666;

                    eighthUpgradeCostIncrease = (int)(eighthUpgradeCost * 1.15);
                    eighthUpgradeCost = eighthUpgradeCostIncrease;
                }
                break;
        }
    }
}