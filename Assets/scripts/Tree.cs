using UnityEngine;

public class Tree : MonoBehaviour
{
    //setting variables 
    //using animationCurve to make the tree shrink and grow continuously like having a bouncing effect 
    public AnimationCurve curve;
    //this variable controls the sizes of the tree when its changing
    public float treeChangingSize;
    //this variable set the speed of how fast the tree changes its size
    public float speed;

    //set the start size of the tree
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

        //use Time.deltaTime*speed to make the object moves through the animation curve
        progress += Time.deltaTime*speed;
        //loop the animation 
        if (progress > 1f)
        {
            progress = 0f;
        }
        //get the current curve value
        float curveValue = curve.Evaluate(progress);
        //change the size of the tree according to the curve value
        float newSize = 1f + curveValue * treeChangingSize;
        transform.localScale = startSize * newSize;

    }
}
