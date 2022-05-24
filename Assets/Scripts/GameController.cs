using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Scrollbar _scrollbar;
    static public float _scrollValue= 0.1f;
    static public int _score;
    [SerializeField] Text _scoreText;
    bool arttir;
    [SerializeField] GameObject _crosshair;
    private void Awake()
    {
        Time.timeScale = 1;
    }
    private void FixedUpdate()
    {
       if(_scrollValue<= 0.06f)
        {
            arttir = true;
        }
       else if(_scrollValue>=0.98f)
        {
            arttir = false;
        }
       if(arttir)
            _scrollValue += 0.03f;
       else
            _scrollValue -= 0.03f;

        _scrollbar.value = _scrollValue;
        _scoreText.text = "Score: "+_score.ToString();
        _crosshair.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _crosshair.transform.position = new Vector3(_crosshair.transform.position.x, _crosshair.transform.position.y, 0);
    }
}
