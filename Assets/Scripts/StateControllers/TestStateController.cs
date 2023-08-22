using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStateController : StateController
{
    // Start is called before the first frame update

    [Header("Board Controller")]
    public BoardController boardController;

    public IEnumerator TestStateBoardCoroutine;

    void Start()
    {
        TestStateBoardCoroutine = boardController.TestStateBoardCoroutine();
        StartCoroutine(TestStateBoardCoroutine);

    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }



}
