using System.Net.NetworkInformation;
using System.Security.Permissions;

namespace BatTapCSharp.OOPCSharp
{
    public class GV : Ps
    {
        private string hocVi;
        GV(){}
        public GV(string id, string name, string hocVi)
        {
            var valueTuple = (id, name);
            this.hocVi = hocVi;
        }
    }
}