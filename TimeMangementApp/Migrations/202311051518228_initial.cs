﻿namespace TimeManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialTimeEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeEntries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    TaskName = c.String(),
                    Duration = c.Time(nullable: false, precision: 7),
                    Notes = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.TimeEntries");
        }
    }
}
