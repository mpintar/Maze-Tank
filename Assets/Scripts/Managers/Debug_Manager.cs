using UnityEngine;

public class Debug_Manager : MonoBehaviour {

    [SerializeField]
    private bool Debug_Mode;
    [SerializeField]
    private bool Debug_Game_State;
    [SerializeField]
    private bool Debug_Game_Level;
    [SerializeField]
    private bool Debug_Player_Manager;
    [SerializeField]
    private bool Debug_Player_Movers;
    [SerializeField]
    private bool Debug_Enemy_Manager;

    void Start () {

        // if the game is in Release Mode, that mean log nothing and set all debug to false
        if (Debug_Mode)
        {
            Debug_Game_State = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool Get_Debug_Game_State()
    {
        return Debug_Game_State;
    }

    public bool Get_Debug_Level_State()
    {
        return Debug_Game_Level;
    }

    public bool Get_Debug_Player_Manager()
    {
        return Debug_Player_Manager;
    }

    public bool Get_Debug_Player_Movers()
    {
        return Debug_Player_Movers;
    }

    public bool Get_Debug_Enemy_Manager()
    {
        return Debug_Enemy_Manager;
    }
}
