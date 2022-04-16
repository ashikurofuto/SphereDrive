using UnityEngine;

public class TimeControl 
{

    public void StopTime()
    {
        Time.timeScale = 0;
    }

    public void ReturnTime()
    {
        Time.timeScale = 1;
    }


}
