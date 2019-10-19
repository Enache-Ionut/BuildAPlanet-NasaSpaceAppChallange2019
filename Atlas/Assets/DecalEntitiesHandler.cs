using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalEntitiesHandler : MonoBehaviour
{
    public List<string> decalNames;
    public List<Sprite> cursorDecals;
    public SpriteRenderer cursorRender;

    TexturePainter texturePainter;

    // Start is called before the first frame update
    void Start()
    {
        texturePainter = GetComponent<TexturePainter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPaintDecal(string decalName)
    {
        switch (decalName)
        {
            case "EarthEntity":
                texturePainter.cursorDecal = cursorDecals[0];
                cursorRender.sprite = cursorDecals[0];
                texturePainter.decalEntityName = "EarthEntity";
                break;
            case "MountainEntity":
                texturePainter.cursorDecal = cursorDecals[1];
                cursorRender.sprite = cursorDecals[1];
                texturePainter.decalEntityName = "MountainEntity";
                break;
            case "SandEntity":
                texturePainter.cursorDecal = cursorDecals[2];
                cursorRender.sprite = cursorDecals[2];
                texturePainter.decalEntityName = "SandEntity";
                break;
            case "WaterEntity":
                texturePainter.cursorDecal = cursorDecals[3];
                cursorRender.sprite = cursorDecals[3];
                texturePainter.decalEntityName = "WaterEntity";
                break;
        }
    }
}
