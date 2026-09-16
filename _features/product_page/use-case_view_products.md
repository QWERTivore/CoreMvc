# View Products: As a user I want to view available products so that I can browse the inventory.
## Goal: Return a list of products the user can browse.

### Happy Path:
- Query Products
- Map to DTO
- Return a List

### Business Rules:
- Category Filter must be valid
- Price Range must be valid
- Product data must be valid (no negative price, quantity, etc...)

### Failure Paths
- No product -> return empty list
- Invalid filter -> throw InvalidProductFilterException
- Invalid product data -> throw InvalidProductDataException
- Database failure -> wrap and throw ProductQueryFailedException