using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Public_Utility : BaseMonoBehaviour
{
    // ============================================[�鿪���� ������]=================================================

    private IOverallManager _overallManager;

    public IOverallManager OverallManager
    {
        get { return _overallManager; }
    }

    public void Init(IOverallManager overallManager)
    {
        _overallManager = overallManager;
    }

    // ============================================[�迪���� ������]=================================================

    // ============================================[����� ��ɼ� �޼��� ������]=================================================

    public static float Clamp(float value, float min, float max)  // ���� ���� �޼���
    {
        return Mathf.Clamp(value, min, max);
    }

    public static float CalculateDistance(Vector3 point1, Vector3 point2)  // �Ÿ� ��� �޼���
    {
        return Vector3.Distance(point1, point2);
    }

    public static int RandomRangeInt(int min, int max) // ���� �������� ���� ���� �޼���
    {
        return Random.Range(min, max + 1);
    }

    public static T Clone<T>(T original) where T : MonoBehaviour // ������Ʈ ���� �޼���
    {
        return Instantiate(original);
    }

    public static void ChangeScene(string sceneName) // �� ��ȯ �޼���
    {
        SceneManager.LoadScene(sceneName);
    }

    public static IEnumerator Timer(float seconds, Action callback) // Ÿ�̸� �޼���
    {
        yield return new WaitForSeconds(seconds);
        callback();
    }

    public static void SetObjectActive(GameObject obj, bool isActive) // ������Ʈ Ȱ��ȭ/��Ȱ��ȭ �޼���
    {
        obj.SetActive(isActive);
    }

    public static Vector3 ScreenToWorldPoint(Vector3 screenPosition) // ȭ�� ��ǥ�� ���� ��ǥ�� ��ȯ �޼���
    {
        return Camera.main.ScreenToWorldPoint(screenPosition);
    }


    // ============================================[����� ��ɼ� �޼��� ������]=================================================


}
