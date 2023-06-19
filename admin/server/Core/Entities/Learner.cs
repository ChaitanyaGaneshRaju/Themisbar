using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Learner
{
    public long IdUser { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public bool Active { get; set; }

    public DateOnly SignupDate { get; set; }

    public int? IdStudentType { get; set; }

    public int? IdReferralType { get; set; }

    public bool EulaAccepted { get; set; }

    public bool WelcomeDismissed { get; set; }

    public virtual ICollection<Bookmark> Bookmarks { get; } = new List<Bookmark>();

    public virtual CampusRep CampusRep { get; set; }

    public virtual ICollection<CoursesLearner> CoursesLearners { get; } = new List<CoursesLearner>();

    public virtual HubspotInfo HubspotInfo { get; set; }

    public virtual User IdUserNavigation { get; set; }

    public virtual ICollection<IntroductionSurveyQuestionsLearner> IntroductionSurveyQuestionsLearners { get; } = new List<IntroductionSurveyQuestionsLearner>();

    public virtual ICollection<LearnersCampusRep> LearnersCampusReps { get; } = new List<LearnersCampusRep>();

    public virtual LearnersLawSchool LearnersLawSchool { get; set; }

    public virtual ICollection<MilestoneQuestionsTasksLearner> MilestoneQuestionsTasksLearners { get; } = new List<MilestoneQuestionsTasksLearner>();

    public virtual ICollection<TasksLearner> TasksLearners { get; } = new List<TasksLearner>();

    public virtual ICollection<TasksVideosLearner> TasksVideosLearners { get; } = new List<TasksVideosLearner>();

    public virtual ICollection<WrittenQuestionsTasksLearner> WrittenQuestionsTasksLearners { get; } = new List<WrittenQuestionsTasksLearner>();
}
