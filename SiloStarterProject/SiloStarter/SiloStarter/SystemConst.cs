using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiloStarter
{
    public class SystemConst
    {

        //
        public const string MAX_RELEASE_VERSION_SERVICE_URL = "https://silo-services.herokuapp.com/releaseversion/max";



        // Constantes para FTP
        /*
        public const string FTP_PROTOCOL_PREFIX = "ftp://";
        public const string FTP_ROOT_HOST = "localhost:52535";
        public const string FTP_ROOT_PATH = "/";
        public const string FTP_USER = "mfallas";
        public const string FTP_PASS = "fztest";
        */
        public const string FTP_PROTOCOL_PREFIX = "ftp://";
        public const string FTP_ROOT_HOST = "ftp.drivehq.com";
        //public const string FTP_ROOT_PATH = "/";
        public const string FTP_ROOT_PATH = "/ftp/downloads/programs/silo/updates/latest/";
        public const string FTP_USER = "mbsoftwarecr";
        public const string FTP_PASS = "Credixmb123$";

        public const string PROGRAM_RELATIVE_DIRECTORY = "SILO\\system\\program\\silo\\";
        public const string PROGRAM_RELATIVE_PATH = "\\" + PROGRAM_RELATIVE_DIRECTORY;
        public const string FTP_DOWNLOAD_FILE_PATH = PROGRAM_RELATIVE_PATH;
        //public const string FTP_DOWNLOAD_FILE_PATH = "\\SILO\\system\\program\\";

        public const string PROGRAM_EXE_NAME = "SILO.exe";
        public const string APPLICATION_RELATIVE_PATH = PROGRAM_RELATIVE_DIRECTORY + PROGRAM_EXE_NAME;

        public const string DEFAULT_PROGRAM_VERSION = "0.0.0.1";
    }
}
