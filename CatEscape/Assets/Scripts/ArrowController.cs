using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public PlayerController player;
    public float radius;
    float arrowPos;

    void Update()
    {
        arrowPos = this.gameObject.transform.position.y;

        MoveArrow();
        DestroyArrow();
    }

    private void OnDrawGizmos()
    {
        GizmosExtensions.DrawWireArc(this.transform.position, 360, radius);
    }

    void MoveArrow()
    {
        this.gameObject.transform.Translate(0, -0.1f, 0);
    }

    void DestroyArrow()
    {
        float distance = Mathf.Abs(arrowPos - player.playerPos);
        float sumRadius = this.radius + player.radius;
        if (distance <= sumRadius)
        {
            Destroy(this.gameObject);
            Debug.Log("충돌했습니다~");
        }
    }
}
