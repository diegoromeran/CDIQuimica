 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using Vuforia;
 
 public class MTrackableBehaviour : MonoBehaviour, ITrackableEventHandler
 {
 
     protected TrackableBehaviour mTrackableBehaviour;
     public bool isTracked=false;
     public GameObject carbono, hidrogeno;
 
 
     protected virtual void Awake()
     {
         mTrackableBehaviour = GetComponent<TrackableBehaviour>();
         if (mTrackableBehaviour)
             mTrackableBehaviour.RegisterTrackableEventHandler(this);
 
         carbono.SetActive(false);
     }
 
 
 
     public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
     {
 
         if (newStatus == TrackableBehaviour.Status.DETECTED ||
             newStatus == TrackableBehaviour.Status.TRACKED ||
             newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
         {
             trackedBehaviour();
 
         }
         else if (previousStatus == TrackableBehaviour.Status.TRACKED)
         {
             trackLostBehaviour();
         }
         else
         {
             trackLostBehaviour();
         }
     }
 
 
     private void trackedBehaviour()
     {
         isTracked = true;
 
         if (!isBothTargetsTracked())
             carbono.SetActive(true);
         else
             hidrogeno.SetActive(true);
     }
 
     private void trackLostBehaviour()
     {
         isTracked = false;
         carbono.SetActive(false);
         hidrogeno.SetActive(false);
     }
 
     private bool isBothTargetsTracked()
     {
         bool value = true;
 
         foreach (MTrackableBehaviour m in FindObjectsOfType<MTrackableBehaviour>())
         {
             if (!m.isTracked)
                 value = false;
         }
         return value;
     }
 
 }
