using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredictionProbabilityLSLInletController : LSLInletInterface
{
    // Start is called before the first frame update
    void Start()
    {
        streamName = Presets.PredictionProbabilityLSLInletStreamName;
        StartContinousResolver();
    }

    // Update is called once per frame
    void Update()
    {
        //pullPredictionProbabilitySample(); // this function has been called in the board controller for each time we wait for prediction 
    }

    public void pullPredictionProbabilitySample()
    {
        if (streamActivated)
        {
            pullSample();
            clearBuffer();
        }
    }


}
