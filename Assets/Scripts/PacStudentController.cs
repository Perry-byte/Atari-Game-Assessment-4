using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    Vector3 lastInput;
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
            lastInput = gameObject.transform.position + new Vector3(-0.35f, 0.0f, 0.0f);
            if (checkCollision()) {
                Debug.Log("stop");
            } else
            {
                tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(-0.36f, 0.0f, 0.0f), 0.5f);
            }
        }
        if (Input.GetKeyDown("d"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.36f, 0.0f, 0.0f), 0.5f);
        }
        if (Input.GetKeyDown("w"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, 0.36f, 0.0f), 0.5f);
        }
        if (Input.GetKeyDown("s"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, -0.36f, 0.0f), 0.5f);
        }
    }

    bool checkCollision() {
        if (lastInput.x < -3.75 || (lastInput.x > -3.66 && lastInput.x < -1.79 && lastInput.y < 4.9 && lastInput.y > 3.8))
        {
            return true;
        }
        return false;
    }
}
