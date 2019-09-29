namespace Ecom.Domain.Contacts.Validators
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
    }
}
