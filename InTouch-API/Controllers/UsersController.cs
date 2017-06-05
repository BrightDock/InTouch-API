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
        public List<UserGroupUniversity> GetStudents(string userID = null)
        {
            Guid uID = new Guid();
            Guid.TryParse(userID, out uID);
            var usersList = Db.Users.Join(Db.Universities,
                    student => student.University,
                    university => university.Id,
                    (student, university) =>
                        new { Student = student, University = university })
                    .Join(Db.Groups,
                        student => student.Student.Student_group,
                        group => group.Id,
                        (student, group) =>
                            new { Student = student, Group = group })
                .Select(student => new UserGroupUniversity()
                {
                    User = student.Student.Student,
                    Group = student.Group,
                    SubjectsInLearn = student.Student.Student.Groups.Subjects_learn,
                    University = student.Student.University,
                    AllTests = Db.Tests.Where(test => 
                    test.Subjects.Subjects_learn.Intersect(student.Student.Student.Groups.Subjects_learn
                        .Where(subject => subject.Group_ID == student.Group.Id)).Count() > 0),
                    Passed_tests = student.Student.Student.Passed_tests
                }).Where(student => student.User.Id == uID || userID.Equals(null));
            return usersList.ToList();
        }

        [Route("GetProfessors")]
        [HttpGet]
        public List<ProfessorSubjects> GetProfessors()
        {
            var usersList = Db.Users.Join(Db.Universities,
                    professor => professor.University,
                    University => University.Id,
                    (Professor, ProfessorUniversity) =>
                        new { professor = Professor, professorUniversity = ProfessorUniversity })
                .Where(professor => professor.professor.User_type == 2)
                .Select(professorProfessorUniversity => new ProfessorSubjects{
                    Professor = professorProfessorUniversity.professor,
                    University = professorProfessorUniversity.professorUniversity,
                    Subjects = professorProfessorUniversity.professor.Subjecst_professors
                        .Where(subject => subject.Professor == professorProfessorUniversity.professor.Id)
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
