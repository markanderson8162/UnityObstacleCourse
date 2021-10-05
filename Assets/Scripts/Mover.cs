using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // using SerializeField makes your variables known only to the Unity Engine, but not known to other scripts
    // using the public accessor makes your variables known to other scripts.

    [SerializeField] float moveSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    void PrintInstructions()
	{
        Debug.Log("Welcom to the game");

	}

    void MovePlayer()
	{
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        
        transform.Translate(xValue * moveSpeed, yValue, zValue * moveSpeed);

	}
}
