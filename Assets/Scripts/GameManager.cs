using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField, Header ("Ball")]
    private GameObject _ball;

    [SerializeField, Header("Player1")]
    private GameObject _player1Paddle;
    [SerializeField]
    private GameObject _player1Goal;

    [SerializeField, Header("Player2")]
    private GameObject _player2Paddle;
    [SerializeField]
    private GameObject _player2Goal;

    [SerializeField, Header("ScoreUI")]
    private GameObject _player1Text;
    [SerializeField]
    private GameObject _player2Text;

    private Vector3 _startPosition;

    private int _player1Score;
    private int _player2Score;

    private void Start()
    {
        _startPosition = _ball.transform.position;
    }

    internal void Player1Scored()
    {
        _player1Score++;
        _player1Text.GetComponent<TextMeshProUGUI>().text = _player1Score.ToString();
        ResetPosition();
    }

    internal void Player2Scored()
    {
        _player2Score++;
        _player2Text.GetComponent<TextMeshProUGUI>().text = _player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        _ball.GetComponent<BallScript>().Reset();
        _player1Paddle.GetComponent<PlayerController>().Reset();
        _player2Paddle.GetComponent<SecondController>().Reset();
    }
}
