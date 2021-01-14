using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class NPC : MonoBehaviour
{
    [Header("NPC 資料")]
    public NPCData data;
    [Header("對話框")]
    public GameObject dialog;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話者名稱")]
    public Text textName;
    [Header("對話間隔")]
    public float interval = 0.2f;



    ///<summary>
    /// 是否進入感應區
    /// </summary>
    public bool playerInArea;

    public enum NPCState
    {
        FirstDialog,Missioning,Finish
    }

    public NPCState state = NPCState.FirstDialog;


    



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "少女")
        {
            playerInArea = true;
           StartCoroutine( Dialog());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "少女")
        {
            playerInArea = false;
            StopDialog();
        }
    }

    private void StopDialog()
    {
        dialog.SetActive(false);
        StopAllCoroutines();
    }


    private IEnumerator Dialog()
    {
        dialog.SetActive(true);

        textContent.text = "";

        textName.text = name;

        for (int i = 0; i< data.dialougA.Length; i++)
        {
            textContent.text += data.dialougA[i] + "";
            yield return new WaitForSeconds(interval);
        }

    }


}
