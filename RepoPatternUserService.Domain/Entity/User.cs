using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RepoPatternUserService.Domain.Enum;

namespace RepoPatternUserService.Domain.Entity;

[Table("user")]
public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    [Key]
    public long Id { get; set; }
    
    [Column("first_name")]
    [MaxLength(50)]
    [MinLength(2)]
    public string FirstName { get; set; }
    
    [Column("last_name")]
    [MaxLength(50)]
    [MinLength(2)]
    public string LastName { get; set; }

    [Column("gender")]
    [MaxLength(10)]
    public Gender Gender { get; set; }
    
    [Column("passport_ser_num")]
    [MaxLength(9)]
    [MinLength(9)]
    public string PassportSerNum { get; set; }

    [Column("pinfl")]
    [MaxLength(14)]
    [MinLength(14)]
    public string PINFL { get; set; }

    
    [Column("email")]
    [MaxLength(255)]
    public string? Email { get; set; }

    [Column("username")]
    [MaxLength(150)]
    [MinLength(4)]
    public string Username { get; set; }

    [JsonIgnore] 
    [Column("password_hash")]
    public byte[] PasswordHash { get; set; }

    [JsonIgnore]
    [Column("salt")] 
    public byte[] Salt { get; set; }
}