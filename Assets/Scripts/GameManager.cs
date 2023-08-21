using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Presets.ExperimentState> experimentState = new List<Presets.ExperimentState>();
    public int currentExperimentStateIndex = 0;


    //    public static KeyCode NextStateKey = KeyCode.Space;
    //public static KeyCode InterruptKey = KeyCode.Escape;

    void Start()
    {
        experimentState = Presets.ExperimentProcedure;
        currentExperimentStateIndex = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
