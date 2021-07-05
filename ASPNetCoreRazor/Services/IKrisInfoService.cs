using System.Collections.Generic;

namespace ASPNetCoreRazor.Services
{
    public interface IKrisInfoService
    {
        List<KrisInfo> GetAllKrisInformation();
        List<KrisInfo> GetEmergencies();
        KrisInfo GetKrisInformation(string id);
    }
}