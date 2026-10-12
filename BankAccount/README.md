# BankAccount — Bank Account

Create a class named BankAccount that represents a bank account.

## Requirements

- The account has an account number, an owner's name, and a balance.
- The constructor initializes all three values.
- The initial balance must not be negative. If it is negative,
  display a message and set it to 0.
- The balance can be read, but it must not be modified directly from outside the class.
- A method Deposit(amount) adds money to the account.
- A method Withdraw(amount) withdraws money from the account.
- The deposit or withdrawal amount must be greater than 0.
- Withdrawing more than the available balance is not allowed.
- For an invalid deposit or withdrawal, display an appropriate message
  and leave the balance unchanged.
- A method PrintInfo() displays the account number, owner's name, and balance.

## Testing

In Main:
1. Create a bank account with an initial balance.
2. Display its details.
3. Make a deposit.
4. Make a successful withdrawal.
5. Attempt a withdrawal with insufficient funds.
6. Attempt a deposit and a withdrawal with invalid amounts.
7. Display the final balance.