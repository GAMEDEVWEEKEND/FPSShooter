using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{

    Animator m_animator;

    void Start()
    {
        m_animator = gameObject.GetComponent<Animator>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_animator.SetBool("Go", true);
            Debug.Log("start");
        }
    }
}
