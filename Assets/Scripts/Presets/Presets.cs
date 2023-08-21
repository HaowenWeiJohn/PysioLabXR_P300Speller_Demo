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

    public enum CharValue
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6,
        H = 7,
        I = 8,
        J = 9,
        K = 10,
        L = 11,
        M = 12,
        N = 13,
        O = 14,
        P = 15,
        Q = 16,
        R = 17,
        S = 18,
        T = 19,
        U = 20,
        V = 21,
        W = 22,
        X = 23,
        Y = 24,
        Z = 25,
        Zero = 26,
        One = 27,
        Two = 28,
        Three = 29,
        Four = 30,
        Five = 31,
        Six = 32,
        Seven = 33,
        Eight = 34,
        Nine = 35
    }

}
