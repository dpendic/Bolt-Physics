﻿using UnityEngine;
using System.Collections;

public class TPCspawner : Bolt.GlobalEventListener
{

    // Use this for initialization
    public override void SceneLoadLocalDone(string map)
    {
        BoltNetwork.Instantiate(BoltPrefabs.ThirdPersonControllerClientAuth, new Vector3(0,-1f,0), Quaternion.identity);
        Debug.Log("wew");
    }


}
