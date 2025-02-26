using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace MultiplayerARPG
{
    public class ShooterPlayerControllerRG : ShooterPlayerCharacterController
    {


        protected override void Update()
        {

            if (CurrentGameInstance.switchControllerModeWhenSheathed && CurrentGameInstance.enableRatherGoodSheath)
            {
                mode = (viewMode == ShooterControllerViewMode.Fps) ? ControllerMode.Combat : ((PlayerCharacterEntity.IsSheathed) ? ControllerMode.Adventure : ControllerMode.Combat);
            }

            base.Update();
        }
    }
}