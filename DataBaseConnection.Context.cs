﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace UploadExcelToSQLServer
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class DBRasSsrsProd : DbContext
{
    public DBRasSsrsProd()
        : base("name=DBRasSsrsProd")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Lowes_Daily_List> Lowes_Daily_List { get; set; }

}

}

