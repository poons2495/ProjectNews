using MITService.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MITService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMITService
    {
        // TODO: Add your service operations here

        [OperationContract]
        string GetName(int regNo);

        [OperationContract]
        List<Subject> GetMarks(int regNo);
    }

}
