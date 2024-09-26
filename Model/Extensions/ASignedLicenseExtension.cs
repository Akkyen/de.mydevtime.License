using de.mydevtime.DataExtendable.Model;

namespace de.mydevtime.License.Model.Extensions;

public abstract class ASignedLicenseExtension : ADataExtension<ASignedLicenseExtension>
{
    protected ASignedLicenseExtension(string extensionId) : base(extensionId)
    {
    }

    protected ASignedLicenseExtension(string extensionId, HashSet<ASignedLicenseExtension> extensions) : base(extensionId, extensions)
    {
    }
}