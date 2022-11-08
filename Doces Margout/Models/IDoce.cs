namespace DocesMargout.Models
{
    public interface IDoce
    {
        public IEnumerable<Doce> TodosDoces { get; }

        public Doce GetDoceID(int DoceID);





    }
}
