using UnityEngine;

namespace ExtensionsTools
{
    public static class DebugTools
    {
        public static Color DefaultColor = Color.red;
        
        public static void DrawSpark(Vector3 position, float size, Color color, float duration = 1f)
        {
            Debug.DrawLine(position + Vector3.down * size, position + Vector3.up * size, color, duration);
            Debug.DrawLine(position + Vector3.left * size, position + Vector3.right * size, color, duration);
            Debug.DrawLine(position + Vector3.back * size, position + Vector3.forward * size, color, duration);
            Debug.DrawLine(position - Vector3.one * size, position + Vector3.one * size, color, duration);
        
            Debug.DrawLine(position - new Vector3(1, 1, 0) * size, position + new Vector3(1, 1, 0) * size, color, duration);
            Debug.DrawLine(position - new Vector3(1, 0, 1) * size, position + new Vector3(1, 0, 1) * size, color, duration);
            Debug.DrawLine(position - new Vector3(0, 1, 1) * size, position + new Vector3(0, 1, 1) * size, color, duration);
        
            Debug.DrawLine(position - new Vector3(1, -1, 0) * size, position + new Vector3(1, -1, 0) * size, color, duration);
            Debug.DrawLine(position - new Vector3(1, 0, -1) * size, position + new Vector3(1, 0, -1) * size, color, duration);
            Debug.DrawLine(position - new Vector3(0, 1, -1) * size, position + new Vector3(0, 1, -1) * size, color, duration);
        
            Debug.DrawLine(position - new Vector3(-1, 1, 0) * size, position + new Vector3(-1, 1, 0) * size, color, duration);
            Debug.DrawLine(position - new Vector3(-1, 0, 1) * size, position + new Vector3(-1, 0, 1) * size, color, duration);
            Debug.DrawLine(position - new Vector3(0, -1, 1) * size, position + new Vector3(0, -1, 1) * size, color, duration);
        }
        
        public static void DrawSpark(Vector3 position, float size, float duration = 1f)
        {
            DrawSpark(position, size, DefaultColor, duration);
        }
    }
}