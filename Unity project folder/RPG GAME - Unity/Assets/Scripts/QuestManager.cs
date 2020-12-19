using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//QUESTMANAGER

public class QuestManager : MonoBehaviour
{

    public static int ActiveQuestNumber;
    public int InternalQuestNumber;

    void Update()
    {
        InternalQuestNumber = ActiveQuestNumber;
    }

}
