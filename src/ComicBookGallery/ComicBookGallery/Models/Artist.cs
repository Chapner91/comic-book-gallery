﻿namespace ComicBookGallery.Models
{
	public class Artist
	{
		public string Name { get; set; }
		public string Role { get; set; }

		public string DisplayText => $"{Role}: {Name}";
	}
}