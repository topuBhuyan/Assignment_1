```
What is an Inventory Management System?
We can call inventory management all the issues related to the stock or stock management of products in a business. Here, starting from the purchase and production of products or raw materials to the orders, sales and repurchases of customers, a management of all these issues is called an inventory management system as a whole. So to understand the inventory management system, it is necessary to know the issues under it-
```

# Code Refactoring Summary

| Principle | Old Code (Given) | New Refactored Code |
|-----------|------------------|---------------------|
| DRY | Grade logic written 3 times | `GradeCalculator.GetGrade()` used once everywhere |
| DRY | Attendance logic written 2 times | `GetEligibilityStatus()` once |
| DRY | Salary logic 1 time (was correct) | Explained |
| DRY | Teacher Rank logic 1 time (was correct) | Explained |
| YAGNI | Unnecessary nested loop (3x2) | Removed (not needed) |
| YAGNI | Unnecessary variables (a,b,c,d,e) | Removed |
| YAGNI | Unnecessary marks again? | Explained (was in original code) |
| Clean Code | Everything mixed in `main()` | Split into small methods |
| Clean Code | Unclear names (m, att, ch, m2) | Meaningful names (marks, attendance, choice) |


