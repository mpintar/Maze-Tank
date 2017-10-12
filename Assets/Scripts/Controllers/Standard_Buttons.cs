using UnityEngine;
public class Action_Buttons
{
    private KeyCode Start_Button;
    private KeyCode Select_Button;
    private KeyCode A_Button;
    private KeyCode B_Button;
    private KeyCode X_Button;
    private KeyCode Y_Button;

    public Action_Buttons
        (KeyCode Set_Start_Button,
        KeyCode Set_Select_Button,
        KeyCode Set_A_Button,
        KeyCode Set_B_Button,
        KeyCode Set_X_Button,
        KeyCode Set_Y_Button)
    {
        Start_Button = Set_Start_Button;
        Select_Button = Set_Select_Button;
        A_Button = Set_A_Button;
        B_Button = Set_B_Button;
        X_Button = Set_X_Button;
        Y_Button = Set_Y_Button;
    }

    public KeyCode Get_Start_Button_Key_Code()
    {
        return Start_Button;
    }

    public KeyCode Get_Select_Button_Key_Code()
    {
        return Select_Button;
    }

    public KeyCode Get_A_Button_Key_Code()
    {
        return A_Button;
    }

    public KeyCode Get_B_Button_Key_Code()
    {
        return B_Button;
    }

    public KeyCode Get_X_Button_Key_Code()
    {
        return X_Button;
    }

    public KeyCode Get_Y_Button_Key_Code()
    {
        return Y_Button;
    }
}

public class Directional_Buttons
{
    private KeyCode Left_Button;
    private KeyCode Right_Button;
    private KeyCode Up_Button;
    private KeyCode Down_Button;

    public Directional_Buttons
        (KeyCode Set_Left_Button,
        KeyCode Set_Right_Button,
        KeyCode Set_Up_Button,
        KeyCode Set_Down_Button)
    {
        Left_Button = Set_Left_Button;
        Right_Button = Set_Right_Button;
        Up_Button = Set_Up_Button;
        Down_Button = Set_Down_Button;
    }

    public KeyCode Get_Left_Button_Key_Code()
    {
        return Left_Button;
    }

    public KeyCode Get_Right_Button_Key_Code()
    {
        return Right_Button;
    }

    public KeyCode Get_Up_Button_Key_Code()
    {
        return Up_Button;
    }

    public KeyCode Get_Down_Button_Key_Code()
    {
        return Down_Button;
    }
}

