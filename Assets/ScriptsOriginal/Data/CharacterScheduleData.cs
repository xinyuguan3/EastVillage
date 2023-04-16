using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterScheduleData", menuName = "EastVillage/CharacterScheduleData", order = 0)]
public class CharacterScheduleData : ScriptableObject {
    [SerializeField]
    private 角色 所属角色;

    public 事件[] 角色日程表;
}
