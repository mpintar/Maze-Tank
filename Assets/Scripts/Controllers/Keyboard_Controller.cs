using System;
using UnityEngine;

public class Keyboard_Controller :  MonoBehaviour, Controller_Interface
{
    private Action_Buttons Action_Buttons;
    private Directional_Buttons Right_Joystick_Buttons;
    private Directional_Buttons Left_Joystick_Buttons;

    // for use with Action_Buttons
    [SerializeField]
    private KeyCode Start_Button;
    [SerializeField]
    private KeyCode Select_Button;
    [SerializeField]
    private KeyCode A_Button;
    [SerializeField]
    private KeyCode B_Button;
    [SerializeField]
    private KeyCode X_Button;
    [SerializeField]
    private KeyCode Y_Button;

    //for use with Right_Joystick_Buttons
    [SerializeField]
    private KeyCode Left_Button;
    [SerializeField]
    private KeyCode Right_Button;
    [SerializeField]
    private KeyCode Up_Button;
    [SerializeField]
    private KeyCode Down_Button;

    //for use with Left_Joystick_Buttons
    [SerializeField]
    private KeyCode Left_D_Pad;
    [SerializeField]
    private KeyCode Right_D_Pad;
    [SerializeField]
    private KeyCode Up_D_Pad;
    [SerializeField]
    private KeyCode Down_D_Pad;


    private bool AnyKey_Pressed()
    {
        bool is_Pressed = false;
        if (Input.anyKey || Input.anyKeyDown)
        {
            is_Pressed = true;
        }
        return is_Pressed;
    }

    bool Controller_Interface.Get_A_Button_Status()
    {
        bool is_Pressed = false;
        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Action_Buttons.Get_A_Button_Key_Code()))
            {
                is_Pressed = true;
            }
        }
        return is_Pressed;
    }

    bool Controller_Interface.Get_B_Button_Status()
    {
        bool is_Pressed = false;
        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Action_Buttons.Get_B_Button_Key_Code()))
            {
                is_Pressed = true;
            }
        }
        return is_Pressed;
    }

    bool Controller_Interface.Get_Left_Bumper_Status()
    {
        throw new NotImplementedException();
    }

    Joystick Controller_Interface.Get_Left_Joystick()
    {
        int x = 0;
        int y = 0;
        //Joystick This_Joystick = new Joystick(0.0f, 0.0f);

        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Left_Joystick_Buttons.Get_Left_Button_Key_Code()))
            {
                x-=1;
            }

            if (Input.GetKey(Left_Joystick_Buttons.Get_Right_Button_Key_Code()))
            {
                x+=1;
            }

            if (Input.GetKey(Left_Joystick_Buttons.Get_Up_Button_Key_Code()))
            {
                y++;
            }

            if (Input.GetKey(Left_Joystick_Buttons.Get_Down_Button_Key_Code()))
            {
                y--;
            }
        }
        return new Joystick(x, y);
    }

    bool Controller_Interface.Get_Left_Joystick_Button_Status()
    {
        throw new NotImplementedException();
    }

    Trigger Controller_Interface.Get_Left_Trigger()
    {
        throw new NotImplementedException();
    }

    bool Controller_Interface.Get_Right_Bumper_Status()
    {
        throw new NotImplementedException();
    }

    Joystick Controller_Interface.Get_Right_Joystick()
    {
        int x = 0;
        int y = 0;

        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Right_Joystick_Buttons.Get_Left_Button_Key_Code()))
            {
                x--;
            }

            if (Input.GetKey(Right_Joystick_Buttons.Get_Right_Button_Key_Code()))
            {
                x++;
            }

            if (Input.GetKey(Right_Joystick_Buttons.Get_Up_Button_Key_Code()))
            {
                y++;
            }

            if (Input.GetKey(Right_Joystick_Buttons.Get_Down_Button_Key_Code()))
            {
                y--;
            }
        }

        return new Joystick(x, y);
    }

    bool Controller_Interface.Get_Right_Joystick_Button_Status()
    {
        throw new NotImplementedException();
    }

    Trigger Controller_Interface.Get_Right_Trigger()
    {
        throw new NotImplementedException();
    }

    bool Controller_Interface.Get_Select_Button_Status()
    {
        bool is_Pressed = false;
        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Action_Buttons.Get_Select_Button_Key_Code()))
            {
                is_Pressed = true;
            }
        }
        return is_Pressed;
    }

    bool Controller_Interface.Get_Start_Button_Status()
    {
        bool is_Pressed = false;
        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Action_Buttons.Get_Start_Button_Key_Code()))
            {
                is_Pressed = true;
            }
        }
        return is_Pressed;
    }

    bool Controller_Interface.Get_X_Button_Status()
    {
        bool is_Pressed = false;
        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Action_Buttons.Get_X_Button_Key_Code()))
            {
                is_Pressed = true;
            }
        }
        return is_Pressed;
    }

    bool Controller_Interface.Get_Y_Button_Status()
    {
        bool is_Pressed = false;
        if (AnyKey_Pressed())
        {
            if (Input.GetKey(Action_Buttons.Get_Y_Button_Key_Code()))
            {
                is_Pressed = true;
            }
        }
        return is_Pressed;
    }

    bool Controller_Interface.Is_Anything_Pressed()
    {
        return AnyKey_Pressed();
    }

    Controller_Types Controller_Interface.Get_Controller_Type()
    {
        return Controller_Types.Keyboard;
    }

    // Use this for initialization
    void Start () {
        Action_Buttons = new Action_Buttons(Start_Button, Select_Button, A_Button, B_Button, X_Button, Y_Button);
        Right_Joystick_Buttons = new Directional_Buttons(Left_Button, Right_Button, Up_Button, Down_Button);
        Left_Joystick_Buttons = new Directional_Buttons(Left_D_Pad, Right_D_Pad, Up_D_Pad, Down_D_Pad);
    }
    
	// Update is called once per frame
	void Update () {
		
	}
}
