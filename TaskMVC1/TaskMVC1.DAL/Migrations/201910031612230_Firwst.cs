namespace TaskMVC1.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firwst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Title = c.String(),
                        Photo = c.Binary(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kinds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questionaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        ArticleId = c.Int(),
                        ComplectationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId)
                .ForeignKey("dbo.Complectations", t => t.ComplectationId)
                .Index(t => t.ArticleId)
                .Index(t => t.ComplectationId);
            
            CreateTable(
                "dbo.Complectations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Text = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KindArticles",
                c => new
                    {
                        Kind_Id = c.Int(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Kind_Id, t.Article_Id })
                .ForeignKey("dbo.Kinds", t => t.Kind_Id, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.Article_Id, cascadeDelete: true)
                .Index(t => t.Kind_Id)
                .Index(t => t.Article_Id);
            
            CreateTable(
                "dbo.TagQuestionaries",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        Questionary_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Questionary_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Questionaries", t => t.Questionary_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Questionary_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagQuestionaries", "Questionary_Id", "dbo.Questionaries");
            DropForeignKey("dbo.TagQuestionaries", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.Questionaries", "ComplectationId", "dbo.Complectations");
            DropForeignKey("dbo.Questionaries", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.KindArticles", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.KindArticles", "Kind_Id", "dbo.Kinds");
            DropIndex("dbo.TagQuestionaries", new[] { "Questionary_Id" });
            DropIndex("dbo.TagQuestionaries", new[] { "Tag_Id" });
            DropIndex("dbo.KindArticles", new[] { "Article_Id" });
            DropIndex("dbo.KindArticles", new[] { "Kind_Id" });
            DropIndex("dbo.Questionaries", new[] { "ComplectationId" });
            DropIndex("dbo.Questionaries", new[] { "ArticleId" });
            DropTable("dbo.TagQuestionaries");
            DropTable("dbo.KindArticles");
            DropTable("dbo.Votes");
            DropTable("dbo.Reviews");
            DropTable("dbo.Tags");
            DropTable("dbo.Complectations");
            DropTable("dbo.Questionaries");
            DropTable("dbo.Kinds");
            DropTable("dbo.Articles");
        }
    }
}
