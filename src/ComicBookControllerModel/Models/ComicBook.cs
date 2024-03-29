﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicBookControllerModel.Models
{
	[Table("ComicBook", Schema = "DATA")]
	public class ComicBook
	{
		public int ComicBookID { get; set; }
		public int SeriesID { get; set; }
		public int IssueNumber { get; set; }
		public string Description { get; set; }
		public DateTime PublishedOn { get; set; }
		public decimal? AverageRating { get; set; }

		public virtual Series Series { get; set; }
		public virtual ICollection<ComicBookArtist> Artists { get; set; }

		public string DisplayText => $"{Series?.Title}: #{IssueNumber}";

		public ComicBook()
		{
			Artists = new List<ComicBookArtist>();
		}

		public void AddArtist(Artist artist, Role role)
		{
			Artists.Add(new ComicBookArtist { Artist = artist, Role = role });
		}
	}
}
