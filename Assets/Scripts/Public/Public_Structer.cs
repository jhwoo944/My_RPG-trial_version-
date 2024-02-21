using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Public_Structer : BaseMonoBehaviour
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

    // ============================================[����� ����ü ������]=================================================

    public struct Coordinates       //��ǥ��
    {
        public float x;
        public float y;
        public float z;
    }

    public struct RGBColor      //RGB��
    {
        public byte red;
        public byte green;
        public byte blue;
    }

    public struct TimeInterval      //�ð� ����
    {
        public float seconds;
        public int minutes;
        public int hours;
    }

    public struct PlayerAttributes      //�÷��̾� �Ӽ�
    {
        public int health;
        public int attackDamage;
        public float movementSpeed;
    }

    public struct ItemProperties    //������ �Ӽ�
    {
        public string itemName;
        public int itemID;
        public float weight;
    }

    public struct ScreenSize    //ȭ�� ũ��
    {
        public int width;
        public int height;
    }
    // ============================================[����� ����ü ������]=================================================
}
