using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchingDigits : MonoBehaviour
{
    //on canvas/block of numbers
    [SerializeField] private TextMeshProUGUI numberInButtonLeft, numberInButtonCentr, numberInButtonRight;
    public static byte simpleNumbersLeft, simpleNumbersCentr, simpleNumbersRight = 0;

    public void LeftSelectNumbers()
    {
        simpleNumbersLeft++;
        if (simpleNumbersLeft > 9)
        {
            simpleNumbersLeft = 0;
        }
        numberInButtonLeft.text = simpleNumbersLeft.ToString();
    }
    public void CentrSelectNumbers()
    {
        simpleNumbersCentr++;
        if (simpleNumbersCentr > 9)
        {
            simpleNumbersCentr = 0;
        }
        numberInButtonCentr.text = simpleNumbersCentr.ToString();
    }
    public void RightSelectNumbers()
    {
        simpleNumbersRight++;
        if (simpleNumbersRight > 9)
        {
            simpleNumbersRight = 0;
        }
        numberInButtonRight.text = simpleNumbersRight.ToString();
    }
}
