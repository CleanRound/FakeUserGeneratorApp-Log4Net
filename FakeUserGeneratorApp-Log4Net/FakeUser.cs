using Bogus;

namespace FakeUserGeneratorApp
{
    public class FakeUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public static FakeUser GenerateFakeUser()
        {
            var faker = new Faker();

            return new FakeUser
            {
                Name = faker.Name.FirstName(),
                Surname = faker.Name.LastName(),
                ContactPhoneNumber = faker.Phone.PhoneNumber(),
                Email = faker.Internet.Email(),
                Address = faker.Address.FullAddress()
            };
        }
    }
}
