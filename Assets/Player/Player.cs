using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform ballPosition;

    public bool user;
    public bool hasPossession;

    public Team team;
    private Rigidbody rb;
    public Vector3 startPosition;
    // Start is called before the first frame update
    private void Awake()
    {
        team = GetComponentInParent<Team>();
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public List<Player> ToList()
    {
        throw new System.NotImplementedException();
    }
}
