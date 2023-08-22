using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Presets
{


    public static string EventMarkerLSLOutletStreamName = "PhysioLabXR_P300SpellerDemo_EventMarker";
    public static string EventMarkerLSLOutletStreamType = "EventMarker";
    public static string EventMarkerLSLOutletStreamID = "1";
    public static int EventMarkerChannelNum = 6; // block marker index 0
    public static float EventMarkerNominalSamplingRate = 1;

    public static Color CharOffColor = new Color(0.5f, 0.5f, 0.5f, 1);
    public static Color CharOnColor = new Color(1, 1, 1, 1);

    public static Color CharTrainHintColor = new Color(1, 0, 1, 1);


    // 0: State Enter Exit Marker 1: Flashing Block Enter Exit Marker 2: Flashing Row Index, 3. Flashing Column Index 4. The flashing Row/Column Contains Target Char
    public enum EventMarkerChannelInfo
    {
        StateEnterExitMarker = 0,
        FlashBlockStartEndMarker = 1,
        FlashingMarker = 2,
        ColIndexMarker = 3,
        RowIndexMarker = 4,
        FlashingTarget = 5
    }

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

    public static KeyCode NextStateKey = KeyCode.Space;
    public static KeyCode InterruptKey = KeyCode.Escape;
    //public static KeyCode FullScreenKey = KeyCode.;

    public enum Character
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

    public static char[] P300TargetChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    public static Dictionary<int, char> P300SpellerIndexCharDictonary = new Dictionary<int, char>()
{
    {0, 'A'},
    {1, 'B'},
    {2, 'C'},
    {3, 'D'},
    {4, 'E'},
    {5, 'F'},
    {6, 'G'},
    {7, 'H'},
    {8, 'I'},
    {9, 'J'},
    {10, 'K'},
    {11, 'L'},
    {12, 'M'},
    {13, 'N'},
    {14, 'O'},
    {15, 'P'},
    {16, 'Q'},
    {17, 'R'},
    {18, 'S'},
    {19, 'T'},
    {20, 'U'},
    {21, 'V'},
    {22, 'W'},
    {23, 'X'},
    {24, 'Y'},
    {25, 'Z'},
    {26, '0'},
    {27, '1'},
    {28, '2'},
    {29, '3'},
    {30, '4'},
    {31, '5'},
    {32, '6'},
    {33, '7'},
    {34, '8'},
    {35, '9'}
};


    public static Dictionary<char, int> P300SpellerCharInexDictionary = new Dictionary<char, int>()
{
    {'A', 0},
    {'B', 1},
    {'C', 2},
    {'D', 3},
    {'E', 4},
    {'F', 5},
    {'G', 6},
    {'H', 7},
    {'I', 8},
    {'J', 9},
    {'K', 10},
    {'L', 11},
    {'M', 12},
    {'N', 13},
    {'O', 14},
    {'P', 15},
    {'Q', 16},
    {'R', 17},
    {'S', 18},
    {'T', 19},
    {'U', 20},
    {'V', 21},
    {'W', 22},
    {'X', 23},
    {'Y', 24},
    {'Z', 25},
    {'0', 26},
    {'1', 27},
    {'2', 28},
    {'3', 29},
    {'4', 30},
    {'5', 31},
    {'6', 32},
    {'7', 33},
    {'8', 34},
    {'9', 35}
};


    public static float BoardEnableWaitTime = 2.0f;


}
