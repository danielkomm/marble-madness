using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragController : MonoBehaviour

{
    public float slownessValue = 3.5f;
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.CompareTag("Ball"))
        {
            OponentManager.Instance.ChangePlayerSpeed(slownessValue, StatsRestrains.Mud);
            Debug.Log("Mud");
        }
    }

    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.CompareTag("Ball"))
        {
            StartCoroutine(ContinueDragSlowness());            
            Debug.Log("No Mud");
        }
    }
    
    // Fremdes Code - Snippte(siehe Quellenangabe)
    IEnumerator ContinueDragSlowness()
    {
        yield return new WaitForSeconds(3);
        OponentManager.Instance.ResetPlayerSpeed(); ;
    }
}