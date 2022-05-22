using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowController : MonoBehaviour
{
    [SerializeField] Button _button;
    void Update()
    {
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - bowPosition;

        var targetPos = new Vector2(direction.x, direction.y);
        var targetXPos = Mathf.Clamp(targetPos.x, 11, 20f);
        var targetYPos = Mathf.Clamp(targetPos.y, -3, 6);
        transform.right = new Vector2(targetXPos, targetYPos);
    }
}
