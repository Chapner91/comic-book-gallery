using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
	public class ComicBookRepository
	{
		private static List<ComicBook> _comicBooks = new List<ComicBook>()
		{
				new ComicBook()
				{
					ID = 1,
					SeriesTitle = "The Amazing Spider-Man",
					IssueNumber = 700,
					DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
					Artists = new List<Artist>
					{
						new Artist() { Name = "Dan Slott", Role = "Script" },
						new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
						new Artist() { Name = "Victor Olazaba", Role = "Inks" },
						new Artist() { Name = "Edgar Delgado", Role = "Colors" },
						new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
					},
					Favorite = false
				},
				new ComicBook()
				{
					ID = 2,
					SeriesTitle = "The Amazing Spider-Man",
					IssueNumber = 657,
					DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
					Artists = new List<Artist>
					{
						new Artist() { Name = "Dan Slott", Role = "Script" },
						new Artist() { Name = "Marcos Martin", Role = "Pencils" },
						new Artist() { Name = "Marcos Martin", Role = "Inks" },
						new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
						new Artist() { Name = "Joe Caramagna", Role = "Letters" }
					},
					Favorite = false
				},
				new ComicBook()
				{
					ID = 3,
					SeriesTitle = "Bone",
					IssueNumber = 50,
					DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
					Artists = new List<Artist>
					{
						new Artist() { Name = "Jeff Smith", Role = "Script" },
						new Artist() { Name = "Jeff Smith", Role = "Pencils" },
						new Artist() { Name = "Jeff Smith", Role = "Inks" },
						new Artist() { Name = "Jeff Smith", Role = "Letters" }
					},
					Favorite = false
				}
		};

		public ComicBook GetComicBook(int id)
		{
			ComicBook comicBook;
			try
			{
				comicBook = _comicBooks.Single(comic => comic.ID == id);
			}
			catch (System.InvalidOperationException)
			{
				comicBook = null;
			}
			return comicBook;
		}

		public List<ComicBook> GetComicBookList()
		{
			return new List<ComicBook>(_comicBooks);
		}
	}
}