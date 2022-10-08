using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTop : MonoBehaviour
{
    private Vector3 direction;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0.2f,0,0);
        count = 0;
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
