Use Bank;
WITH AccountBalancess AS (
SELECT
a.Account_number,
a.Balance,
b.Name AS BranchName
FROM
Account a , Branch b
where a.Branch_id = b.Branch_id
)
SELECT
BranchName,
SUM(Balance) AS TotalBalance
FROM
AccountBalancess
GROUP BY BranchName;



WITH AccountLatestTransaction AS (
  SELECT
    t.account_number,
    MAX(t.transaction_date) AS latest_transaction_date
  FROM transaction_acc t
  GROUP BY t.account_number
)
SELECT
  t.account_number,
  t.transaction_id,
  t.transaction_date,
  CASE
    WHEN DATEDIFF(MONTH,  CAST(t.transaction_date AS DATE), CAST(GETDATE() AS DATE)) <=6 THEN 'Active'
    ELSE 'Dormant'
  END AS account_status


FROM transaction_acc t
INNER JOIN AccountLatestTransaction alt ON t.account_number = alt.account_number AND t.transaction_date = alt.latest_transaction_date;
