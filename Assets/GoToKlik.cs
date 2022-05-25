using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToKlik : MonoBehaviour
{

    public int aktif;

    public NavMeshAgent agen;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        this.aktif = 0;
        this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && aktif == 1)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                this.agen.SetDestination(hit.point);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            this.aktif = 0;
            this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }

    }

    private void OnMouseDown()
    {
        if(this.aktif == 0) 
        { 
            this.aktif = 1;

            this.gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);

        }
        else 
        { 
            this.aktif = 0;
            this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
    }
}
