using System.Collections.Generic;
using System.Linq;
using MyPersistance.Data;
using MyPersistance.Entities;

namespace MyPersistance.Repositories
{
    public class ZipcodeRepository
    {
        private readonly TemaS2MiercuriV2Context _context;

        public ZipcodeRepository(TemaS2MiercuriV2Context context)
        {
            _context = context;
        }

        public List<Zipcode> GetZipcodes()
        {
            return _context.Zipcode.ToList();
        }

        public void AddZipcode(Zipcode zipcode)
        {
            _context.Zipcode.Add(zipcode);
            _context.SaveChanges();
        }
    }
}
