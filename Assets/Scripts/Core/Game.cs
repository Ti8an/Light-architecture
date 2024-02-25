using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        _gameManager.StartGame();
    }
}
