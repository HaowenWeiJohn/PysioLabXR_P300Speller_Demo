using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P300SpellerSettingsInputFeildController : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_InputField inputFeild;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public string getInput()
    {
        string text = inputFeild.text;
        return text;
    }


    //public bool inputIsInt()
    //{
    //    string inputString = getInput();
    //    int outputValue = 0;
    //    return int.TryParse(getInput(), out outputValue);
    //}

    //public bool inputIsFloat()
    //{
    //    string inputString = getInput();
    //    float outputValue = 0;
    //    return float.TryParse(getInput(), out outputValue);
    //}

    //public bool inputIsP300Chars()
    //{
    //    string inputString = getInput();
    //    string[] targetList = inputString.Split("");
    //    foreach (string charactorString in targetList)
    //    {
    //        char targetChar = charactorString[0];
    //        bool exists = Array.Exists(Presets.P300TargetChars, element => element == targetChar);
    //        if (!exists) { return false; }

    //    }
    //    return true;
    //}

    
    //public int textToInt()
    //{
    //    string inputString = getInput();
    //    int.TryParse(getInput(), out outputValue);
    //    return 
    //}
    

}
