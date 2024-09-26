using de.mydevtime.DataExtendable.Interfaces;
using de.mydevtime.DataExtendable.Model;
using de.mydevtime.License.Model.Extensions;

namespace de.mydevtime.License.Model;

public class LicenseSignature : ADataExtendable<ALicenseSignatureExtension>
{
    #region LicenseSignature - Fields
    
    string _signature;
    
    string _publicKey;
    
    #endregion
    
    
    #region LicenseSignature - Properties

    public string Signature => _signature;

    public string PublicKey => _publicKey;

    #endregion


    public LicenseSignature(string signature, string publicKey)
    {
        _signature = signature;
        _publicKey = publicKey;
    }

    public LicenseSignature(HashSet<ALicenseSignatureExtension> extensions, string signature, string publicKey) : base(extensions)
    {
        _signature = signature;
        _publicKey = publicKey;
    }
}