# TDD Bank Account - Group Activity

## What this project is about

This is a class activity where we built a simple `BankAccount` class in C# following the **Test-Driven Development (TDD)** approach. The idea was to write all the tests first before writing any actual code, then implement just enough to make those tests pass.

## Project structure

- **BankAccountLib/** — Contains the `BankAccount` class with three methods: `Deposit`, `Withdraw`, and `GetBalance`.
- **BankAccountTests/** — Contains 10 NUnit tests that cover all the requirements.

## Requirements we implemented

- Deposit money into the account
- Withdraw money from the account
- Check the current balance
- No negative deposits or withdrawals allowed
- No overdrafts — you cannot withdraw more than what you have

## How we followed TDD (Red-Green-Refactor)

1. **Red phase** — We wrote all the test cases first. At this point the `BankAccount` class did not exist, so the project did not even compile. That was expected.
2. **Green phase** — We created the `BankAccount` class and wrote just enough logic to make every test pass.
3. **Refactor phase** — We reviewed the code and kept it clean. All tests still passed after cleanup.

## How to run the project

Make sure you have the .NET SDK installed, then open a terminal in the project folder and run:

```
dotnet test .\BankAccountTests\
```

You should see output like:

```
Test summary: total: 10, failed: 0, succeeded: 10, skipped: 0
```

## Tests we wrote

| # | Test name | What it checks |
|---|-----------|---------------|
| 1 | NewAccount_ShouldHaveZeroBalance | A new account starts with a balance of 0 |
| 2 | Deposit_ValidAmount_ShouldIncreaseBalance | Depositing 100 gives a balance of 100 |
| 3 | Deposit_MultipleTimes_ShouldAccumulateBalance | Depositing 50 then 30 gives 80 |
| 4 | Deposit_NegativeAmount_ShouldThrowException | Depositing a negative amount throws an error |
| 5 | Deposit_ZeroAmount_ShouldThrowException | Depositing zero throws an error |
| 6 | Withdraw_ValidAmount_ShouldDecreaseBalance | Depositing 200 and withdrawing 50 gives 150 |
| 7 | Withdraw_NegativeAmount_ShouldThrowException | Withdrawing a negative amount throws an error |
| 8 | Withdraw_ZeroAmount_ShouldThrowException | Withdrawing zero throws an error |
| 9 | Withdraw_MoreThanBalance_ShouldThrowException | Trying to withdraw more than the balance throws an error |
| 10 | Withdraw_ExactBalance_ShouldLeaveZeroBalance | Withdrawing the full balance leaves 0 |

## Tools used

- C# / .NET
- NUnit (testing framework)
