using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour {

    public enum Game_Modes
    {
        Trial,
        Release
    };

    public enum Game_States
    {
        In_Menu,
        Loading,
        Running,
        Paused,
        Trial_Timeout
    };

    public enum Game_Platforms
    {
        Windows,
        Mac,
        Linux,
        Xbox_360,
    };

    private float Game_Runtime = 0.0f;
    private Game_States Current_Game_State = Game_States.In_Menu;
    private bool Debugging;

    //
    [SerializeField]
    private Game_Platforms Current_Game_Platform;
    [SerializeField]
    private Game_Modes Current_Game_Mode;
    [SerializeField]
    private int Maximum_Trial_Time_In_Minutes = 10;
    private int Maximum_Trial_Time_In_Seconds;

    // Use this for initialization
    void Start () {
        Maximum_Trial_Time_In_Seconds = Maximum_Trial_Time_In_Minutes * 60;
        Debugging = this.GetComponent<Debug_Manager>().Get_Debug_Game_State();
        Set_Current_Game_State(Game_States.Loading);
    }
	
	// Update is called once per frame
	void Update () {
        Game_Runtime += Time.deltaTime;
        if (Game_Runtime > Maximum_Trial_Time_In_Seconds)
        {
            Set_Current_Game_State(Game_States.Trial_Timeout);
        }
    }

    public Game_States Get_Current_Game_State()
    {
        return Current_Game_State;
    }

    public void Set_Current_Game_State(Game_States Game_State)
    {
        if (Debugging)
        {
            Debug.Log("Set_Current_Game_State called: Current_Game_State set to " + Game_State.ToString());
        }
        Current_Game_State = Game_State;
    }

    public Game_Platforms Get_Current_Game_Platform()
    {
        return Current_Game_Platform;
    }

    public Game_Modes Get_Current_Game_Modes()
    {
        return Current_Game_Mode;
    }
}
