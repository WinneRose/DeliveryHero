using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeBox : MonoBehaviour
{
    [SerializeField] GameObject boxObj;
    [SerializeField] int boxCount;
    [SerializeField] GameObject boxRangeStart;
    [SerializeField] GameObject boxRangeEnd;

    void Start()
    {
        float tempPosX;
        float tempPosY;

        

        for (int i = 0; i < boxCount; i++)
        {
            tempPosX = Random.Range(boxRangeStart.transform.position.x, boxRangeEnd.transform.position.x);
            tempPosY = Random.Range(boxRangeStart.transform.position.y, boxRangeEnd.transform.position.y);
            Instantiate(boxObj, new Vector2(tempPosX, tempPosY), Quaternion.identity);
        }
    }

   
}
