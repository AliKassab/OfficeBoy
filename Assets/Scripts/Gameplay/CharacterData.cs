using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    private static CharacterData _instance;

    public static CharacterData Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<CharacterData>("Characters/CharacterData");
                if (_instance == null)
                {
                    Debug.LogError("CharacterData not found in Resources folder!");
                }
            }
            return _instance;
        }
    }

    [SerializeField] private int sittingStateWeight = 8;
    [SerializeField] private int angryStateWeight = 8;
    [SerializeField] private int standingStateWeight = 2;
    [SerializeField] private float walkSpeed = 1f;
    [SerializeField] private float lookingDuration = 1f;
    [SerializeField] private float minStandDelay = 1f;
    [SerializeField] private float maxStandDelay = 3f;
    [SerializeField] private float minSittingDelay = 1f;
    [SerializeField] private float maxSittingDelay = 3f;

    public float WalkSpeed => walkSpeed;
    public float LookingDuration => lookingDuration;
    public float MinStandDelay => minStandDelay;
    public float MaxStandDelay => maxStandDelay;
    public float MinSittingDelay => minSittingDelay;
    public float MaxSittingDelay => maxSittingDelay;
    public int SittingStateWeight => sittingStateWeight;
    public int AngryStateWeight => angryStateWeight;
    public int StandingStateWeight => standingStateWeight;
}

