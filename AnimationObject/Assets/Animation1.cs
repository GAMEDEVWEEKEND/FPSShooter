using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation1 : MonoBehaviour {


    Animator m_animator;

	// Use this for initialization
	void Start () {
        m_animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            m_animator.SetBool("Go", true);
            Debug.Log("Animation Start");
        }
	}
}
