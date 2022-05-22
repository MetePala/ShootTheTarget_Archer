using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{

    [SerializeField] GameObject _arrow;
    [SerializeField] GameObject _bow;

    public void Gonder()
    {
        Instantiate(_arrow, transform.position, _bow.transform.rotation);
    }
}
