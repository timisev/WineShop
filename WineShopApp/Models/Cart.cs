using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace WineShopApp.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Wine wine, int quantity)
        {
            CartLine line = lineCollection
                .Where(w => w.Wine.Id == wine.Id)
                .FirstOrDefault();
            if(line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Wine = wine,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Wine wine) =>
            lineCollection.RemoveAll(l => l.Wine.Id == wine.Id);

        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Wine.Price * e.Quantity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Wine Wine { get; set; }
        public int Quantity { get; set; }
    }
}