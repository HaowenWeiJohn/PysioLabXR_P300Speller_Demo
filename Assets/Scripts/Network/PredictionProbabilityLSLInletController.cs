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
        pullPredictionProbabilitySample();
    }

    void pullPredictionProbabilitySample()
    {
        if (activated)
        {
            pullSample();
            clearBuffer();
        }
    }


}
