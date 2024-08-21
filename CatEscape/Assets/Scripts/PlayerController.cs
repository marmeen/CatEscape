using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float radius;
    public float playerPos;

    void Update()
    {
        bool isDownLeftArrow = Input.GetKeyDown(KeyCode.LeftArrow);
        bool isDownRightArrow = Input.GetKeyDown(KeyCode.RightArrow);

        playerPos = this.gameObject.transform.position.y;

        if (isDownLeftArrow)
        {
            Debug.Log("���� ����Ű�� �������ϴ�.");
        }
        else if (isDownRightArrow)
        {
            Debug.Log("������ ����Ű�� �������ϴ�.");
        }

        if (isDownLeftArrow)
        {
            MovePlayer(-1);
        }
        else if (isDownRightArrow)
        {
            MovePlayer(1);
        }

    }

    private void OnDrawGizmos()
    {
        GizmosExtensions.DrawWireArc(this.transform.position, 360, radius);
    }

    private void MovePlayer(int moveDir)
    {
        this.transform.Translate(moveDir, 0, 0);
    }

}
