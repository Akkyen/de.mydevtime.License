using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using de.mydevtime.DataExtendable.Model;
using de.mydevtime.License.Model.Extensions;

namespace de.mydevtime.License.Model;

public class License : ADataExtendable<ALicenseExtension>
{
    #region License - Fields

    private readonly string _licenseId;

    private string _displayName;
    private string _description;

    private string _licenseeId;
    private DateTime _expirationDate;

    private Dictionary<string, string> _features;

    private bool _isLicenseSigned;
    
    #endregion
    
    
    #region License - Properties
    
    public string LicenseId => _licenseId;
    
    public string DisplayName => _displayName;
    
    public string Description => _description;
    
    public string LicenseeId => _licenseeId;
    
    public DateTime ExpirationDate => _expirationDate;
    
    public Dictionary<string, string> Features => _features;
    
    [JsonIgnore]
    public bool IsLicenseSigned => _isLicenseSigned;

    #endregion
    
    
    #region Ctors

    public License()
    {
        _licenseId = Guid.NewGuid().ToString();
        
        _displayName = string.Empty;
        _description = string.Empty;
        _licenseeId = string.Empty;
        
        _expirationDate = DateTime.Now;
        _features = new Dictionary<string, string>();
    }

    public License(HashSet<ALicenseExtension> extensions) : base(extensions)
    {
        _licenseId = Guid.NewGuid().ToString();
        
        _displayName = string.Empty;
        _description = string.Empty;
        _licenseeId = string.Empty;
        
        _expirationDate = DateTime.Now;
        _features = new Dictionary<string, string>();
    }

    public License(string licenseId, string displayName, string description, string licenseeId, DateTime expirationDate, Dictionary<string, string> features, bool isLicenseSigned)
    {
        _licenseId = licenseId;
        _displayName = displayName;
        _description = description;
        _licenseeId = licenseeId;
        _expirationDate = expirationDate;
        _features = features;
        _isLicenseSigned = isLicenseSigned;
    }

    public License(HashSet<ALicenseExtension> extensions, string licenseId, string displayName, string description, string licenseeId, DateTime expirationDate, Dictionary<string, string> features, bool isLicenseSigned) : base(extensions)
    {
        _licenseId = licenseId;
        _displayName = displayName;
        _description = description;
        _licenseeId = licenseeId;
        _expirationDate = expirationDate;
        _features = features;
        _isLicenseSigned = isLicenseSigned;
    }

    #endregion
}