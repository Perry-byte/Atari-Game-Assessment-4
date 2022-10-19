using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    KeyCode lastInput;
    Vector3 move;
    [SerializeField]
    Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")) {
            move = gameObject.transform.position + new Vector3(-0.35f, 0.0f, 0.0f);
            if (checkCollision()) {
                Debug.Log("stop");
            } else
            {
                tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(-0.36f, 0.0f, 0.0f), 0.5f);
                lastInput = KeyCode.A;
            }
        }
        if (Input.GetKeyDown("d"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.36f, 0.0f, 0.0f), 0.5f);
            lastInput = KeyCode.D;
        }
        if (Input.GetKeyDown("w"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, 0.36f, 0.0f), 0.5f);
            lastInput = KeyCode.W;
        }
        if (Input.GetKeyDown("s"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, -0.36f, 0.0f), 0.5f);
            lastInput = KeyCode.S;
        }
    }

    bool checkCollision() {
        if (move.x < -3.75 || (move.x > -3.66 && move.x < -1.79 && move.y < 4.9 && move.y > 3.8))
        {
            return true;
        }
        return false;
    }
}
