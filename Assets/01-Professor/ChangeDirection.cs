using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    private Animator myAnimator;
    private float horizDir;
    private float vertDir;


    // Start is called before the first frame update
    void Start()
    {
        // find the animator
        myAnimator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //read from the keyboard
        horizDir = Input.GetAxis("Horizontal");
        vertDir = Input.GetAxis("Vertical");

        // use the input to send a message to the animator
        if (horizDir < 0)
        {
            myAnimator.SetInteger("direction", 1);
        }
        else if (horizDir > 0)
        {
            myAnimator.SetInteger("direction", 3);
        }
        else if (vertDir > 0)
        {
            myAnimator.SetInteger("direction", 2);
        }
        else if (vertDir < 0)
        {
            myAnimator.SetInteger("direction", 0);
        }
        // let professor stay in direction last chosen
        //else  // this would be the idle state - go North by default
        //{
        //    myAnimator.SetInteger("direction", 0);
        //}

    }
}
