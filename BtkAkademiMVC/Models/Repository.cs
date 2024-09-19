namespace BtkAkademiMVC.Models
{
    public static class Repository
    {
        private static List<Candidate> aplication = new List<Candidate>();
        public static IEnumerable<Candidate> Aplications => aplication;
        public static void Add(Candidate candidate)
        {
            aplication.Add(candidate);
        }
    }
}
