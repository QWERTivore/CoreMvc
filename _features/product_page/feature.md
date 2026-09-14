# Feature: A product page that allows a user to filter, view, and add products to a cart.

## User Actions
- View the list of products
- Filter products by category, price, rating
- Add a product to the cart

## User Story

### View Products: As a user I want to view available products so that I can browse the inventory.

<details>
    <summary>View Sequence</summary>

```mermaid
sequenceDiagram
    participant UI
    participant Controller
    participant Service
    participant Repository
    participant Db

    UI->>Controller: GET /products
    Controller->>Service: BrowseProductsDto
    Service->>Repository: QueryProducts()
    Repository->>Db: SELECT Id, Name, Price, Qty, Category, Rating FROM Products
    Db-->>Repository: ProductRows
    Repository-->>Service: List<Product>
    Service-->>Controller: ProductListDto
    Controller-->>UI: ProductListViewModel
```

</details>

### Filter Products: As a user I want to filter products by category, price, and rating so that I can find relevant items quickly.

<details>
    <summary>Filter Sequence</summary>

```mermaid
sequenceDiagram
    participant UI
    participant Controller
    participant Service
    participant Repository
    participant Db

    UI->>Controller: GET /products?category=soap&minPrice=5&maxPrice=50&minRating=4
    Controller->>Service: FilterProductsDto
    Service->>Repository: QueryProducts(filter)
    Repository->>Db: SELECT * FROM Products WHERE Category = @category AND Price BETWEEN @minPrice AND @maxPrice AND Rating >= @minRating
    Db-->>Repository: FilteredRows
    Repository-->>Service: List<Product>
    Service-->>Controller: FilteredProductListDto
    Controller-->>UI: FilteredProductListViewModel
```

</details>

### Add Products to a Cart: As a user I want to add a product to my cart so that I can purchase it later.

<details>
    <summary>Add Product Sequence</summary>

```mermaid
sequenceDiagram
    participant UI
    participant Controller
    participant Service
    participant Repository
    participant Db

    UI->>Controller: POST /cart/items { productId, quantity }
    Controller->>Service: AddToCartDto
    Service->>Repository: GetProductById(productId)
    Repository->>Db: SELECT Id, Name, Price, Qty FROM Products WHERE Id = @productId
    Db-->>Repository: Product
    Repository-->>Service: Product
    Service->>Repository: AddOrUpdateCartItem(userId, productId, quantity)
    Repository->>Db: INSERT INTO CartItems(...) OR UPDATE CartItems SET Qty = Qty + @quantity
    Db-->>Repository: CartItemRow
    Repository-->>Service: CartItem
    Service-->>Controller: CartItemDto
    Controller-->>UI: CartItemViewModel
```

</details>