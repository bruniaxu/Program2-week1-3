using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Pulser : MonoBehaviour
{
    public AnimationCurve curve;
    public float startSize;
    public float endSize;

    public float duration;

    private float progress = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        transform.localScale = curve.Evaluate(progress / duration) * Vector3.one;


    }
}
