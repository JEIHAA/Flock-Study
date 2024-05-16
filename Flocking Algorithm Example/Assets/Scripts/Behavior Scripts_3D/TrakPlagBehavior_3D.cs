using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "3DFlock/Behavior/TrakPlagBehavior")]
public class TrakingPlagBehavior_3D : FlockBehavior_3D
{
    [SerializeField] private GameObject[] plags;
    public override Vector3 CalculateMove(FlockAgent_3D agent, List<Transform> context, Flock_3D flock)
    {   
        Vector3 followPlag = Vector3.zero;
        return followPlag;
    }
}
