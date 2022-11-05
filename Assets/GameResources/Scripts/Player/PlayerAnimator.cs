using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public bool IsBlock
    {
        get => _animator.GetBool(_isBlock);
        set => _animator.SetBool(_isBlock, value);
    }

    [SerializeField] private Animator _animator;

    private readonly int _animatorX = Animator.StringToHash("X");
    private readonly int _animatorY = Animator.StringToHash("Y");
    private readonly int _animatorSpeed = Animator.StringToHash("Speed");
    private readonly int _isBlock = Animator.StringToHash("IsBlock");
    
    public void OnMoveAnimation(Vector3 inputAxis, Quaternion rotation, float speed)
    {
        _animator.SetFloat(_animatorSpeed, speed);

        Vector3 rotatedAxis = RotateAxis(inputAxis, rotation);

        _animator.SetFloat(_animatorX, rotatedAxis.x);
        _animator.SetFloat(_animatorY, rotatedAxis.z);
    }

    public void EndMoveAnimation() 
        => _animator.SetFloat(_animatorSpeed, 0f);

    public void PlayAnimation(string animationName) 
        => _animator.Play(animationName);

    public void PlayAnimation(int animationHash) 
        => _animator.Play(animationHash);

    private Vector3 RotateAxis(Vector3 inputAxis, Quaternion rotation)
    {
        rotation = rotation.ChangeY(-rotation.y);
        return rotation * inputAxis;
    }
}