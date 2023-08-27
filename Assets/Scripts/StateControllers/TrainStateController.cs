using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainStateController : StateController
{
    // Start is called before the first frame update

    [Header("Board Controller")]
    public BoardController boardController;


    public IEnumerator TrainStateBoardCoroutine;

    void Start()
    {
        //TrainStateBoardCoroutine = boardController.TrainStateBoardCoroutine();
        //StartCoroutine(TrainStateBoardCoroutine);

    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }

    public override void enterState()
    {
        base.enterState();
        TrainStateBoardCoroutine = boardController.TrainStateBoardCoroutine();
        StartCoroutine(TrainStateBoardCoroutine);
    }

    public override void interruptState()
    {
        base.interruptState();
        StopCoroutine(TrainStateBoardCoroutine);
        Debug.Log("TrainStateBoardCoroutine Stopped");
    }



}
