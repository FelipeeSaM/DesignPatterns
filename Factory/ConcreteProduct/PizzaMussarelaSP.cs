namespace Factory.ConcreteProduct
{
    //ConcreteProduct
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de mussarela Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmessão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}
