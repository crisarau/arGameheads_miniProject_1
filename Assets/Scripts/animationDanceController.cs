using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationDanceController : MonoBehaviour
{
    [SerializeField]
    bool partyOn;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        partyOn = false;
        animator = GetComponent<Animator>();
    }

    public void ChangeDance(bool danceState){
        if(danceState){
            animator.SetBool("isDancing", danceState);
            partyOn = true;
        }else{
            animator.SetBool("isDancing", danceState);
            partyOn = false;
        }
    }

    public void ChangeSpeed(float speed){
        animator.speed = speed;
    }
}
