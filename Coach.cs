namespace NFL
{
    public partial class Coach
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        public Coach(string dataRow)
        {
            var data = dataRow.Split(';');
            Name = data[0];
            TeamName = data[1];
        }
    }
}
