﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class tranningEntities : DbContext
    {
        public tranningEntities()
            : base("name=tranningEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
    
        public virtual ObjectResult<Employee> FN_Create_Rec(string empName, string empDepartment, string empPhone, string empAddress, string empEmailId)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empDepartmentParameter = empDepartment != null ?
                new ObjectParameter("EmpDepartment", empDepartment) :
                new ObjectParameter("EmpDepartment", typeof(string));
    
            var empPhoneParameter = empPhone != null ?
                new ObjectParameter("EmpPhone", empPhone) :
                new ObjectParameter("EmpPhone", typeof(string));
    
            var empAddressParameter = empAddress != null ?
                new ObjectParameter("EmpAddress", empAddress) :
                new ObjectParameter("EmpAddress", typeof(string));
    
            var empEmailIdParameter = empEmailId != null ?
                new ObjectParameter("EmpEmailId", empEmailId) :
                new ObjectParameter("EmpEmailId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FN_Create_Rec", empNameParameter, empDepartmentParameter, empPhoneParameter, empAddressParameter, empEmailIdParameter);
        }
    
        public virtual ObjectResult<Employee> FN_Create_Rec(string empName, string empDepartment, string empPhone, string empAddress, string empEmailId, MergeOption mergeOption)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empDepartmentParameter = empDepartment != null ?
                new ObjectParameter("EmpDepartment", empDepartment) :
                new ObjectParameter("EmpDepartment", typeof(string));
    
            var empPhoneParameter = empPhone != null ?
                new ObjectParameter("EmpPhone", empPhone) :
                new ObjectParameter("EmpPhone", typeof(string));
    
            var empAddressParameter = empAddress != null ?
                new ObjectParameter("EmpAddress", empAddress) :
                new ObjectParameter("EmpAddress", typeof(string));
    
            var empEmailIdParameter = empEmailId != null ?
                new ObjectParameter("EmpEmailId", empEmailId) :
                new ObjectParameter("EmpEmailId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FN_Create_Rec", mergeOption, empNameParameter, empDepartmentParameter, empPhoneParameter, empAddressParameter, empEmailIdParameter);
        }
    
        public virtual int Delete_Rec(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Rec", empIdParameter);
        }
    
        public virtual ObjectResult<Employee> FN_Disp_Rec()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FN_Disp_Rec");
        }
    
        public virtual ObjectResult<Employee> FN_Disp_Rec(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FN_Disp_Rec", mergeOption);
        }
    
        public virtual ObjectResult<Employee> FN_Edit_Rec(Nullable<int> empid)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FN_Edit_Rec", empidParameter);
        }
    
        public virtual ObjectResult<Employee> FN_Edit_Rec(Nullable<int> empid, MergeOption mergeOption)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FN_Edit_Rec", mergeOption, empidParameter);
        }
    
        public virtual int Update_Rec(Nullable<int> empid, string empName, string empDepartment, string empPhone, string empAddress, string empEmailId)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empDepartmentParameter = empDepartment != null ?
                new ObjectParameter("EmpDepartment", empDepartment) :
                new ObjectParameter("EmpDepartment", typeof(string));
    
            var empPhoneParameter = empPhone != null ?
                new ObjectParameter("EmpPhone", empPhone) :
                new ObjectParameter("EmpPhone", typeof(string));
    
            var empAddressParameter = empAddress != null ?
                new ObjectParameter("EmpAddress", empAddress) :
                new ObjectParameter("EmpAddress", typeof(string));
    
            var empEmailIdParameter = empEmailId != null ?
                new ObjectParameter("EmpEmailId", empEmailId) :
                new ObjectParameter("EmpEmailId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Rec", empidParameter, empNameParameter, empDepartmentParameter, empPhoneParameter, empAddressParameter, empEmailIdParameter);
        }
    
        public virtual int Create_Record(string empName, string empDepartment, string empPhone, string empAddress, string empEmailId)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empDepartmentParameter = empDepartment != null ?
                new ObjectParameter("EmpDepartment", empDepartment) :
                new ObjectParameter("EmpDepartment", typeof(string));
    
            var empPhoneParameter = empPhone != null ?
                new ObjectParameter("EmpPhone", empPhone) :
                new ObjectParameter("EmpPhone", typeof(string));
    
            var empAddressParameter = empAddress != null ?
                new ObjectParameter("EmpAddress", empAddress) :
                new ObjectParameter("EmpAddress", typeof(string));
    
            var empEmailIdParameter = empEmailId != null ?
                new ObjectParameter("EmpEmailId", empEmailId) :
                new ObjectParameter("EmpEmailId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Create_Record", empNameParameter, empDepartmentParameter, empPhoneParameter, empAddressParameter, empEmailIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> LoginCheck(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("LoginCheck", usernameParameter, passwordParameter);
        }
    }
}
