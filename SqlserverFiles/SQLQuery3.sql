--Retrieve all accounts with their corresponding branch name 
use Bank;
SELECT Account.Account_number, Account.Account_Type, Branch.Name
FROM Account
JOIN Branch ON Account.Branch_id = Branch.Branch_id; 
--


--Retrieve the total balance of all accounts at a specific branch
SELECT SUM(Balance) AS Total_Balance
FROM Account WHERE Branch_id = 2;


--Retrieve the names of all customers who have a loan: 
SELECT Customer.Name
FROM Customer
JOIN Loan_Customer ON Customer.Customer_id = Loan_Customer.Customer_id; 
--Retrieve the loan amount for a specified loan type and customer name:
SELECT Loan.Amount
FROM Loan
JOIN Loan_Customer ON Loan.Loan_id = Loan_Customer.Loan_id
JOIN Customer ON Loan_Customer.Customer_id = Customer.Customer_id
WHERE Loan.Loan_Type = 'Personal'
  AND Customer.Name = 'John Smith'; 

--Retrieve the customer with the highest total account balance:
SELECT SUM(Account.Balance) AS Total_Balance
FROM Customer
JOIN Account_Customer ON Customer.Customer_id = Account_Customer.Customer_id
JOIN Account ON Account_Customer.Account_number = Account.Account_number
GROUP BY Customer.Customer_id
ORDER BY Total_Balance DESC 


--Stored Precudure : 
