using ContactAddress.ContactAddress.Helper;
using DataverseModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAddress.ContactAddress
{
    public class ContactHelper
    {
        public ContactHelper(IOrganizationService service, ITracingService tracingService, IPluginExecutionContext context)
        {
            this.Service = service;
            this.TracingService = tracingService;
            this.Context = context;
        }

        private IOrganizationService Service { get; set; }
        private ITracingService TracingService { get; set; }
        private IPluginExecutionContext Context { get; set; }

        public void CreateOrUpdateContact(Contact currentContact)
        {

            TracingService.Trace("Start Function - CreateOrUpdateContact()");
            EntityReference account = currentContact?.ParentCustomerId;
            if (account == null) return;
            Account parentAccount = FindAssociatedAccount(account.Id);
            if (parentAccount == null) return;
            UpdateEntity(currentContact, parentAccount);
            TracingService.Trace("Exit Function - CreateOrUpdateContact()");

        }

        public Account FindAssociatedAccount(Guid accountid)
        {
            TracingService.Trace("Start Function - CreateOrUpdateContact()");

            try
            {
                TracingService.Trace("Function - FindAssociatedAccount() - Try");
                return this.Service.Retrieve(Account.EntityLogicalName, accountid, new ColumnSet(true)).ToEntity<Account>();
            }
            catch (Exception e)
            {
                TracingService.Trace("Function - FindAssociatedAccount() - Catch");
                throw new InvalidPluginExecutionException(e.Message);
            }

        }

        public void UpdateEntity(Contact contactEntity, Account parentAccount)
        {
            TracingService.Trace("Start Function - UpdateEntity()");

            contactEntity.Address1_Line1 = contactEntity.Address1_Line1 == parentAccount.Address1_Line1 ? contactEntity.Address1_Line1 : parentAccount.Address1_Line1;
            contactEntity.Address1_Line2 = contactEntity.Address1_Line2 == parentAccount.Address1_Line2 ? contactEntity.Address1_Line2 : parentAccount.Address1_Line2;
            contactEntity.Address1_Line3 = contactEntity.Address1_Line3 == parentAccount.Address1_Line3 ? contactEntity.Address1_Line3 : parentAccount.Address1_Line3;
            contactEntity.Address1_City = contactEntity.Address1_City == parentAccount.Address1_City ? contactEntity.Address1_City : parentAccount.Address1_City;
            contactEntity.Address1_StateOrProvince = contactEntity.Address1_StateOrProvince == parentAccount.Address1_StateOrProvince ? contactEntity.Address1_StateOrProvince : parentAccount.Address1_StateOrProvince;
            contactEntity.Address1_PostalCode = contactEntity.Address1_PostalCode == parentAccount.Address1_PostalCode ? contactEntity.Address1_PostalCode : parentAccount.Address1_PostalCode;
            contactEntity.Address1_Country = contactEntity.Address1_Country == parentAccount.Address1_Country ? contactEntity.Address1_Country : parentAccount.Address1_Country;
            
            TraceAddressInformation(contactEntity);
            TracingService.Trace("Exit Function - UpdateEntity()");
        }

        public void TraceAddressInformation(Contact contact)
        {
            TracingService.Trace("Contact Address1_Line1 : " + contact.Address1_Line1);
            TracingService.Trace("Contact Address1_Line2 : " + contact.Address1_Line2);
            TracingService.Trace("Contact Address1_Line3 : " + contact.Address1_Line3);
            TracingService.Trace("Contact Address1_City : " + contact.Address1_City);
            TracingService.Trace("Contact Address1_StateOrProvince : " + contact.Address1_StateOrProvince);
            TracingService.Trace("Contact Address1_PostalCode : " + contact.Address1_PostalCode);
            TracingService.Trace("Contact Address1_Country : " + contact.Address1_Country);
        }

    }
}
