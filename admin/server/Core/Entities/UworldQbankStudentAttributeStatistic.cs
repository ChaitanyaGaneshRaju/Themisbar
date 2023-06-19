using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UworldQbankStudentAttributeStatistic
{
    public uint Id { get; set; }

    public uint StudentId { get; set; }

    public string StudentName { get; set; }

    public string StudentEmail { get; set; }

    public string SchoolName { get; set; }

    public int GroupId { get; set; }

    /// <summary>
    ///  deprecated column 
    /// </summary>
    public string GroupName { get; set; }

    public string CourseName { get; set; }

    public int ParentAttributeId { get; set; }

    public string ParentAttributeName { get; set; }

    public int AttributeId { get; set; }

    public string AttributeName { get; set; }

    public int TotalQuestionsCorrect { get; set; }

    public int TotalQuestionsIncorrect { get; set; }

    public int TotalQuestionsOmitted { get; set; }

    public int TotalQuestions { get; set; }

    public int UniqueUsedQuestions { get; set; }

    public string DateOfExpiry { get; set; }

    public DateTime ConvertedDateOfExpiry { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }
}
