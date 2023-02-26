using System;
using UnityEngine;
using JuhaKurisu.PopoTools.Utility;
using popoInputTestFPS.Multiplay;

public class GameManager : PopoBehaviour
{
    protected override void Start()
    {
        GameClient gameClient = new(1, Guid.NewGuid(), Guid.NewGuid());
    }
}
