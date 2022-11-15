## Data Dictionary: Warehouse.StockItemTransactions 
 <br /> 
 <br /> 
 Transactions covering all movements of all stock items 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**StockItemTransactionID**| Numeric ID used to refer to a stock item transaction within the database | 
|**StockItemID**| StockItem for this transaction | 
|**TransactionTypeID**| Type of transaction | 
|**CustomerID**| Customer for this transaction (if applicable) | 
|**InvoiceID**| ID of an invoice (for transactions associated with an invoice) | 
|**SupplierID**| Supplier for this stock transaction (if applicable) | 
|**PurchaseOrderID**| ID of an purchase order (for transactions associated with a purchase order) | 
|**TransactionOccurredWhen**| Date and time when the transaction occurred | 
|**Quantity**| Quantity of stock movement (positive is incoming stock, negative is outgoing) | 
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
 |**StockItemTransactionID**| (NEXT VALUE FOR [Sequences].[TransactionID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockItemID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**TransactionTypeID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**CustomerID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**InvoiceID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**SupplierID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PurchaseOrderID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**TransactionOccurredWhen**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**Quantity**| Null | NO | decimal | Null | Null | 18 | 3 | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
