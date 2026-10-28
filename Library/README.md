# Library — Book Management

Create a system for managing books in a library.

## Requirements

Create a Book class:
- Each book has an ID, a title, an author, and an IsBorrowed status.
- The constructor initializes the ID, title, and author.
- New books are not borrowed.
- Properties can be read but must not be modified directly from outside.
- Borrow() marks the book as borrowed.
- If the book is already borrowed, display an appropriate message.
- Return() marks the book as available.
- If the book is not borrowed, display an appropriate message.
- PrintInfo() displays all book details.

Create a Library class:
- It has a name and a private collection of books.
- AddBook(Book book) adds a book to the library.
- Reject null books and duplicate book IDs with an appropriate message.
- BorrowBook(int id) finds and borrows a book by ID.
- ReturnBook(int id) finds and returns a book by ID.
- If the book ID does not exist, display an appropriate message.
- PrintAvailableBooks() displays only books that are not borrowed.
- Invalid operations must leave the existing state unchanged.

## Testing

In Main:
1. Create a library and three books.
2. Add the books to the library.
3. Attempt to add a book with a duplicate ID.
4. Borrow a book.
5. Attempt to borrow the same book again.
6. Display all available books.
7. Return the borrowed book.
8. Attempt to return it again.
9. Attempt to borrow a book with a nonexistent ID.
10. Display all available books again.