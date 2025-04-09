using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    myAnimator = this.gameObject.GetComponent<Animator>();


    private Animator myAnimator;
    private float horizDir;
    private float vertDir;
    }

    // Update is called once per frame
    void Update()

{
    horizDir = Input.GetAxis("Horizontal")
    vertDir = Input.GetAxis("Vertical")

        if (horizDir < 0)
    {
        myAnimator.SetInteger("direction", 1)
    }
    else if (horizDir > 0)
    {
        myAnimator.SetInterger("direction", 3)
    }
    
    else if (vertDir < 0)
    {
        myAnimator.SetInterger("direction", 2)
    }
    
    else if (vertDir > 0)
    { 
        myAnimator.SetInterger("direction", 0)
    }
}
