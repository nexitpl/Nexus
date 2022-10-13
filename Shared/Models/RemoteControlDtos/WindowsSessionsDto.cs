using Nexus.Shared.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nexus.Shared.Models.RemoteControlDtos
{
    [DataContract]
    public class WindowsSessionsDto : BaseDto
    {
        public WindowsSessionsDto(List<WindowsSession> windowsSessions)
        {
            WindowsSessions = windowsSessions;
        }


        [DataMember(Name = "WindowsSessions")]
        public List<WindowsSession> WindowsSessions { get; set; }


        [DataMember(Name = "DtoType")]
        public override BaseDtoType DtoType { get; init; } = BaseDtoType.WindowsSessions;
    }
}
