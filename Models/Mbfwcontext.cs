using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace mbfwAPI.Models
{
    public partial class Mbfwcontext : DbContext
    {
        public Mbfwcontext()
        {
        }

        public Mbfwcontext(DbContextOptions<Mbfwcontext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acbal> Acbals { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Adv> Advs { get; set; }
        public virtual DbSet<Agroup> Agroups { get; set; }
        public virtual DbSet<Agroupsub> Agroupsubs { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<Balrep> Balreps { get; set; }
        public virtual DbSet<Bankjv> Bankjvs { get; set; }
        public virtual DbSet<Cashpym> Cashpyms { get; set; }
        public virtual DbSet<Cashrcp> Cashrcps { get; set; }
        public virtual DbSet<Cheque> Cheques { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Claim1> Claim1s { get; set; }
        public virtual DbSet<Claim2> Claim2s { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Debit> Debits { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<DeptSub> DeptSubs { get; set; }
        public virtual DbSet<Desg> Desgs { get; set; }
        public virtual DbSet<Dllog> Dllogs { get; set; }
        public virtual DbSet<DwageAtt> DwageAtts { get; set; }
        public virtual DbSet<EmpView> EmpViews { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmptySheetAdvance> EmptySheetAdvances { get; set; }
        public virtual DbSet<FormInSoftware> FormInSoftwares { get; set; }
        public virtual DbSet<Gin1> Gin1s { get; set; }
        public virtual DbSet<Gin2> Gin2s { get; set; }
        public virtual DbSet<Gnrllgr> Gnrllgrs { get; set; }
        public virtual DbSet<GnrllgrChq> GnrllgrChqs { get; set; }
        public virtual DbSet<Gprice> Gprices { get; set; }
        public virtual DbSet<Grn1> Grn1s { get; set; }
        public virtual DbSet<Grn2> Grn2s { get; set; }
        public virtual DbSet<GrnProdtn1> GrnProdtn1s { get; set; }
        public virtual DbSet<GrnProdtn2> GrnProdtn2s { get; set; }
        public virtual DbSet<Grnpending> Grnpendings { get; set; }
        public virtual DbSet<Grp> Grps { get; set; }
        public virtual DbSet<Imgpath> Imgpaths { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<LesOldSoft> LesOldSofts { get; set; }
        public virtual DbSet<LesslistNew> LesslistNews { get; set; }
        public virtual DbSet<Lgrrep> Lgrreps { get; set; }
        public virtual DbSet<Lgrrep1> Lgrrep1s { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Mess> Messes { get; set; }
        public virtual DbSet<Mgrp> Mgrps { get; set; }
        public virtual DbSet<Mob> Mobs { get; set; }
        public virtual DbSet<Mprodtn1> Mprodtn1s { get; set; }
        public virtual DbSet<Mprodtn2> Mprodtn2s { get; set; }
        public virtual DbSet<Opjournal> Opjournals { get; set; }
        public virtual DbSet<Overtime> Overtimes { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<PayLnPayment> PayLnPayments { get; set; }
        public virtual DbSet<PendingOrdersPO> PendingOrdersPO { get; set; }
        public virtual DbSet<PendingOrdersSO> PendingordersSO { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<Periodclo> Periodclos { get; set; }
        public virtual DbSet<Pgroup> Pgroups { get; set; }
        public virtual DbSet<Pl> Pls { get; set; }
        public virtual DbSet<Pocan1> Pocan1s { get; set; }
        public virtual DbSet<Pocan2> Pocan2s { get; set; }
        public virtual DbSet<Porder1> Porder1s { get; set; }
        public virtual DbSet<Porder2> Porder2s { get; set; }
        public virtual DbSet<Prdadj1> Prdadj1s { get; set; }
        public virtual DbSet<Prdadj2> Prdadj2s { get; set; }
        public virtual DbSet<Prdbal> Prdbals { get; set; }
        public virtual DbSet<Prdbal1> Prdbal1s { get; set; }
        public virtual DbSet<Prdid> Prdids { get; set; }
        public virtual DbSet<Prdinfo> Prdinfos { get; set; }
        public virtual DbSet<Pret1> Pret1s { get; set; }
        public virtual DbSet<Pret2> Pret2s { get; set; }
        public virtual DbSet<Prlist> Prlists { get; set; }
        public virtual DbSet<Prodtn1> Prodtn1s { get; set; }
        public virtual DbSet<Prodtn2> Prodtn2s { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product2delete> Product2deletes { get; set; }
        public virtual DbSet<ProductColor> ProductColors { get; set; }
        public virtual DbSet<ProductColor1> ProductColor1s { get; set; }
        public virtual DbSet<Pujournal> Pujournals { get; set; }
        public virtual DbSet<Purch1> Purch1s { get; set; }
        public virtual DbSet<Purch2> Purch2s { get; set; }
        public virtual DbSet<SalInfo> SalInfos { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Sale1> Sale1s { get; set; }
        public virtual DbSet<Sale2> Sale2s { get; set; }
        public virtual DbSet<Salecash1> Salecash1s { get; set; }
        public virtual DbSet<Salecash2> Salecash2s { get; set; }
        public virtual DbSet<SentSm> SentSms { get; set; }
        public virtual DbSet<Service1> Service1s { get; set; }
        public virtual DbSet<Service2> Service2s { get; set; }
        public virtual DbSet<Sljournal> Sljournals { get; set; }
        public virtual DbSet<Slrep> Slreps { get; set; }
        public virtual DbSet<Sobal> Sobals { get; set; }
        public virtual DbSet<Socan1> Socan1s { get; set; }
        public virtual DbSet<Socan2> Socan2s { get; set; }
        public virtual DbSet<Sorder1> Sorder1s { get; set; }
        public virtual DbSet<Sorder2> Sorder2s { get; set; }
        public virtual DbSet<Sret1> Sret1s { get; set; }
        public virtual DbSet<Sret2> Sret2s { get; set; }
        public virtual DbSet<Stkcon1> Stkcon1s { get; set; }
        public virtual DbSet<Stkcon2> Stkcon2s { get; set; }
        public virtual DbSet<Stkiw1> Stkiw1s { get; set; }
        public virtual DbSet<Stkiw2> Stkiw2s { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockColor> StockColors { get; set; }
        public virtual DbSet<Stockpo> Stockpos { get; set; }
        public virtual DbSet<Stockso> Stocksos { get; set; }
        public virtual DbSet<TattSummary> TattSummaries { get; set; }
        public virtual DbSet<Tattendance> Tattendances { get; set; }
        public virtual DbSet<Tchkuser> Tchkusers { get; set; }
        public virtual DbSet<Tempe> Tempes { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
        public virtual DbSet<Trial> Trials { get; set; }
        public virtual DbSet<Trsf1> Trsf1s { get; set; }
        public virtual DbSet<Trsf2> Trsf2s { get; set; }
        public virtual DbSet<Tsalary> Tsalaries { get; set; }
        public virtual DbSet<Tstktrf> Tstktrves { get; set; }
        public virtual DbSet<UidPassChild> UidPassChildren { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<View2> View2s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Agroup>(entity =>
            {
                entity.Property(e => e.Pgrp).ValueGeneratedNever();
            });

            modelBuilder.Entity<Agroupsub>(entity =>
            {
                entity.Property(e => e.Pgrp).ValueGeneratedNever();
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Ccode).ValueGeneratedNever();
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.Grp).ValueGeneratedNever();
            });

            modelBuilder.Entity<Credit>(entity =>
            {
                entity.Property(e => e.Clrdate)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Debit>(entity =>
            {
                entity.Property(e => e.Clrdate)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.Property(e => e.Dpcode).IsUnicode(false);

                entity.Property(e => e.Dpname).IsUnicode(false);
            });

            modelBuilder.Entity<DeptSub>(entity =>
            {
                entity.Property(e => e.Dpcode).IsUnicode(false);

                entity.Property(e => e.Dpname).IsUnicode(false);
            });

            modelBuilder.Entity<Desg>(entity =>
            {
                entity.Property(e => e.Dcode).IsUnicode(false);

                entity.Property(e => e.Dname).IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Dcode).IsUnicode(false);

                entity.Property(e => e.Dpcode).IsUnicode(false);

                entity.Property(e => e.Ecode).IsUnicode(false);

                entity.Property(e => e.Ename).IsUnicode(false);

                entity.Property(e => e.Experience).IsUnicode(false);

                entity.Property(e => e.Fname).IsUnicode(false);

                entity.Property(e => e.Nic).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Gin1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();

                entity.Property(e => e.Bbno).IsFixedLength(true);
            });

            modelBuilder.Entity<Gnrllgr>(entity =>
            {
                entity.Property(e => e.Clrdate)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<GnrllgrChq>(entity =>
            {
                entity.Property(e => e.Clrdate)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Grn1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<Grp>(entity =>
            {
                entity.Property(e => e.Grp1).ValueGeneratedNever();
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Gcode).ValueGeneratedNever();
            });

            modelBuilder.Entity<Mgrp>(entity =>
            {
                entity.Property(e => e.Grp).ValueGeneratedNever();
            });


            modelBuilder.Entity<Pgroup>(entity =>
            {
                entity.Property(e => e.Pgrp).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pocan1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<Porder1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<Prdadj1>(entity =>
            {
                entity.Property(e => e.Stype)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Pret1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<Product2delete>(entity =>
            {
                entity.HasKey(e => e.Pcode)
                    .HasName("PK_PRODUCT_1");
            });

            modelBuilder.Entity<ProductColor>(entity =>
            {
                entity.HasKey(e => e.Pcid)
                    .HasName("PK__PRODUCT___83E06A9FAF6EF7A4");

                entity.Property(e => e.Color).IsUnicode(false);

                entity.Property(e => e.Pcode).IsUnicode(false);
            });

            modelBuilder.Entity<Purch1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<SalInfo>(entity =>
            {
                entity.Property(e => e.Ecode).IsUnicode(false);

                entity.Property(e => e.Edept).IsUnicode(false);

                entity.Property(e => e.Edesg).IsUnicode(false);

                entity.Property(e => e.Ename).IsUnicode(false);

                entity.Property(e => e.Estat).IsUnicode(false);
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.Property(e => e.Ecode).IsUnicode(false);
            });

            modelBuilder.Entity<Sale1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<Service1>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_SERVICE3");

                entity.HasOne(d => d.VcodeNavigation)
                    .WithMany(p => p.Service1s)
                    .HasForeignKey(d => d.Vcode)
                    .HasConstraintName("FK_SERVICE1_CUSTOMER");
            });

            modelBuilder.Entity<Service2>(entity =>
            {
                entity.HasOne(d => d.OrdernoNavigation)
                    .WithMany(p => p.Service2s)
                    .HasForeignKey(d => d.Orderno)
                    .HasConstraintName("FK_SERVICE2_SERVICE1");

                entity.HasOne(d => d.PcodeNavigation)
                    .WithMany(p => p.Service2s)
                    .HasForeignKey(d => d.Pcode)
                    .HasConstraintName("FK_SERVICE2_SERVICE2");
            });

            modelBuilder.Entity<Sorder1>(entity =>
            {
                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.Property(e => e.Tcode).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tsalary>(entity =>
            {
                entity.Property(e => e.Ecode).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
