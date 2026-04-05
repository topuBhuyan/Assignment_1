
# What is an Inventory Management System?
We can call inventory management all the issues related to the stock or stock management of products in a business. Here, starting from the purchase and production of products or raw materials to the orders, sales and repurchases of customers, a management of all these issues is called an inventory management system as a whole. So to understand the inventory management system, it is necessary to know the issues under it-

---

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

## folder structure using Domain-Driven Design (DDD)
<img width="460" height="402" alt="image" src="https://github.com/user-attachments/assets/8054aee6-2e6b-4030-96c2-0bda42949353" />
<img width="263" height="411" alt="CS_folderStructure" src="https://github.com/user-attachments/assets/dd7de007-725a-4d30-810f-4d3fc2bba63d" />

## Sample Output
<img width="891" height="418" alt="SampleOutput" src="https://github.com/user-attachments/assets/bbc35255-dab2-406a-9c5e-539fbaec6930" />

<h2>SOLID</h2>
<h4>S --> Single Responsibility Principle</h4>
<h4>O --> Open/Closed Principle</h4>
<h4>L --> Liskov Substitution Principle</h4>
<h4>I --> Interface Segregation Principle</h4>
<h4>D --> Dependency Inversion Principle</h4> <br>
---
```DRY - Don't Repeat Yourself``` <br>
```KISS - Keep It Simple, Stupid``` <br>
```YAGNI - You Ain't Gonna Need It``` <br>

