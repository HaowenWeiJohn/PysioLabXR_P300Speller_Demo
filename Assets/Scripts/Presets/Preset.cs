using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Preset
{

    public enum GameState
    {
        StartState = 1,
        TrainIntroductionState = 2,
        TrainState = 3,
        TestIntroductionState = 4,
        TestState = 5,
        EndState = 6,


        InterruptState = -1 // this will reset the game to the GameState.StartState
    }


    public static List<GameState> GameProcedure = new List<GameState>() { 
        GameState.StartState, 
        GameState.TrainIntroductionState, 
        GameState.TrainState, 
        GameState.TestIntroductionState, 
        GameState.TestState,
        GameState.EndState
    };




}
