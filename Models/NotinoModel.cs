using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotinoAppka.Models
{
	[PrimaryKey(nameof(Id))]
	public class NotinoModel
	{
		
		public int Id { get; set; }
		public string Tags { get; set; }

		[ForeignKey("DataFiles")]
		public int DataId { get; set; }
		public List<DataFiles> Data { get; set; } = new List<DataFiles>();
	}


	[PrimaryKey(nameof(DataId))]
	public class DataFiles
	{
		[Key]
		public int DataId { get; set; }
		public string some { get; set; }
		public string optional { get; set; }
	}
}
