using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{
    public float ShakeSpeed;
    public Animator Animator;

	void Start ()
    {
		
	}
	
	void Update ()
	{
	    
	}

    public void ShakeIt()
    {
        var pos = transform.position;
        pos.x = Mathf.Sin(Time.time * ShakeSpeed);

        transform.position = pos;
    }

    public void OnMouseClicked()
    {
        Animator.SetTrigger("Active");
    }
}
