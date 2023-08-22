using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Presets;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Presets.ExperimentState> experimentStates = new List<Presets.ExperimentState>();
    public int experimentStateIndex = 0;
    public StateController currentState;


    //    public static KeyCode NextStateKey = KeyCode.Space;
    //public static KeyCode InterruptKey = KeyCode.Escape;


    [Header("Experiment State")]
    public StartStateController startStateController;
    public TrainIntroductionStateController trainIntroductionStateController;
    public TrainStateController trainStateController;
    public TestIntroductionStateController testIntroductionStateController;
    public TestStateController testStateController;
    public EndStateController endStateController;

    public EventMarkerLSLOutletController eventMarkerLSLOutletController;


    [Header("Settings")]
    public char[] trainCharsArray;
    public int repeatTimes;
    public float flashInterval;
    public float flashDuration;
    



    void Start()
    {

        experimentStates = Presets.ExperimentProcedure;
        stateSelector(experimentStates[experimentStateIndex]);
        currentState.enterState();
    }

    // Update is called once per frame
    void Update()
    {

        

        if (currentState.getCurrentState() == Presets.State.EndingState)
        {
            currentState.setCurrentState(Presets.State.IdleState);
            experimentStateIndex += 1;
            Debug.Log(experimentStateIndex);

            if (experimentStateIndex < experimentStates.Count)
            {
                stateSelector(experimentStates[experimentStateIndex]);
                currentState.enterState();
            }
            else
            {
                
            }

        }
        

    }



    public void stateSelector(Presets.ExperimentState nextState)
    {
        switch (nextState)
        {
            case Presets.ExperimentState.StartState:
                currentState = startStateController;
                break;
            case Presets.ExperimentState.TrainIntroductionState:
                currentState = trainIntroductionStateController;
                break;
            case Presets.ExperimentState.TrainState:
                currentState = trainStateController;
                break;
            case Presets.ExperimentState.TestIntroductionState:
                currentState = testIntroductionStateController;
                break;
            case Presets.ExperimentState.TestState:
                currentState = testStateController;
                break;
            case Presets.ExperimentState.EndState:
                currentState = endStateController;
                break;

        }
    }


}
