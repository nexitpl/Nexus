﻿using Nexus.Shared.Enums;
using System.Runtime.Serialization;

namespace Nexus.Shared.Models.RemoteControlDtos
{
    [DataContract]
    public class ToggleAudioDto : BaseDto
    {
        [DataMember(Name = "ToggleOn")]
        public bool ToggleOn { get; set; }

        [DataMember(Name = "DtoType")]
        public override BaseDtoType DtoType { get; init; } = BaseDtoType.ToggleAudio;
    }
}
