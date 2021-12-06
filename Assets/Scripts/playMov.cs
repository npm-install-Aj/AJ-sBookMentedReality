using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
public class playMov : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
    //  GameObject obj = GameObject.Find("VideoOne");
    //         var videoPlayer = obj.GetComponent<UnityEngine.Video.VideoPlayer>();
    //          videoPlayer.url = "Assets/videoAssets/video1.mp4";
    //         videoPlayer.Play(); 
      
    } 

//     // Update is called once per frame
//    void EndReached(UnityEngine.Video.VideoPlayer vp)
//     {
//         vp.playbackSpeed = vp.playbackSpeed / 10.0F;
//     }

     void OnBecameInvisible()
    {
        GameObject obj = GameObject.Find("VideoOne");
         var videoPlayer = obj.GetComponent<UnityEngine.Video.VideoPlayer>();
         videoPlayer.Stop();
         Debug.Log("stopped...");
     
    }

   void OnBecameVisible()
    {
        
            GameObject obj = GameObject.Find("VideoOne");
            var videoPlayer = obj.GetComponent<UnityEngine.Video.VideoPlayer>();
             videoPlayer.url = "https://vimeo.com/31087450";
             videoPlayer.Prepare();
             Debug.Log("VideoPlayerPrepared");
            videoPlayer.Play(); 
            Debug.Log("Started again...");

            
   }
        
        //   videoPlayer.targetCameraAlpha = 0.9F;
        
       
       
        
      

}
