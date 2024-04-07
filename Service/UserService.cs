using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;


namespace AccommodationManagerApp.Service {
    public class UserService {
        private readonly UserRepository _userRepository;
        private readonly ContractRepository _contractRepository;

        public UserService(UserRepository userRepository, ContractRepository contractRepository) {
            _userRepository = userRepository;
            _contractRepository = contractRepository;
        }

        public User GetUserByEmail(string email) {
            return _userRepository.GetByEmail(email);
        }

        public List<User> GetAll() {
            return _userRepository.GetAll();
        }
        
        public List<User> GetAllWithRoleTenantAndWithContractAndRoom() {
            return _userRepository.GetAllWithRoleTenantAndWithContractAndRoom();
        }

        public int? GetIdByNameAndEmail(string name, string email) {
            var user = _userRepository.GetByNameAndEmail(name, email);

            if (user != null) {
                return user.Id;
            }

            return null;
        }

        public User GetById(int? id)
        {
            return _userRepository.GetById(id);
        }

        public bool IsEmailExists(string text) {
            return _userRepository.GetByEmail(text) != null;
        }

        public void Add(User user) {
            _userRepository.Add(user);
        }

        public bool Update(int userId, User user) {
            try
            {
                _userRepository.Update(userId, user);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Delete(int userId) {
            try {
                _userRepository.Delete(userId);
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
        
        public Image CompressImage(Image image, int quality) {
            var qualityParam = new EncoderParameter(Encoder.Quality, quality);
            var jpegCodec = GetEncoderInfo("image/jpeg");

            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            var ms = new MemoryStream();
            image.Save(ms, jpegCodec, encoderParams);

            return Image.FromStream(ms);
        }
        
        private ImageCodecInfo GetEncoderInfo(String mimeType) {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j) {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }

            return null;
        }

        public bool IsExistContract(int userId) {
            return _contractRepository.GetByUserId(userId).Any();
        }

        public List<User> GetAllWithRoleTenant() {
            return _userRepository.GetAllWithRoleTenant();
        }
        public User GetByName(string name) => _userRepository.GetByName(name);
        public List<String> GetAllEmailByName(string name) {
            var users = _userRepository.GetAllByName(name);
            var emails = new List<string>();
            
            foreach (var user in users) {
                emails.Add(user.Email);
            }
            
            return emails;
        }

        public User GetByNameAndEmail(string name, string email) {
            return _userRepository.GetByNameAndEmail(name, email);
        }
    }
}