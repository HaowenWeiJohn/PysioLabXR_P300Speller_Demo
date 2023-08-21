using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Presets
{


    public static string EventMarkerLSLOutletStreamName = "PhysioLabXR_P300SpellerDemo_EventMarker";
    public static string EventMarkerLSLOutletStreamType = "EventMarker";
    public static string EventMarkerLSLOutletStreamID = "1";
    public static int EventMarkerChannelNum = 5; // block marker index 0
    public static float EventMarkerNominalSamplingRate = 1;

    // 0: State Enter Exit Marker 1: Flashing Block Enter Exit Marker 2: Flashing Row Index, 3. Flashing Column Index 4. The flashing Row/Column Contains Target Char
    

    public enum ExperimentState
    {
        StartState = 1,
        TrainIntroductionState = 2,
        TrainState = 3,
        TestIntroductionState = 4,
        TestState = 5,
        EndState = 6,


        InterruptState = -1 // this will reset the game to the GameState.StartState
    }


    public static List<ExperimentState> ExperimentProcedure = new List<ExperimentState>() { 
        ExperimentState.StartState, 
        ExperimentState.TrainIntroductionState, 
        ExperimentState.TrainState, 
        ExperimentState.TestIntroductionState, 
        ExperimentState.TestState,
        ExperimentState.EndState
    };

    public enum State
    {
        IdleState = 0,
        RunningState = 1,
        EndingState = 2,
        InterruptState = 3
    }

    public static KeyCode NextStateKey = KeyCode.N;
    public static KeyCode InterruptKey = KeyCode.I;
    public static KeyCode FullScreenKey = KeyCode.F;



}
