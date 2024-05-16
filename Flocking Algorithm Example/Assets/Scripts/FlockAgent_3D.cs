using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//RequireComponent: �ش� ��ũ��Ʈ�� ���Ե� GameObject�� RequireComponent�� ����� ������Ʈ�� �ڵ����� �߰��ǰų� ��õ� ������Ʈ�� �����ϴ��� �˻���
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
