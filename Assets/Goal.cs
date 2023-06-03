using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Team _team;

    private void Awake()
    {
        _team = GetComponentInParent<Team>();
    }
     private void OnTrigger(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            Debug.Log("Goal");
            StartCoroutine(GameReset.Instance.ResetScene());
        }
        // GOAL
    }
}
