using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//RequireComponent: 해당 스크립트가 포함된 GameObject에 RequireComponent에 명시한 컴포넌트가 자동으로 추가되거나 명시된 컴포넌트가 존재하는지 검사함
[RequireComponent(typeof(Collider))]
public class FlockAgent_3D : MonoBehaviour
{
    private Flock_3D agentFlock;
    public Flock_3D AgentFlock { get { return agentFlock; } }

    private Collider agentCollider;
    public Collider AgentCollider { get { return agentCollider; } }

    private void Start()
    {
        agentCollider = GetComponent<Collider>();
    }

    public void Init(Flock_3D flock)
    {
        agentFlock = flock;
    }

    public void Move(Vector3 _velocity) {
        transform.forward = _velocity;
        transform.position += _velocity * Time.deltaTime;
    }
}
