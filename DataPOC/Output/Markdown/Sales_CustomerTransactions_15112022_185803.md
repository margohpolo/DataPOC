## Data Dictionary: Sales.CustomerTransactions 
 <br /> 
 <br /> 
 All financial transactions that are customer-related 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**CustomerTransactionID**| Numeric ID used to refer to a customer transaction within the database | 
|**CustomerID**| Customer for this transaction | 
|**TransactionTypeID**| Type of transaction | 
|**InvoiceID**| ID of an invoice (for transactions associated with an invoice) | 
|**PaymentMethodID**| ID of a payment method (for transactions involving payments) | 
|**TransactionDate**| Date for the transaction | 
|**AmountExcludingTax**| Transaction amount (excluding tax) | 
|**TaxAmount**| Tax amount calculated | 
|**TransactionAmount**| Transaction amount (including tax) | 
|**OutstandingBalance**| Amount still outstanding for this transaction | 
|**FinalizationDate**| Date that this transaction was finalized (if it has been) | 
|**IsFinalized**| Is this transaction finalized (invoices, credits and payments have been matched) | 
|**LastEditedBy**| Null | 
|**LastEditedWhen**| Null | 
 
 </Details> 
 <br /> 
 <br />  


#### Column Attributes 
 <Details> 
 <Summary>Click to view</Summary>
 

<br /> 
 | Column | ColumnDefault | IsNullable | DataType | CharMaxLength | CharDataLength | NumericPrecision | NumericScale | DatetimePrecision | CharSetName | CollationName |
 |------|------|------|------|------|------|------|------|------|------|------|
 |**CustomerTransactionID**| (NEXT VALUE FOR [Sequences].[TransactionID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**CustomerID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**TransactionTypeID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**InvoiceID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PaymentMethodID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**TransactionDate**| Null | NO | date | Null | Null | Null | Null | 0 | Null | Null | 
|**AmountExcludingTax**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**TaxAmount**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**TransactionAmount**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**OutstandingBalance**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**FinalizationDate**| Null | YES | date | Null | Null | Null | Null | 0 | Null | Null | 
|**IsFinalized**| Null | YES | bit | Null | Null | Null | Null | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
