﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenIvy.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GreenivyDBEntities : DbContext
    {
        public GreenivyDBEntities()
            : base("name=GreenivyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentParent> StudentParents { get; set; }
        public virtual DbSet<vw_ClassCount> vw_ClassCount { get; set; }
        public virtual DbSet<Vw_StudentParentDetails> Vw_StudentParentDetails { get; set; }
    
        public virtual int StudentEntry(string studentName, string studentEmail, Nullable<int> @class, string fatherName, string motherName)
        {
            var studentNameParameter = studentName != null ?
                new ObjectParameter("StudentName", studentName) :
                new ObjectParameter("StudentName", typeof(string));
    
            var studentEmailParameter = studentEmail != null ?
                new ObjectParameter("StudentEmail", studentEmail) :
                new ObjectParameter("StudentEmail", typeof(string));
    
            var classParameter = @class.HasValue ?
                new ObjectParameter("Class", @class) :
                new ObjectParameter("Class", typeof(int));
    
            var fatherNameParameter = fatherName != null ?
                new ObjectParameter("FatherName", fatherName) :
                new ObjectParameter("FatherName", typeof(string));
    
            var motherNameParameter = motherName != null ?
                new ObjectParameter("MotherName", motherName) :
                new ObjectParameter("MotherName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StudentEntry", studentNameParameter, studentEmailParameter, classParameter, fatherNameParameter, motherNameParameter);
        }
    }
}
