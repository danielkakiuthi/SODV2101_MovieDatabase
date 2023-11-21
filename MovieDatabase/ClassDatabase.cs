using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDatabase.OmdbApi;

namespace MovieDatabase
{
    public class ClassDatabase {

        public List<ClassOmdbTitle> listMostRecent;
        public List<ClassOmdbTitle> listTopRated;
        public List<ClassOmdbTitle> listFavourites;
        public List<ClassOmdbTitle> listFeatured;
        public List<ClassOmdbTitle> listTopBoxOffice;


        public ClassDatabase() {

        }


        public ClassOmdbTitle GetTitleById(string idTitle) {
            return null;
        }

        public List<ClassOmdbTitle> GetListMostRecent() {
            return null;
        }

        public List<ClassOmdbTitle> GetListTopRated() {
            return null;
        }

        public List<ClassOmdbTitle> GetListFavourites() {
            return null;
        }

        public List<ClassOmdbTitle> GetListFeatured() {
            return null;
        }

        public List<ClassOmdbTitle> GetListTopBoxOffice() {
            return null;
        }

    }
}
