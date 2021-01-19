using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScoring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //create a reference to the scorekeeper script
            ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
            //we need to check if the script was found
            if(scoreKeeper != null)
            {
                //Increment Score
                scoreKeeper.IncrementScore();
            }
        }
    }
}