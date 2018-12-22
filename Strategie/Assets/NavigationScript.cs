using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationScript : MonoBehaviour {

    public Camera cam; //бросаем камеру
    NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) //если нажата клавиша мыши
        {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);//снимаем точку клика
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point); //перемещаем агента в точку
            }
        }
    }
}

