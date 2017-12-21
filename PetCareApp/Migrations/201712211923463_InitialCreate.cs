namespace PetCareApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicalHistory",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pet", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Pet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Birthdate = c.DateTime(nullable: false),
                        Genre = c.Int(nullable: false),
                        Weight = c.String(),
                        Neutered = c.Boolean(nullable: false),
                        Description = c.String(maxLength: 500),
                        SpeciesId = c.Int(nullable: false),
                        OwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owner", t => t.OwnerId, cascadeDelete: true)
                .ForeignKey("dbo.Species", t => t.SpeciesId, cascadeDelete: true)
                .Index(t => t.SpeciesId)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        DNI = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        Genre = c.Int(nullable: false),
                        Address = c.String(maxLength: 50),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VisitDate = c.DateTime(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 500),
                        VisitPrice = c.Double(nullable: false),
                        MedicalHistory_Id = c.Int(),
                        Vet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MedicalHistory", t => t.MedicalHistory_Id)
                .ForeignKey("dbo.Vet", t => t.Vet_Id)
                .Index(t => t.MedicalHistory_Id)
                .Index(t => t.Vet_Id);
            
            CreateTable(
                "dbo.Vet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        License = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 18),
                        IsAdmin = c.Boolean(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        DNI = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        Genre = c.Int(nullable: false),
                        Address = c.String(maxLength: 50),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visit", "Vet_Id", "dbo.Vet");
            DropForeignKey("dbo.Visit", "MedicalHistory_Id", "dbo.MedicalHistory");
            DropForeignKey("dbo.MedicalHistory", "Id", "dbo.Pet");
            DropForeignKey("dbo.Pet", "SpeciesId", "dbo.Species");
            DropForeignKey("dbo.Pet", "OwnerId", "dbo.Owner");
            DropIndex("dbo.Visit", new[] { "Vet_Id" });
            DropIndex("dbo.Visit", new[] { "MedicalHistory_Id" });
            DropIndex("dbo.Pet", new[] { "OwnerId" });
            DropIndex("dbo.Pet", new[] { "SpeciesId" });
            DropIndex("dbo.MedicalHistory", new[] { "Id" });
            DropTable("dbo.Vet");
            DropTable("dbo.Visit");
            DropTable("dbo.Species");
            DropTable("dbo.Owner");
            DropTable("dbo.Pet");
            DropTable("dbo.MedicalHistory");
        }
    }
}
