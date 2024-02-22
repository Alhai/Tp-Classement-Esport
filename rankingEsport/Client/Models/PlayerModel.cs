using System;
namespace rankingEsport.Models
{
	public class PlayerModel
	{

        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Pseudo { get; set; }
        public required string Team { get; set; }
        public required int Statistic { get; set; }

}
}

