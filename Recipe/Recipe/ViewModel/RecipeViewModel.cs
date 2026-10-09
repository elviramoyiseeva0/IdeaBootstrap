namespace Recipe.ViewModel
{
    public class RecipeViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Dictionary<int, IngredientViewModel> Ingredients { get; set; } = new Dictionary<int, IngredientViewModel>();
    }
}
