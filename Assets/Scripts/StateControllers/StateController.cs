using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Presets;
using UnityEngine;

public class StateController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public Presets.ExperimentState experimentState;
    Presets.State currentState = Presets.State.Idle;

    public GameObject StateGraphicInterface;
    public EventMarkerLSLOutletController eventMarkerLSLOutletController;
    void Start()
    {
        //eventMarkerLSLOutletController = GameObject.Find("Game").compopen;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        stateShift();
    }

    public virtual void enterState()
    {
        EnableSelf();
        setCurrentState(Presets.State.Running);

        eventMarkerLSLOutletController.sendStateOnEnterMarker(experimentState);

    }

    public virtual void exitState()
    {
        DisableSelf();
        setCurrentState(Presets.State.Ending);

        eventMarkerLSLOutletController.sendStateOnExitMarker(experimentState);
    }

    public virtual void interruptState()
    {
        DisableSelf();
        setCurrentState(Presets.State.Interrupt);

        eventMarkerLSLOutletController.sendStateOnInterruptMarker();
    }


    //public virtual void OnEnable()
    //{
    //    enterState();
    //}


    //public virtual void OnDisable()
    //{
    //    exitState();
    //}

    public void EnableSelf()
    {
        gameObject.SetActive(true);
        StateGraphicInterface.SetActive(true);
    }

    public void DisableSelf()
    {
        gameObject.SetActive(false);
        StateGraphicInterface.SetActive(false);
    }

    public Presets.State getCurrentState()
    {
        return currentState;
    }

    public void setCurrentState(Presets.State newState)
    {
        currentState = newState;
    }

    public void stateShift()
    {
        // check the key press and do state shfit
        if (Input.GetKeyDown(Presets.NextStateKey))
        {
            if (stateShiftValidCheck())
            {
                exitState();
            }
        }
        if (Input.GetKeyDown(Presets.InterruptKey))
        {
            interruptState();
        }
    }

    public virtual bool stateShiftValidCheck()
    {
        return true;
    }

}
