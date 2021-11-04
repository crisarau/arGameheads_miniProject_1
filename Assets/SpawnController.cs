using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpawnController : MonoBehaviour
{

//    public GameObject mCubeObj;
//
//    public int mTotalCubes = 10;
//
//    private GameObject[] mCubes;
//
//    private bool mPositionSet;
//
//    // Define the position if the object
//    // according to ARCamera position
//    private bool SetPosition()
//	{
//		// get the camera position
//		Transform cam = Camera.main.transform;
//
//		// set the position 10 units forward from the camera position
//		transform.position = cam.forward * 10;
//		return true;
//	}
//
//    private IEnumerator ChangePosition(){
//        yield return new WaitForSeconds(0.2f);
//		// Define the Spawn position only once
//		if ( !mPositionSet ){
//			// change the position only if Vuforia is active
//			if ( VuforiaBehaviour.Instance.enabled )
//				SetPosition();
//		}
//    }
//
//    private IEnumerator SpawnLoop(){
//
//        // Defining the Spawning Position
//		StartCoroutine( ChangePosition() );
//
//		yield return new WaitForSeconds(0.2f);
//
//		// Spawning the elements
//		int i = 0;
//		while ( i <= (mTotalCubes-1) ) {
//
//			mCubes[i] = SpawnElement();
//			i++;
//			yield return new WaitForSeconds(Random.Range(mTimeToSpawn, mTimeToSpawn*3));
//		}
//    }
//
//
//    // Start is called before the first frame update
//    void Start()
//    {
//        
//    }
//
//    // Update is called once per frame
//    void Update()
//    {
//        
//    }
}
