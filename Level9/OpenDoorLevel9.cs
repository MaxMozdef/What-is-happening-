public class OpenDoorLevel9 : OpenDoor
{
    //on door
    public void OpenDoorAtLevelNine()
    {
        if (SwitchingDigits.simpleNumbersLeft == 1 && SwitchingDigits.simpleNumbersCentr == 9 
            && SwitchingDigits.simpleNumbersRight == 8 && SwitchingDigits.simpleNumbersLast == 6)
        {
            openOrCloseDoor = true;
            OpenTheDoor();
        }
    }
}
