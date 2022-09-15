using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemie : MonoBehaviour
{
    public string tag_NL_docent = "NLdocent";
    public GameObject PS_break;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag(tag_NL_docent))
        {
            Debug.Log("hit NLdocent");
            Instantiate(PS_break, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
