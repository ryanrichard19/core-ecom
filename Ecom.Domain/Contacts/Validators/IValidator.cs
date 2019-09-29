namespace Ecom.Domain.Contacts.Validators
{
    public interface IValidator<T>
    {
        bool IsValidProperties(T entity);
    }
}
