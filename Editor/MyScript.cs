using UnityEditor;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    private void Start()
    {
        UnityEngine.Debug.Log("[SamTest] Start Hello World!");
    }

    [MenuItem("SamTesting/Hello World")]
    static void Testing()
    {
        UnityEngine.Debug.Log("[SamTest] MenuItem Hello World!");
    }
}
