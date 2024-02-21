using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOverallManager
{

}
public class OverallManager : BaseMonoBehaviour, IOverallManager
{
    // ============================================[��̱��� ������]=================================================

    // �̱��� �ν��Ͻ�
    private static OverallManager _instance;

    // �ܺο��� �̱��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ
    public static OverallManager Instance
    {
        get
        {
            // �ν��Ͻ��� ������ ����
            if (_instance == null)
            {
                // FindObjectOfType�� ��Ÿ�� �߿� �ش� Ÿ���� ��ü�� ã��
                _instance = FindObjectOfType<OverallManager>();

                // ã�� ���� ��� ���� ���ٸ� ���� ����
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(OverallManager).Name);
                    _instance = singletonObject.AddComponent<OverallManager>();
                }
            }

            return _instance;
        }
    }

    // Awake �޼��忡�� �ʱ�ȭ
    private void Awake()
    {
        // �̹� �ٸ� �ν��Ͻ��� �ִٸ� ���� �ν��Ͻ��� �ı�
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }

        // �̱��� �ν��Ͻ��� ���� �ν��Ͻ��� ����
        _instance = this;

        // �� ��ȯ �� �ı����� �ʵ��� ����
        DontDestroyOnLoad(this.gameObject);
    }

    // ============================================[��̱��� ������]=================================================

    // ============================================[������ȭ ������]=================================================

    [SerializeField]
    private Public_Enum _PublicEnum;

    [SerializeField]
    private Public_Structer _PublicStructer;

    [SerializeField]
    private Public_Utility _PublicUtility;

    [SerializeField]
    private Public_Variable _PublicVariable;

    [SerializeField]
    private TestManager _TestManager;

    [SerializeField]
    private SoundManager _SoundManager;

    [SerializeField]
    private UiManager _UiManager;

    // ============================================[������ȭ ������]=================================================

}

