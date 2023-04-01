using System.Collections.Generic;
using System.Linq;
using DomainModel;

namespace Api
{
    public class StudentRepository
    {
        private static readonly List<Student> existingStudents = new List<Student>
        {
            Alice(),
            Bob()
        };

        private static long lastId = existingStudents.Max(x => x.Id);
        public Student GetById(long id) => existingStudents.SingleOrDefault(x => x.Id == id);
        public Student GetByEmail(Email email) => existingStudents.SingleOrDefault(x => x.Email == email);

        public void Save(Student student)
        {
            if (student.Id == 0)
            {
                lastId++;
                SetId(student, lastId);
            }

            existingStudents.RemoveAll(x => x.Id == student.Id);
            existingStudents.Add(student);
        }

        private static void SetId(Entity entity, long id) =>
            entity.GetType().GetProperty(nameof(Entity.Id)).SetValue(entity, id);


        private static Student Alice()
        {
            var alice = new Student(
                Email.Create("alice@gmail.com").Value,
                "Alice Alison",
                new[] { Address.Create("1234 Main St", "Arlington", "VA", "22201", new[] { "VA" }).Value });
            SetId(alice, 1);
            alice.Enroll(new[] { new Enrollment(new Course(1, "Calculus", 5), Grade.A) });

            return alice;
        }

        private static Student Bob()
        {
            var bob = new Student(
                Email.Create("bob@gmail.com").Value,
                "Bob Bobson",
                new[] { Address.Create("2345 Second St", "Barlington", "VA", "22202", new[] { "VA" }).Value });
            SetId(bob, 2);
            bob.Enroll(new[] { new Enrollment(new Course(2, "History", 4), Grade.B) });
            
            return bob;
        }
    }
}
