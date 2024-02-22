using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalInfo : BaseMonoBehaviour
{
    [SerializeField] private string NextMap;
    [SerializeField] private Vector3 NextCoordinate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("���� �� �̵�");
            // �÷��̾�� �浹�� ���
            OverallManager.Instance.MoveMapInfo(NextCoordinate); //������ �Ŵ����� �÷��̾��� ���� �� ��ġ ����
            UnityEngine.SceneManagement.SceneManager.LoadScene(NextMap);
        }
    }
}