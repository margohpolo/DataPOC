## Data Dictionary: Sales.InvoiceLines 
 <br /> 
 <br /> 
 Detail lines from customer invoices 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**InvoiceLineID**| Numeric ID used for reference to a line on an invoice within the database | 
|**InvoiceID**| Invoice that this line is associated with | 
|**StockItemID**| Stock item for this invoice line | 
|**Description**| Description of the item supplied (Usually the stock item name but can be overridden) | 
|**PackageTypeID**| Type of package supplied | 
|**Quantity**| Quantity supplied | 
|**UnitPrice**| Unit price charged | 
|**TaxRate**| Tax rate to be applied | 
|**TaxAmount**| Tax amount calculated | 
|**LineProfit**| Profit made on this line item at current cost price | 
|**ExtendedPrice**| Extended line price charged | 
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
 |**InvoiceLineID**| (NEXT VALUE FOR [Sequences].[InvoiceLineID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**InvoiceID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockItemID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**Description**| Null | NO | nvarchar | 100 | 200 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PackageTypeID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**Quantity**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**UnitPrice**| Null | YES | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**TaxRate**| Null | NO | decimal | Null | Null | 18 | 3 | Null | Null | Null | 
|**TaxAmount**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**LineProfit**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**ExtendedPrice**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
