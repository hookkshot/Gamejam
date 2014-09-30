﻿using UnityEngine;
using System.Collections;

public class FallingBlock : MonoBehaviour {

	public DamageType Damage;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other)	{
		
		if (other.gameObject.layer == LayerMask.NameToLayer ("Character")) {
			
			HealthSystem h = other.gameObject.GetComponent<HealthSystem>();
			if(h != null){
				
				h.TakeDamage(Damage, gameObject);
				Destroy(gameObject);
				
			}
			
		}
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -10) {
			Destroy(gameObject);		
		}
	}
}
