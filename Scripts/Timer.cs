using UnityEngine;

public class Timer 
{
    private float _updatetick;
    private int _seconds = 0;
    private int _minutes;
    private int _hours;
    private bool _isTickedTime = false;

    public int Seconds { get => _seconds; }
    public int Minutes { get => _minutes; }
    public int Hours { get => _hours; }


    public void CheckGameTime()
    {
        if (!_isTickedTime) 
            return;


        _updatetick += Time.deltaTime;
        if (_updatetick >=1)
        {
            _updatetick -= 1;
            _seconds++;
        }
        if (_seconds >= 60)
        {
            _seconds -= 60;
            _minutes++;
        }
        if (_minutes >= 60) 
        {
            _minutes -= 60;
            _hours++;
        }
    }
    public void ResetGameTime()
    {
        _hours = _minutes = _seconds = 0;
    }
    public void StopTimer()
    {
        _isTickedTime = false;
    }
    public void StartTimer()
    {
        _isTickedTime = true;
    }
    public void SetTime(int hours, int minutes,int seconds)
    {
        this._hours = hours;
        this._minutes = minutes;
        this._seconds = seconds;
    }

}

