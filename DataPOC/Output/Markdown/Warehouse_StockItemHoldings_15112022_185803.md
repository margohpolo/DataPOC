## Data Dictionary: Warehouse.StockItemHoldings 
 <br /> 
 <br /> 
 Non-temporal attributes for stock items 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**StockItemID**| ID of the stock item that this holding relates to (this table holds non-temporal columns for stock) | 
|**QuantityOnHand**| Quantity currently on hand (if tracked) | 
|**BinLocation**| Bin location (ie location of this stock item within the depot) | 
|**LastStocktakeQuantity**| Quantity at last stocktake (if tracked) | 
|**LastCostPrice**| Unit cost price the last time this stock item was purchased | 
|**ReorderLevel**| Quantity below which reordering should take place | 
|**TargetStockLevel**| Typical quantity ordered | 
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
 |**StockItemID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**QuantityOnHand**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**BinLocation**| Null | NO | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LastStocktakeQuantity**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastCostPrice**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**ReorderLevel**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**TargetStockLevel**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
