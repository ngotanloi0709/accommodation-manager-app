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
        private readonly BillRepository _billRepository;
        public UserService(UserRepository userRepository, ContractRepository contractRepository, BillRepository billRepository) {
            _userRepository = userRepository;
            _contractRepository = contractRepository;
            _billRepository = billRepository;
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

        public List<User> GetByCustomizeQuery(List<User> users, bool? isFemale, List<string> text)
        {
            var filteredUsers = users.Where(user =>
                (user.IsFemale == isFemale || isFemale == null) &&
                (text[0] == null || text[0].Equals(user.Name, StringComparison.OrdinalIgnoreCase)) &&
                (text[1] == null || text[1].Equals(user.Phone, StringComparison.OrdinalIgnoreCase)) &&
                (text[2] == null || text[2].Equals(user.IdentityNumber, StringComparison.OrdinalIgnoreCase)) &&
                (text[3] == null || text[3].Equals(user.Email, StringComparison.OrdinalIgnoreCase)) &&
                (text[4] == null || (int.TryParse(text[4], out int year) && year == user.DateOfBirth.Year))
            );
            return filteredUsers.ToList();
        }
        public List<User> GetAllWithRoleTenantAndWithContractAndRoomWhereHasUnpaidBill() {
            var users = _billRepository.GetAllUnpaidBill().Select(bill => bill.User).ToList();
            var distinctUsers = users.Distinct().ToList();
            
            return distinctUsers;
        }

        public List<User> GetAllWithRoleNotTenantAndWithContractAndRoom() {
            return _userRepository.GetAllWithRoleNotTenantAndWithContractAndRoom();
        }
    }
}