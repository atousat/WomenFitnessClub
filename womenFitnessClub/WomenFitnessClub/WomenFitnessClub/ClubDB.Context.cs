﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WomenFitnessClub
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ClubDBEntities : DbContext
    {
        public ClubDBEntities()
            : base("name=ClubDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Coach> Coaches { get; set; }
    
        public virtual int CreatAdmin(string name, string pass)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatAdmin", nameParameter, passParameter);
        }
    
        public virtual ObjectResult<GetAllUser_Result> GetAllUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUser_Result>("GetAllUser");
        }
    
        public virtual ObjectResult<GetUser_Result> GetUser(string name, string pass)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUser_Result>("GetUser", nameParameter, passParameter);
        }
    
        public virtual int CreatClass(string code, string days, string time, string coachname)
        {
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            var daysParameter = days != null ?
                new ObjectParameter("days", days) :
                new ObjectParameter("days", typeof(string));
    
            var timeParameter = time != null ?
                new ObjectParameter("time", time) :
                new ObjectParameter("time", typeof(string));
    
            var coachnameParameter = coachname != null ?
                new ObjectParameter("coachname", coachname) :
                new ObjectParameter("coachname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatClass", codeParameter, daysParameter, timeParameter, coachnameParameter);
        }
    
        public virtual int CreatMember(string name, string lastname, string nationalcode, string phone, string address)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var nationalcodeParameter = nationalcode != null ?
                new ObjectParameter("nationalcode", nationalcode) :
                new ObjectParameter("nationalcode", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatMember", nameParameter, lastnameParameter, nationalcodeParameter, phoneParameter, addressParameter);
        }
    
        public virtual int CreatCoachAccount(string code, string name, string lastname, string nationalcode, string phone)
        {
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var nationalcodeParameter = nationalcode != null ?
                new ObjectParameter("nationalcode", nationalcode) :
                new ObjectParameter("nationalcode", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatCoachAccount", codeParameter, nameParameter, lastnameParameter, nationalcodeParameter, phoneParameter);
        }
    
        public virtual ObjectResult<GetSearchListClass_Result> GetSearchListClass(string code, string coachname)
        {
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            var coachnameParameter = coachname != null ?
                new ObjectParameter("coachname", coachname) :
                new ObjectParameter("coachname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSearchListClass_Result>("GetSearchListClass", codeParameter, coachnameParameter);
        }
    
        public virtual ObjectResult<GetSearchListMember_Result> GetSearchListMember(string lastname, string nationalcode)
        {
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var nationalcodeParameter = nationalcode != null ?
                new ObjectParameter("nationalcode", nationalcode) :
                new ObjectParameter("nationalcode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSearchListMember_Result>("GetSearchListMember", lastnameParameter, nationalcodeParameter);
        }
    }
}