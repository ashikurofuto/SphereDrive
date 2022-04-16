using UnityEngine;

public class SaveScore
{
    public void SaveRecord(int hours, int minutes, int seconds)
    {
        PlayerPrefs.SetInt("Hours", hours);
        PlayerPrefs.SetInt("Minutes", minutes);
        PlayerPrefs.SetInt("Seconds", seconds);
    }

    public int LoadHours()
    {
        return PlayerPrefs.GetInt("Hours");
    }
    public int LoadMinutes()
    {
        return PlayerPrefs.GetInt("Minutes");
    }
    public int LoadSeconds()
    {
        return PlayerPrefs.GetInt("Seconds");
    }


}

