using UnityEngine;

[RequireComponent(typeof(Player), (typeof(PlayerAnimator)))]
public class PlayerBlock : MonoBehaviour
{
    private Player _player;
    private InputSystem _input;
    private PlayerAnimator _animator;
    
    private void Start()
    {
        _animator = GetComponent<PlayerAnimator>();
        _player = GetComponent<Player>();
        _input = _player.Input;
        SubscribeActions();
    }

    private void SubscribeActions()
    {
        _input.Player.Block.started += context => BlockStart();
        _input.Player.Block.canceled += context => BlockEnd();
    }

    private void BlockStart()
    {
        _player.SpeedFactor = 0.5f;
        _player.DamageFactor = 0.5f;
        _animator.IsBlock = true;
    }

    private void BlockEnd()
    {
        _player.SpeedFactor = 1f;
        _player.DamageFactor = 1f;
        _animator.IsBlock = false;
    }
}