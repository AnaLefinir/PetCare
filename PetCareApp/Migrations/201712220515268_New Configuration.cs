namespace PetCareApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Visit", "MedicalHistory_Id", "dbo.MedicalHistory");
            DropForeignKey("dbo.Visit", "Vet_Id", "dbo.Vet");
            DropIndex("dbo.Visit", new[] { "MedicalHistory_Id" });
            DropIndex("dbo.Visit", new[] { "Vet_Id" });
            AlterColumn("dbo.Visit", "MedicalHistory_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Visit", "Vet_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Visit", "MedicalHistory_Id");
            CreateIndex("dbo.Visit", "Vet_Id");
            AddForeignKey("dbo.Visit", "MedicalHistory_Id", "dbo.MedicalHistory", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Visit", "Vet_Id", "dbo.Vet", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visit", "Vet_Id", "dbo.Vet");
            DropForeignKey("dbo.Visit", "MedicalHistory_Id", "dbo.MedicalHistory");
            DropIndex("dbo.Visit", new[] { "Vet_Id" });
            DropIndex("dbo.Visit", new[] { "MedicalHistory_Id" });
            AlterColumn("dbo.Visit", "Vet_Id", c => c.Int());
            AlterColumn("dbo.Visit", "MedicalHistory_Id", c => c.Int());
            CreateIndex("dbo.Visit", "Vet_Id");
            CreateIndex("dbo.Visit", "MedicalHistory_Id");
            AddForeignKey("dbo.Visit", "Vet_Id", "dbo.Vet", "Id");
            AddForeignKey("dbo.Visit", "MedicalHistory_Id", "dbo.MedicalHistory", "Id");
        }
    }
}
