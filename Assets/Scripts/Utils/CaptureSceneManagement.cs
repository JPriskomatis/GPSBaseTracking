using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManagement : PocketDroidsSceneManagement
{
    public override void DroidTapped(GameObject droid)
    {
        print("CaptureSceneManager.droidTapped activated");
    }

    public override void PlayerTapped(GameObject player)
    {
        print("CaptureSceneManager.playerTapped activated");
    }
}
