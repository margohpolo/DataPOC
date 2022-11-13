## Data Dictionary: Sales.OrderLines 
 <br /> 
 <br /> 
 Detail lines from customer orders 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**OrderLineID**| Numeric ID used for reference to a line on an Order within the database | 
|**OrderID**| Order that this line is associated with | 
|**StockItemID**| Stock item for this order line (FK not indexed as separate index exists) | 
|**Description**| Description of the item supplied (Usually the stock item name but can be overridden) | 
|**PackageTypeID**| Type of package to be supplied | 
|**Quantity**| Quantity to be supplied | 
|**UnitPrice**| Unit price to be charged | 
|**TaxRate**| Tax rate to be applied | 
|**PickedQuantity**| Quantity picked from stock | 
|**PickingCompletedWhen**| When was picking of this line completed? | 
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
 |**OrderLineID**| (NEXT VALUE FOR [Sequences].[OrderLineID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**OrderID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockItemID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**Description**| Null | NO | nvarchar | 100 | 200 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PackageTypeID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**Quantity**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**UnitPrice**| Null | YES | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**TaxRate**| Null | NO | decimal | Null | Null | 18 | 3 | Null | Null | Null | 
|**PickedQuantity**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PickingCompletedWhen**| Null | YES | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
