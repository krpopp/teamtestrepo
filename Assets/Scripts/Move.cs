using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //i have made some changes!
        //wow!
        //game of the year

        //i see those changes
        //amazing!
        //so glad to be working with you, comrade

        //by the way, how do you do games again
    }

    // Update is called once per frame
    void Update()
    {
        MoveChar();
    }

    void MoveChar()
    {
        Vector3 newPos = transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPos.y += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            newPos.y -= speed * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            newPos.x += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPos.x -= speed * Time.deltaTime;
        }
        transform.position = newPos;
    }

}
