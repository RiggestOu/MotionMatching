﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MotionBoneData
{
    public Vector3 position;
    public Quaternion rotation;
    //Bone Velocity
    public Vector3 velocity;

    //Debug
    public string boneName;
    public int boneIndex;
}
