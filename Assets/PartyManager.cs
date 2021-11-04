using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class PartyManager : MonoBehaviour
{

    [SerializeField]
    bool isParty;

    [SerializeField]
    float currentAnimationSpeed;

    [SerializeField]
    int currentActive;

    bool isInitialized;

    AudioSource audioSource;


    [SerializeField]
    List<animationDanceController> characters;
    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        currentAnimationSpeed = 1f;
        //characters = new List<animationDanceController>();
        //currentActive = 0;
        VuforiaApplication.Instance.OnVuforiaStarted += OnVuforiaStarted;
        VuforiaApplication.Instance.OnVuforiaStopped += OnVuforiaStopped;

    }

    public void ToggleParty(){
        isParty = !isParty;
        if(isParty){
            //was false, now turn on.
            audioSource.time = 2;
            audioSource.Play();
        }else{
            //was true, now turn off
            audioSource.Stop();
        }
        
        foreach(animationDanceController guestController in characters){
            guestController.ChangeDance(isParty);
        }
    }

    //changes speed and active based on how many are there
    public void OnRegisteredTarget(){
        if(isInitialized){
            currentActive += 1; 
            currentActive = Mathf.Abs(currentActive);
            SetSpeedOfAllAnimators();
        }
    }

    public void OnLosingTarget(){
        if(isInitialized){
            currentActive -= 1; 
            currentActive = Mathf.Abs(currentActive);
            SetSpeedOfAllAnimators();
        }
        
        //have an error
    }

    public void SetSpeedOfAllAnimators(){
        currentAnimationSpeed = 1.0f + ((currentActive-1) /* * 0.5f*/);

        foreach(animationDanceController guestController in characters){
            guestController.ChangeSpeed(currentAnimationSpeed);
        }        
    }
    public void OnVuforiaStopped(){
        isInitialized = false;
    }
    public void OnVuforiaStarted(){
        isInitialized = true;
    }

}
