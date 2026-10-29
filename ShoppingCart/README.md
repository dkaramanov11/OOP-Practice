# ShoppingCart — Shopping Cart Management

Create a system for managing a shopping cart.

## Requirements

Create a Product class:
- It has read-only Id, Name, and Price properties.
- Initialize them through a constructor.
- If the price is negative, display a message and set it to 0.
- Use decimal for prices.

Create a CartItem class:
- It contains a Product and a Quantity.
- The initial quantity must be greater than 0.
- If the initial quantity is invalid, display a message and set it to 1.
- Quantity must not be modified directly from outside.
- IncreaseQuantity(int amount) increases the quantity.
- Reject amounts that are 0 or negative without changing the quantity.
- GetSubtotal() returns the product price multiplied by the quantity.

Create a ShoppingCart class:
- It has a private collection of cart items.
- AddProduct(Product product, int quantity) adds a product.
- Reject null products and quantities that are 0 or negative.
- If a product with the same ID already exists, increase its quantity.
- RemoveProduct(int productId) removes an item by product ID.
- If the product is not found, display an appropriate message.
- GetTotal() returns the total price of all items.
- PrintCart() displays each product's name, quantity, and subtotal,
  followed by the cart total.
- If the cart is empty, display an appropriate message.

## Testing

In Main:
1. Create three products.
2. Add them to a shopping cart.
3. Add the same product again and verify that its quantity increases.
4. Attempt to add an invalid quantity and a null product.
5. Display the cart.
6. Remove a product.
7. Attempt to remove a nonexistent product.
8. Display the updated cart.
9. Display an empty cart.