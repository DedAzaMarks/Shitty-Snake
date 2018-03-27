using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{


    public float Speed;

    public Vector3 TailTarget;

    public GameObject TailTatgrObject;

    public int Indx;

    public SnakeMovement MainSnake;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if (Indx > 2)
            {
                Application.LoadLevel(Application.loadedLevel);

            }
        } 
    }
    // Use this for initialization
    void Start()
    {
        MainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        Speed = (MainSnake.Speed) + 2.75f;
        TailTatgrObject = MainSnake.TailObjects[MainSnake.TailObjects.Count - 2];

        Indx = MainSnake.TailObjects.IndexOf(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        TailTarget = TailTatgrObject.transform.position;
        transform.LookAt(TailTarget);
        transform.position = Vector3.Lerp(transform.position, TailTarget, Time.deltaTime * Speed);
    }


}
