using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    public int[] Arkerja = new int[10];
    public int pemain = 1;
    public int FlagArray;

    int Jumnol;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void tukarpemain()
    {
        if (pemain == 1) { pemain = 2; } else { pemain = 1; }

        if (pemain == 2) { AIPlayer(); }
    }

    void HitungJumnol()
    {
        Jumnol = 0;

        for (int x = 1; x <= 9; x++)
        {
            if (Arkerja[x] == 0) { Jumnol++; }
        }
    }

    void AIPlayer()
    {
        /// 1 2 3
        /// 4 5 6
        /// 7 8 9 


        // Arkerja[5] = pemain; FlagArray = 5;

        HitungJumnol();
        if (Jumnol == 8)
        {
            if (Arkerja[5] == 0) { Arkerja[5] = pemain; FlagArray = 5; } else { Arkerja[1] = pemain; FlagArray = 1; }
        }

        if (Jumnol <= 6)
        {
            //menyerang
                 if (Arkerja[1] == 2 && Arkerja[2] == 2 && Arkerja[3] == 0) { Arkerja[3] = pemain; FlagArray = 3; }
            else if (Arkerja[1] == 2 && Arkerja[2] == 0 && Arkerja[3] == 2) { Arkerja[2] = pemain; FlagArray = 2; }
            else if (Arkerja[1] == 0 && Arkerja[2] == 2 && Arkerja[3] == 2) { Arkerja[1] = pemain; FlagArray = 1; }

            else if (Arkerja[4] == 2 && Arkerja[5] == 2 && Arkerja[6] == 0) { Arkerja[6] = pemain; FlagArray = 6; }
            else if (Arkerja[4] == 2 && Arkerja[5] == 0 && Arkerja[6] == 2) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[4] == 0 && Arkerja[5] == 2 && Arkerja[6] == 2) { Arkerja[4] = pemain; FlagArray = 4; }

            else if (Arkerja[7] == 2 && Arkerja[8] == 2 && Arkerja[9] == 0) { Arkerja[9] = pemain; FlagArray = 9; }
            else if (Arkerja[7] == 2 && Arkerja[8] == 0 && Arkerja[9] == 2) { Arkerja[8] = pemain; FlagArray = 8; }
            else if (Arkerja[7] == 0 && Arkerja[8] == 2 && Arkerja[9] == 2) { Arkerja[7] = pemain; FlagArray = 7; }

            else if (Arkerja[1] == 2 && Arkerja[4] == 2 && Arkerja[7] == 0) { Arkerja[7] = pemain; FlagArray = 7; }
            else if (Arkerja[1] == 2 && Arkerja[4] == 0 && Arkerja[7] == 2) { Arkerja[4] = pemain; FlagArray = 4; }
            else if (Arkerja[1] == 0 && Arkerja[4] == 2 && Arkerja[7] == 2) { Arkerja[1] = pemain; FlagArray = 1; }

            else if (Arkerja[2] == 2 && Arkerja[5] == 2 && Arkerja[8] == 0) { Arkerja[8] = pemain; FlagArray = 8; }
            else if (Arkerja[2] == 2 && Arkerja[5] == 0 && Arkerja[8] == 2) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[2] == 0 && Arkerja[5] == 2 && Arkerja[8] == 2) { Arkerja[2] = pemain; FlagArray = 2; }

            else if (Arkerja[3] == 2 && Arkerja[6] == 2 && Arkerja[9] == 0) { Arkerja[9] = pemain; FlagArray = 9; }
            else if (Arkerja[3] == 2 && Arkerja[6] == 0 && Arkerja[9] == 2) { Arkerja[6] = pemain; FlagArray = 6; }
            else if (Arkerja[3] == 0 && Arkerja[6] == 2 && Arkerja[9] == 2) { Arkerja[3] = pemain; FlagArray = 3; }

            else if (Arkerja[1] == 2 && Arkerja[5] == 2 && Arkerja[9] == 0) { Arkerja[9] = pemain; FlagArray = 9; }
            else if (Arkerja[1] == 2 && Arkerja[5] == 0 && Arkerja[9] == 2) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[1] == 0 && Arkerja[5] == 2 && Arkerja[9] == 2) { Arkerja[1] = pemain; FlagArray = 1; }

            else if (Arkerja[3] == 2 && Arkerja[5] == 2 && Arkerja[7] == 0) { Arkerja[7] = pemain; FlagArray = 7; }
            else if (Arkerja[3] == 2 && Arkerja[5] == 0 && Arkerja[7] == 2) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[3] == 0 && Arkerja[5] == 2 && Arkerja[7] == 2) { Arkerja[3] = pemain; FlagArray = 3; }

            //defensif
            else if (Arkerja[1] == 1 && Arkerja[2] == 1 && Arkerja[3] == 0) { Arkerja[3] = pemain; FlagArray = 3; }
            else if (Arkerja[1] == 1 && Arkerja[2] == 0 && Arkerja[3] == 1) { Arkerja[2] = pemain; FlagArray = 2; }
            else if (Arkerja[1] == 0 && Arkerja[2] == 1 && Arkerja[3] == 1) { Arkerja[1] = pemain; FlagArray = 1; }

            else if (Arkerja[4] == 1 && Arkerja[5] == 1 && Arkerja[6] == 0) { Arkerja[6] = pemain; FlagArray = 6; }
            else if (Arkerja[4] == 1 && Arkerja[5] == 0 && Arkerja[6] == 1) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[4] == 0 && Arkerja[5] == 1 && Arkerja[6] == 1) { Arkerja[4] = pemain; FlagArray = 4; }
            
            else if (Arkerja[7] == 1 && Arkerja[8] == 1 && Arkerja[9] == 0) { Arkerja[9] = pemain; FlagArray = 9; }
            else if (Arkerja[7] == 1 && Arkerja[8] == 0 && Arkerja[9] == 1) { Arkerja[8] = pemain; FlagArray = 8; }
            else if (Arkerja[7] == 0 && Arkerja[8] == 1 && Arkerja[9] == 1) { Arkerja[7] = pemain; FlagArray = 7; }
           
            else if (Arkerja[1] == 1 && Arkerja[4] == 1 && Arkerja[7] == 0) { Arkerja[7] = pemain; FlagArray = 7; }
            else if (Arkerja[1] == 1 && Arkerja[4] == 0 && Arkerja[7] == 1) { Arkerja[4] = pemain; FlagArray = 4; }
            else if (Arkerja[1] == 0 && Arkerja[4] == 1 && Arkerja[7] == 1) { Arkerja[1] = pemain; FlagArray = 1; }
           
            else if (Arkerja[2] == 1 && Arkerja[5] == 1 && Arkerja[8] == 0) { Arkerja[8] = pemain; FlagArray = 8; }
            else if (Arkerja[2] == 1 && Arkerja[5] == 0 && Arkerja[8] == 1) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[2] == 0 && Arkerja[5] == 1 && Arkerja[8] == 1) { Arkerja[2] = pemain; FlagArray = 2; }
           
            else if (Arkerja[3] == 1 && Arkerja[6] == 1 && Arkerja[9] == 0) { Arkerja[9] = pemain; FlagArray = 9; }
            else if (Arkerja[3] == 1 && Arkerja[6] == 0 && Arkerja[9] == 1) { Arkerja[6] = pemain; FlagArray = 6; }
            else if (Arkerja[3] == 0 && Arkerja[6] == 1 && Arkerja[9] == 1) { Arkerja[3] = pemain; FlagArray = 3; }
            
            else if (Arkerja[1] == 1 && Arkerja[5] == 1 && Arkerja[9] == 0) { Arkerja[9] = pemain; FlagArray = 9; }
            else if (Arkerja[1] == 1 && Arkerja[5] == 0 && Arkerja[9] == 1) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[1] == 0 && Arkerja[5] == 1 && Arkerja[9] == 1) { Arkerja[1] = pemain; FlagArray = 1; }
            
            else if (Arkerja[3] == 1 && Arkerja[5] == 1 && Arkerja[7] == 0) { Arkerja[7] = pemain; FlagArray = 7; }
            else if (Arkerja[3] == 1 && Arkerja[5] == 0 && Arkerja[7] == 1) { Arkerja[5] = pemain; FlagArray = 5; }
            else if (Arkerja[3] == 0 && Arkerja[5] == 1 && Arkerja[7] == 1) { Arkerja[3] = pemain; FlagArray = 3; }

            // kasus pesimis yang tidak dapat terdeteksi
            // 1 0 0
            // 0 2 0
            // 0 0 3

            if (FlagArray == 0)
            {
                // logika menyerang

                // logika pesimis

                if (Arkerja[1] == 0) { Arkerja[1] = pemain; FlagArray = 1; }
                else if (Arkerja[3] == 0) { Arkerja[3] = pemain; FlagArray = 3; }
                else if (Arkerja[7] == 0) { Arkerja[7] = pemain; FlagArray = 7; }
                else if (Arkerja[9] == 0) { Arkerja[9] = pemain; FlagArray = 9; }
            }

        }

        tukarpemain();
        
    }

}