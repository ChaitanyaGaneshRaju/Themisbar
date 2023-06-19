using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DTO
{
    public class UserLearnerDto
    {

        public long IdUser { get; set; }

        public long? UworldUserId { get; set; }

        public long IdRole { get; set; }

        public int? MemberId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public string Email { get; set; }

        public string EmailNormalized { get; set; }

        public string AlternateEmail { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string AlternatePhone { get; set; }

        public string Username { get; set; }

        public bool Active { get; set; }

        public string LeadType { get; set; }

        public int? CreatorUserId { get; set; }

        public DateTime? ResetPasswordSentAt { get; set; }

        public int? IdTimeZone { get; set; }

        public virtual Learner Learner { get; set; }
    }
}