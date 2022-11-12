namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Authorname = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.tbl_Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherId = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(),
                    })
                .PrimaryKey(t => t.PublisherId);
            
            CreateStoredProcedure(
                "dbo.InsertBook",
                p => new
                    {
                        BookName = p.String(),
                    },
                body:
                    @"INSERT [dbo].[tbl_Book]([BookName])
                      VALUES (@BookName)
                      
                      DECLARE @BookId int
                      SELECT @BookId = [BookId]
                      FROM [dbo].[tbl_Book]
                      WHERE @@ROWCOUNT > 0 AND [BookId] = scope_identity()
                      
                      SELECT t0.[BookId]
                      FROM [dbo].[tbl_Book] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[BookId] = @BookId"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateBook",
                p => new
                    {
                        BookId = p.Int(),
                        BookName = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[tbl_Book]
                      SET [BookName] = @BookName
                      WHERE ([BookId] = @BookId)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteBook",
                p => new
                    {
                        BookId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[tbl_Book]
                      WHERE ([BookId] = @BookId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteBook");
            DropStoredProcedure("dbo.UpdateBook");
            DropStoredProcedure("dbo.InsertBook");
            DropTable("dbo.Publishers");
            DropTable("dbo.tbl_Book");
            DropTable("dbo.Authors");
        }
    }
}
