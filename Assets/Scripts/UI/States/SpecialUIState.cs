using UnityEngine;
using Characters;

public class SpecialUIState : UIStateBase
{

    public SpecialUIState(CommandViewController controlled) : base(controlled)
    {

    }


    public override void OnMousePositionChanged(Vector3 mousePosition)
    {

    }

    public override void OnClick(Vector3 mousePosition)
    {
        Debug.Log("Special");
    }
}