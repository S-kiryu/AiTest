using Unity.Behavior;
using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private BehaviorGraphAgent agent;

    private void Start()
    {
        // Blackboard�̒l������������
        agent.BlackboardReference.SetVariableValue("WaitSec", 10.0f);
    }

    private void Reset()
    {
        agent = GetComponent<BehaviorGraphAgent>();
    }
}