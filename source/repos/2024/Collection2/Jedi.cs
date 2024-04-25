namespace Collection2
{
    public class Jedi : IEquatable<Jedi>
    {
        public string Name { get; set; }

        public bool Equals(Jedi? other)
        {
            if (other is null)
            {
                return false;
            }

            return other.Name == this.Name;
        }
    }
}
