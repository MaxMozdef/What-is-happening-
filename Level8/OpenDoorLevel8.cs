public class OpenDoorLevel8 : OpenDoor
{
    //on door
    public void OpenDoorAtLevelEight()
    {
        if (SwitchingDigits.simpleNumbersLeft == 2 && SwitchingDigits.simpleNumbersCentr == 7 && SwitchingDigits.simpleNumbersRight == 8)
        {
            openOrCloseDoor = true;
            OpenTheDoor();
        }
    }
}
