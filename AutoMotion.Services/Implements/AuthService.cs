using AutoMapper;
using AutoMotion.Repositories.UoW;
using AutoMotion.Services.Interfaces;
using Automoviles.Models.DTO;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
//using AutoMotion.Repositories.UoW;

namespace AutoMotion.Services.Implements
{
    public class AuthService : IAuthService
    {
        #region Dependencias
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AuthService> _logger;
        #endregion

        #region Constructor
        public AuthService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ILogger<AuthService> logger
            )
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        #endregion

        #region Metodos

        public async Task<LoginResponseDTO> Login( LoginRequestDTO model )
        {
            var usuario = await _unitOfWork.Usuarios.GetByNombre(model.Nombre);

            //DESCOMENTAR CUANDO ESTE EL ABM DE USUARIOS Y SE GUARDE LA PASSWORD ENCRIPTADA!
            //bool passwordCorrecto = HelperCryptography.CompareEncryptPassword(model.password, usuario.Password);

            //bool passwordCorrecto = model.Password.ToLower() == credencial.Password.ToLower();

            LoginResponseDTO response = new LoginResponseDTO()
            {
                Nombre = usuario.Nombre ?? "",
            };

            return response;
        }


        //public async Task<LoginResponseDTO> ActiveDirectoryAuthenticate( LoginRequestDTO model )
        //{
        //    var domain = "SMSARGENTINA\\";

        //    using( DirectoryEntry _entry = new DirectoryEntry() )
        //    {
        //        _entry.Username = domain + model.Email;
        //        _entry.Password = model.Password;
        //        DirectorySearcher _searcher = new DirectorySearcher(_entry);
        //        _searcher.Filter = "(&(objectClass=user)(anr=" + model.Email + "))";
        //        _searcher.PropertiesToLoad.Add("givenName");   // first name
        //        _searcher.PropertiesToLoad.Add("sn");          // last name
        //        _searcher.PropertiesToLoad.Add("mail");        // smtp mail address

        //        try
        //        {
        //            SearchResult _sr = _searcher.FindOne();
        //            string _name = _sr.Properties["givenName"][0].ToString();

        //            return new LoginResponseDTO()
        //            {
        //                UserName = model.Email,
        //                Email = _sr.Properties["mail"][0].ToString(),
        //                NombreCompleto = _sr.Properties["givenName"][0].ToString() + " " +
        //                  _sr.Properties["sn"][0].ToString(),
        //            };

        //        }
        //        catch
        //        { /* Error handling omitted to keep code short: remember to handle exceptions !*/ }
        //    }

        //    return null; //true = user authenticated!
        //}

        #endregion
    }
}
