using System.Net.Mail;

namespace HomeApi.Model
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public bool FromRussia { get; set; }
        public UserViewModel(User user)
        {
            Id = user.Id;
            FullName = GetFullNme(user.FirstName, user.LastName);
            FromRussia = GetFromRussia(user.Email);
        }
        public string GetFullNme (string firstname, string lastname)
        {
            return String.Concat(firstname, " ", lastname);
        }
        public bool GetFromRussia(string mail)
        {
            MailAddress mailAddress = new MailAddress(mail);
            if (mailAddress.Host.Contains(".ru"))
                return true;
            return false;
        }
    }
}
