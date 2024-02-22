namespace rankingEsport.Domains
{
    public class TeamEntity
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Members { get; set; }
        public required string StatsTeam { get; set; }
    }
}