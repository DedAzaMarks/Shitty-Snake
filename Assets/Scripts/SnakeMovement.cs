using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{

    public float Speed = 2;

    public float RotationSpeed;

    public List<GameObject> TailObjects = new List<GameObject>();

    public float ZOffSet = -0.5f; //смещение хвота змени при появлении

    public GameObject TailPrefab;

    public Text ScoreText;
    private int Score = 0;


    public void AddTail()
    {
        Score++;
        Vector3 NewTailPos = TailObjects[TailObjects.Count - 1].transform.position;
        NewTailPos.z -= ZOffSet;

        TailObjects.Add(GameObject.Instantiate(TailPrefab, NewTailPos, Quaternion.identity) as GameObject);
    }
    // Use this for initialization
    void Start()
    {
        TailObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -1 * RotationSpeed * Time.deltaTime);
        }
    }


}
