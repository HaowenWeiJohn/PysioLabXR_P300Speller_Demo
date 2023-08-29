using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    // Start is called before the first frame update


    //public GameObject[,] gameBoard = new GameObject[10,10];
    //public List<GameObject> row_one = new List<GameObject>();

    [Header("Game Manager")]
    public GameManager gameManager;

    [Header("Row Char")]
    public CharactorController[] row_0 = new CharactorController[6];
    public CharactorController[] row_1 = new CharactorController[6];
    public CharactorController[] row_2 = new CharactorController[6];
    public CharactorController[] row_3 = new CharactorController[6];
    public CharactorController[] row_4 = new CharactorController[6];
    public CharactorController[] row_5 = new CharactorController[6];


    [Header("Col Char")]
    public CharactorController[] col_0 = new CharactorController[6];
    public CharactorController[] col_1 = new CharactorController[6];
    public CharactorController[] col_2 = new CharactorController[6];
    public CharactorController[] col_3 = new CharactorController[6];
    public CharactorController[] col_4 = new CharactorController[6];
    public CharactorController[] col_5 = new CharactorController[6];


    [Header("All Chars")]
    public CharactorController[] allChars = new CharactorController[36];

    public List<CharactorController[]> flashItems = new List<CharactorController[]>();


    void Start()
    {
        flashItems.Add(row_0);
        flashItems.Add(row_1);
        flashItems.Add(row_2);
        flashItems.Add(row_3);
        flashItems.Add(row_4);
        flashItems.Add(row_5);

        flashItems.Add(col_0);
        flashItems.Add(col_1);
        flashItems.Add(col_2);
        flashItems.Add(col_3);
        flashItems.Add(col_4);
        flashItems.Add(col_5);
        // 12 flash in total
    }




    // Update is called once per frame
    void Update()
    {
        
    }

    void setAllCharsToCharOffColor()
    {
        foreach (CharactorController charactorController in allChars)
        {
            charactorController.setOffColor();
        }
    }


    void setAllCharsToCharOnColor()
    {
        foreach (CharactorController charactorController in allChars)
        {
            charactorController.setOnColor();
        }
    }


    void allCharsGetSpriteRenderer()
    {
        foreach (CharactorController charactorController in allChars)
        {
            charactorController.getSpriteRenderer();
        }
    }

    public void setCharsToCharOnCholor(CharactorController[] charactorControllers)
    {
        foreach (CharactorController charactorController in charactorControllers)
        {
            charactorController.setOnColor();
        }
    }

    public void setCharsToCharOffCholor(CharactorController[] charactorControllers)
    {
        foreach (CharactorController charactorController in charactorControllers)
        {
            charactorController.setOffColor();
        }
    }

    private void OnEnable()
    {
        allCharsGetSpriteRenderer();
        setAllCharsToCharOffColor();
    }

    private void OnDisable()
    {
        setAllCharsToCharOffColor();
    }


    public IEnumerator TrainStateBoardCoroutine()
    {
        Debug.Log("Start Train Actions");

        yield return new WaitForSeconds(Presets.BoardEnableWaitTime);

        Debug.Log("Train Start");

        char[] trainCharsArray = gameManager.trainCharsArray;



        for (int i = 0; i < trainCharsArray.Length; i++)
        {
            // send flash block start marker
            gameManager.eventMarkerLSLOutletController.sendFlashBlockStartMarker();



            //gameManager.eventMarkerLSLOutletController.sendStateOnEnterMarker


            char targetChar = trainCharsArray[i];
            int targetCharIndex = Presets.P300SpellerCharInexDictionary[targetChar];
            CharactorController targetCharController = allChars[targetCharIndex];
            Debug.Log("Target Char: " +targetChar);
            Debug.Log("Target Char Index: " + targetCharIndex);
            targetCharController.setTrainHintColor();
            yield return new WaitForSeconds(Presets.HintDuration);
            targetCharController.setOffColor();
            yield return new WaitForSeconds(Presets.WaitDurationBeforeStartFlashing);

            setAllCharsToCharOffColor(); // make sure all char is off


            // flash char n times
            for (int j=0; j<gameManager.repeatTimes; j++)
            {
                // create random list
                int[] shuffledFlashSequence = Presets.Shuffle(Presets.flashElementIndexList);
                Debug.Log(shuffledFlashSequence);
                // flash each elements sequentially
                foreach(int flashItemIndex in shuffledFlashSequence)
                {
                    // set if target flashing marker
                    float targetFlashingMarker = 0;
                    foreach (CharactorController charactorControllers in flashItems[flashItemIndex]) {
                        if (charactorControllers == targetCharController) // if the target controler is in the array
                        {
                            targetFlashingMarker = 1;
                        }
                    }

                    // set all event markers off
                    gameManager.eventMarkerLSLOutletController.sendFlashMarker(1.0f, (float)flashItemIndex, (float)targetFlashingMarker);
                    
                    // turn on all event markers
                    setCharsToCharOnCholor(flashItems[flashItemIndex]);
                    // on wiat
                    yield return new WaitForSeconds(gameManager.flashDuration);
                    // turn off
                    setCharsToCharOffCholor(flashItems[flashItemIndex]);
                    // off wait
                    yield return new WaitForSeconds(gameManager.flashInterval);

                }
            }

            yield return new WaitForSeconds(Presets.FlashCharEndRestDuration);
            gameManager.eventMarkerLSLOutletController.sendFlashBlockEndMarker();
            yield return new WaitForSeconds(Presets.FlashCharEndRestDuration);
        }

        gameManager.trainStateController.exitState(); // exit train state



    }


    public IEnumerator TestStateBoardCoroutine()
    {
        Debug.Log("Start Test Actions");
        yield return new WaitForSeconds(Presets.BoardEnableWaitTime);
        //yield return new WaitForSeconds(Presets.HintDuration);
        //setAllCharsToCharOnColor();
        //yield return new WaitForSeconds(Presets.WaitDurationBeforeStartFlashing);
        //setAllCharsToCharOffColor();

        while (true)
        {
            // flash block start
            yield return new WaitForSeconds(Presets.WaitDurationBeforeStartFlashing);
            gameManager.eventMarkerLSLOutletController.sendFlashBlockStartMarker();
            // hint flash will start soon

            setAllCharsToCharOnColor();
            yield return new WaitForSeconds(Presets.HintDuration);
            setAllCharsToCharOffColor();
            yield return new WaitForSeconds(Presets.WaitDurationBeforeStartFlashing);

            for (int j = 0; j < gameManager.repeatTimes; j++)
            {
                // create random list
                int[] shuffledFlashSequence = Presets.Shuffle(Presets.flashElementIndexList);
                Debug.Log(shuffledFlashSequence);
                // flash each elements sequentially
                foreach (int flashItemIndex in shuffledFlashSequence)
                {
                    // turn on

                    gameManager.eventMarkerLSLOutletController.sendFlashMarker(1.0f, (float)flashItemIndex, 0.0f);
                    setCharsToCharOnCholor(flashItems[flashItemIndex]);
                    // send event marker

                    // on wiat
                    yield return new WaitForSeconds(gameManager.flashDuration);
                    // turn off
                    setCharsToCharOffCholor(flashItems[flashItemIndex]);
                    // off wait
                    yield return new WaitForSeconds(gameManager.flashInterval);

                }
            }

            yield return new WaitForSeconds(Presets.FlashCharEndRestDuration);
            gameManager.eventMarkerLSLOutletController.sendFlashBlockEndMarker();
            yield return new WaitForSeconds(Presets.FlashCharEndRestDuration);

        }


    }




}

