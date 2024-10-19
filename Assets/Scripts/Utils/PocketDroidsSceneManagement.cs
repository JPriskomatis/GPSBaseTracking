using Mapbox.Unity.Map;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PocketDroidsSceneManagement : MonoBehaviour
{
    public abstract void PlayerTapped(GameObject player);
    public abstract void DroidTapped(GameObject droid);
}
