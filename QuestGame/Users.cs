using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGame {
    internal class Users {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNname { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public string repeatPassword { get; set; }
        public bool isAdmin { get; set; }

        public override string ToString() {
            return $"{FirstName} {LastNname} {MiddleName}, пол: {Gender}, дата рождения: {Birthday}, почта: {Email}";
        }

        public int BirthdayToUnixTimeStamp() {
            DateTime unixEpohch = new DateTime(1970, 1, 1, 0, 0, 0);
            return (int)(Birthday.ToUniversalTime() - unixEpohch).TotalSeconds;
        }

        public void SetBirthdayfromUTS(int seconds) {
            DateTime u = new DateTime(1970, 1, 1, 0, 0, 0);
            Birthday = u.AddSeconds(seconds);
        }
    }
}
