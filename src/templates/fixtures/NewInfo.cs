using System;
using System.Runtime.Serialization;
using CMS.DataEngine;

namespace MySite.Admin.ModulePrefix;

public class NewInfo : AbstractInfoBase<NewInfo>
{
    public const string OBJECT_TYPE = "";

    public readonly static ObjectTypeInfo TYPEINFO =
        new(
            typeof(NewInfo),
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
        );

    public NewInfo() : base(TYPEINFO)
    {

    }

    public NewInfo(ObjectTypeInfo typeInfo) : base(typeInfo)
    {
    }

    public NewInfo(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    protected override BaseInfo NewObject(LoadDataSettings settings)
    {
        throw new NotImplementedException();
    }
}