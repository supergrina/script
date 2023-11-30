using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //вывод в консоль здоровье игрока
        int health = 3;

        int level = 2 ;

        health = health + level;

        print("здоровьеровье игрока:"+ health);
    }
}
