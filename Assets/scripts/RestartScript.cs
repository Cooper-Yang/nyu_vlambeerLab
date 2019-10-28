using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public Transform pathMakingS;
    
    void Start(){
        Pathmaker.globalTileCount = 0;
        Instantiate(pathMakingS,new Vector3(0,0,0),Quaternion.Euler(0,0,0));

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(0);
            //Application.LoadLevel(Application.loadedLevel);
		}
    }
}
