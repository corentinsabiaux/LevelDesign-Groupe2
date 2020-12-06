using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToKill : MonoBehaviour
{
    //A placer sur un Gameobject vide
    public GameObject[] enemies;
    public GameObject pad;

    // Update is called once per frame
    void Update()
    {
        if (enemies.Length == 2)
        {
            if (enemies[0] == null && enemies[1] == null)
            {
                pad.SetActive(true);
            }
        }

        if (enemies.Length == 3)
        {
            if (enemies[0] == null && enemies[1] == null && enemies[2] == null)
            {
                pad.SetActive(true);
            }
        }

        if (enemies.Length == 5)
        {
            if (enemies[0] == null && enemies[1] == null && enemies[2] == null && enemies[3] == null && enemies[4] == null)
            {
                pad.SetActive(true);
            }
        }
    }
}
