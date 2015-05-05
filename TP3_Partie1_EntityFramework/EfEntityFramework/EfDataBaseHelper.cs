using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework.Model;

namespace TP3_Partie1_EntityFramework.EfEntityFramework
{
    public class EfDataBaseHelper
    {
        public EfEntityRepository<Tutor> _tutorsRepository;
        public EfEntityRepository<HelpedStudent> _studentsRepository;
        public EfEntityRepository<TutoringSession> _tutoringSessionRepository;

        public EfDataBaseHelper()
        {
            _tutorsRepository = new EfEntityRepository<Tutor>();
            _studentsRepository = new EfEntityRepository<HelpedStudent>();
            _tutoringSessionRepository = new EfEntityRepository<TutoringSession>();

        }
        public void SeedTables()
        {
            DeleteAll();
            AddData();
            ShowAll();
        }

        public void DeleteAll()
        {
            _tutorsRepository.DeleteAll();
            _studentsRepository.DeleteAll();
            _tutoringSessionRepository.DeleteAll();

        }

        private void AddData()
        {
            var t1 = new Tutor() { Id = 1, LastName = "Bilodeau", FirstName = "Gary", EmailAddress = "bgary2@hotmail.com" };
            _tutorsRepository.Add(t1);
            var t2 = new Tutor() { Id = 2, LastName = "Gagnon", FirstName = "Samuel", EmailAddress = "samPP92@hotmail.com" };
            _tutorsRepository.Add(t2);
            var t3 = new Tutor() { Id = 3, LastName = "Gingras", FirstName = "Simon", EmailAddress = "ptitguy22@bell.net" };
            _tutorsRepository.Add(t3);
            var t4 = new Tutor() { Id = 4, LastName = "Roy", FirstName = "Eric", EmailAddress = "eroy231@videotron.ca" };
            _tutorsRepository.Add(t4);
            var t5 = new Tutor() { Id = 5, LastName = "Veilleux", FirstName = "Caroline", EmailAddress = "caro.koko@hotmail.com" };
            _tutorsRepository.Add(t5);
            var t6 = new Tutor() { Id = 6, LastName = "Tremblay", FirstName = "Karine", EmailAddress = "kar.tremblay@gmail.com" };
            _tutorsRepository.Add(t6);
            var t7 = new Tutor() { Id = 7, LastName = "Vezina", FirstName = "Louis", EmailAddress = "vl410Bd@gmail.com" };
            _tutorsRepository.Add(t7);
            _tutorsRepository.SaveChanges();

            var stu1 = new HelpedStudent() { Id = 1, LastName = "Arsenault", FirstName = "Marc", EmailAddress = "marco.arsault@hotmail.com" };
            _studentsRepository.Add(stu1);
            var stu2 = new HelpedStudent() { Id = 2, LastName = "Boilard", FirstName = "Eric", EmailAddress = "eric.r.boilard2@coop.com" };
            _studentsRepository.Add(stu2);
            var stu3 = new HelpedStudent() { Id = 3, LastName = "Couture", FirstName = "Jean-Cristophe", EmailAddress = "jc.couture.wilde@hotmail.com" };
            _studentsRepository.Add(stu3);
            var stu4 = new HelpedStudent() { Id = 4, LastName = "Desrosiers", FirstName = "Julianne", EmailAddress = "galypo13@hotmail.com" };
            _studentsRepository.Add(stu4);
            var stu5 = new HelpedStudent() { Id = 5, LastName = "Gregoire-Allen", FirstName = "Leo", EmailAddress = "leoga@hotmail.com" };
            _studentsRepository.Add(stu5);
            var stu6 = new HelpedStudent() { Id = 6, LastName = "Hamel", FirstName = "Francois", EmailAddress = "f.Hamel@hotmail.com" };
            _studentsRepository.Add(stu6);
            var stu7 = new HelpedStudent() { Id = 7, LastName = "Lepage", FirstName = "Jeremie", EmailAddress = "these.nuttzz.JL@hotmail.com" };
            _studentsRepository.Add(stu7);
            var stu8 = new HelpedStudent() { Id = 8, LastName = "Poitras", FirstName = "Nicolas", EmailAddress = "GotThem.HAHAHA.NP@hotmail.com" };
            _studentsRepository.Add(stu8);
            var stu9 = new HelpedStudent() { Id = 9, LastName = "Roy-Gagnon", FirstName = "Samuel", EmailAddress = "WOW.Such.Email.SR@hotmail.com" };
            _studentsRepository.Add(stu9);
            var stu10 = new HelpedStudent() { Id = 10, LastName = "Simard", FirstName = "Benjamin", EmailAddress = "BJ.Simard@5Bucks.com" };
            _studentsRepository.Add(stu10);
            var stu11 = new HelpedStudent() { Id = 11, LastName = "Vachon", FirstName = "Samuel", EmailAddress = "DOGE.Lover@Shiba.inu" };
            _studentsRepository.Add(stu11);
            _studentsRepository.SaveChanges();

            var tuto1 = new TutoringSession() { DateSession = new DateTime(2015, 03, 16), TimeSession = 13, LenghtSession = 2, HelpedId = stu5.Id, TutorId = t5.Id };
           _tutoringSessionRepository.Add(tuto1);
           var tuto2 = new TutoringSession() { DateSession = new DateTime(2015, 03, 24), TimeSession = 10, LenghtSession = 1, HelpedId = stu5.Id, TutorId = t1.Id };
           _tutoringSessionRepository.Add(tuto2);
           var tuto3 = new TutoringSession() { DateSession = new DateTime(2015, 03, 25), TimeSession = 13, LenghtSession = 1, HelpedId = stu2.Id, TutorId = t4.Id };
           _tutoringSessionRepository.Add(tuto3);
           var tuto4 = new TutoringSession() { DateSession = new DateTime(2015, 04, 01), TimeSession = 12, LenghtSession = 2, HelpedId = stu1.Id, TutorId = t5.Id };
           _tutoringSessionRepository.Add(tuto4);
           var tuto5 = new TutoringSession() { DateSession = new DateTime(2015, 04, 01), TimeSession = 13, LenghtSession = 1, HelpedId = stu2.Id, TutorId = t3.Id };
           _tutoringSessionRepository.Add(tuto5);
           var tuto6 = new TutoringSession() { DateSession = new DateTime(2015, 04, 06), TimeSession = 16, LenghtSession = 1, HelpedId = stu1.Id, TutorId = t4.Id };
           _tutoringSessionRepository.Add(tuto6);
           var tuto7 = new TutoringSession() { DateSession = new DateTime(2015, 04, 08), TimeSession = 10, LenghtSession = 1, HelpedId = stu7.Id, TutorId = t4.Id };
           _tutoringSessionRepository.Add(tuto7);
           var tuto8 = new TutoringSession() { DateSession = new DateTime(2015, 04, 10), TimeSession = 10, LenghtSession = 2, HelpedId = stu1.Id, TutorId = t4.Id };
           _tutoringSessionRepository.Add(tuto8);
           var tuto9 = new TutoringSession() { DateSession = new DateTime(2015, 04, 29), TimeSession = 12, LenghtSession = 1, HelpedId = stu9.Id, TutorId = t5.Id };
           _tutoringSessionRepository.Add(tuto9);
           var tuto10 = new TutoringSession() { DateSession = new DateTime(2015, 05, 25), TimeSession = 13, LenghtSession = 1, HelpedId = stu10.Id, TutorId = t7.Id };
           _tutoringSessionRepository.Add(tuto10);
           var tuto11 = new TutoringSession() { DateSession = new DateTime(2015, 05, 27), TimeSession = 12, LenghtSession = 2, HelpedId = stu10.Id, TutorId = t5.Id };
           _tutoringSessionRepository.Add(tuto11);
           var tuto12 = new TutoringSession() { DateSession = new DateTime(2015, 05, 27), TimeSession = 13, LenghtSession = 1, HelpedId = stu2.Id, TutorId = t3.Id };
           _tutoringSessionRepository.Add(tuto12);
           var tuto13 = new TutoringSession() { DateSession = new DateTime(2015, 06, 01), TimeSession = 9, LenghtSession = 1, HelpedId = stu7.Id, TutorId = t7.Id };
           _tutoringSessionRepository.Add(tuto13);
           var tuto14 = new TutoringSession() { DateSession = new DateTime(2015, 06, 02), TimeSession = 9, LenghtSession = 1, HelpedId = stu11.Id, TutorId = t7.Id };
           _tutoringSessionRepository.Add(tuto14);
           var tuto15 = new TutoringSession() { DateSession = new DateTime(2015, 06, 02), TimeSession = 11, LenghtSession = 1, HelpedId = stu2.Id, TutorId = t7.Id };
           _tutoringSessionRepository.Add(tuto15);
           var tuto16 = new TutoringSession() { DateSession = new DateTime(2015, 06, 02), TimeSession = 13, LenghtSession = 1, HelpedId = stu5.Id, TutorId = t1.Id };
           _tutoringSessionRepository.Add(tuto16);
           var tuto17 = new TutoringSession() { DateSession = new DateTime(2015, 06, 02), TimeSession = 15, LenghtSession = 1, HelpedId = stu9.Id, TutorId = t4.Id };
           _tutoringSessionRepository.Add(tuto17);
           var tuto18 = new TutoringSession() { DateSession = new DateTime(2015, 06, 03), TimeSession = 13, LenghtSession = 2, HelpedId = stu7.Id, TutorId = t3.Id };
           _tutoringSessionRepository.Add(tuto18);
           _tutoringSessionRepository.SaveChanges();
        }

        public void ShowAll()
        {
            var DbContext = new TutoringDbContext();
            foreach (var tutors in DbContext.Tutors)
            {
                Console.WriteLine(tutors.ToString());
                _tutorsRepository.SaveChanges();
            }
            Console.ReadKey();

            foreach (var students in DbContext.HelpedStudents)
            {
                Console.WriteLine(students.ToString());
                _studentsRepository.SaveChanges();
            }
            Console.ReadKey();

            foreach (var sessions in DbContext.TutoringSessions)
            {
                Console.WriteLine(sessions.ToString());
                _tutoringSessionRepository.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
