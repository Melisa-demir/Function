﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeAppConsole;
public class Anime
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GenreId { get; set; }
    public Genre Genre { get; set; }
}
