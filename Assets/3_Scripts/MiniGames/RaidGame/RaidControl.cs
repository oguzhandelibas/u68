using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

namespace MiniGame.RaidGame
{
    public class RaidControl : MonoBehaviour
    {
        public bool HasStarted { get; set; }
        private PlayerController _playerController;
        [SerializeField] private TimerEventHandler TimerEventHandler;
        
        public void StartSlowMotionGame(PlayerController playerController)
        {
            TimerEventHandler.OnTimerStart?.Invoke();
            playerController.TimerPanelActiveness(true);
            HasStarted = true;
            _playerController = playerController;
            _playerController.SetSlowMotion();
        }

        public void FinishSlowMotionGame()
        {
            _playerController.SetCurrentTime();
            gameObject.SetActive(false);
        }
    }
}

