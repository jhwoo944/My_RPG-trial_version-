using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Public_Enum : BaseMonoBehaviour
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

    // ============================================[����� Enum ������]=================================================


    public enum PlayerState         //�÷��̾� ����
    {
        Idle,
        Walking,
        Running,
        Jumping
    }
    public enum DifficultyLevel     //���̵� ����
    {
        Easy,
        Normal,
        Hard
    }
    public enum QuestType       // ����Ʈ ����
    {
        Main,
        Side,
        Daily
    }
    public enum ItemType         // ������ ����
    {
        Weapon,
        Armor,
        Consumable,
        QuestItem
    }
    public enum UIState        // UI ����
    {
        MainMenu,
        InGame,
        PauseMenu,
        GameOver

    }
    public enum PlatformType        // �÷��� ����
    {
        PC,
        Console,
        Mobile

    }
    // ============================================[����� Enum ������]=================================================
}
