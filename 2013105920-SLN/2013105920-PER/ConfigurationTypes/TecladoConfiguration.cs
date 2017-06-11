using _2013115366_ENT.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _2013115366_PER.ConfigurationTypes
{
    public class TecladoConfiguration : EntityTypeConfiguration<Teclado>
    {
        public TecladoConfiguration()
        {

            ToTable("Teclado");

            HasKey(a => a.TecladoId);
            Property(c => c.TecladoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);        
                

            //Retiro
            HasOptional(c => c.Retiro).WithRequired(c => c.Teclado);

        }


    }
}
