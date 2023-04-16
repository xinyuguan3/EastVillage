using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScheduleList", menuName = "EastVillage/ScheduleList", order = 0)]
public class ScheduleList : ScriptableObject {
    public CharacterScheduleData[] scheduleList;
}
