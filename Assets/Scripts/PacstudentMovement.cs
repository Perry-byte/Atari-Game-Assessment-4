using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacstudentMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject item;
    private Tweener tweener;
    [SerializeField]
    private AudioSource music;
    private bool one = false;
    private bool two = false;
    private bool three = false;
    private bool four = false;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Tweener>().tweenStatus() && one == false)
        {
            item.transform.rotation = Quaternion.identity;
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-11.95f, 4.71f, 2.21f), 1.5f);
            one = true;
        }

        if (gameObject.GetComponent<Tweener>().tweenStatus() && two == false)
        {
            item.transform.Rotate(0.0f,0.0f,-90.0f, Space.World);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-11.95f, -1.2f, 2.21f), 1.5f);
            two = true;
        }

        if (gameObject.GetComponent<Tweener>().tweenStatus() && three == false)
        {
            item.transform.Rotate(0.0f, 180.0f, 90.0f, Space.World);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-19.0f, -1.2f, 2.21f), 1.5f);
            three = true;
        }

        if (gameObject.GetComponent<Tweener>().tweenStatus() && four == false)
        {
            item.transform.Rotate(0.0f, 180.0f, 270.0f, Space.World);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-19.0f, 4.71f, 2.21f), 1.5f);
            one = false;
            two = false;
            three = false;
            four = false;
        }
    }
}
