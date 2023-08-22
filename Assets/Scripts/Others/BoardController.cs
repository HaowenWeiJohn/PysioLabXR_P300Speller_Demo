using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    // Start is called before the first frame update


    //public GameObject[,] gameBoard = new GameObject[10,10];
    //public List<GameObject> row_one = new List<GameObject>();
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



    private void OnEnable()
    {
        allCharsGetSpriteRenderer();
        setAllCharsToCharOffColor();
    }

    void allCharsGetSpriteRenderer()
    {
        foreach (CharactorController charactorController in allChars)
        {
            charactorController.getSpriteRenderer();
        }
    }


    public void OnBeforeTransformParentChanged()
    {
        
    }


}
