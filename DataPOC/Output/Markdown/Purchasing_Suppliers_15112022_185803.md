## Data Dictionary: Purchasing.Suppliers 
 <br /> 
 <br /> 
 Main entity table for suppliers (organizations) 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**SupplierID**| Numeric ID used for reference to a supplier within the database | 
|**SupplierName**| Supplier's full name (usually a trading name) | 
|**SupplierCategoryID**| Supplier's category | 
|**PrimaryContactPersonID**| Primary contact | 
|**AlternateContactPersonID**| Alternate contact | 
|**DeliveryMethodID**| Standard delivery method for stock items received from this supplier | 
|**DeliveryCityID**| ID of the delivery city for this address | 
|**PostalCityID**| ID of the mailing city for this address | 
|**SupplierReference**| Supplier reference for our organization (might be our account number at the supplier) | 
|**BankAccountName**| Supplier's bank account name (ie name on the account) | 
|**BankAccountBranch**| Supplier's bank branch | 
|**BankAccountCode**| Supplier's bank account code (usually a numeric reference for the bank branch) | 
|**BankAccountNumber**| Supplier's bank account number | 
|**BankInternationalCode**| Supplier's bank's international code (such as a SWIFT code) | 
|**PaymentDays**| Number of days for payment of an invoice (ie payment terms) | 
|**InternalComments**| Internal comments (not exposed outside organization) | 
|**PhoneNumber**| Phone number | 
|**FaxNumber**| Fax number   | 
|**WebsiteURL**| URL for the website for this supplier | 
|**DeliveryAddressLine1**| First delivery address line for the supplier | 
|**DeliveryAddressLine2**| Second delivery address line for the supplier | 
|**DeliveryPostalCode**| Delivery postal code for the supplier | 
|**DeliveryLocation**| Geographic location for the supplier's office/warehouse | 
|**PostalAddressLine1**| First postal address line for the supplier | 
|**PostalAddressLine2**| Second postal address line for the supplier | 
|**PostalPostalCode**| Postal code for the supplier when sending by mail | 
|**LastEditedBy**| Null | 
|**ValidFrom**| Null | 
|**ValidTo**| Null | 
 
 </Details> 
 <br /> 
 <br />  


#### Column Attributes 
 <Details> 
 <Summary>Click to view</Summary>
 

<br /> 
 | Column | ColumnDefault | IsNullable | DataType | CharMaxLength | CharDataLength | NumericPrecision | NumericScale | DatetimePrecision | CharSetName | CollationName |
 |------|------|------|------|------|------|------|------|------|------|------|
 |**SupplierID**| (NEXT VALUE FOR [Sequences].[SupplierID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**SupplierName**| Null | NO | nvarchar | 100 | 200 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**SupplierCategoryID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PrimaryContactPersonID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**AlternateContactPersonID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**DeliveryMethodID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**DeliveryCityID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PostalCityID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**SupplierReference**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**BankAccountName**| Null | YES | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**BankAccountBranch**| Null | YES | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**BankAccountCode**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**BankAccountNumber**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**BankInternationalCode**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PaymentDays**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**InternalComments**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PhoneNumber**| Null | NO | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**FaxNumber**| Null | NO | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**WebsiteURL**| Null | NO | nvarchar | 256 | 512 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**DeliveryAddressLine1**| Null | NO | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**DeliveryAddressLine2**| Null | YES | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**DeliveryPostalCode**| Null | NO | nvarchar | 10 | 20 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**DeliveryLocation**| Null | YES | geography | -1 | -1 | Null | Null | Null | Null | Null | 
|**PostalAddressLine1**| Null | NO | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PostalAddressLine2**| Null | YES | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PostalPostalCode**| Null | NO | nvarchar | 10 | 20 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ValidFrom**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**ValidTo**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
