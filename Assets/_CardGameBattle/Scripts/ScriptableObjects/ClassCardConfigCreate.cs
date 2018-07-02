using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "ClassCardConfig", 
    menuName = "Configs/CreateClassCardConfig", 
    order = 1)]
public class ClassCardConfigCreate : ScriptableObject
{
    public List<ClassCardInfo> listClassCardInfos = new List<ClassCardInfo>();
}
