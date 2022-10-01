using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace leonardo_benetti_d7_avaliacao.Model;

[Table("Users")]
public class User
{
    [Key]
    public int Id { get; set; }
    
    [Column(TypeName = "VARCHAR(150)")]
    public string UserName { get; set; } = string.Empty;

    [Column(TypeName = "VARCHAR(150)")]
    public string Password { get; set; } = string.Empty;
}
