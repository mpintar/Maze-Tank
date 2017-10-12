using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Manager : MonoBehaviour{

    [SerializeField]
    private List<GameObject> Spawn_Locations;

    //[SerializeField]
    //private Enemy enemyPrefab;
    //private List<Enemy> enemies;

    [SerializeField]
    private List<GameObject> Enemy_Prefabs;  //should actually be the line below until I have the enemies working
    //private List<Enemy> Enemy_Prefabs; 

    [SerializeField]
    private GameObject Default_Enemy;

    //in seconds
    [SerializeField]
    [Range(10, 60)]
    private int Enemy_Spawn_Timer_Length;

    private float Enemy_Spawn_Timer;
    private bool Debugging;
    
    void Start()
    {
        Enemy_Spawn_Timer = 0.0f;
        Debugging = this.GetComponent<Debug_Manager>().Get_Debug_Enemy_Manager();
    }

    void Update()
    {
        if (this.GetComponent<Game_Manager>().Get_Current_Game_State() == global::Game_Manager.Game_States.Running)
        {
            Enemy_Spawn_Timer += Time.deltaTime;
            Debug.Log(Enemy_Spawn_Timer);
            if (Enemy_Spawn_Timer > Enemy_Spawn_Timer_Length)
            {
                Spawn_Enemy();
                Enemy_Spawn_Timer -= Enemy_Spawn_Timer_Length;
                if (Debugging)
                {
                    Debug.Log("Enemy_Spawn_Timer reset");
                }
            }
        }        
    }

    private void Spawn_Enemy(int Spawn_Location = -1)
    {

        if((Spawn_Location > Spawn_Locations.Count) || (Spawn_Location < -1))
        {
            Debug.Log("Spawn_Enemy Error: Spawn_Location = " + Spawn_Location + ", Spawn_Locations.Count = " + Spawn_Locations.Count);
            return;
        }
        else if (Spawn_Location == -1) //the default optional value meaning spawn at random spawn point
        {
            if (Debugging)
            {
                Debug.Log("Spawning new enemy at random location");
            }
            Spawn_Location = Random.Range(0, Spawn_Locations.Count);
        }
        else
        {
            if (Debugging)
            {
                Debug.Log("Spawning new enemy at location: " + Spawn_Location);
            }            
        }
        //var enemy = Instantiate(enemyPrefab, Spawn_Locations[Spawn_Location].transform.position, Spawn_Locations[Spawn_Location].transform.rotation) as Enemy;
        //enemy.transform.parent = transform;
        //enemies.Add(enemy);
    }
}
