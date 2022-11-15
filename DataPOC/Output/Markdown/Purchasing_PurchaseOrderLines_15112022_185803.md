## Data Dictionary: Purchasing.PurchaseOrderLines 
 <br /> 
 <br /> 
 Detail lines from supplier purchase orders 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**PurchaseOrderLineID**| Numeric ID used for reference to a line on a purchase order within the database | 
|**PurchaseOrderID**| Purchase order that this line is associated with | 
|**StockItemID**| Stock item for this purchase order line | 
|**OrderedOuters**| Quantity of the stock item that is ordered | 
|**Description**| Description of the item to be supplied (Often the stock item name but could be supplier description) | 
|**ReceivedOuters**| Total quantity of the stock item that has been received so far | 
|**PackageTypeID**| Type of package received | 
|**ExpectedUnitPricePerOuter**| The unit price that we expect to be charged | 
|**LastReceiptDate**| The last date on which this stock item was received for this purchase order | 
|**IsOrderLineFinalized**| Is this purchase order line now considered finalized? (Receipted quantities and weights are often not precise) | 
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
 |**PurchaseOrderLineID**| (NEXT VALUE FOR [Sequences].[PurchaseOrderLineID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PurchaseOrderID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockItemID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**OrderedOuters**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**Description**| Null | NO | nvarchar | 100 | 200 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**ReceivedOuters**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PackageTypeID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ExpectedUnitPricePerOuter**| Null | YES | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**LastReceiptDate**| Null | YES | date | Null | Null | Null | Null | 0 | Null | Null | 
|**IsOrderLineFinalized**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
