﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBowl : MonoBehaviour {
    public Sprite empty;
    public Sprite full;
    private SpriteRenderer spriteRenderer;
    
	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if( spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = empty;
        }
	}
	

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.Space))
        {
            spriteRenderer.sprite = full;
        }
    }
}
