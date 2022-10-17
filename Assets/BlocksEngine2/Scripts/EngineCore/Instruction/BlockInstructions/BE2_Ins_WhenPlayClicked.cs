using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BE2_Ins_WhenPlayClicked : BE2_InstructionBase, I_BE2_Instruction
{

    public bool IsPlayActive = false;
    public bool PlayOn = false;
    public int Point;

    public static BE2_Ins_WhenPlayClicked instance = null;
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

    void Update()
    {
        if (PlayOn)
        {

        }
        //{
        //    if (IsPlayActive)
        //    {
        //        if (BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionActive == true)
        //        {
        //            BlocksStack.IsActive = false;
        //            Debug.Log("함수시작");
        //            Point = BlocksStack.Pointer;
        //        }

        //    }
        //    else if (BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionActive == false)
        //    {
        //        BlocksStack.Pointer = Point;
        //        BlocksStack.IsActive = true;
        //        Debug.Log("함수끝");
        //    }

        //}
        

    }

    protected override void OnButtonPlay()
    {
        BlocksStack.IsActive = true;
        IsPlayActive = true;
        PlayOn = true;
    }

    //protected override void OnAwake()
    //{
    //
    //}

    //protected override void OnStart()
    //{
    //
    //}


    public new void Function()
    {
        ExecuteSection(0);
    }
}
