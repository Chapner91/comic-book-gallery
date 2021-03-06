using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
	public class ComicBook
	{
		public int ID { get; set; }
		public string SeriesTitle { get; set; }
		public int IssueNumber { get; set; }
		public string DescriptionHtml { get; set; }
		public List<Artist> Artists { get; set; }
		public bool Favorite { get; set; }


		public string DisplayText => SeriesTitle + " #" + IssueNumber;
		//seriesTitle-issuenumber.jpg
		public string CoverImageFileName => $"{SeriesTitle.Replace(" ", "-").ToLower()}-{IssueNumber}.jpg";
		//{
		//	"Script: Dan Slott",
		//	"Pencils: Humberto Ramos",
		//	"Inks: Victor Olazaba",
		//	"Colors: Edgar Delgado",
		//	"Letters: Chris Eliopoulos"
		//};
	}
}
