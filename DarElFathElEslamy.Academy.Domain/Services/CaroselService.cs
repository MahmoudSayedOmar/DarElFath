using DarElFathElEslamy.Academy.Domain.Models.LookUps;
using DarElFathElEslamy.Academy.Domain.Validations;
using System;
using System.Linq;

namespace DarElFathElEslamy.Academy.Domain.Services
{
    public class CaroselService
    {
        private readonly IRepository<Carosel> _caroselRepository;
        public CaroselService(IRepository<Carosel> caroselRepository)
        {
            _caroselRepository = caroselRepository;
        }
        public Carosel Add(Carosel carosel)
        {
            if (carosel == null)
                throw new ArgumentNullException(nameof(carosel));
           //var carosels = _caroselRepository.GetAll().ToList();
            DataModelValidator.Validate(carosel);

            _caroselRepository.Add(carosel);
            _caroselRepository.UOF.Commit();
            return carosel;
        }

        public Carosel GetCarosel(int? Id)
        {
            if (Id < 1)
                throw new ArgumentException();

            return _caroselRepository.GetAll()
                .FirstOrDefault(carosel => carosel.Id == Id);
        }

        public IQueryable<Carosel> GetAll()
        {
            return _caroselRepository.GetAll();
        }

        public void Modify(Carosel carosel)
        {
            if (carosel == null)
                throw new ArgumentNullException(nameof(Carosel));

            if (carosel.Id < 1)
                throw new ArgumentException();

            DataModelValidator.Validate(carosel);

            _caroselRepository.Modify(carosel);
            _caroselRepository.UOF.Commit();
        }
        public void Remove(Carosel carosel)
        {
            if (carosel == null)
                throw new ArgumentNullException(nameof(Carosel));

            if (carosel.Id < 1)
                throw new ArgumentException();

            _caroselRepository.Remove(carosel);
            _caroselRepository.UOF.Commit();

        }


    }
}