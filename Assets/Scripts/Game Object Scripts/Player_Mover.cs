using UnityEngine;

public class Player_Mover : MonoBehaviour {

    [SerializeField]
    [Range(0.01f, 10.0f)]
    private float Speed;

    [SerializeField]
    private GameObject Game_Manager;

    private Controller_Interface Controller;
    private Vector3 Position;
    private bool Debugging;

    // Use this for initialization
    void Start () {
        Debugging = Game_Manager.GetComponent<Debug_Manager>().Get_Debug_Player_Movers();
        Controller = this.GetComponent<Controller_Interface>();
        if(Debugging)
        {
            Debug.Log("Player 1 Controller is a " + Controller.Get_Controller_Type().ToString());
            Debug.Log("Player 1 Speed set to " + Speed);
        }
        Position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Game_Manager.GetComponent<Game_Manager>().Get_Current_Game_State() == global::Game_Manager.Game_States.Running)
        {
            if (Debugging)
            {
                if (Controller.Get_A_Button_Status())
                {
                    Debug.Log("A button being pressed");
                }

                if (Controller.Get_B_Button_Status())
                {
                    Debug.Log("B button being pressed");
                }
                Debug.Log("X: " + Controller.Get_Left_Joystick().X() + " Y: " + Controller.Get_Left_Joystick().Y());
            }
            Position.x += Controller.Get_Left_Joystick().X() * Time.deltaTime * Speed;
            Position.z += Controller.Get_Left_Joystick().Y() * Time.deltaTime * Speed;
            transform.position = Position;
        }
        else
        {
            Game_Manager.GetComponent<Game_Manager>().Set_Current_Game_State(global::Game_Manager.Game_States.Running);
        }
    }
}
