namespace GreyhoundRace
{
    public static class Factory
    {
        // Decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0: return new Joe();
                case 1: return new McGee();
                case 2: return new George();
                default: return null;
            }
        }

    }
}
