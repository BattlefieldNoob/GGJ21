using System;
using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;

public class CorpseEditorManager : Singleton<CorpseEditorManager>
{
    [SerializeField] private Linkable bust;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            ExploreBody();
        }
    }

    public Linkable GetBust()
    {
        return bust;
    }

    private void ExploreBody()
    {
        Debug.Log(bust.PrintName());
    }
}
