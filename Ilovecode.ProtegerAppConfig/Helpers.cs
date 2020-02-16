using System.Configuration;

namespace Ilovecode.ProtegerAppConfig
{
    public static class Helpers
    {
        public static void Criptografar()
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSection section =
                config.ConnectionStrings;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("RSAProtectedConfigurationProvider");
                section.SectionInformation.ForceSave = true;
                config.Save();
            }
        }

        public static void Decriptografar()
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConnectionStringsSection section =
                config.ConnectionStrings;

            if (section.SectionInformation.IsProtected)
            {
                section.SectionInformation.UnprotectSection();
                section.SectionInformation.ForceSave = true;
                config.Save();
            }
        }

        public static string GetConnectionString()
        {
            Decriptografar();
            string stringConexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            Criptografar();
            return stringConexao;
        }
    }
}
