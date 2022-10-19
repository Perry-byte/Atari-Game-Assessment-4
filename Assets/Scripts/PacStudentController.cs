using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    Input lastInput;
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
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(-0.35f,0.0f,0.0f), 1.5f);
        }
        if (Input.GetKeyDown("d"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.35f, 0.0f, 0.0f), 1.5f);
        }
        if (Input.GetKeyDown("w"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, 0.35f, 0.0f), 1.5f);
        }
        if (Input.GetKeyDown("s"))
        {
            tweener.AddTween(gameObject.transform, gameObject.transform.position, gameObject.transform.position + new Vector3(0.0f, -0.35f, 0.0f), 1.5f);
        }
    }
}
