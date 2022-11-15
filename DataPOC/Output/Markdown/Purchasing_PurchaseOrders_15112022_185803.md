## Data Dictionary: Purchasing.PurchaseOrders 
 <br /> 
 <br /> 
 Details of supplier purchase orders 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**PurchaseOrderID**| Numeric ID used for reference to a purchase order within the database | 
|**SupplierID**| Supplier for this purchase order | 
|**OrderDate**| Date that this purchase order was raised | 
|**DeliveryMethodID**| How this purchase order should be delivered | 
|**ContactPersonID**| The person who is the primary contact for this purchase order | 
|**ExpectedDeliveryDate**| Expected delivery date for this purchase order | 
|**SupplierReference**| Supplier reference for our organization (might be our account number at the supplier) | 
|**IsOrderFinalized**| Is this purchase order now considered finalized? | 
|**Comments**| Any comments related this purchase order (comments sent to the supplier) | 
|**InternalComments**| Any internal comments related this purchase order (comments for internal reference only and not sent to the supplier) | 
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
 |**PurchaseOrderID**| (NEXT VALUE FOR [Sequences].[PurchaseOrderID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**SupplierID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**OrderDate**| Null | NO | date | Null | Null | Null | Null | 0 | Null | Null | 
|**DeliveryMethodID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ContactPersonID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ExpectedDeliveryDate**| Null | YES | date | Null | Null | Null | Null | 0 | Null | Null | 
|**SupplierReference**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**IsOrderFinalized**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**Comments**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**InternalComments**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
