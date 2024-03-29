﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookControllerModel.Models
{
	[Table("ComicBookArtist", Schema = "XREF")]
	public class ComicBookArtist
	{
		public int ID { get; set; }
		public int ComicBookID { get; set; }
		public int ArtistID { get; set; }
		public int RoleID { get; set; }

		public virtual ComicBook ComicBook { get; set; }
		public virtual Artist Artist { get; set; }
		public virtual Role Role { get; set; }
	}
}
