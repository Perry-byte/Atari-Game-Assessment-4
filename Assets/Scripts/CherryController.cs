using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    [SerializeField]
    Tweener tweener;
    float yValue;

    // Start is called before the first frame update
    void Start()
    {
        yValue = Random.Range(-6.0f, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time % 10 == 0)
        {
            Debug.Log("Move");
            Instantiate(gameObject);
            gameObject.transform.position = new Vector3(13.0f, yValue, 0.0f);
            moves();
        }
    }

    private void moves()
    {
        StartCoroutine(move());
    }

    public IEnumerator move()
    {
        float currentTime = 0.0f;
        while (currentTime < 2.0f)
        {
            gameObject.transform.position = new Vector3(Mathf.Lerp(13.0f, 0.0f, currentTime / 2.0f), Mathf.Lerp(yValue, 0.0f, currentTime / 2.0f), gameObject.transform.position.z);
            currentTime += Time.deltaTime;
            yield return null;
        }
        yield return null;
        gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        StartCoroutine(move1());
        //gameObject.transform.position = new Vector3(-13.0f, -1 * yValue, gameObject.transform.position.z);
    }
    public IEnumerator move1()
    {
        float currentTime = 0.0f;
        while (currentTime < 2.0f)
        {
            gameObject.transform.position = new Vector3(Mathf.Lerp(0.0f, -13.0f, currentTime / 2.0f), Mathf.Lerp(0.0f, -1 * yValue, currentTime / 2.0f), gameObject.transform.position.z);
            currentTime += Time.deltaTime;
            yield return null;
        }
        yield return null;
        gameObject.transform.position = new Vector3(-13.0f, -1 * yValue, gameObject.transform.position.z);
        Destroy(gameObject);
    }
}
