namespace LearningCSharp.BroCodeTutorial
{
    public class OverloadedConstructors
    {
        public OverloadedConstructors()
        {
            // overloaded constructors = multiple constructors with different parameters

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
            Pizza pizzaWithoutTopping = new Pizza("stuffed crust", "red sauce", "mozzarella");
            Pizza pizzaWithoutToppingAndWithoutCheese = new Pizza("stuffed crust", "red sauce");
        }
    }

    public class Pizza
    {
        String bread;
        
        String sauce;

        String cheese;

        String topping;

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = "";
        }

        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = "";
            this.topping = "";
        }

        public Pizza(String bread)
        {
            this.bread = bread;
            this.sauce = "";
            this.cheese = "";
            this.topping = "";
        }
    }
}