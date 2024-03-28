namespace coronaApi.Entities
{
    public class Member
    {
        public string FullName { get; set; }
        public string Id { get; set; }
        public string FullAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone { get; set; }
        public string Phone { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public DateTime Date3 { get; set; }
        public DateTime Date4 { get; set; }
        public string Maker1 { get; set; }
        public string Maker2 { get; set; }
        public string Maker3 { get; set; }
        public string Maker4 { get; set; }
        public DateTime DateOfResult { get; set; }
        public DateTime DateOfRecovery { get; set; }


        public Member(string fullName, string id, string fullAddress, DateTime birthDate, string telephone, string phone, DateTime date1, DateTime date2, DateTime date3, DateTime date4, string maker1, string maker2, string maker3, string maker4, DateTime dateOfResult, DateTime dateOfRecovery)
        {
            FullName = fullName;
            Id = id;
            FullAddress = fullAddress;
            BirthDate = birthDate;
            Telephone = telephone;
            Phone = phone;
            Date1 = date1;
            Date2 = date2;
            Date3 = date3;
            Date4 = date4;
            Maker1 = maker1;
            Maker2 = maker2;
            Maker3 = maker3;
            Maker4 = maker4;
            DateOfResult = dateOfResult;
            DateOfRecovery = dateOfRecovery;
        }
    }
}
