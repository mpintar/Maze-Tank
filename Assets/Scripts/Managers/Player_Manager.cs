using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour {

    [SerializeField]
    [Range(1,4)]
    private int Number_Of_Players = 1;

    private bool Debugging;

    // Use this for initialization
    void Start () {
        Debugging = this.GetComponent<Debug_Manager>().Get_Debug_Player_Manager();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int Get_Number_Of_Players()
    {
        return Number_Of_Players;
    }

    public void Set_Number_Of_Players(int Player_Count)
    {
        if (Debugging)
        {
            Debug.Log("Set_Number_Of_Players called: Number_Of_Players set to " + Player_Count);
        }
        Number_Of_Players = Player_Count;
    }
}
