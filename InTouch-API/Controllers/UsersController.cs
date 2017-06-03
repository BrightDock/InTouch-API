using InTouch_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InTouch_API.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        InTouch_DBEntities Db = new InTouch_DBEntities();

        [Route("GetUsers")]
        [HttpGet]
        public List<UserUniversity> GetAllUsers()
        {
            var usersList = Db.Users.Join(Db.Universities,
                    student => student.University,
                    University => University.Id,
                    (student, StudentUniversity) => 
                        new { student = student, studentUnivirsity = StudentUniversity })
                .Select(student => new UserUniversity()
                {
                    User = student.student,
                    University = student.studentUnivirsity
                });
            return usersList.ToList();
        }

        [Route("GetStudents")]
        [HttpGet]
        public List<UserGroupUniversity> GetStudents()
        {
            var usersList = Db.Users.Join(Db.Groups,
                user => user.Student_group,
                group => group.Id,
                (user, group) => new { Student = user, StudentGroup = group })
                .Join(Db.Universities,
                    student => student.Student.University,
                    University => University.Id,
                    (StudentStudentGroup, StudentUniversity) =>
                        new { studentStudentGroup = StudentStudentGroup, studentUnivirsity = StudentUniversity })
                .Select(student => new UserGroupUniversity()
                {
                    User = student.studentStudentGroup.Student,
                    Group = student.studentStudentGroup.StudentGroup,
                    University = student.studentUnivirsity
                });
            return usersList.ToList();
        }

        [Route("GetProfessors")]
        [HttpGet]
        public List<ProfessorSubjects> GetProfessors()
        {
            var usersList = Db.Subjects.Join(Db.Subjecst_professors,
                subject => subject.Id,
                subjectProfessor => subjectProfessor.Id,
                (subject, subjectProfessor) => new { Subject = subject, SubjectProfessor = subjectProfessor })
                .Join(Db.Users,
                    SubjectProfessor => SubjectProfessor.SubjectProfessor.Professor,
                    Professor => Professor.Id,
                    (Professor, SubjectProfessor) =>
                        new { professor = Professor, subjectProfessor = SubjectProfessor })
                .Select(professor => new ProfessorSubjects()
                {
                    Professor = professor.professor.SubjectProfessor.Users,
                    Subjects = professor.professor.Subject
                });
            return usersList.ToList();
        }

        public async Task AddUser(Users user)
        {
            using (var Db = new InTouch_DBEntities())
            {
                try
                {
                    Db.Users.Add(user);
                    await Db.SaveChangesAsync();
                }
                catch (Exception ex) {
                    throw ex;
                }
            }
        }
    }
}
