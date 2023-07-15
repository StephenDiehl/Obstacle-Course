using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    
    [SerializeField] float yValue = 0;
    [SerializeField] float moveSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        InstructionsToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void InstructionsToConsole()
    {
        Debug.Log("Use W,A,S,D to move, avoid the obstacles and make it to the end of the course. ");
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
