using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gensui : MonoBehaviour {
    private Vector3 offset;
    public Transform player;
	// Use this for initialization
	void Start () {
        offset = player.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, player.position - offset, Time.deltaTime*10);
	}
}
