using UnityEngine;
using Characters;
using System.Collections;

public class AttackUIState : UIStateBase 
{
    private Vector2 temporaldirection;

    public AttackUIState(CommandViewController controlled) : base(controlled)
    {

    }
    public override void OnMousePositionChanged(Vector3 mousePosition)
    {
        
    }

    public override void OnClick(Vector3 mousePosition)
    {
        
        Attack Attack = new Attack(AtackDirection.direction);
        if (controlled.TryAddAction(Attack))
        {
          // controlled.Preview.SetPosition(mousePosition);
            controlled.SetState(ActionType.None);


        }
    }

    
}