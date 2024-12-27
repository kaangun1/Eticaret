namespace Eticaret.Core.Entities;

public class Brand: IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Descripton { get; set; }
    public string? Logo { get; set; }
    public bool IsActive { get; set; }
    public int OrderNo { get; set; }
    public DateTime CreateDate { get; set; }

}