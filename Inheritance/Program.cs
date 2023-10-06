using System;

namespace CSharpInter
{
    public partial class Oct6
    {
        static void Main(String[] args)
        {

            //-------------------INHERITANCE--------------------------
            var text = new Text();
            text.Width = 100;
            text.Copy();//Copy, duplicate - parent class  --else - object class

            //------------------COMPOSITION---------------------------
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}