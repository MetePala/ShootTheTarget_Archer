using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpeed : MonoBehaviour
{
    Rigidbody2D rgd2d;
    float _speed;
    bool _touch=false;
    float _currentTime;
    private void Awake()
    {
        _speed = GameController._scrollValue;
        _speed *= 22;
        rgd2d = GetComponent<Rigidbody2D>();
        rgd2d.velocity = transform.right * _speed;
    }
    void Update()
    {
        if(_touch==false)
        {
        float angle = Mathf.Atan2(rgd2d.velocity.y, rgd2d.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
       
    }
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        if (_touch==false)
        {
            if (_currentTime > 3)
            {
                Destroy(this.gameObject);
            }
        }
       else
        {
            if (_currentTime > 7)
            {
                Destroy(this.gameObject);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       

        if (col.gameObject.CompareTag("target10"))
        {
            transform.SetParent(col.collider.transform);
            _touch = true;
            Destroy(GetComponent<Rigidbody2D>());
            GameController._score += 10;
        }
        else if (col.gameObject.CompareTag("target25"))
        {
            transform.SetParent(col.collider.transform);
            _touch = true;
            Destroy(GetComponent<Rigidbody2D>());
            GameController._score += 25;
        }
        else if (col.gameObject.CompareTag("taget50"))
        {
            transform.SetParent(col.collider.transform);
            _touch = true;
            Destroy(GetComponent<Rigidbody2D>());
            GameController._score += 50;
        }
    }
}
