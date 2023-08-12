namespace IIS_Projekat.Services
{
    public interface IEmailValidationService
    {
        public long Create(string email);
        public void Validate(string email, long code);
        public void CancelEmailSubscription(string email);
    }
}
