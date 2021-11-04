using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    
    Animator animator;
    int isDancingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isDancingHash = Animator.StringToHash("isDancing");
    }

    // Update is called once per frame
    void Update()
    {
        bool isDancing = animator.GetBool(isDancingHash);
        bool dancePressed = Input.GetKey("w");
        //highly inneficient btw...but just a dmeo
        if(!isDancing && dancePressed){
            animator.SetBool("isDancing", true);
        }
        if(isDancing && !dancePressed){
            animator.SetBool("isDancing", false);
        }
    }


}
