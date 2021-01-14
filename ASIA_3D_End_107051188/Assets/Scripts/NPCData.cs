using UnityEngine;


// ScriptableObject腳本化物件

[CreateAssetMenu(fileName ="NPC 資料", menuName ="Natsu/NPC 資料")]
public class NPCData : ScriptableObject

{
    [Header("第一段對話"), TextArea(1, 5)]
    public string dialougA;
    [Header("第一段對話"), TextArea(1, 5)]
    public string dialougB;
    [Header("第一段對話"), TextArea(1, 5)]
    public string dialougC;


}
