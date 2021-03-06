// <auto-generated />
using System;
using CMS.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMS.EntityFramework.Migrations
{
    [DbContext(typeof(CmsDbContext))]
    partial class CmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMS.EntityFramework.Domain.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFollow")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("MetaTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<Guid>("NewsNewsCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NewsType")
                        .HasColumnType("int");

                    b.Property<string>("OgDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Slug")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NewsNewsCategoryId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.NewsCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid?>("NewsNewsCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Slug")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Thumbnail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NewsNewsCategoryId");

                    b.HasIndex("ParentId");

                    b.ToTable("NewsCategories");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.NewsNewsCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NewsCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NewsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("NewsNewsCategories");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.NewsTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("NewsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.HasIndex("TagId");

                    b.ToTable("NewsTags");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleteable")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndPublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hierarchy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IncludeInSiteNavigation")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFollow")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHomepage")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Language")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("MetaTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("OgDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Readers")
                        .HasColumnType("int");

                    b.Property<int>("RecordOrder")
                        .HasColumnType("int");

                    b.Property<bool>("ShowOnSitemap")
                        .HasColumnType("bit");

                    b.Property<bool>("SlugEditable")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartPublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.PageCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HashCode")
                        .HasColumnType("int");

                    b.Property<string>("Hierarchy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFollow")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("MetaTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Name")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("OgDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<Guid?>("PageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("ParentId");

                    b.ToTable("PageCategories");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.PageContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HashCode")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Language")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Link")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid?>("PageCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Slug")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Title")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PageCategoryId");

                    b.ToTable("PageContents");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.PageTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("TagId");

                    b.ToTable("PageTags");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AllowComment")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowRating")
                        .HasColumnType("bit");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<bool>("IncludeInSiteNavigation")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSale")
                        .HasColumnType("bit");

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("ShowOnHomepage")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Thumbnail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Slug")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Thumbnail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.ProductProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductProductCategories");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.ProductTagMapping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTagMappings");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNoFollow")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("MetaTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Name")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("OgDescription")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("OgTitle")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Slug")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("LastName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Menu", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.Menu", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.News", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.NewsNewsCategory", "NewsNewsCategory")
                        .WithMany("News")
                        .HasForeignKey("NewsNewsCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NewsNewsCategory");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.NewsCategory", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.NewsNewsCategory", "NewsNewsCategory")
                        .WithMany("NewsCategories")
                        .HasForeignKey("NewsNewsCategoryId");

                    b.HasOne("CMS.EntityFramework.Domain.NewsCategory", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("NewsNewsCategory");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.NewsTag", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.News", "News")
                        .WithMany("NewsTags")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMS.EntityFramework.Domain.Tag", "Tag")
                        .WithMany("NewsTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Page", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.Page", "Parent")
                        .WithMany("ChildrenPages")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.PageCategory", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.Page", "Page")
                        .WithMany("PageCategories")
                        .HasForeignKey("PageId");

                    b.HasOne("CMS.EntityFramework.Domain.PageCategory", "Parent")
                        .WithMany("ChildPageCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Page");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.PageContent", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.PageCategory", "PageCategory")
                        .WithMany("PageContents")
                        .HasForeignKey("PageCategoryId");

                    b.Navigation("PageCategory");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.PageTag", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.Page", "Page")
                        .WithMany("PageTags")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMS.EntityFramework.Domain.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Page");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.ProductCategory", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.ProductCategory", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.ProductProductCategory", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.ProductCategory", "ProductCategory")
                        .WithMany("ProductProductCategories")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMS.EntityFramework.Domain.Product", "Product")
                        .WithMany("ProductProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.ProductTagMapping", b =>
                {
                    b.HasOne("CMS.EntityFramework.Domain.Product", "Product")
                        .WithMany("ProductTagMappings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMS.EntityFramework.Domain.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.News", b =>
                {
                    b.Navigation("NewsTags");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.NewsNewsCategory", b =>
                {
                    b.Navigation("News");

                    b.Navigation("NewsCategories");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Page", b =>
                {
                    b.Navigation("ChildrenPages");

                    b.Navigation("PageCategories");

                    b.Navigation("PageTags");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.PageCategory", b =>
                {
                    b.Navigation("ChildPageCategories");

                    b.Navigation("PageContents");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Product", b =>
                {
                    b.Navigation("ProductProductCategories");

                    b.Navigation("ProductTagMappings");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.ProductCategory", b =>
                {
                    b.Navigation("ProductProductCategories");
                });

            modelBuilder.Entity("CMS.EntityFramework.Domain.Tag", b =>
                {
                    b.Navigation("NewsTags");

                    b.Navigation("ProductTags");
                });
#pragma warning restore 612, 618
        }
    }
}
