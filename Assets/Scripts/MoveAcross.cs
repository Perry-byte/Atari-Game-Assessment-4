using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAcross : MonoBehaviour
{
    private Vector3 direction;
    private int count;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        pos = gameObject.transform.position;
        if (pos.y > 0)
        {
            direction = new Vector3(0.2f, 0, 0);
        } else
        {
            direction = new Vector3(-0.2f, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(direction);
        count++;
        if (count == 50)
        {
            count = 0;
            if (direction == new Vector3(0.2f, 0, 0))
            {
                direction = new Vector3(-0.2f, 0, 0);
            } else
            {
                direction = new Vector3(0.2f, 0, 0);
            }
        }
    }
}
