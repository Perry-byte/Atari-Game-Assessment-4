using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    Vector3 lastInput = new Vector3(0.0f,0.0f,0.0f);
    Vector3 currentInput = new Vector3(0.0f, 0.0f, 0.0f);
    [SerializeField]
    Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            currentInput = gameObject.transform.position + new Vector3(-0.36f, 0.0f, 0.0f);
            if (checkCollision(currentInput))
            {
                Debug.Log("stop");
            }
            else
            {
                tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(-0.36f, 0.0f, 0.0f), 0.5f);
            }
            lastInput = gameObject.transform.position + new Vector3(-0.36f, 0.0f, 0.0f);
        }
        else if (Input.GetKeyDown("d"))
        {
            currentInput = gameObject.transform.position + new Vector3(0.36f, 0.0f, 0.0f);
            if (checkCollision(currentInput))
            {
                Debug.Log("stop");
            }
            else
            {
                tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.36f, 0.0f, 0.0f), 0.5f);
            }
            lastInput = gameObject.transform.position + new Vector3(0.36f, 0.0f, 0.0f);
        }
        else if (Input.GetKeyDown("w"))
        {
            currentInput = gameObject.transform.position + new Vector3(0.0f, 0.36f, 0.0f);
            if (checkCollision(currentInput))
            {
                Debug.Log("stop");
            }
            else
            {
                tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, 0.36f, 0.0f), 0.5f);
            }
            lastInput = gameObject.transform.position + new Vector3(0.0f, 0.36f, 0.0f);
        }
        else if (Input.GetKeyDown("s"))
        {
            currentInput = gameObject.transform.position + new Vector3(0.0f, -0.36f, 0.0f);
            if (checkCollision(currentInput))
            {
                Debug.Log("stop");
            }
            else
            {
                tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, -0.36f, 0.0f), 0.5f);
            }
            lastInput = gameObject.transform.position + new Vector3(0.0f, -0.36f, 0.0f);
        }
        else if (checkCollision(lastInput)) { 
            
        }
    }

    bool checkCollision(Vector3 move) {
        if (move.x < -3.75 || (move.x > -3.66 && move.x < -1.79 && move.y < 4.9 && move.y > 3.8))
        {
            return true;
        }
        return false;
    }
}
