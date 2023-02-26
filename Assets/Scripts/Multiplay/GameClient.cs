using System;
using NativeWebSocket;
using JuhaKurisu.PopoTools.Extentions;
using JuhaKurisu.PopoTools.InputSystem;
using UnityEngine;
using Input = popoInputTestFPS.Logic.Input;
using UnityInput = UnityEngine.Input;

namespace popoInputTestFPS.Multiplay
{
    public class GameClient
    {
        private InputManager inputManager;
        private readonly int playerCount;
        private readonly Guid clientID;
        private readonly Guid secretID;

        public GameClient(int playerCount, Guid clientID, Guid secretID)
        {
            this.playerCount = playerCount;
            this.clientID = clientID;
            this.secretID = secretID;
            this.inputManager = new InputManager(clientID, secretID, playerCount, () =>
            {
                return new Input(
                    UnityInput.GetKeyDown(KeyCode.D),
                    UnityInput.GetKeyDown(KeyCode.A),
                    UnityInput.GetKeyDown(KeyCode.W),
                    UnityInput.GetKeyDown(KeyCode.S)
                ).Serialize();
            });
        }
    }
}