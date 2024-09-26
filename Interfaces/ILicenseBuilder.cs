using de.mydevtime.License.Model;

namespace de.mydevtime.License.Interfaces;

public interface ILicenseBuilder<P>
{
    public Model.License License { get; }
    
    public ILicenseBuilder<P> WithName(string displayName);
    public ILicenseBuilder<P> WithDescription(string description);
    
    public ILicenseBuilder<P> ExpiresAt(DateTime expirationDate);

    public ILicenseBuilder<P> LicensedTo(string licenseeId);
    
    public ILicenseBuilder<P> WithProductFeatures(Dictionary<string, string> features);


    public SignedLicense SignLicense(P privateKey);
    
    public void Reset();
}