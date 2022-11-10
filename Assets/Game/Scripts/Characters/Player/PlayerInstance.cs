using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : Singleton<PlayerInstance>
{
    public Vector3 position;

    private void Update()
    {
        position = transform.position;
    }
}
