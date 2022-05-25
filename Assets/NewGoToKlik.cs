using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewGoToKlik : MonoBehaviour
{
    public int aktif;
    public int upactive;
    public NavMeshAgent agen;
    public Camera cam;
    public float jitter = 1f;


    // Start is called before the first frame update
    void Start()
    {
        this.upactive = 0;
        this.aktif = 0;
        this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 240);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && this.upactive == 1)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "plane")
                {
                    this.agen.SetDestination(hit.point);

                    this.upactive = 0;
                    this.aktif = 0;
                    this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 240);

                }


                //  Debug.Log(hit.collider.gameObject.name);
                //  Debug.Log(hit.transform.name);
            }

        }

        if (Input.GetMouseButtonDown(1))
        {
            this.aktif = 0;
            this.upactive = 0;
            this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 240);
        }

        if (this.agen.remainingDistance<2)
        {
            wander();
        }
   

    }


    private void OnMouseDown()
    {
        if (this.aktif == 0)
        {
            this.aktif = 1;
            this.gameObject.GetComponent<Renderer>().material.color = new Color(240, 0, 0);
        }
        else
        {
            this.aktif = 0;
            this.upactive = 0;
            this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 240);
        }
    }

    private void OnMouseUp()
    {
        if (this.aktif == 1) { upactive = 1; }
    }


    Vector3 wandertarget = Vector3.zero;

    private void wander()
    {
        float wanderRadius = 6f;
        float wanderDistance = 9f;

        wandertarget += new Vector3(Random.RandomRange(-1.0f, 1.0f) * jitter, 0, Random.RandomRange(-1.0f, 1.0f) * jitter);
        wandertarget.Normalize();
        wandertarget *= wanderRadius;


        Vector3 targetlokal = wandertarget + new Vector3(0, 0, wanderDistance);
        Vector3 targetworld = this.gameObject.transform.InverseTransformVector(targetlokal);
        this.agen.SetDestination(targetworld);

    }
}