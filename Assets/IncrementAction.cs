using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Increment", story: "Increment [variable]", category: "Action/Blackboard", id: "76fb45155c49794a4beff9251350d4e6")]
public partial class IncrementAction : Action
{
    [SerializeReference] public BlackboardVariable<float> Variable;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        Variable.Value += 1;
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

