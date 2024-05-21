using Ecommerce.Models.Abstracts;
using Ecommerce.Models.Enums;

namespace Ecommerce.Models.Base
{
    public class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            Status = DataStatus.INSERTED;
            IsActive = true;
            CreatedDate = DateTime.Now;
            CreatedComputer = Environment.MachineName;
            MasterId = Guid.NewGuid();
            
        }
        public int ID { get; set; }
        public Guid MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputer { get; set; }
        public string CreatedIpAdress { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputer { get; set; }
        public string? UpdatedIpAdress { get; set; }
        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }
    }
}
