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
        /*if (move.x < -3.75 || (move.x > -3.4 && move.x < -1.9 && move.y < 5 && move.y > 4) || (move.y > 4 && move.y < 5 && move.x < 0.2 && move.x > -1.6))
        {
            return true;
        }
        if ((move.y < 3.5 && move.y > 2.75 && move.x > -3.4 && move.x < -2.1) || (move.y < 2.5 && move.y > 0.67 && move.x > -3.77 && move.x < -2.1) || (move.y < 3.47 && move.y > 0.63 && move.x > -1.71 && move.x < -0.78) || (move.y < 2.6 && move.y > 1.64 && move.x > -0.78 && move.x < 0.19) || (move.y > 3.9 && move.x > 0.6 && move.x < 1.5))
        {
            return true;
        }
        if ((move.y < 5 && move.y > 4 && move.x > 1.88 && move.x < 3.83) || (move.y < 5 && move.y > 4 && move.x > 4 && move.x < 5.64) || (move.x > 5.92 && move.y < 5.32 && move.y > 2.57) || (move.y < 3.43 && move.y > 2.84 && move.x > 4 && move.x < 5.64) || (move.y < 3.5 && move.y > 2.72 && move.x > -0.31 && move.x < 2.6) || (move.y < 2.89 && move.y > 1.65 && move.x > 0.67 && move.x < 1.55))
        {
            return true;
        }
        if ((move.y < 3.46 && move.y > 0.51 && move.x > 3.12 && move.x < 3.75) || (move.y < 2.44 && move.y > 1.57 && move.x > 1.92 && move.x < 3.85) || (move.y < 2.5 && move.y > 0.56 && move.x > 4.07 && move.x < 5.91))
        {
            return true;
        }*/


        if ((move.y > -2.21 && move.y < -0.66 && move.x < -1.97) || (move.y > -2.21 && move.y < -0.66 && move.x > 4.28) || (move.y > 0.791 && move.y < 2.3 && move.x < -1.97) || (move.y > 0.791 && move.y < 2.3 && move.x > 4.28)) // Holes on Side
        {
            return true;
        }
        if ((move.y > 0.47 && move.y < 3.55 && move.x > -1.5 && move.x < -0.4) || (move.y > 1.6 && move.y < 2.48 && move.x > -1.5 && move.x < 0.342) || (move.y > 0.47 && move.y < 3.55 && move.x > 2.85 && move.x < 3.83) || (move.y > 1.6 && move.y < 2.48 && move.x > 1.68 && move.x < 3.83)) // Top Side T
        {
            return true;
        }
        if ((move.y > -3.63 && move.y < -0.34 && move.x > -1.5 && move.x < -0.4) || (move.y > -2.416 && move.y < -1.423 && move.x > -1.5 && move.x < 0.342) || (move.y > -3.63 && move.y < -0.34 && move.x > 2.85 && move.x < 3.83) || (move.y > -2.416 && move.y < -1.423 && move.x > 1.68 && move.x < 3.83)) // Bottom Side T
        {
            return true;
        }
        if ((move.y > 2.73 && move.y < 3.51 && move.x > -0.44 && move.x < 2.57) || (move.y > 1.66 && move.y < 3.51 && move.x > 0.76 && move.x < 1.41)) // Top T
        {
            return true;
        }
        if ((move.y > -3.41 && move.y < -2.76 && move.x > -0.44 && move.x < 2.57) || (move.y > -3.41 && move.y < -1.58 && move.x > 0.76 && move.x < 1.41)) // Bottom T
        {
            return true;
        }
        if ((move.y > -3.41 && move.y < -2.76 && move.x > -3.36 && move.x < -2.04) || (move.y > -3.41 && move.y < -2.76 && move.x > 4.24 && move.x < 5.6)) // Top Small Rect
        {
            return true;
        }
        if ((move.y > 2.76 && move.y < 3.3 && move.x > -3.36 && move.x < -2.04) || (move.y > 2.76 && move.y < 3.3 && move.x > 4.24 && move.x < 5.6)) // Bottom Small Rect
        {
            return true;
        }
        if ((move.y > 4.03 && move.y < 4.89 && move.x > -3.36 && move.x < -2.04) || (move.y > 4.03 && move.y < 4.89 && move.x > 4.24 && move.x < 5.6)) // Top Medium Rect
        {
            return true;
        }
        if ((move.y > -4.82 && move.y < -3.95 && move.x > -3.36 && move.x < -2.04) || (move.y > -4.82 && move.y < -3.95 && move.x > 4.24 && move.x < 5.6)) // Bottom Medium Rect
        {
            return true;
        }
        return false;
    }
}
