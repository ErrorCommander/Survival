using UnityEngine;

public static class DataExtensions
{
    public static Vector3 AsVector3XZ(this Vector2 input) => new Vector3(input.x, 0, input.y);
    public static Vector3 ChangeY(this Vector3 input, float value = 0) => new Vector3(input.x, value, input.z);
    public static Quaternion ChangeY(this Quaternion input, float value = 0) => new Quaternion(input.x, value, input.z, input.w);
}
