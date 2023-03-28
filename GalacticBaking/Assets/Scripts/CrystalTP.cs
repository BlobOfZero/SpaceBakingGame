using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrystalTP : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player teleported");
    }
}
