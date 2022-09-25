using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class BE2_Cst_CheckrFrontMonster : BE2_InstructionBase, I_BE2_Instruction

{

    FrontCheck frontCheck = new FrontCheck();
    public void MonsterOn()
    {
        
    }

    public void MonsterOff()
    {

    }

    void Awake()
    {
       // FrontCheck.FrontMonsterOn += MonsterOn();
        //FrontCheck.FrontMonsterOff += MonsterOff();
    }

    

    //////////**REMAKE**///////// 

    //protected override void OnStart()
    //{
    //    _variablesManager = BE2_VariablesManager.instance;
    //}

    //BE2_VariablesManager _variablesManager;
    //I_BE2_BlockSectionHeaderInput _input0;

    //public new string Operation()
    //{

    //    _input0 = Section0Inputs[0];
    //    return _variablesManager.GetVariableStringValue(_input0.StringValue);

    //}

    ////////////////////////////

    //public new void Function()

    //{

    //    // --- use Section0Inputs[inputIndex] to get the Block inputs from the first section (index 0).

    //    // --- Optionally, use GetSectionInputs(sectionIndex)[inputIndex] to get inputs from a different section

    //    // --- the input values can be retrieved as .StringValue, .FloatValue or .InputValues 

    //    // Section0Inputs[inputIndex];



    //    // ### Stack Pointer Calls ###

        

    //    // --- execute first block inside the indicated section, used to execute blocks inside this block (ex. if, if/else, repeat)

    //    //ExecuteSection(sectionIndex);

        

    //    // --- execute next block after this, used to finish the execution of this function

    //    ExecuteNextInstruction();

    //}



    //// --- Method used to implement Operation Blocks (will only be called by type: operation)

    //public new string Operation()

    //{

    //    string result = "";

        

    //    // --- use Section0Inputs[inputIndex] to get the Block inputs from the first section (index 0).

    //    // --- Optionally, use GetSectionInputs(sectionIndex)[inputIndex] to get inputs from a different section

    //    // --- the input values can be retrieved as .StringValue, .FloatValue or .InputValues 

    //    // Section0Inputs[inputIndex];

        

    //    // --- opeartion results are always of type string.

    //    // --- bool return strings are usually "1", "true", "0", "false".

    //    // --- numbers are returned as strings and converted on the input get.

    //    return result;

    //}



    // ### Execution Setting ###



    // --- Use ExecuteInUpdate for functions that plays repeatedly in update, holding the blocks stack execution flow until completed (ex.: wait, lerp).

    // --- Default value is false. Loop Blocks are always executed in update (true).

    //public new bool ExecuteInUpdate => true; 



    // ### Additional Methods ###



    // --- executed after base Awake

    //protected override void OnAwake()

    //{

    //    

    //}

    

    // --- executed after base Start

    //protected override void OnStart()

    //{

    //    

    //}



    // --- Update can be overridden

    //void Update()

    //{

    //

    //}



    // --- executed on button play pressed

    //protected override void OnButtonPlay()

    //{

    //

    //}



    // --- executed on button stop pressed

    //protected override void OnButtonStop()

    //{

    //

    //}



    // --- executed after blocks stack is populated

    //public override void OnPrepareToPlay()

    //{

    //

    //}



    // --- executed on the stack transition from deactive to active

    //public override void OnStackActive()

    //{

    //

    //}

}
