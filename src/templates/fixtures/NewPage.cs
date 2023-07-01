using System;
using CMS.DocumentEngine;

namespace MySite.Admin.ModulePrefix;

public class NewPage : TreeNode
{
    [Obsolete("Obsolete")]
    public NewPage()
    {
    }

    protected NewPage(string className) : base(className)
    {
    }
}