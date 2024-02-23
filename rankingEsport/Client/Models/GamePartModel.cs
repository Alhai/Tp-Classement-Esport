using System;
namespace rankingEsport.Models
{
	public class GamePartModel
	{
			public int ID {  get; set; }
			public DateTime Date { get; set; }
			public required string GameName { get; set; }
			public required string Teams { get; set; }
			public required int Score { get; set; }
			public required string Statistic {  get; set; }
		

	}
}

