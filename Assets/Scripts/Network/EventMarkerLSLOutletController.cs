using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMarkerLSLOutletController : LSLOutletInterface
{
    // Start is called before the first frame update
    void Start()
    {
        initLSLStreamOutlet(
                            Presets.EventMarkerLSLOutletStreamName,
                            Presets.EventMarkerLSLOutletStreamType,
                            Presets.EventMarkerChannelNum,
                            Presets.EventMarkerNominalSamplingRate,
                            LSL.channel_format_t.cf_float32
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sendStateOnEnterMarker(Presets.ExperimentState currentExperimentState)
    {

        //float[] currentStateMarker = new float[] { (float)currentExperimentState, 0, 0, 0, 0 , 0};
        //streamOutlet.push_sample(currentStateMarker);
        float[] eventMarkerArray = createEventMarkerArrayFloat();
        eventMarkerArray[(int)Presets.EventMarkerChannelInfo.StateEnterExitMarker] = (float)currentExperimentState;
        streamOutlet.push_sample(eventMarkerArray);
    }


    public void sendStateOnExitMarker(Presets.ExperimentState currentExperimentState)
    {
        float[] eventMarkerArray = createEventMarkerArrayFloat();
        eventMarkerArray[(int)Presets.EventMarkerChannelInfo.StateEnterExitMarker] = (float)currentExperimentState * -1; // revert the value to indicate exit
        streamOutlet.push_sample(eventMarkerArray);
    }

    

}
