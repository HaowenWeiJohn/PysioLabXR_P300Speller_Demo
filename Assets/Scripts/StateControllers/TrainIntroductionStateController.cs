using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrainIntroductionStateController : StateController
{
    // Start is called before the first frame update

    [Header("Setting Input Feild")]
    public P300SpellerSettingsInputFeildController trainCharsInputFeildController;
    public P300SpellerSettingsInputFeildController repeatTimesInputFeildController;
    public P300SpellerSettingsInputFeildController flashIntervalInputFeildController;

    

    //public TMP_InputField TrainCharsInputFeild;
    //public TMP_InputField RepeatTimesInputFeild;
    //public TMP_InputField FlashIntervalInputFeild;




    void Start()
    {
        //string inputValue = TrainChars.text;
        //Debug.Log("InputField value: " + inputValue);
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
        
    }

    public override bool stateShiftValidCheck()
    {

        //bool trainCharsValid = trainCharsInputFeildController.inputIsP300Chars();
        //bool repeatTimesValid = repeatTimesInputFeildController.inputIsInt();
        //bool flashIntervalValid = flashIntervalInputFeildController.inputIsFloat();

        //if (trainCharsValid && repeatTimesValid && flashIntervalValid)
        //{
        //    returnSettingsToGameManager();
        //}

        if (trainCharsValid() && repeatTimeValid() && falshIntervalValid())
        {
            return true;
        }
        else 
        { 
            return false; 
        }

    }




    public bool trainCharsValid()
    {
        //List<Char> trainCharsList = new List<Char>();
        string targetCharsStringInput = trainCharsInputFeildController.getInput();
        char[] trainCharsArray = targetCharsStringInput.ToCharArray();


        foreach (char trainChar in trainCharsArray)
        {

            bool exists = Array.Exists(Presets.P300TargetChars, element => element == trainChar);
            if (!exists) 
            { 
                return false; 
            }
        }
        gameManager.trainCharsArray = trainCharsArray;
        return true;
    }


    public bool repeatTimeValid()
    {
        string inputString = repeatTimesInputFeildController.getInput();
        int outputValue = 0;
        bool valid =  int.TryParse(inputString, out outputValue);
        if (valid)
        {
            gameManager.repeatTimes = outputValue;
            return true;
        }
        else
        {
            return false;
        }

    }


    public bool falshIntervalValid()
    {
        string inputString = flashIntervalInputFeildController.getInput();
        float outputValue = 0;
        bool valid = float.TryParse(inputString, out outputValue);
        if (valid)
        {
            gameManager.flashInterval = outputValue;
            return true;
        }
        else
        {
            return false;
        }

    }




}
