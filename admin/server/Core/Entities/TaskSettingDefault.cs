using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class TaskSettingDefault
{
    public int IdCourse { get; set; }

    public short? MultipleChoiceRequiredScore { get; set; }

    public short? MilestoneExamRequiredScore { get; set; }

    public short? GradedEssayRange { get; set; }

    public short? EssayCharacterLimit { get; set; }

    public short? GradedEssayCharacterLimit { get; set; }

    public short? EssayExamCharacterLimit { get; set; }

    public short? ShortAnswerCharacterLimit { get; set; }

    public short? EssayTimeLimit { get; set; }

    public short? GradedEssayTimeLimit { get; set; }

    public short? EssayExamTimeLimit { get; set; }

    public short? ShortAnswerTimeLimit { get; set; }

    public short? MultipleChoiceTimeLimit { get; set; }

    public string MultipleChoiceIntro { get; set; }

    public string EssayIntro { get; set; }

    public string EssayExamIntro { get; set; }

    public string ShortAnswerIntro { get; set; }

    public string GradedEssayIntro { get; set; }

    public string MilestoneExamIntro { get; set; }

    public string IntermittentQuizIntro { get; set; }

    public string DrillTaskIntro { get; set; }

    public string UworldMbeQbankIntro { get; set; }
}
