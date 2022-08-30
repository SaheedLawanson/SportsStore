namespace SportsStore.Models;

public class Cart {
    public List<CartLine> Lines { get; set; } = new List<CartLine>();

    public virtual void AddItem(Product product, Int32 quantity) {
        CartLine? line = Lines
            .Where(p => p.Product.ProductID == product.ProductID)
            .FirstOrDefault();

        if (line == null) {
            Lines.Add(new CartLine {
                Product = product,
                Quantity = quantity
            });
        }
        else {
            line.Quantity += quantity;
        }
    }
    
    public virtual void RemoveLine(Product product) {
        Lines.RemoveAll(l => l.Product.ProductID == product.ProductID);
    }

    public Decimal ComputeTotalValue() => 
        Lines.Sum(e => e.Product.Price * e.Quantity);

    public virtual void Clear() => Lines.Clear();
}

public class CartLine {
    public Int32 CartLineID { get; set; }
    public Product Product { get; set; } = new();
    public Int32 Quantity { get; set; }
}