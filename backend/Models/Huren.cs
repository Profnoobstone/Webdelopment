using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Huren
{
    [Key]
    public string Id { get; set; }
    public string? Naam {get;set;}
    public DateTime? Datum { get; set; }
    [ForeignKey("Gebruiker")]
    public string VerhuurdeId { get; set; }
    [ForeignKey("Zaal")]
    public int? Zaalnr {get;set;}
    [ForeignKey("Ruimte")]
    public int? RuimteNr { get; set; }

}