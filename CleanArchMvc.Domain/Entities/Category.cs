using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; private set; }
        public  string? Name { get; private set; }
        public ICollection<Product>? Products { get; private set; }

        public Category(string name) {
            ValidadeDomain(name);
        }

        public Category(int id, string name) {
            DomainValidationException.When(id < 0, "Invalid Id value");
            Id = id;
            ValidadeDomain(name);
        }

        private void ValidadeDomain(string categoryName)
        {
            DomainValidationException.When(string.IsNullOrEmpty(categoryName), "Invalid Name, Name is Required!!!");
            DomainValidationException.When(categoryName.Length < 3, "Invalid Name, too short, minimun is 3 character!!!");

            Name = categoryName;
        }
        
    }
}
