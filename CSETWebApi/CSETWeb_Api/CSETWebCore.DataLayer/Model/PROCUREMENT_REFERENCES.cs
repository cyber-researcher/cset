﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model;

/// <summary>
/// A collection of PROCUREMENT_REFERENCES records
/// </summary>
[PrimaryKey("Procurement_Id", "Reference_Id")]
public partial class PROCUREMENT_REFERENCES
{
    /// <summary>
    /// The Procurement Id is used to
    /// </summary>
    [Key]
    public int Procurement_Id { get; set; }

    /// <summary>
    /// The Reference Id is used to
    /// </summary>
    [Key]
    public int Reference_Id { get; set; }

    [ForeignKey("Procurement_Id")]
    [InverseProperty("PROCUREMENT_REFERENCES")]
    public virtual PROCUREMENT_LANGUAGE_DATA Procurement { get; set; }

    [ForeignKey("Reference_Id")]
    [InverseProperty("PROCUREMENT_REFERENCES")]
    public virtual REFERENCES_DATA Reference { get; set; }
}