﻿using MrCMS.Entities;

namespace MrCMS.Web.IdentityServer.NHibernate.Storage.Entities
{
    #pragma warning disable 1591

    public class ClientIdPRestriction : SystemEntity
    {
        public virtual string Provider { get; set; }

        public virtual Client Client { get; set; }
    }
}