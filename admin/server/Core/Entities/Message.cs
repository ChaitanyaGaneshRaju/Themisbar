using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Message
{
    public long IdMessage { get; set; }

    public string Title { get; set; }

    public DateTime Date { get; set; }

    public string MessageText { get; set; }

    public long IdCourse { get; set; }

    /// <summary>
    /// the user who sent the message
    /// </summary>
    public long IdUser { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public sbyte Active { get; set; }

    public string MessageType { get; set; }

    public string MessageComments { get; set; }

    public string MessageSubject { get; set; }

    public virtual AttorneyAssignment AttorneyAssignment { get; set; }

    public virtual BroadcastMessage BroadcastMessage { get; set; }

    public virtual User IdUserNavigation { get; set; }

    public virtual LearnerMessage LearnerMessage { get; set; }

    public virtual ICollection<MessageAttachment> MessageAttachments { get; } = new List<MessageAttachment>();

    public virtual ICollection<MessageStatus> MessageStatuses { get; } = new List<MessageStatus>();
}
