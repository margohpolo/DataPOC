## Data Dictionary: Purchasing.SupplierTransactions 
 <br /> 
 <br /> 
 All financial transactions that are supplier-related 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**SupplierTransactionID**| Numeric ID used to refer to a supplier transaction within the database | 
|**SupplierID**| Supplier for this transaction | 
|**TransactionTypeID**| Type of transaction | 
|**PurchaseOrderID**| ID of an purchase order (for transactions associated with a purchase order) | 
|**PaymentMethodID**| ID of a payment method (for transactions involving payments) | 
|**SupplierInvoiceNumber**| Invoice number for an invoice received from the supplier | 
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
 |**SupplierTransactionID**| (NEXT VALUE FOR [Sequences].[TransactionID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**SupplierID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**TransactionTypeID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PurchaseOrderID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PaymentMethodID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**SupplierInvoiceNumber**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
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
