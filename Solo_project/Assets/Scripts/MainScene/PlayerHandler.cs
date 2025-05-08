using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerHandler : CharactersHandler
{
    private Camera camera;

    protected override void Start()
    {
        base.Start();
        camera = Camera.main;

    }

    protected override void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        movementDirection = new Vector2(horizontal, vertical).normalized;
        
        if(Mathf.Abs(horizontal) > 0.01)
        {
            lookDirection = new Vector2(horizontal, 0).normalized;
        }

    }
}
