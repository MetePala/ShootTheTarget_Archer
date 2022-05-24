using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    [SerializeField] float _currentTime=30;
    [SerializeField] Text _timerText;
    [SerializeField] GameObject _panel;
    [SerializeField] Text _panelScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime -= Time.deltaTime;
        _timerText.text = _currentTime.ToString("##.");
        if(_currentTime<=0)
        {
            _panelScore.text = "Score: " + GameController._score;
            _panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
   public void ReStartGame()
    {
        SceneManager.LoadScene(0);
    }
}
