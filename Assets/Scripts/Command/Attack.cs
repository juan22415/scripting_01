using UnityEngine;
using Characters;

public class Attack : Command
{
    private Vector3 position;


    public Attack(Vector3 position)
    {
        this.position = position;
    }
    public override int Cost
    {
        get
        {
            return 1;
        }
    }

    public override void Execute(Character character)
    {
       
        character.Attack(position, OnFinished);
    }
}

