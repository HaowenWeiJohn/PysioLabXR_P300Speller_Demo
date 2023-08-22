using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorController : MonoBehaviour
{
    // Start is called before the first frame update

    //public List<CharactorController> row_1 = new List<CharactorController>();
    //public CharactorController[] row_1 = new CharactorController[6];
    public Presets.Character character;


    //public Color OnColor;
    //public Color OffColor;

    //public Color trainTargetHintColor;

    private SpriteRenderer spriteRenderer;


    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.color = Presets.CharOffColor;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setColor(Color color)
    {
        spriteRenderer.color = color;
    }

    public void setOffColor()
    {
        spriteRenderer.color = Presets.CharOffColor;
    }

    public void setOnColor()
    {
        spriteRenderer.color = Presets.CharOnColor;
    }

    public void setTrainHintColor(Color color)
    {

    }

    public void getSpriteRenderer()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

}
