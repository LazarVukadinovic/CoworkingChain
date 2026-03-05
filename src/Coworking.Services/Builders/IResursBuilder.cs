using Coworking.Domain.Entities;

namespace Coworking.Services.Builders
{
    public interface IResursBuilder<TResurs> where TResurs : Resurs
    {
        void Reset();
        void SetLokacijaId(int lokacijaId);
        void SetOznaka(string oznaka);
        void SetOpis(string opis);
        TResurs Build();
    }
}
