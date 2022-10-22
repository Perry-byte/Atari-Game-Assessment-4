using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    [SerializeField]
    Tweener tweener;
    float yValue;
    [SerializeField]
    GameObject energy;
    GameObject cherry;
    bool generate;

    // Start is called before the first frame update
    void Start()
    {
        generate = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time % 10.0f < 1.0f && Time.time > 1.0f && generate == false)
        {
            Debug.Log("Move");
            yValue = Random.Range(-6.0f, 6.0f);
            cherry = Instantiate(energy, new Vector3(13.0f, yValue, 0.0f), Quaternion.identity);
            generate = true;
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
            cherry.transform.position = new Vector3(Mathf.Lerp(13.0f, 0.0f, currentTime / 2.0f), Mathf.Lerp(yValue, 0.0f, currentTime / 2.0f), cherry.transform.position.z);
            currentTime += Time.deltaTime;
            yield return null;
        }
        yield return null;
        cherry.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        StartCoroutine(move1());
        //gameObject.transform.position = new Vector3(-13.0f, -1 * yValue, gameObject.transform.position.z);
    }
    public IEnumerator move1()
    {
        float currentTime = 0.0f;
        while (currentTime < 2.0f)
        {
            cherry.transform.position = new Vector3(Mathf.Lerp(0.0f, -13.0f, currentTime / 2.0f), Mathf.Lerp(0.0f, -1 * yValue, currentTime / 2.0f), cherry.transform.position.z);
            currentTime += Time.deltaTime;
            yield return null;
        }
        yield return null;
        cherry.transform.position = new Vector3(-13.0f, -1 * yValue, cherry.transform.position.z);
        Destroy(cherry);
        generate = false;
    }
}
