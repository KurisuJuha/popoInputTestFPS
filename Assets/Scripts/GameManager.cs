using System;
using UnityEngine;
using JuhaKurisu.PopoTools.Utility;
using popoInputTestFPS.Multiplay;

public class GameManager : PopoBehaviour
{
    [SerializeField] private string url;

    protected override void Start()
    {
        GameClient gameClient = new(1, Guid.NewGuid(), Guid.NewGuid(), url);
    }
}
