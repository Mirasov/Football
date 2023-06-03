using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;


public class Players<TextMeshProGUI> : MonoBehaviour
{
    [SerializeField] private TextMeshProGUI textScore;
    [SerializeField] private Transform _sphere;
    // Start is called before the first frame update
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        agent.SetDestination(_sphere.position);
    }
}
