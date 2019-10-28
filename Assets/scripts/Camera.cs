using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 currentPosition;
    Vector3 total;
    Vector3 center;
    float x;
    float z;

    void Start()
    {
        Pathmaker.floorList = new List<Transform>();
        currentPosition = Vector3.zero;
        Pathmaker.floorList = new List<Transform>();
        x = 0;
        z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        // for(int i = 0; i<Pathmaker.floorList.Count;i++){
        //     if(Pathmaker.floorList[i] == null){
        //         Pathmaker.floorList.RemoveAt(i);
        //     }
        // }
        
        if(Pathmaker.globalTileCount<Pathmaker.MaxTile){
            total = Vector3.zero;
            foreach(Transform a in Pathmaker.floorList){
                total+=a.position;
                center = total/Pathmaker.floorList.Count;
                //Debug.Log(total);
            }
        }
        

        currentPosition = new Vector3(center.x,Pathmaker.globalTileCount*0.2f+100f,center.z);
        transform.position = currentPosition;
        
    }
}
