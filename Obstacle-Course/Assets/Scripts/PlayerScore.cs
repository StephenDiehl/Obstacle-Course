using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int Score = 0;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit"){
            Score ++;
            Debug.Log("You have bumped into " + Score + " objects");
            other.gameObject.tag = "Hit";
        }
        
    }
}
