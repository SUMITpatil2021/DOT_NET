using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Models
{
    public partial class knowitContext : DbContext
    {
        public knowitContext()
        {
        }

        public knowitContext(DbContextOptions<knowitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bonu> Bonus { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Course1> Courses1 { get; set; } = null!;
        public virtual DbSet<CustVehicle> CustVehicles { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Customer1> Customer1s { get; set; } = null!;
        public virtual DbSet<Dept> Depts { get; set; } = null!;
        public virtual DbSet<Dept100> Dept100s { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<Emp100> Emp100s { get; set; } = null!;
        public virtual DbSet<EmpView> EmpViews { get; set; } = null!;
        public virtual DbSet<Empdot> Empdots { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Employee1> Employee1s { get; set; } = null!;
        public virtual DbSet<Emptmp> Emptmps { get; set; } = null!;
        public virtual DbSet<JobName> JobNames { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Salesman> Salesmen { get; set; } = null!;
        public virtual DbSet<Salesman1> Salesman1s { get; set; } = null!;
        public virtual DbSet<Salgrade> Salgrades { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=sumit;database=knowit", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Bonu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bonus");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("category");

                entity.HasIndex(e => e.Cname, "cname")
                    .IsUnique();

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .HasMaxLength(15)
                    .HasColumnName("cname");

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("course");

                entity.HasIndex(e => e.Cname, "cname")
                    .IsUnique();

                entity.Property(e => e.Cid)
                    .HasMaxLength(10)
                    .HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .HasMaxLength(20)
                    .HasColumnName("cname");

                entity.Property(e => e.Fees)
                    .HasColumnName("fees")
                    .HasDefaultValueSql("'5000'");
            });

            modelBuilder.Entity<Course1>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("courses");

                entity.HasIndex(e => e.Cname, "cname")
                    .IsUnique();

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .HasMaxLength(20)
                    .HasColumnName("cname");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Fees).HasColumnName("fees");
            });

            modelBuilder.Entity<CustVehicle>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.ToTable("cust_vehicle");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.BuyPrice).HasColumnName("Buy_price");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Vid).HasColumnName("vid");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Custid)
                    .HasName("PRIMARY");

                entity.ToTable("customer");

                entity.Property(e => e.Custid)
                    .ValueGeneratedNever()
                    .HasColumnName("custid");

                entity.Property(e => e.Cname).HasMaxLength(30);

                entity.Property(e => e.Location).HasMaxLength(20);
            });

            modelBuilder.Entity<Customer1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer1");

                entity.Property(e => e.Cname).HasMaxLength(30);

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Location).HasMaxLength(20);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dept");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Dname)
                    .HasMaxLength(14)
                    .HasColumnName("DNAME");

                entity.Property(e => e.Loc)
                    .HasMaxLength(13)
                    .HasColumnName("LOC");
            });

            modelBuilder.Entity<Dept100>(entity =>
            {
                entity.HasKey(e => e.Deptno)
                    .HasName("PRIMARY");

                entity.ToTable("dept100");

                entity.Property(e => e.Deptno)
                    .ValueGeneratedNever()
                    .HasColumnName("DEPTNO");

                entity.Property(e => e.Dname)
                    .HasMaxLength(14)
                    .HasColumnName("DNAME");

                entity.Property(e => e.Loc)
                    .HasMaxLength(13)
                    .HasColumnName("LOC");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp");

                entity.HasIndex(e => e.Ename, "ename_index");

                entity.HasIndex(e => e.Sal, "sal_index");

                entity.Property(e => e.Comm)
                    .HasPrecision(7, 2)
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Empno).HasColumnName("EMPNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<Emp100>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PRIMARY");

                entity.ToTable("emp100");

                entity.Property(e => e.Empno)
                    .ValueGeneratedNever()
                    .HasColumnName("EMPNO");

                entity.Property(e => e.Comm)
                    .HasPrecision(7, 2)
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<EmpView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("emp_view");

                entity.Property(e => e.Deptno).HasColumnName("deptno");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ename");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("sal");
            });

            modelBuilder.Entity<Empdot>(entity =>
            {
                entity.HasKey(e => e.Eno)
                    .HasName("PRIMARY");

                entity.ToTable("empdot");

                entity.Property(e => e.Eno)
                    .ValueGeneratedNever()
                    .HasColumnName("eno");

                entity.Property(e => e.Ename)
                    .HasMaxLength(45)
                    .HasColumnName("ename");

                entity.Property(e => e.Job)
                    .HasMaxLength(45)
                    .HasColumnName("job");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("sal");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.Ename)
                    .HasMaxLength(15)
                    .HasColumnName("ename");

                entity.Property(e => e.Eno).HasColumnName("eno");

                entity.Property(e => e.Hiredate).HasColumnName("hiredate");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee1");

                entity.Property(e => e.Basic).HasColumnName("basic");

                entity.Property(e => e.Ename)
                    .HasMaxLength(15)
                    .HasColumnName("ename");

                entity.Property(e => e.Eno).HasColumnName("eno");

                entity.Property(e => e.Inscentive).HasColumnName("inscentive");

                entity.Property(e => e.Job)
                    .HasMaxLength(20)
                    .HasColumnName("job");
            });

            modelBuilder.Entity<Emptmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emptmp");

                entity.Property(e => e.Comm)
                    .HasPrecision(7, 2)
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Empno).HasColumnName("EMPNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<JobName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("job_name");

                entity.Property(e => e.Comm)
                    .HasPrecision(7, 2)
                    .HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Empno).HasColumnName("EMPNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate).HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal)
                    .HasPrecision(7, 2)
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.HasIndex(e => e.Cid, "fk_cid1");

                entity.HasIndex(e => e.Sid, "fk_sid");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .HasColumnName("pname");

                entity.Property(e => e.Price)
                    .HasColumnType("float(6,2)")
                    .HasColumnName("price")
                    .HasDefaultValueSql("'20.00'");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_cid1");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("fk_sid");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("salesman");

                entity.HasIndex(e => e.Sname, "sname")
                    .IsUnique();

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("sid");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasColumnName("city");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<Salesman1>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("salesman1");

                entity.Property(e => e.Sid).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("city");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Sname).HasMaxLength(30);
            });

            modelBuilder.Entity<Salgrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("salgrade");

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.Hisal).HasColumnName("HISAL");

                entity.Property(e => e.Losal).HasColumnName("LOSAL");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.ToTable("trainer");

                entity.HasIndex(e => e.Cid, "fk_cid");

                entity.Property(e => e.Tid)
                    .HasMaxLength(10)
                    .HasColumnName("tid");

                entity.Property(e => e.Cid)
                    .HasMaxLength(10)
                    .HasColumnName("cid");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.Tname)
                    .HasMaxLength(20)
                    .HasColumnName("tname");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.Trainers)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_cid");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.Vid)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle");

                entity.Property(e => e.Vid)
                    .ValueGeneratedNever()
                    .HasColumnName("vid");

                entity.Property(e => e.Details)
                    .HasMaxLength(200)
                    .HasColumnName("details");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Milage).HasColumnName("milage");

                entity.Property(e => e.Vname)
                    .HasMaxLength(30)
                    .HasColumnName("vname");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Cid, "fk_id");

                entity.Property(e => e.Tid)
                    .HasMaxLength(10)
                    .HasColumnName("tid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .HasColumnName("email");

                entity.Property(e => e.Incentive)
                    .HasColumnType("float(6,2)")
                    .HasColumnName("incentive");

                entity.Property(e => e.Sal).HasColumnName("sal");

                entity.Property(e => e.Tname)
                    .HasMaxLength(20)
                    .HasColumnName("tname");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("fk_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
