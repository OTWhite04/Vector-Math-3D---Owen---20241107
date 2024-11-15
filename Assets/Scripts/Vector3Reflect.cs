using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vector3Reflect : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.up, out hit, 200.0f))
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, hit.point);

            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(hit.point, 0.05f);

            Vector3 reflectedHitDirection = Vector3.Reflect(transform.up, hit.normal);

            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(hit.point, hit.point + reflectedHitDirection * 7.0f);

            
            


        }

        else 
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + transform.up * 2.0f);
        
        }
    
    }
}
