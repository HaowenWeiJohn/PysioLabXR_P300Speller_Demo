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


    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    





}
