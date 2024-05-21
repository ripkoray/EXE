using Ecommerce.Models.Enums;

namespace Ecommerce.Models.Abstracts
{
    public interface IEntity<T>
    {
        //ID-MasterId
        public int ID { get; set; }
        public T MasterId { get; set; }

        //Created
        public DateTime CreatedDate { get; set; }
        public string CreatedComputer { get; set; }
        public string CreatedIpAdress { get; set; }

        //Updated
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputer { get; set; }
        public string? UpdatedIpAdress { get; set; }

        //Activity
        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }
    }
}
