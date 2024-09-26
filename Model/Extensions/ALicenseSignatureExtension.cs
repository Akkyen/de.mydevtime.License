using de.mydevtime.DataExtendable.Model;

namespace de.mydevtime.License.Model.Extensions;

public abstract class ALicenseSignatureExtension : ADataExtension<ALicenseSignatureExtension>
{
    protected ALicenseSignatureExtension(string extensionId) : base(extensionId)
    {
    }

    protected ALicenseSignatureExtension(string extensionId, HashSet<ALicenseSignatureExtension> extensions) : base(extensionId, extensions)
    {
    }
}