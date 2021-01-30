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

    private void ExploreBody()
    {
        var depth = 0;
        foreach (var linkable in bust.Linkables)
        {
            linkable.PrintName(depth+1);
        }
    }
}
