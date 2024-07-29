namespace Factory.ConcreteProduct 
{
    //ConcreteProduct
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            Nome = "Pizza de calabresa Paulista com muita calabresa";
            massa = "Massa fina crocante";
            molho = "Molho de tomate italiano";
            ingredientes.Add("Fatias de calabresa defumada especial");
            ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
