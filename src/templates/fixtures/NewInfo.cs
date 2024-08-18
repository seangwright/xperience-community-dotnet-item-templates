using System.Runtime.Serialization;
using CMS.DataEngine;

namespace MySite.Admin.ModulePrefix;

public class NewInfo : AbstractInfoBase<NewInfo>
{
    public const string OBJECT_TYPE = "";

    public static readonly ObjectTypeInfo TYPEINFO =
        new(
            providerType: typeof(NewInfo),
            objectType: "",
            objectClassName: "",
            idColumn: "",
            timeStampColumn: "",
            guidColumn: "",
            codeNameColumn: "",
            displayNameColumn: "",
            binaryColumn: "",
            parentIDColumn: "",
            parentObjectType: ""
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

    protected override BaseInfo NewObject(LoadDataSettings settings) => new NewInfo();
}
