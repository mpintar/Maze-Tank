using UnityEngine;

public enum Controller_Types
{
    Keyboard,
    Mouse_And_Keyboard,
    Gamepad
};

public class Joystick
{
    private Vector2 Vector;

    public Joystick(float X, float Y)
    {
        Vector = new Vector2(X, Y);
        if (Vector.magnitude > 1)
        {
            Vector = Vector.normalized;
        }

    }

    public float X()
    {
        return Vector.x;
    }

    public float Y()
    {
        return Vector.y;
    }
}

public class Trigger
{
    private float value = 0.0f;
    public float Value
    {
        get { return value; }
        set
        {
            if (Value > 1.0f)
            {
                value = 1.0f;
            }
            else if(Value < 0.0f)
            {
                value = 0.0f;
            }
            else
            {
                value = Value;
            }
        }
    }
}

public interface Controller_Interface
{
    Joystick Get_Left_Joystick();
    Joystick Get_Right_Joystick();
    bool Get_Left_Joystick_Button_Status();
    bool Get_Right_Joystick_Button_Status();
    Trigger Get_Left_Trigger();
    Trigger Get_Right_Trigger();
    bool Get_Start_Button_Status();
    bool Get_Select_Button_Status();
    bool Get_Left_Bumper_Status();
    bool Get_Right_Bumper_Status();
    bool Get_X_Button_Status();
    bool Get_Y_Button_Status();
    bool Get_A_Button_Status();
    bool Get_B_Button_Status();
    bool Is_Anything_Pressed();
    Controller_Types Get_Controller_Type();
}