﻿using System.Collections.Generic;
using PikaCore.Areas.Infrastructure.Data;
using PikaCore.Areas.Infrastructure.Models;

namespace PikaCore.Areas.Core.Pages.Admin.DTO
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsVisible { get; set; }

        public MessageType MessageType { get; set; } = MessageType.None;

        public int RelatedIssueCount { get; set; } = 0;

        public List<SystemDescriptor> Systems { get; set; } = new List<SystemDescriptor>();

        public string SystemName { get; set; } = "";

        public MessageEntity ToMessageEntity()
        {
            return new MessageEntity()
            {
                Id = Id,
                Message = this.Content,
                IsVisible = IsVisible,
                MessageType = MessageType
            };
        }
    }
}