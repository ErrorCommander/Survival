using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public bool IsBlock
    {
        get => _animator.GetBool(_animtorBlock);
        set => _animator.SetBool(_animtorBlock, value);
    }

    [SerializeField] private Animator _animator;

    private readonly int _animatorX = Animator.StringToHash("X");
    private readonly int _animatorY = Animator.StringToHash("Y");
    private readonly int _animatorSpeed = Animator.StringToHash("Speed");
    private readonly int _animatorWeapon = Animator.StringToHash("Weapon");
    private readonly int _animtorBlock = Animator.StringToHash("IsBlock");
    private readonly int _animtorDie = Animator.StringToHash("Death");
    
    public void OnMoveAnimation(Vector3 inputAxis, Quaternion rotation, float speed)
    {
        _animator.SetFloat(_animatorSpeed, speed);

        Vector3 rotatedAxis = RotateAxis(inputAxis, rotation);

        _animator.SetFloat(_animatorX, rotatedAxis.x);
        _animator.SetFloat(_animatorY, rotatedAxis.z);
    }

    public void SetWeapon(WeaponType weaponType)
    {
        _animator.SetInteger(_animatorWeapon, (int)weaponType);
    }

    public void EndMoveAnimation() 
        => _animator.SetFloat(_animatorSpeed, 0f);

    public void PlayAnimation(string animationName) 
        => _animator.Play(animationName);

    public void PlayAnimation(int animationHash) 
        => _animator.Play(animationHash);
    
    public void Death() 
        => _animator.Play(_animtorDie);

    private Vector3 RotateAxis(Vector3 inputAxis, Quaternion rotation)
    {
        rotation = rotation.ChangeY(-rotation.y);
        return rotation * inputAxis;
    }
}