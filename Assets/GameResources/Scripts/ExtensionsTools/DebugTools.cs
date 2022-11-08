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

        public static void DrawCube(Vector3 center, Vector3 halfExtents, Quaternion rotation, float duration = 1f)
        {
            DrawCube( center,  halfExtents,  rotation, DefaultColor, duration);
        }

        public static void DrawCube(Vector3 center, Vector3 halfExtents, Quaternion rotation, Color color,
            float duration = 1f)
        {
            Vector3 point1 = new Vector3(halfExtents.x, halfExtents.y, halfExtents.z);
            Vector3 point2 = new Vector3(halfExtents.x, -halfExtents.y, halfExtents.z);
            Vector3 point3 = new Vector3(-halfExtents.x, halfExtents.y, halfExtents.z);
            Vector3 point4 = new Vector3(-halfExtents.x, -halfExtents.y, halfExtents.z);

            Vector3 point5 = center + rotation * -point1;
            Vector3 point6 = center + rotation * -point2;
            Vector3 point7 = center + rotation * -point3;
            Vector3 point8 = center + rotation * -point4;

            point1 = center + rotation * point1;
            point2 = center + rotation * point2;
            point3 = center + rotation * point3;
            point4 = center + rotation * point4;
            
            Debug.DrawLine(point1, point2, color, duration);
            Debug.DrawLine(point1, point3, color, duration);
            Debug.DrawLine(point3, point4, color, duration);
            Debug.DrawLine(point5, point6, color, duration);
            Debug.DrawLine(point8, point7, color, duration);
            Debug.DrawLine(point8, point6, color, duration);
            Debug.DrawLine(point2, point4, color, duration);
            Debug.DrawLine(point7, point5, color, duration);

            Debug.DrawLine(point1, point8, color, duration);
            Debug.DrawLine(point2, point7, color, duration);
            Debug.DrawLine(point3, point6, color, duration);
            Debug.DrawLine(point4, point5, color, duration);
        }
    }
}