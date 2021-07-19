using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
	public Inventory inventory;

	private void Start()
	{
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			inventory.fichas++;
			Destroy(gameObject);
			Debug.Log(inventory.fichas);
		}
		
	}
}
