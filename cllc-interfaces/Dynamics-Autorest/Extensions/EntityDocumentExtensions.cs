﻿using Gov.Lclb.Cllb.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gov.Lclb.Cllb.Interfaces
{
    /// <summary>
    /// Extensions to support documents for entities.
    /// </summary>
    public static class EntityDocumentExtensions
    {
        

        public static string CleanGuidForSharePoint(string guidString)
        {
            string result = null;
            if (result != null)
            {
                guidString.ToUpper().Replace("-", "");
            }
            return result;
        }

        public static string GetDocumentFolderName(this MicrosoftDynamicsCRMaccount account)
        {
            string accountIdCleaned = CleanGuidForSharePoint(account.Accountid);
            string folderName = $"{account.Accountid}_{accountIdCleaned}";
            return folderName;
        }

        public static string GetDocumentFolderName(this MicrosoftDynamicsCRMadoxioApplication application)
        {
            string applicationIdCleaned = CleanGuidForSharePoint(application.AdoxioApplicationid);
            string folderName = $"{application.AdoxioJobnumber}_{applicationIdCleaned}";
            return folderName;
        }

        public static string GetDocumentFolderName(this MicrosoftDynamicsCRMcontact contact)
        {
            string applicationIdCleaned = CleanGuidForSharePoint(contact.Contactid);
            string folderName = $"contact_{applicationIdCleaned}";
            return folderName;
        }

        public static string GetDocumentFolderName(this MicrosoftDynamicsCRMadoxioWorker worker)
        {
            string applicationIdCleaned = CleanGuidForSharePoint(worker.AdoxioWorkerid);
            string folderName = $"{worker.AdoxioName}_{applicationIdCleaned}";
            return folderName;
        }

    }
}
