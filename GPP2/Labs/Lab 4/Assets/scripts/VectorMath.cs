///<summary>
/// Began 25/09/2019
/// Paul O'Callaghan Vector Calculations for 2D Vectors 
/// </summary>
///
///

using UnityEngine;

public class VectorMath : MonoBehaviour
{

    /// <summary>
    /// Calculates angle between two vectors
    /// </summary>
    /// <param name="t_vec1">current vector</param>
    /// <param name="t_vec2">target vector</param>
    /// <returns></returns>
    public static float Vector2Angle(Vector2 t_vec1, Vector2 t_vec2)
    {
        Vector2 diff = t_vec2 - t_vec1;
        float sign = 0;
        if(t_vec2.y < t_vec1.y)
        {
            sign = -1.0f;
        }
        else
        {
            sign = 1.0f;
        }

        return Vector2.Angle(Vector2.right, diff) * sign;
    }

    /// <summary>
    /// Moves towards target at speed
    /// </summary>
    /// <param name="t_vec1"> current position </param>
    /// <param name="t_vec2"> target position </param>
    /// <param name="t_speed"> speed you wish the player to travel at </param>
    /// <returns></returns>
    public static Vector2 Vector2MoveTowards(Vector2 t_vec1, Vector2 t_vec2, float t_speed)
    {

        Vector2 direction = t_vec2 - t_vec1;
        Vector2 moveDir = Vector3.Normalize(direction);
        
        return t_vec1 + (moveDir * t_speed);
    }

    /// <summary>
    /// Gets distance between 2 vectors
    /// </summary>
    /// <param name="t_vec1"> current position </param>
    /// <param name="t_vec2"> target position </param>
    /// <returns></returns>
    public static float Vec2Distance(Vector2 t_vec1, Vector2 t_vec2)
    {
        float x = t_vec2.x - t_vec1.x;
        float y = t_vec2.y - t_vec1.y;
       // float distance = ;
        return Mathf.Sqrt((x * x) + (y * y));
    }
}
