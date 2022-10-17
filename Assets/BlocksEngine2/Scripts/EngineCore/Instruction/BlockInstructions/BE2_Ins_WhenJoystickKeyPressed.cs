using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BE2_Ins_WhenJoystickKeyPressed : BE2_InstructionBase, I_BE2_Instruction
{
    Dropdown _dropdown;
    BE2_VirtualJoystick _virtualJoystick;

    public bool IsFunctionActive = false;
    //public bool isFunctionActive
    //{

    //}


    public static BE2_Ins_WhenJoystickKeyPressed instance = null;
    protected override void OnAwake()
    {
        if (instance == null) //instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; //내자신을 instance로 넣어줍니다.
            DontDestroyOnLoad(gameObject); //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); //둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제
        }
    }


    protected override void OnStart()
    {
        _dropdown = GetSectionInputs(0)[0].Transform.GetComponent<Dropdown>();
        _virtualJoystick = BE2_VirtualJoystick.instance;

        //PopulateDropdown();
        //_dropdown.value = _dropdown.options.FindIndex(option => option.text == "A");
        //ParseKeyCode();
        //_dropdown.onValueChanged.AddListener(delegate { ParseKeyCode(); });
    }

    //void PopulateDropdown()
    //{
    //    _dropdown.ClearOptions();
    //    string[] keys = System.Enum.GetNames(typeof(KeyCode));
    //    foreach (string key in keys)
    //    {
    //        _dropdown.options.Add(new Dropdown.OptionData(key));
    //    }
    //    _dropdown.RefreshShownValue();
    //}

    void Update()
    {
        if (_virtualJoystick.keys[_dropdown.value].isPressed)
        {
            BlocksStack.IsActive = true;
            BE2_Ins_WhenPlayClicked.instance.IsPlayActive = false;
        }
        IsFunctionActive = BlocksStack.IsActive;
        

    }
    

    public new void Function()
    {
        ExecuteSection(0);
    }
}
