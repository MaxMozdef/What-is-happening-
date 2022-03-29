using TMPro;
using UnityEngine;

public class SwitchingDigits : MonoBehaviour
{
    //on canvas/block of numbers
    [SerializeField] private TextMeshProUGUI numberInButtonLeft, numberInButtonCentr, numberInButtonRight, numberInButtonLast;
    public static byte simpleNumbersLeft, simpleNumbersCentr, simpleNumbersRight, simpleNumbersLast;

    private void Start()
    {
        simpleNumbersLeft = 0;
        simpleNumbersCentr = 0;
        simpleNumbersRight = 0; 
        simpleNumbersLast = 0;
    }
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
    public void LastSelectNumbers()
    {
        simpleNumbersLast++;
        if (simpleNumbersLast > 9)
        {
            simpleNumbersLast = 0;
        }
        numberInButtonLast.text = simpleNumbersLast.ToString();
    }
}
