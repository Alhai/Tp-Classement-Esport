namespace rankingEsport.Domains
{
    public class Teams
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Members { get; set; }
        public required Teams StatsTeam { get; set; }
    }
}