namespace Factory.ConcreteProduct
{
    //ConcreteProduct
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela Carioca";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmessão ralado");
            ingredientes.Add("Azeitonas pretas");
        }
    }
}
