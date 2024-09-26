using de.mydevtime.DataExtendable.Interfaces;
using de.mydevtime.DataExtendable.Model;
using de.mydevtime.License.Model.Extensions;

namespace de.mydevtime.License.Model;

public class SignedLicense : ADataExtendable<ASignedLicenseExtension>
{
    #region SignedLicense - Fields
    
    private License _license;
    private LicenseSignature _licenseSignature;
    
    #endregion
    
    
    #region SignedLicense - Properties
    
    public License License => _license;
    public LicenseSignature LicenseSignature => _licenseSignature;
    
    #endregion


    public SignedLicense(License license, LicenseSignature licenseSignature)
    {
        _license = license;
        _licenseSignature = licenseSignature;
    }

    public SignedLicense(HashSet<ASignedLicenseExtension> extensions, License license, LicenseSignature licenseSignature) : base(extensions)
    {
        _license = license;
        _licenseSignature = licenseSignature;
    }
}