using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStore.Models;
using SportsStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Pages;

public class CartModel: PageModel {
    private IStoreRepository repository;

    public CartModel (IStoreRepository repo, Cart cartService) {
        repository = repo;
        Cart = cartService;
    }

    public Cart Cart { get; set; }
    public String ReturnUrl { get; set; } = "/";

    public void OnGet(String returnUrl) {
        ReturnUrl = returnUrl ?? "/";
        // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
    }

    public IActionResult OnPost(Int64 productId, String returnUrl) {
        Product? product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);

        if (product != null) {
            Cart.AddItem(product, 1);
        }

        return RedirectToPage(new { returnUrl = returnUrl });
    }

    public IActionResult OnPostRemove(Int64 productId, String returnUrl) {
        Cart.RemoveLine(Cart.Lines.First(cl => 
            cl.Product.ProductID == productId).Product);

        return RedirectToPage(new { returnUrl = returnUrl });
    }
}