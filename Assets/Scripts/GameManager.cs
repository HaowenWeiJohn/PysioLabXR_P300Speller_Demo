using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Preset.GameState> gameStates = new List<Preset.GameState>();
    public int currentGameStaateIndex = 0;
    public static KeyCode NextStateKey = KeyCode.N;
    public static KeyCode InterruptKey = KeyCode.I;



    void Start()
    {
        gameStates = Preset.GameProcedure;
        currentGameStaateIndex = 0;

        // set current Game State

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
