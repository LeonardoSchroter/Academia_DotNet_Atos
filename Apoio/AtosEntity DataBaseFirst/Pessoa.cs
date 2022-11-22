using System;
using System.Collections.Generic;

namespace AtosEntity_DataBaseFirst;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();
}
