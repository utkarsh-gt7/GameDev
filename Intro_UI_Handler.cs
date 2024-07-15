using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_UI_Handler : MonoBehaviour
{
    public GameObject instructionPanel;

    public void ToggleInstructionPanel(string toggle){
        if(toggle == "false"){
            instructionPanel.SetActive(false);
        }else if(toggle == "true"){
            instructionPanel.SetActive(true);
        }
    }
}
