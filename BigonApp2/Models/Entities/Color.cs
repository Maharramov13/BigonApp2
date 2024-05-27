namespace BigonApp2.Models.Entities
{
    public class Color:BaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HexCode { get; set; }
        //public int CreatedBy { get; set; }
        //public int? ModifiedBy { get; set; }
        //public int? DeletedBy { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime? ModifiedAt { get; set; }
        //public DateTime? DeletedAt { get; set; }


    }
}
