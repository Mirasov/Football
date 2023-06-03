using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball Instance;

    [HideInInspector] public Rigidbody rb;

    [HideInInspector] public Vector3 startPosition;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance = null)
            Instance = this;
        else 
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    public void ResetPosition()
    {
        transform.position = startPosition;
        transform.SetParent(null);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.constraints = RigidbodyConstraints.None;
    }
}

