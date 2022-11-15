## Data Dictionary: Application.People 
 <br /> 
 <br /> 
 People known to the application (staff, customer contacts, supplier contacts) 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**PersonID**| Numeric ID used for reference to a person within the database | 
|**FullName**| Full name for this person | 
|**PreferredName**| Name that this person prefers to be called | 
|**SearchName**| Name to build full text search on (computed column) | 
|**IsPermittedToLogon**| Is this person permitted to log on? | 
|**LogonName**| Person's system logon name | 
|**IsExternalLogonProvider**| Is logon token provided by an external system? | 
|**HashedPassword**| Hash of password for users without external logon tokens | 
|**IsSystemUser**| Is the currently permitted to make online access? | 
|**IsEmployee**| Is this person an employee? | 
|**IsSalesperson**| Is this person a staff salesperson? | 
|**UserPreferences**| User preferences related to the website (holds JSON data) | 
|**PhoneNumber**| Phone number | 
|**FaxNumber**| Fax number   | 
|**EmailAddress**| Email address for this person | 
|**Photo**| Photo of this person | 
|**CustomFields**| Custom fields for employees and salespeople | 
|**OtherLanguages**| Other languages spoken (computed column from custom fields) | 
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
 |**PersonID**| (NEXT VALUE FOR [Sequences].[PersonID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**FullName**| Null | NO | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PreferredName**| Null | NO | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**SearchName**| Null | NO | nvarchar | 101 | 202 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**IsPermittedToLogon**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**LogonName**| Null | YES | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**IsExternalLogonProvider**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**HashedPassword**| Null | YES | varbinary | -1 | -1 | Null | Null | Null | Null | Null | 
|**IsSystemUser**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**IsEmployee**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**IsSalesperson**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**UserPreferences**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PhoneNumber**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**FaxNumber**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**EmailAddress**| Null | YES | nvarchar | 256 | 512 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Photo**| Null | YES | varbinary | -1 | -1 | Null | Null | Null | Null | Null | 
|**CustomFields**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**OtherLanguages**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ValidFrom**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**ValidTo**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
