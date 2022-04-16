using UnityEngine;

public class SaveScore
{
    public void SaveRecord(int hours, int minutes, int seconds)
    {
        PlayerPrefs.SetInt("Hours", hours);
        PlayerPrefs.SetInt("Minutes", minutes);
        PlayerPrefs.SetInt("Seconds", seconds);
    }
    public void LoadRecord()
    {
        PlayerPrefs.GetInt("Hours");
        PlayerPrefs.GetInt("Minutes");
        PlayerPrefs.GetInt("Seconds");
    }
}

