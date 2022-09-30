using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;

    // Start is called before the first frame update
    void Start()
    {
        // activeTweens = new List<Tween>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeTween != null)
        {
            if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
            {
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, (Time.time - activeTween.StartTime) / activeTween.Duration);
            }
            else
            {
                Debug.Log("5");
                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;
            }
        }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null)
        {
            Debug.Log("1");
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }

    float cubic(float num)
    {
        return num * num * num;
    }

    public bool tweenStatus()
    {
        if (activeTween == null)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
