using System;
using Unity.VisualScripting;
using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private Bird[] _sparrows;
    [SerializeField] private float _interactDist;
    [SerializeField] private Transform _playerTrans;

    public void Update()
    {
        foreach (Bird sparrow in _sparrows)
        {
            if (Vector3.Distance(sparrow.transform.position, _playerTrans.position) <= _interactDist)
            {
                sparrow.gameObject.SetActive(true);
            }
        }
    }
}