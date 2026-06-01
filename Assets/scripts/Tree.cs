using UnityEngine;

public class Tree : MonoBehaviour
{
    public AnimationCurve curve;
    public float treeChangingSize;
    public float speed;

    private Vector3 startSize;
    private float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime*speed;
        if (progress > 1f)
        {
            progress = 0f;
        }

        float curveValue = curve.Evaluate(progress);
        float newSize = 1f + curveValue * treeChangingSize;
        transform.localScale = startSize * newSize;

    }
}
