﻿using System;
using System.Collections.Generic;

namespace HelpScout.Conversations.Models.List
{
    public class ConversationListItem
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Threads { get; set; }
        public string Type { get; set; }
        public int FolderId { get; set; }
        public string Status { get; set; }
        public string State { get; set; }
        public string Subject { get; set; }
        public string Preview { get; set; }
        public int MailboxId { get; set; }
        public Assignee Assignee { get; set; }
        public CreatedBy CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ClosedBy { get; set; }
        public DateTime? ClosedAt { get; set; }
        public DateTime? UserUpdatedAt { get; set; }
        public CustomerWaitingSince CustomerWaitingSince { get; set; }
        public Source Source { get; set; }
        public IList<TagItem> Tags { get; set; }
        public IList<string> Cc { get; set; }
        public IList<string> Bcc { get; set; }
        public PrimaryCustomer PrimaryCustomer { get; set; }
        public IList<CustomField> CustomFields { get; set; }
    }
}