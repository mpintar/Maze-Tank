using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour {

    [SerializeField]
    private int Current_Level = 0;

    [SerializeField]
    private List<GameObject> Levels_List;

    private bool Debugging;

    // Use this for initialization
    void Start () {
        Debugging = this.GetComponent<Debug_Manager>().Get_Debug_Level_State();
        Load_Level(Current_Level);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int Get_Current_Level()
    {
        return Current_Level;
    }

    public void Load_Level(int Level_To_Load)
    {
        if (Debugging)
        {
            Debug.Log("Load_Level called: Current_Level set to " + Current_Level.ToString());
        }
    }
}
