using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 8f, Zsize = 8f;

    public GameObject FoodPrefab;

    public Vector3 curPosition;

    public GameObject CurFood;

    void AddNewFood()
    {
        RandomPosition();
        CurFood = GameObject.Instantiate(FoodPrefab, curPosition, Quaternion.identity) as GameObject;
    }

    void RandomPosition()
    {
        curPosition = new Vector3(Random.Range((XSize * -1), XSize), 0.25f, Random.Range((Zsize * -1), Zsize));
    }

    //every frame
    void Update()
    {
        if (!CurFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
