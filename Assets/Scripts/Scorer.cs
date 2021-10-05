using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int bump = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag != "Hit")
        {
            bump += 1;
            Debug.Log($"Bumped into the wall {bump} time(s)");
        }
	}
}
