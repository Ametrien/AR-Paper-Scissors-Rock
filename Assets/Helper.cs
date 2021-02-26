using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Helper: DefaultTrackableEventHandler {
protected override void OnTrackingFound()
  {
    base.OnTrackingFound ();
      for (int a = 0; a < transform.childCount; a++){
        transform.GetChild(a).gameObject.SetActive(true);
      }
  }
  protected override void OnTrackingLost()
  {
    base.OnTrackingLost ();
      for (int a = 0; a < transform.childCount; a++){
        transform.GetChild(a).gameObject.SetActive(false);
      }
  }
}
