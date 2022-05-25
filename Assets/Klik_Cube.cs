using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik_Cube : MonoBehaviour
{
    public int kotaknomor;
    public GameObject kendaligame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kendaligame.GetComponent<Game_Controller>().FlagArray != 0) { SinkronArray(); }
    }

    void SinkronArray()
    {
        if(this.kotaknomor == kendaligame.GetComponent<Game_Controller>().FlagArray)
        {
            this.gameObject.GetComponent<Renderer>().material.color = new Color(240, 0, 240);

            kendaligame.GetComponent<Game_Controller>().FlagArray = 0;
        }
    }

    private void OnMouseDown()
    {
        if (kendaligame.GetComponent<Game_Controller>().Arkerja[this.kotaknomor]== 0)
        {
            kendaligame.GetComponent<Game_Controller>().Arkerja[this.kotaknomor] = 
                kendaligame.GetComponent<Game_Controller>().pemain;

            if(kendaligame.GetComponent<Game_Controller>().pemain ==1) 
            { 
                this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            } else 
            { 
                this.gameObject.GetComponent<Renderer>().material.color = new Color(240, 0, 240); 
            }

            kendaligame.GetComponent<Game_Controller>().tukarpemain();

        }
    }
}
