using UnityEngine;


public class Race : MonoBehaviour
{
    [SerializeField] private SphereInput _sphereInput;
    [SerializeField] private MenuPanel _menuPanel;
    [SerializeField] private ResultScreen _resutPanel;

    private Road _gameTrack;
    private FinishLine _finish;
    private TimeControl _timeControl;
    private Timer _timer;
    private SaveScore _saveScore;

    private void Awake()
    {
        _finish = FindObjectOfType<FinishLine>();
        _gameTrack = FindObjectOfType<Road>();
        _timeControl = new TimeControl();
        _timer = new Timer();
        _saveScore = new SaveScore();
        LoadResult();
    }
    private void Start()
    {
        _sphereInput.CanUseInput = false;
        _timeControl.StopTime();
        
    }
    private void OnEnable()
    {
        _gameTrack.OnGameLosing += Lose;
        _finish.OnGameWin += Win;
        _sphereInput.OnMenuCalled += StopGame;
        _menuPanel.OnMenuOpened += GetLastResult;
    }
    private void OnDisable()
    {
        _gameTrack.OnGameLosing -= Lose;
        _finish.OnGameWin -= Win;
        _sphereInput.OnMenuCalled -= StopGame;
        _menuPanel.OnMenuOpened -= GetLastResult;
    }
    private void Update()
    {
        _timer.CheckGameTime();
    }

    public void StartGame()
    {
        _timeControl.ReturnTime();
        _sphereInput.CanUseInput = true;
        _menuPanel.gameObject.SetActive(false);
        _timer.ResetGameTime();
        _timer.StartTimer();
    }
    private void StopGame()
    {
        _timer.StopTimer();
        _menuPanel.gameObject.SetActive(true);
        _timeControl.StopTime();
        
    }

    private void Lose()
    {
        _resutPanel.gameObject.SetActive(true);
        _sphereInput.CanUseInput = false;
        _timer.StopTimer();
        _timeControl.StopTime();
        _resutPanel.SetResultText(LoseResult());
    }

    private void Win()
    {
        _resutPanel.gameObject.SetActive(true);
        _sphereInput.CanUseInput = false;
        _timer.StopTimer();
        _timeControl.StopTime();
        _saveScore.SaveRecord(_timer.Hours, _timer.Minutes, _timer.Seconds);
        _resutPanel.SetResultText(WinResult());
    }

    private string WinResult()
    {
        string goodResult = $"You win!!!!  Your time {_timer.Hours}:{_timer.Minutes}:{_timer.Seconds}";
        return goodResult;
    }
    private string LoseResult()
    {
        string badResult = "You Lose!!!!";
        return badResult;
    }

    private void LoadResult()
    {
        _timer.SetTime(_saveScore.LoadHours(), _saveScore.LoadMinutes(), _saveScore.LoadSeconds());
    }
    private void GetLastResult()
    {
        _resutPanel.SetResultText($"Your last result! {_timer.Hours}:{_timer.Minutes}:{_timer.Seconds}");
    }

}
