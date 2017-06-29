using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public MainClicker mainClicker;

    private void Start()
    {
		
	}

    private void Update()
    {
		HandleMouse();
	}

    private void HandleMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "MainClicker")
                {
                    mainClicker.OnMouseClicked();
                }
            }
        }
    }
}
