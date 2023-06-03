using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    private int goals;
    
        // Start is called before the first frame update
    void Start()
    {
        goals = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Ball")
        {
            goals++;
        }
    }
}
