namespace LearningGit.Models
{
    public class Recipes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PreparationTime { get; set; }
        public List<string> ProductList { get; set; }
        public List<string> StepsToPerform { get; set; }
    }
}
