using de.mydevtime.DataExtendable.Model;

namespace de.mydevtime.License.Model.Extensions;

public abstract class ALicenseExtension : ADataExtension<ALicenseExtension>
{
    public ALicenseExtension(string extensionId) : base(extensionId)
    {
    }

    public ALicenseExtension(string extensionId, HashSet<ALicenseExtension> extensions) : base(extensionId, extensions)
    {
    }
}