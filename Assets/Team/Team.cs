using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
    
public enum TeamEnum
{
    
}
public class Team : MonoBehaviour
{
    [SerializeField] private TextMeshProGUI _textScore;
    public int score;
    public Team team;
    public bool user;
    public Transform ballPosition;
    public Vector3 startPosition;
    public TeamEnum teamEnum;

    public object currentPlayer;

    // Start is called before the first frame update
    public void Awake()
    {
        team = GetComponentInParent<Team>();
        startPosition = transform.position;
    }


    public void ResetPosition()
    {
        transform.position = startPosition;
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

internal class TextMeshProGUI
{
    public object text;
}
