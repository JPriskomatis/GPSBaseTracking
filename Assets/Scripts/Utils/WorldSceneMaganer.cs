using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneMaganer : PocketDroidsSceneManagement
{
    private GameObject droid;
    private AsyncOperation loadScene;
    public override void DroidTapped(GameObject droid)
    {
        SceneManager.LoadScene(PocketDroidsConstants.SCENE_CAPTURE);
    }

    public override void PlayerTapped(GameObject player)
    {

    }
}
