using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainClicker : MonoBehaviour
{
    public float ShakeSpeed;
    public Animator Animator;

    public float Score;
    public float ScoreMultiplier = 1.0f;

    public Text ScoreText;

    private void Start()
    {
		
	}
	
	private void Update()
	{
	    UpdateUi();
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
        AddClickedScore();
    }

    public void AddClickedScore()
    {
        Score += ScoreMultiplier;
    }

    private void UpdateUi()
    {
        ScoreText.text = string.Format("{0}", Score);
    }
}
